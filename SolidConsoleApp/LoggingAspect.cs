using PostSharp.Aspects;
using System;

namespace SolidConsoleApp
{
    [Serializable]
    internal class LoggingAspect : OnMethodBoundaryAspect
    {
        //public override void OnEntry(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("Loglama yapıldı.");
        //}

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Loglama yapıldı.");
        }
    }
}