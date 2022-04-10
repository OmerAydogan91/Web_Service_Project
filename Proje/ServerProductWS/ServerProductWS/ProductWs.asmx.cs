using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerProductWS
{
    /// <summary>
    /// Summary description for ProductWs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWs : System.Web.Services.WebService
    {
        //asmx.cd uzantılı dosya server tarafını temsil ediyor
        [WebMethod(Description = "string türünde bir metot")]
        public string HelloWorld()
        {
            return "Merhaba Ömer";//kendin yap  
        }

        ProductBaglantiDataContext db = new ProductBaglantiDataContext();
        [WebMethod]
        public List<UrunSonuc> UrunleriGetir()
        {
            return db.Products.Select(x => new UrunSonuc
            {
                UrunID = x.ProductID,
                UrunAdi = x.ProductName,
                Fiyat = x.UnitPrice,
                Stok = x.UnitsInStock
            }).ToList();
        }
    }
    public class UrunSonuc
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public short? Stok { get; set; }

    }
}
