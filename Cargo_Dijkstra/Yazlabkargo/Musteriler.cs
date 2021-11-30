using GMap.NET;

namespace Yazlabkargo
{
    internal class Musteriler
    {
        internal static Musteriler sonuc;

        public string Musteri_isim { get; set; }
        public string msuteri_il { get; set; }
        public string musteri_adres { get; set; }
        public PointLatLng musteri_lokasyon { get; set; }
        public int musteri_id { get; set; }
        public int kargo_id { get; set; }
    }
}