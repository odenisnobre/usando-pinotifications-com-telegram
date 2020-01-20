using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Services;

namespace TWS
{
    /// <summary>
    /// Descrição resumida de Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        public object JsonConvert { get; private set; }

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }
      

        [WebMethod]
        public string enviaMensagem(string token_bot, string chat_id, string mensagem)
        {

            string caminho = "https://api.telegram.org/bot";

            string messa = mensagem;

            string ci = chat_id;

            string surl = caminho + token_bot + "/sendMessage?chat_id=" + ci + "&text=" + messa;

            WebRequest wrGETURL;

            wrGETURL = WebRequest.Create(surl);

            return wrGETURL.GetResponse().ContentType;
        }

        [WebMethod]
        public string SendData(string servidor, string caminho, string par1, string par2, string par3)
        {

            byte[] byteArray;

           string url = servidor + "/" + caminho + "?";

            WebRequest request = WebRequest.Create(url);

            request.Credentials = CredentialCache.DefaultCredentials;

            request.Method = "POST";

            string postData = "nome=" + par1 + "&status=" + par2 + "&id=" + par3;

            byteArray = Encoding.UTF8.GetBytes(postData);

            request.ContentLength = byteArray.Length;           

            request.ContentType = "application/x-www-form-urlencoded";

            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            return "ok";


        }



    }
}
