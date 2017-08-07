using System;
using jsreport.Client;
using jsreport.Embedded;
using System.Threading.Tasks;
using System.IO;
using jsreport.Client.Entities;

namespace Jsreporter
{
    public partial class Deafult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GenerateJsReportAsync().Wait();
        }

        protected async Task GenerateJsReportAsync()
        {

            EmbeddedReportingServer embeddedServer = new EmbeddedReportingServer(port: 2000);


            //embeddedServer.StartAsync().Wait();
            await embeddedServer.StartAsync();

            Report result = await embeddedServer.ReportingService.RenderAsync(new RenderRequest()
            {
                template = new Template()
                {
                    content = "<h1>Hello from {{greetings}}</h1>",
                    recipe = "phantom-pdf",
                    engine = "handlebars"
                },
                data = new
                {
                    greetings = ".NET embedded jsreport"
                }
            });

            using (var fileStream = File.Create("C:\\temp\\jsreport.pdf"))
            {
                result.Content.CopyTo(fileStream);
            }

        }
    }
}