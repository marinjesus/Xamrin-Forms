using System;
using System.Collections.Generic;
using System.Text;

namespace USBF.Moldes
{

    public class Antibloqueo {
        public string mobile { get; set; }
        public string video { get; set; }
        public string corto_alternativo { get; set; }
        public string enable_iads { get; set; }
        public string enable_admobbanners { get; set; }
        public string enable_admobinterstitials { get; set; }
        public string alternativo { get; set; }
        public string alternativo2 { get; set; }
        public string notifications { get; set; }
        public string resource_id { get; set; }
    }

    public class Labels {
        public string a { get; set; }
        public string a1 { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }
        public string e { get; set; }
    }

    public class Timestamp {
        public string epoch { get; set; }
        public string fecha { get; set; }
        public string fecha_corta { get; set; }
        public string fecha_corta2 { get; set; }
        public string fecha_nice { get; set; }
        public string dia { get; set; }
        public string dia_corta { get; set; }
    }

    public class USD {
        public double transferencia { get; set; }
        public double transfer_cucuta { get; set; }
        public double efectivo { get; set; }
        public double efectivo_real { get; set; }
        public double efectivo_cucuta { get; set; }
        public double promedio { get; set; }
        public double promedio_real { get; set; }
        public double cencoex { get; set; }
        public double sicad1 { get; set; }
        public double sicad2 { get; set; }
        public double bitcoin_ref { get; set; }
        public double localbitcoin_ref { get; set; }
        public double dolartoday { get; set; }
    }

    public class EUR {
        public double transferencia { get; set; }
        public double transfer_cucuta { get; set; }
        public double efectivo { get; set; }
        public double efectivo_real { get; set; }
        public double efectivo_cucuta { get; set; }
        public double promedio { get; set; }
        public double promedio_real { get; set; }
        public double cencoex { get; set; }
        public double sicad1 { get; set; }
        public double sicad2 { get; set; }
        public double dolartoday { get; set; }
    }

    public class COL {
        public double efectivo { get; set; }
        public double transfer { get; set; }
        public double compra { get; set; }
        public double venta { get; set; }
    }

    public class GOLD {
        public double rate { get; set; }
    }

    public class USDVEF {
        public double rate { get; set; }
    }

    public class USDCOL {
        public double setfxsell { get; set; }
        public double setfxbuy { get; set; }
        public double rate { get; set; }
        public double ratecash { get; set; }
        public double ratetrm { get; set; }
        public double trmfactor { get; set; }
        public double trmfactorcash { get; set; }
    }

    public class EURUSD {
        public double rate { get; set; }
    }

    public class BCV {
        public string fecha { get; set; }
        public string fecha_nice { get; set; }
        public string liquidez { get; set; }
        public string reservas { get; set; }
    }

    public class MISC {
        public string petroleo { get; set; }
        public string reservas { get; set; }
    }

    public class Example {
        public Antibloqueo _antibloqueo { get; set; }
        public Labels _labels { get; set; }
        public Timestamp _timestamp { get; set; }
        public USD USD { get; set; }
        public EUR EUR { get; set; }
        public COL COL { get; set; }
        public GOLD GOLD { get; set; }
        public USDVEF USDVEF { get; set; }
        public USDCOL USDCOL { get; set; }
        public EURUSD EURUSD { get; set; }
        public BCV BCV { get; set; }
        public MISC MISC { get; set; }
    }

}
