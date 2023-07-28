using System;
using System.Net.Http;

static class MainClass {
    public static void Main(string[] args) {
        using (var client = new HttpClient()) {
            var response = client.GetAsync("https://ddg.gg/lite").Result;

            if (response.IsSuccessStatusCode != true) {
                Console.WriteLine($"[E]: ({response.StatusCode}) {response.ReasonPhrase}");
                Environment.Exit(1);
            }

            var result = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
            //ReflectDump.DumpMethods(x.GetType());
            //ReflectDump.DumpProperties(x.GetType());
        }
    }
}
