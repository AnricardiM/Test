using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.Conexion
{
          
   public class Solicitud
    {
           public string urlGeneral = "http://localhost:23792/api/";                       
           public string Method { get; set; }
           public string Id { get; set; }
           public string Json { get; set; }
           public string Control { get; set; }
           
        public string ContentType = "application/json";
           public string Accept = "application/json";
           public Respuesta Llamada()
            {
                 Respuesta respuesta = new Respuesta();
                try
                {
                 
          var URL = this.urlGeneral + (string.IsNullOrEmpty(Control) ? "" : Control) + (string.IsNullOrEmpty(Id) ? "" : "/" + Id);

                var request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = this.Method;
                request.ContentType = this.ContentType;
                request.Accept = this.Accept;


                if (!string.IsNullOrEmpty(Json))
                { 
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(Json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                 }
               
                using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return null;
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                respuesta.responseBody = responseBody;
                                return respuesta;

                            }
                        }
                    }
                }
                catch (WebException ex)
                {

                respuesta.responseBody = ex.Message;
                respuesta.error = true;
                return respuesta;

                }
            }
    }

    public class Respuesta
    {
        public string responseBody { get; set; }
        public bool error { get; set; }
    }

    class SolicitudFactory
    {
        public Solicitud http = new Solicitud();
       

        /// <summary>
        /// Get class
        /// </summary>
        public Respuesta Get(string control, string id)
        {           
          
            http.Method = "GET";
            http.Control = control;
            http.Id = id;

            return http.Llamada();
          
        }
        /// <summary>
        /// GetItem class
        /// </summary>
        public Respuesta GetAll(string control)
        {           
            http.Method = "GET";            
            http.Control = control;
            
            return http.Llamada();
        }

        /// <summary>
        /// Post class
        /// </summary>
        public Respuesta Post(string control, string data)
        {
            http.Method = "POST";
            http.Control = control;           
            http.Json =  data;

            return http.Llamada();
        }
        /// <summary>
        /// Put class
        /// </summary
        public Respuesta Put(string control, string id, string data)
        {
            http.Method = "PUT";
            http.Control = control;
            http.Id = id;            
            http.Json = $"{{\"id\":\"{id}\",\"data\":\"{data}\"}}";
            return http.Llamada();
        }

        /// <summary>
        /// Delete class
        /// </summary>
         public Respuesta Delete(string control, string id)
        {
            http.Method = "DELETE";
            http.Control = control;
            http.Id = id;

            return http.Llamada();
        }
    
}
}

