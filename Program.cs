using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Audit
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
