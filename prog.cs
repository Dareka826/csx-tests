using System;
using System.Net.Http;

static class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Hewwo");

        using (var client = new HttpClient()) {
            var uri = new Uri("https://ddg.gg/lite");

            ReflectDump.DumpType(uri.GetType());
        }
    }
}
