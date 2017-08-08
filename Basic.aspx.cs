using System;
using System.Threading.Tasks;
using System.Data;
using jsreport.Binary;
using jsreport.Types;
using jsreport.Local;
using System.IO;

namespace Jsreporter
{
    public partial class Basic : System.Web.UI.Page
    {
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
        protected async Task GenerateLocalJsReport()
        {
            var rs = new LocalReporting().UseBinary(JsReportBinary.GetBinary()).AsUtility().Create();

            var report = await rs.RenderAsync(new RenderRequest()
            {
                Template = new Template()
                {
                    Recipe = Recipe.PhantomPdf,
                    Engine = Engine.Handlebars,
                    Content = "<h1>{{title}}</h1>"
                },
                Data = new
                {
                    title="Using Handlebars"
                }
                
            });

            using (var fileStream = File.Create("D:\\jsrep\\handlebarjsrep.pdf"))
            {
                report.Content.CopyTo(fileStream);
            }


        }
    }
}