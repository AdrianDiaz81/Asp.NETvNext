namespace ADC.News
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Configuration;

    public class ContactOld
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<string> Friends { get; set; }

        public ContactOld()
        {
            Name = "Adrian";
            LastName = "Diaz";
            Friends = new List<string>();
        }

        public string FullName()
        {
            return string.Format("{0} {1}",Name,LastName);
        }

        public JObject ToJson()
        {
            var result = new JObject();
            result["Name"] = Name;
            result["Apellidos"] = LastName;
            return result;
        }

        public string FromJson(JObject json)
        {
            if (json != null && json["Nombre"] !=null
                && json["Nombre"].Type == JTokenType.String && json["Apellidos"] != null 
                && json["Apellidos"].Type == JTokenType.String)
            {
                return $" {json["Nombre"]} ({json["Apellidos"]} )";
            }
            return "Sin identidad";
        }


        public string AddFriend(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name is null");
            }
            return "Exito";
        }

        public void ExistContact()
        {
            try
            {

            }
            catch (ConfigurationException ex) 
            {
                if (ex.HResult ==1)
                {
                    Console.WriteLine("Error 1");
                }
                if (ex.HResult == 2)
                {
                    Console.WriteLine("Error 2");
                }
            }
            finally
            {

            }
        }
    }
}
