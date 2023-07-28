using System;
using System.Net.Http;

static class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Hewwo");

        using (var client = new HttpClient()) {
            var uri = new Uri("https://ddg.gg/lite");
            var response = client.GetAsync(uri).Result;
            var result = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
            //ReflectDump.DumpMethods(x.GetType());
            //ReflectDump.DumpProperties(x.GetType());
        }
    }
}
