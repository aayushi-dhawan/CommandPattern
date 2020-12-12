using System;

namespace CommandPattern
{
    class Gardener:IJob
    {
        public void Execute()
        {
            Console.WriteLine("Gardener Executed");
        }
    }
}