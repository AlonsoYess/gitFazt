using System.Configuration;
namespace CapaDatos
{
    public class ConexionSAP
    {
        public ConexionSAP()
        {
        }
        public string GetConex()
        {
            string strConex = "Server=192.168.10.199:30015; User Id=SYSTEM; Password=Pr0m4t1s42017";

            //new HanaConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Hana"].ConnectionString);
            //conn.Open();

            if (object.ReferenceEquals(strConex, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strConex;
            }
        }
    }
}

