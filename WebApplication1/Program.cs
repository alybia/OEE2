using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    //public class ConnecttoSAP
    //{
    //    SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
    //    conectado = int.MinValue;
    //    oCompany.Server = "localhost";
    //    oCompany.CompanyDB = "TEST_0504";
     //    oCompany.UserName = "sa";
    //    oCompany.Password = "Qweasd!234";

    //    //language
    //    oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2017;
    //    oCompany.language = BoSuppLangs.ln_Spanish_La;

    //    conectado = oCompany.Connect();
    //    if (conectado != 0)
    //        string error = oCompany.GetLastErrorDescription();
    //}
    
}

