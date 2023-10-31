using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CsharpRobot.Crypto;

namespace CsharpRobot
{
//    public class OghatSharei
//    {
//        public static async Task<string> ShowProvincesAsync()
//        {
//            string str1 = "";
//            string str2 = "";
//            HttpClient httpClient = new();  //instantiating
//            const string API = "https://prayer.aviny.com/api/province"; //Store Url in API variable 
//            HttpResponseMessage response = await httpClient.GetAsync(API); //Get information from API 
//            if (response.IsSuccessStatusCode) //Validating for true response
//            {
//                string json = await response.Content.ReadAsStringAsync(); //Read the content from API as json format
//                ListOfProvince listprovince = JsonConvert.DeserializeObject<ListOfProvince>(json); //Converting json file to a C# class
//                List<Province> dataItems = listprovince.Province;
//                foreach (Province province in dataItems)
//                {
//                    str1 += province.Name;
//                    str2 += province.Code.ToString();

//                }
              
//            }
//            return $"Code:{str2},Name:{str1}";
//        }
       
//    }
//    public class Province
//    {
//        public int Center_City_Code { get; set; }
//        public int Code { get; set; }
//        public int Country_Code { get; set; }
//        public string Name { get; set; }
//    }
//    public class ListOfProvince 
//    {
//        public List<Province> Province { get; set; }
//    }
//}
    
        
