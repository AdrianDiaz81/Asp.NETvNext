namespace ADC.News
{
    using System;
    using Newtonsoft.Json.Linq;
    using System.Configuration;
    using System.Threading.Tasks;

    public class ContactNew
    {
        public string LastName { get; } = "Diaz";
        public string Name { get; } = "Adrian";
        public double Age { get; } = 3;
        public string Country { get; set; }
        public string City { get; set; }
       

        
        public string FullName()
        {
           return  $" {Name} {LastName}";
        }

        public string FullName(string text) => $" {text} : {Name} {LastName}";

        public JObject ToJson()
        {
            var result = new JObject {["Name"] = Name,["Apellidos"] = LastName };
          
            return result;

        }

        public string FromJson(JObject json)
        {
            if (json != null && json["Nombre"]?.Type == JTokenType.String && json["Apellidos"]?.Type == JTokenType.String)
            { 
            return $" {json["Nombre"]} ({json["Apellidos"]} )";
            }
            return "Sin identidad";
        }

        public string AddFriend(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            return "Exito";
        }

        public void ExistContact()
        {
            try
            {
                
            }
            catch(ConfigurationException ex) when (ex.HResult==1)
            {

            }
            catch(ConfigurationException ex) when (ex.HResult == 2)
            {

            }
            finally
            {

            }
        }

        public async Task<bool> Add(string name, string lastName)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                await LogAsyc(ex);
                return false;
            }
            finally
            {
                await CloseAsyn();
            }
        }

        private Task CloseAsyn()
        {
            throw new NotImplementedException();
        }

        private Task LogAsyc(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
