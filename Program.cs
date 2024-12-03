﻿using System;
using System.Net;
using Serilog;
using Serilog.Core;
using Serilog.Formatting.Compact;


class Program{

    private static readonly string logPath = "./logs/log.json";
    private static readonly ILogger _logger = new LoggerConfiguration().WriteTo.File(new CompactJsonFormatter(), logPath).CreateLogger();

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