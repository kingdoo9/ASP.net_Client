using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace Blazor_app.Data
{
    public class CustomerService
    {
        private String url = "https://localhost:44393/Customer";
        private HttpClient client;


        public CustomerService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Customer_Data>> Get() //Read 함수;
        {
            List<Customer_Data> list = new List<Customer_Data>();
            HttpResponseMessage response = await client.GetAsync("/Customer");
            if (response.IsSuccessStatusCode)
            {
                var customer = response.Content.ReadAsAsync<IEnumerable<Customer_Data>>().Result;
                foreach(Customer_Data item in customer)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public bool Insert(Customer_Data data) //Read 함수;
        {
            MediaTypeFormatter JsonMessage = new JsonMediaTypeFormatter();
            HttpContent content = new ObjectContent<Customer_Data>(data, JsonMessage);
            HttpResponseMessage response = client.PostAsync("Customer", content).Result;
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public bool Update(Customer_Data data) //Read 함수;
        {
            MediaTypeFormatter JsonMessage = new JsonMediaTypeFormatter();
            HttpContent content = new ObjectContent<Customer_Data>(data, JsonMessage);
            HttpResponseMessage response = client.PutAsync("Customer/" + data.no, content).Result;
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public bool Delete(Customer_Data data) //Read 함수;
        {
            HttpResponseMessage response = client.DeleteAsync("Customer/" + data.no).Result;
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
