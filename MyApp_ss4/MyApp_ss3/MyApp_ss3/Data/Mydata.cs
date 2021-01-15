//using System;
//using System.Collections.Generic;
//using System.Text;

//using System.Diagnostics;
//using System.Net.Http;

//using System.Threading.Tasks;
//using Newtonsoft.Json;
////using Xamarin.Android.Net;

//namespace MyApp_ss3.Data
//{
//    public class Mydata
//    {
//        private string uri = "http://localhost/api/api/accounts";
//    }
//    public NoteWebService()
//    {

//    }

//    public async Task<List<Account>> GetNoteList()
//    {
//        List<Note> lst = new List<Note>();
//        try
//        {
//            var client = new HttpClient();
//            var response = await client.GetAsync(uri);
//            var content = await response.Content.ReadAsStringAsync();
//            var result = JsonConvert.DeserializeObject<List<Note>>(content);
//            return result;

//        }
//        catch (Exception ex)
//        {
//            Debug.WriteLine("\tERROR {0}", ex.Message);
//        }
//        return lst;
//    }

//    public async Task<bool> AddNote(Note nt)
//    {
//        bool ret = false;
//        try
//        {

//            var client = new HttpClient();
//            var json = JsonConvert.SerializeObject(nt);
//            var data = new StringContent(json, Encoding.UTF8, "application/json");
//            var response = await client.PostAsync(uri, data);
//            ret = response.IsSuccessStatusCode;
//        }
//        catch (Exception ex)
//        {
//            Debug.WriteLine("\tERROR {0}", ex.Message);
//        }
//        return ret;
//    }

//}
//}
