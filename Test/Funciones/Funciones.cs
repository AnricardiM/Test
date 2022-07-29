using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Test.Model;
namespace Test.Funciones
{
    class Funcion
    {
        public List<Auto> ConvertirAuto(string data)
        {
            try
            {
                List<Auto> Lista = new JavaScriptSerializer().Deserialize<List<Auto>>(data);
                return Lista;
            }
            catch {
                return null;
            }           
        }

        public List<Centro> ConvertirCentro(string data)
        {
            try
            {
                List<Centro> Lista = new JavaScriptSerializer().Deserialize<List<Centro>>(data);
                return Lista;
            }
            catch
            {
                return null;
            }
        }

        public List<Dashboard> ConvertirDashboard(string data)
        {
            try
            {
                List<Dashboard> Lista = new JavaScriptSerializer().Deserialize<List<Dashboard>>(data);
                return Lista;
            }
            catch
            {
                return null;
            }
        }



        public string SerializarVenta(Venta listVenta)
        {
            try
            {               
                var jsonString = new JavaScriptSerializer();               
                var data = jsonString.Serialize(listVenta);
                return data;
            }
            catch
            {
                return "";
            }
        }
    }
}
