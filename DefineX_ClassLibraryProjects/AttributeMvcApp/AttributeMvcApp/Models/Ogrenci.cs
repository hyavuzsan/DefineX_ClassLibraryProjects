using System;
using AttributeLibrary; 

namespace AttributeMvcApp.Models
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi { get; set; }

        [ZorunluAlan]
        public string Soyadi { get; set; }

        [ZorunluAlan]
        public string Bolum { get; set; }
    }
}
