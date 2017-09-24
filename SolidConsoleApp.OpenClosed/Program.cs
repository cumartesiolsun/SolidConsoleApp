using System;

namespace SolidConsoleApp.OpenClosed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Logger logger = new Logger(LogType.Database);
            Logger logger = new Logger(new TextLogger());
            logger.Log("Kayıt yapıldı");

            Console.ReadLine();
        }
    }

    internal class Logger : ILogger
    {
        private ILogger _logger;
        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Veritabanı: {0}", message);
        }
    }

    class XmlLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Xml: {0}", message);
        }
    }

    class TextLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Text: {0}", message);
        }
    }

    ////Yanlış yazım*******
    //internal class Logger
    //{
    //    private LogType _logType;

    //    public Logger(LogType logType)
    //    {
    //        _logType = logType;
    //    }

    //    internal void Log(string message)
    //    {
    //        if (_logType == LogType.Database)
    //        {
    //            Console.WriteLine("Veritabanı: {0}", message);
    //        }
    //        else if (_logType == LogType.Text)
    //        {
    //            Console.WriteLine("Text: {0}", message);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Xml: {0}", message);
    //        }
    //    }

    //}


    //internal enum LogType
    //{
    //    Database,
    //    Xml,
    //    Text
    //}
}