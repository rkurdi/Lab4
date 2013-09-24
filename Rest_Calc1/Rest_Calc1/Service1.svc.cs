using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Rest_Calc1
{
     public class Output
    {
        public Double RES { get; set; }

    }

     public class Service1 : IService1
     {
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Addition/{i1}/{i2}")]

         public Output Addition(string i1, string i2)
         {
             int j1 = Convert.ToInt32(i1);
             int j2 = Convert.ToInt32(i2);
             return new Output()
             {
                 RES = j1 + j2
             };

         }

         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Multiply/{i1}/{i2}")]
         public Output Multiply(string i1, string i2)
         {
             int j1 = Convert.ToInt32(i1);
             int j2 = Convert.ToInt32(i2);
             return new Output()
             {
                 RES = j1 * j2
             };
         }

         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Subtract/{i1}/{i2}")]
         public Output Subtract(string i1, string i2)
         {
             int j1 = Convert.ToInt32(i1);
             int j2 = Convert.ToInt32(i2);
             return new Output()
             {
                 RES = j1 - j2
             };

         }

         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Divide/{i1}/{i2}")]
         public Output Divide(string i1, string i2)
         {
             Double j1 = Convert.ToDouble(i1);
             Double j2 = Convert.ToDouble(i2);
             Double c = j1 / j2;
             return new Output()
             {
                 RES = c
             };
         }

         public string GetData(int value)
         {
             return string.Format("You entered: {0}", value);
         }

         public CompositeType GetDataUsingDataContract(CompositeType composite)
         {
             if (composite == null)
             {
                 throw new ArgumentNullException("composite");
             }
             if (composite.BoolValue)
             {
                 composite.StringValue += "Suffix";
             }
             return composite;
         }

         public DateTime a1 { get; set; }
         public DateTime i1 { get; set; }
     }
}
