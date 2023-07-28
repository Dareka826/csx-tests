using System;
using System.Net.Http;

static class MainClass {
    public static void Main(string[] args) {
        using (var client = new HttpClient()) {
            var response = client.GetAsync("https://ddg.gg/lite").Result;
            var result = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
            //ReflectDump.DumpMethods(x.GetType());
            //ReflectDump.DumpProperties(x.GetType());
        }
    }
}
