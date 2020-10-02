using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;

namespace HackeRankPractice.RestApi
{
    class RestApi_Test1
    {
        static HttpClient client;
        public static void Run()
        {
            int year = 2011;
            int count = GetDrawResults(year);

            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static int GetDrawResults(int year)
        {
            string baseUrl = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}";

            client = new HttpClient();
            List<Data> data = new List<Data>();
            int startPage = 1;
            int totalPage = 0;

            for (int c = 0; c < 11; c++)
            {
                startPage = 1;
                var body = GetData(baseUrl, startPage, c);
                totalPage = body.total_pages;
                data.AddRange(body.data);

                for (int i = startPage + 1; i <= totalPage; i++)
                {
                    body = GetData(baseUrl, i, c);
                    totalPage = body.total_pages;
                    data.AddRange(body.data);
                }
            }
            return data.Count(c => c.team1goals == c.team2goals);
        }

        private static Content GetData(string baseUrl, int pageNO, int goalScored)
        {
            var result = client.GetAsync($"{baseUrl}&page={pageNO}&team1goals={goalScored}").GetAwaiter().GetResult();

            var content = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                DataContractJsonSerializer JSserializer = new DataContractJsonSerializer(typeof(Content));
                return (Content)JSserializer.ReadObject(ms);
            }
        }
    }
}
