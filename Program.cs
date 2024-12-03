using System;
using Serilog;
using Serilog.Core;


class Program{

    private static readonly ILogger _logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();

    static public void Main(string[] args){

        try
        {
            _logger.Information("Something something");
        }
        catch (System.Exception)
        {
            
            throw;
        }finally{
            _logger.Information("The program ended ");
        }
    }
}