using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazlabkargo
{
    class firebase
    {
        //Firebaseden bilgi alma ve bilgi verme işlemleri
        public IFirebaseConfig yapılandırma = new FirebaseConfig
        {
            AuthSecret = "mfR76rmM7wWA48ZwKL5Eij7OAuHoqNfHpPkNGGdD",
            BasePath = "https://linear-poet-330418-default-rtdb.firebaseio.com/"
        };
        public IFirebaseClient alma;
        public FirebaseResponse cevap;

        //Gmap API Key
        public string ApiKey = @"AIzaSyBb3A_BOkg0K_ezOD3ZBk9oI5-wdee_Pew";
    }
}
