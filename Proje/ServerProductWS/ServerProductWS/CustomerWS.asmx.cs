using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerProductWS
{
    /// <summary>
    /// Summary description for CustomerWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWS : System.Web.Services.WebService
    {
        MusteriBaglantiDataContext db = new MusteriBaglantiDataContext();

        [WebMethod]

        public List<MusteriSonuc> MusteriGetir()
        {
            return db.Customers.Select(x => new MusteriSonuc
            {
                MusteriID = x.CustomerID,
                MusteriAdi = x.ContactName,
                SirketID = x.CompanyName,
                Telefon = x.Phone
            }).ToList();
        }
    }
    public class MusteriSonuc
    {
        public string MusteriID { get; set; }
        public string SirketID { get; set; }
        public string MusteriAdi { get; set; }
        public string Telefon { get; set; }



    }
}
