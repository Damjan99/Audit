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
using GemBox.Document;
using Microsoft.AspNet.Mvc.ViewFeatures;
using System.Net.Cache;
using Microsoft.AspNetCore.Http;
using System.Web;
using IdentityModel.Client;
using System.Net;

namespace Web_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            //string path = Environment.CurrentDirectory;
            //string file = path + "\\web.html";
            //WebClient client = new WebClient();
          
          
            //string downloadString = client.DownloadString("https://youtube.com");
            //File.WriteAllText(file, downloadString);
            CreateWebHostBuilder(args).Build().Run();




        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();



    }
}
