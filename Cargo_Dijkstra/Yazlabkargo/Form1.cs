using FireSharp.Response;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Yazlabkargo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        firebase connect = new firebase(); //Firebase sınıfından nesne türet
        private void Form1_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = connect.ApiKey; //firebase.cs de verilen API Keyi GMapProvider API Key'i yap
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.DragButton = MouseButtons.Left; //haritayı sol tuş ile hareket ettir
            gMapControl1.MapProvider = GMapProviders.GoogleMap; //GUIdeki gMapControl aracina GMap kullanacağımızı göster
            
            //Kullanici giris yapmadan once sifre degistir menusu gizli kalir
            lbNewPass.Hide();
            lbChangePassEkran.Hide();
            tbNewPass.Hide();
            btChangePass.Hide();

            PointLatLng kargocuKonum = kordinat("izmit");
            konumlar.Add(kargocuKonum);
            gMapControl1.Position = kargocuKonum; //postion attrb. baslangic yeri
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;
            GMapMarker marker = new GMarkerGoogle(kargocuKonum, GMarkerGoogleType.green);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                connect.alma = new FireSharp.FirebaseClient(connect.yapılandırma); //yapılandırma bilgileri ile firebaseden bilgi alma
                
                //Firebasede bulunan Kargocular kategorisi altındaki kullanıcı adını al
                connect.cevap = connect.alma.Get("Kargocular/" + tbUserName.Text);

                //Kargocular sınıfından bir nesne olustur cevaptan gelenleri ata
                Kargocular kargocu = connect.cevap.ResultAs<Kargocular>();

                if (kargocu.Sifre.Equals(tbPassword.Text))
                {
                    lbNewPass.Show();
                    lbChangePassEkran.Show();
                    tbNewPass.Show();
                    btChangePass.Show();

                    MessageBox.Show("Giriş Başarılı");
                    lbKullanici.Text = "İşlem Yapan Kullanıcı: " + tbUserName.Text;
                    tbUserName.Text = "";
                    tbPassword.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Kullanıcı Adı/Şifre Girişi!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (tbPassConfirm.Text.Equals(tbNewUsrPass.Text)) //sifre onayını karsilastir
            {
                try
                {
                    connect.alma = new FireSharp.FirebaseClient(connect.yapılandırma);
                    connect.cevap = connect.alma.Get("Kargocular/" + tbNewUser.Text); //yeni kullanıcı adını al
                    Kargocular kargocu = connect.cevap.ResultAs<Kargocular>();

                    if (kargocu.Kullanici_adi.Equals(tbNewUser.Text)) //firebaseden gelen kullanıcı adı ile girilen esit mi
                    {
                        MessageBox.Show("Girilen Kullanıcı Adı Mevcut, Başka Bir Kullanıcı Adı Seçiniz.");
                    }
                }
                catch (Exception) //yeni kullanici olustur
                {
                    var kargocu = new Kargocular
                    {
                        Kullanici_adi = tbNewUser.Text,
                        Sifre = tbNewUsrPass.Text

                    };
                    connect.alma = new FireSharp.FirebaseClient(connect.yapılandırma);

                    //ayni anda calismasi icin await kullanarak
                    SetResponse res = await connect.alma.SetTaskAsync("Kargocular/" + tbNewUser.Text, kargocu);
                    Kargocular.sonuc = res.ResultAs<Kargocular>();
                    MessageBox.Show("Kayıt işlemi yapıldı.");
                    //tbNewUser.Text = "";
                    //tbNewUsrPass.Text = "";
                    //tbPassConfirm.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil, tekrar deneyiniz.");
            }
        }

        GMapOverlay markers = new GMapOverlay("markers"); //olusturulan markerleri gmapoverlay icine atmamiz icin
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect.alma = new FireSharp.FirebaseClient(connect.yapılandırma);
                connect.cevap = connect.alma.Get("Kargocular/" + tbUserName.Text);
                Kargocular kargocu = connect.cevap.ResultAs<Kargocular>();
                
                var kurye = new Kargocular
                {
                    Kullanici_adi = tbUserName.Text,
                    Sifre = tbNewPass.Text
                };

                connect.alma = new FireSharp.FirebaseClient(connect.yapılandırma);
                SetResponse res = await connect.alma.SetTaskAsync("Kargocular/" + tbUserName.Text, kurye);
                Kargocular.sonuc = res.ResultAs<Kargocular>();
                MessageBox.Show("Şifreniz Değiştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Kullanıcı Adı/Şifre Girişi!");
            }
        }
        List<PointLatLng> konumlar = new List<PointLatLng>(); //enlem boylam listesini tutacak
        
        private async void button4_Click(object sender, EventArgs e)
        {
            PointLatLng konum = kordinat(rtbMusteriAdres.Text); //Girilen adresin enlem boylam bilgisini kordinat metodu ile al
            konumlar.Add(konum); //PointLatLang listesi (konumlar) eklenen konumlari at
            gMapControl1.Position = konum; //postion attrb. baslangic yeri
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 100;
            gMapControl1.Zoom = 10;

            //farkli musteri id ve kargo id olusturduk
            Random rn = new Random();
            int rastgele = rn.Next(1, 20);
            int musteriid = Convert.ToInt32(konum.Lat *rastgele); 
            int kargoid = Convert.ToInt32(konum.Lng *rastgele); 

            var musteri = new Musteriler //musteriler sinifini turet
            {
                Musteri_isim = tbMusteri.Text,
                msuteri_il = tbMusteriCity.Text,
                musteri_adres= rtbMusteriAdres.Text,
                musteri_lokasyon =konum ,
                musteri_id = musteriid ,
                kargo_id = kargoid 
            };

            //firebase e musteri ve kargo bilgilerini verme kismi
            connect.alma = new FireSharp.FirebaseClient(connect.yapılandırma);
            SetResponse res = await connect.alma.SetTaskAsync("Musteriler/" + musteri.musteri_id, musteri);
            Musteriler.sonuc = res.ResultAs<Musteriler>();
            listBox1.Items.Add(musteri.musteri_id + " ID Nolu Müşterinin " + musteri.kargo_id + "Nolu Siparişi " + "Teslim Edilmedi");

            GMapMarker marker = new GMarkerGoogle(konum, GMarkerGoogleType.green);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        public PointLatLng kordinat(string adres) //Girilen adrese göre enlem ve boylam bilgilerini geri gönderen metot
        {
            List<string> sayilar = new List<string>();

            //Kaynakça
            string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(adres), connect.ApiKey);

            WebRequest request = WebRequest.Create(requestUri);
            WebResponse response = request.GetResponse();
            XDocument xdoc = XDocument.Load(response.GetResponseStream());

            XElement result = xdoc.Element("GeocodeResponse").Element("result");
            XElement locationElement = result.Element("geometry").Element("location");
            XElement lat = locationElement.Element("lat");
            XElement lng = locationElement.Element("lng");
            var lati = lat.ToString(); //Enlem verisini stringe cevir
            var longi = lng.ToString(); //Boylam verisini stringe cevir
            List<string> nokta = new List<string>();

            string[] latitude = Regex.Split(lati, @"\D+"); //lati icersinde bircok farklı karakter var sadece sayilari regex ile al ve string diziye ata
            string[] longitude = Regex.Split(longi, @"\D+"); //longi icinde aynı şekilde sadece sayilari al

            foreach (string s in latitude)
            {
                int sayi;
                if (int.TryParse(s, out sayi))
                {
                    sayilar.Add(s); //sayilar listesine enlemin virgulden onceki ve sonraki kisimlarini at
                }
            }
            foreach (string s in longitude)
            {
                int sayi;
                if (int.TryParse(s, out sayi))
                { 
                    sayilar.Add(s); //sayilar listesine boylamin virgulden onceki ve sonraki kisimlarini at
                }
            }

            string a = sayilar[0] + "," + sayilar[1]; //enlem icin sayilardaki veriyi 258,36213 benzeri formatta stringe ata
            string b = sayilar[2] + "," + sayilar[3]; //boylam icin sayilardaki veriyi 258,36213 benzeri formatta stringe ata
            var latitue = Convert.ToDouble(a);
            var longitute = Convert.ToDouble(b);
            return new PointLatLng(latitue, longitute); //islenmis enlem ve boylam verisini geri dondur
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var konum = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                konumlar.Add(konum);
                gMapControl1.Position = konum;
                GMapMarker marker = new GMarkerGoogle(konum, GMarkerGoogleType.red_pushpin);
                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
            }
        }

        int minDistance(double[] dist, bool[] sptSet)
        {
            double min = int.MaxValue;
            int min_index = -1;

            for (int v = 0; v < konumlar.Count; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        void prdoubleSolution(double[] dist, double n)
        {
            listBox1.Items.Add("Vertex     Distance " + "from Source\n");
            for (int i = 0; i < konumlar.Count; i++)
                listBox1.Items.Add(i + " \t\t " + dist[i] + "\n");
        }

        List<double[]> dijkstra(double[,] graph, int src)
        {
            int V = konumlar.Count;
            double[] dist = new double[V];
            double[] nodes = new double[V];
            bool[] sptSet = new bool[V];
            for (int i = 0; i < V; i++)
            {
                dist[i] = double.MaxValue;
                sptSet[i] = false;
            }
            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = minDistance(dist, sptSet);
                sptSet[u] = true;
                for (int v = 0; v < V; v++)
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != double.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        nodes[v] = v;
                    }
            }
            prdoubleSolution(dist, V);
            List<double[]> diziler = new List<double[]>();
            diziler.Add(dist);
            diziler.Add(nodes);
            return diziler;
        }

        private void getroute_Click(object sender, EventArgs e)
        {
            double[,] komsulukMatrisi = new double[konumlar.Count, konumlar.Count];
            for (int i = 0; i < konumlar.Count; i++)
            {
                for (int j = 0; j < konumlar.Count; j++)
                {
                    var route = GoogleMapProvider.Instance.GetRoute(konumlar[i], konumlar[j], false, false, 14);
                    komsulukMatrisi[i, j] = route.Distance;
                }
            }

            List<double[]> path = dijkstra(komsulukMatrisi, 0);

            for (int i = 0; i < path[0].Length -1; i++)
            {
                for (int j = 0; j < path[0].Length-1-i; j++)
                {
                    if(path[0][j] > path[0][j + 1])
                    {
                        double temp = path[0][j];
                        path[0][j] = path[0][j + 1];
                        path[0][j + 1] = temp;

                        temp = path[1][j];
                        path[1][j] = path[1][j + 1];
                        path[1][j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < path[0].Length-1; i++)
            {
                //listBox1.Items.Add(path[0][i] + " -> " + path[1][i]);
                var route = GoogleMapProvider.Instance.GetRoute(konumlar[(int)path[1][i]], konumlar[(int)path[1][i+1]], false, false, 14);
                var r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Red, 5)
                };
                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                gMapControl1.Overlays.Add(routes);
                gMapControl1.RefreshMap();
                label1.Text = route.Distance + " KM";
            }
        }
    }
}
