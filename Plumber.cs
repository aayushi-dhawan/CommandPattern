using System;

namespace CommandPattern
{
    class Plumber: IJob
    {
        public void Execute()
        {
            Console.WriteLine("Plumber Executed");
        }
    }
}