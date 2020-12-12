using System;

namespace CommandPattern
{
    class Carpenter:IJob
    {
        public void Execute()
        {
            Console.WriteLine("Carpenter Executed");
        }
    }
}