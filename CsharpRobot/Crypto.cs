using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRobot
{
    public class Crypto
    {
        public static async Task<string> CryptoPriceAsync(string cryptocurrency)
        {
            string str = "";
            HttpClient httpClient = new();  //instantiating
            const string API = "https://api.wallex.ir/v1/currencies/stats"; //Store Url in API variable 
            HttpResponseMessage response = await httpClient.GetAsync(API); //Get information from API 
            if (response.IsSuccessStatusCode) //Validating for true response
            {
                string json = await response.Content.ReadAsStringAsync(); //Read the content from API as json format
                ApiResponseWrapper apiWrapper = JsonConvert.DeserializeObject<ApiResponseWrapper>(json); //Converting json file to a C# class
                List<DataItem> dataItems = apiWrapper.result; //Store it in a List of DataItem for using the methods of Lists
                if (dataItems.Find(x => x.Name_en == cryptocurrency) != null)
                {
                    str += dataItems.Find(x => x.Name_en == cryptocurrency).Price.ToString();
                }
                else
                { 
                
                }
            }
            else
            {

            }
            return str; 
        }
        public class ApiResponseWrapper
        {
            public List<DataItem> result { get; set; }
        }
        public class DataItem
        {
            [JsonProperty("key")]
            public string? Key { get; set; }
            [JsonProperty("name_en")]
            public string? Name_en { get; set; }

            [JsonProperty("rank")]
            public int? Rank { get; set; }

            [JsonProperty("price")]
            public double? Price { get; set; }


            [JsonProperty("daily_high_price")]
            public double? Daily_High_Price { get; set; }

            [JsonProperty("daily_low_price")]
            public double? Daily_Low_Price { get; set; }

        }
    }
}
