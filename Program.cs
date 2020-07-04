using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

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

             using (var context = new LftmtesteContext()) {
                context.Add(leadsRD);
                context.SaveChanges();
             }
            

        }
    }
}
