using System;

namespace CommandPattern
{
    class Invoker
    {
        IJob job;
        public Invoker(IJob job)
        {            
            this.job = job;
        }           
        
        public void InvokeJob()
        {
            this.job.Execute();
        }
    }
}