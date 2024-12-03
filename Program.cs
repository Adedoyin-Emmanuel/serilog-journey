using System;
using System.Net;
using Serilog;
using Serilog.Core;
using Serilog.Formatting.Json;


class Program{

    private static readonly string logPath = "./logs/log.json";
    private static readonly ILogger _logger = new LoggerConfiguration().WriteTo.File(new JsonFormatter(), logPath, rollingInterval: RollingInterval.Day).CreateLogger();

    static public void Main(string[] args){

        try
        {
            _logger.Information("Something something");

            throw new Exception("Something went wrong bruh");
        }
        catch (System.Exception ex)
        {
            _logger.Error($"{ex}");

        }finally{
            _logger.Information("The program ended ");
        }
    }
}