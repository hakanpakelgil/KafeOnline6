﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOnline6.Data
{
    public class SiparisDetay
    {
        public string UrunAd {  get; set; } = string.Empty;
        public decimal BirimFiyat { get; set; }
        public int Adet {  get; set; }
        public string TutarTL {  get { return Tutar().ToString("c2"); } }//readonly
        public decimal Tutar()
        {
            return Adet * BirimFiyat;
        }
    }
}
