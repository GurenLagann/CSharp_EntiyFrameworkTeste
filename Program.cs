using System;
using System.IO;
using Newtonsoft.Json;
using static System.Console;

using Dev01.Json;

namespace Dev01
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            RD leadsRD = JsonConvert.DeserializeObject<RD>(File.ReadAllText("RDteste.json"));

            WriteLine(leadsRD.leads[0].name);
            WriteLine(leadsRD.leads[0].email);
        }
    }
}
