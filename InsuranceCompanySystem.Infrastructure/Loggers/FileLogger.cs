using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using InsuranceCompanySystem.Core.Interfaces;

namespace InsuranceCompanySystem.Infrastructure.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using var stream = File.AppendText("log.txt");
            stream.WriteLine($"[{DateTime.Now}] - {message}");
            stream.Flush();
        }
    }
}
