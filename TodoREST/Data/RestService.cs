using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TodoREST
{
	public class RestService : IRestService
	{
		HttpClient client;

		public List<TodoItem> Items { get; private set; }

		public RestService ()
		{
			client = new HttpClient ();
			client.MaxResponseContentBufferSize = 256000;
        }

		public async Task<List<TodoItem>> RefreshDataAsync ()
		{
			Items = new List<TodoItem> ();

            var uri = new Uri (string.Format (Constants.RestUrl + Constants.pagenum + "&_type=json", string.Empty));
            Debug.WriteLine(@"   page number: {0}", Constants.pagenum);
			try {
                
                Debug.WriteLine(@"maked uri {0}",uri);
                var response = await client.GetAsync(uri);

				if (response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();

                    //응답 형식을 알맞게 바꾸는 부분
                    Debug.WriteLine(@"\t\t\t BEFORE {0}", content);

					int startIndex = content.IndexOf("[");
					int endIndex = content.IndexOf("]") - startIndex + 1;

                    Debug.WriteLine(@"\t\t\t AFTER {0}", content.Substring(startIndex,endIndex));

                    Items = JsonConvert.DeserializeObject <List<TodoItem>> (content.Substring(startIndex,endIndex));
                }
            } catch (Exception ex) {
                Debug.WriteLine (@"				ERROR {0}", ex.Message);
			}
            return Items;
		}

	}
}
