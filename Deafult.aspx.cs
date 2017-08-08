using System;
using System.Threading.Tasks;
using System.Data;
using jsreport.Binary;
using jsreport.Types;
using jsreport.Local;
using System.IO;

namespace Jsreporter
{
    public partial class Deafult : System.Web.UI.Page
    {
        public DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if checkbox checked atleast one then get data
            int aid = 1;
            getCheckedData(aid);

            //            GenerateJsReportAsync().Wait();
            //Task.Run(GenerateJsReportAsync).GetAwaiter().GetResult();

            Task.Run(GenerateLocalJsReport).GetAwaiter().GetResult();
        }

        protected void getCheckedData(int assetid)
        {
            //connect to the database get the data for the selected asset and fill dt.
        }
        //protected async Task GenerateJsReportAsync()
        //{

        //    //EmbeddedReportingServer embeddedServer = new EmbeddedReportingServer(port: 2000);


        //    ////embeddedServer.StartAsync().Wait();
        //    //await embeddedServer.StartAsync();

        //    //Report result = await embeddedServer.ReportingService.RenderAsync(new RenderRequest()
        //    //{
        //    //    template = new Template()
        //    //    {
        //    //        content = "<h1>Hello from {{greetings}}</h1>",
        //    //        recipe = "phantom-pdf",
        //    //        engine = "handlebars"
        //    //    },
        //    //    data = new
        //    //    {
        //    //        greetings = ".NET embedded jsreport. Simple Report"
        //    //    }
        //    //});

        //    //using (var fileStream = File.Create("C:\\temp\\jsreport.pdf"))
        //    //{
        //    //    result.Content.CopyTo(fileStream);
        //    //}

        //}

        protected async Task GenerateLocalJsReport()
        {
            var rs = new LocalReporting().UseBinary(JsReportBinary.GetBinary()).AsUtility().Create();

            var report = await rs.RenderAsync(new RenderRequest()
            {
                Template = new Template()
                {
                    Recipe = Recipe.PhantomPdf,
                    Engine = Engine.None,
                    Content = "Hello from pdf"
                }
            });

            using (var fileStream = File.Create("D:\\jsrep\\hellojsrep.pdf"))
            {
                report.Content.CopyTo(fileStream);
            }

   
        }
    }
}