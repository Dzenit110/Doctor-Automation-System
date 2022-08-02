using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Doctor_Automation
{
    //Veritabanı diğer  formlardan çağırabileceğimiz bir sınıf oluşturduk
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            //Burada veritabınımızın uzantısını girdik ve veritabanı ile bağlantı yaptık
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BFHTG89\\SQLEXPRESS;Initial Catalog=DoktorOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
