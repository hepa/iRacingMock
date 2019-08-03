using CommandLine;
using iRacingMock.ClassLibrary;
using System;
using System.Diagnostics;
using System.IO;

namespace iRacingMock.Console
{
    class Program
    {
        static object _lock = new object();

        static void Main(string[] args)
        {            

            //Parser.Default.ParseArguments<Options>(args)
            //       .WithParsed<Options>(o =>
            //       {
            //           var file = File.ReadAllLines(o.Input);
            //           new Mock(file).Start();
            //       });
        }
    }
}
