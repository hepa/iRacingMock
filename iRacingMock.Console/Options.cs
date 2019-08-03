using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace iRacingMock.Console
{
    class Options
    {
        [Option('i', "input", Required = true, HelpText = "Set the input file path.")]
        public string Input { get; set; }        
    }
}
