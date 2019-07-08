using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Management;
using System.Reflection.Emit;
using System.Linq;

namespace Web_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();



            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");

                var arr = MOS.Get();
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }


    }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();


        
    }
}
