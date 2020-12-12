using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker jobObj = new Invoker(new Plumber());
            jobObj.InvokeJob();

            jobObj = new Invoker(new Gardener());
            jobObj.InvokeJob();

            jobObj = new Invoker(new Gardener());
            jobObj.InvokeJob();
        }
    }
}
