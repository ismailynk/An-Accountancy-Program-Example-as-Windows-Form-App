using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Globalization;
namespace Muhasebe_uygulama
{
    class dbtool
    {

        public static String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\dataBase\\muhaces.accdb; Jet OLEDB:Database Password='My.234052';";
        public static String constr2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\dataBase\\kullanicilar.accdb; Jet OLEDB:Database Password='My.234052';";
        
         //public static String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\umedosya\\G4-IDARI\\SATINALMA\\SATINALMA.brmozel\\sabes\\dataBase\\muhaces.accdb; Jet OLEDB:Database Password='My.234052';";
         //public static String constr2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\umedosya\\G4-IDARI\\SATINALMA\\SATINALMA.brmozel\\sabes\\dataBase\\kullanicilar.accdb; Jet OLEDB:Database Password='My.234052';";

//public static String constr1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Network\\umedosya\\G4-IDARI\\SATINALMA\\SATINALMA.brmozel\\sabes\\dataBase\\muhaces.accdb";
       
        /*
          * 
         public static String constr5 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\dataBase\\kullanicilar.accdb; Jet OLEDB:Database Password='My.234052';";
         *
         * 
         */



        //OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Network\\umedosya\\G4-IDARI\\SATINALMA\\SATINALMA.brmozel\\sabes\\dataBase\\kullanicilar.accdb; Jet OLEDB:Database Password='My.234052';");
        //Network\\umedosya\\G4-IDARI\\SATINALMA\\SATINALMA.brmozel\\sabes\\dataBase\\
        // public static String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Network\\umedosya\\G4-IDARI\\SATINALMA\\SATINALMA.brmozel\\sabes\\dataBase\\muhaces.accdb";
        public static kayıt_ekranı kayıtekran = new kayıt_ekranı();
        public static Form2 rapor = new Form2();
        public static kullanici_bilgi bilgiform = new kullanici_bilgi();

    }
}
