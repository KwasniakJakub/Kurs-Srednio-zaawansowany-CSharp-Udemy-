using System;
using System.Collections.Generic;

namespace WorkflowEngine_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
            Console.ReadLine();
        }
    }
    public interface iTask
    {
        void Execute();
    }
    public interface iWorkFLow
    {
        void Add(iTask task);
        void Remove(iTask itask);
        IEnumerable<iTask> GetTasks();
    }
    public class WorkFlow : iWorkFLow
    {
        private readonly List<iTask> _tasks;
        public WorkFlow()
        {
            _tasks = new List<iTask>();
        }
        public void Add(iTask task)
        {
            _tasks.Add(task);
        }

        public void Remove(iTask task)
        {
            _tasks.Remove(task);
        }
        public IEnumerable<iTask> GetTasks()
        {
            return _tasks;
        }
    }
    class VideoUploader : iTask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video.");
        }

    }
    class CallWebService : iTask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }
    class SendEmail : iTask
    {
        public void Execute()
        {
            Console.WriteLine("Sending a email...");
        }
    }
    class ChangeStatus : iTask
    {
        public void Execute()
        {
            Console.WriteLine("Status changed...");
        }
    }
    public class WorkFlowEngine
    {
       
        public void Run(iWorkFLow workFlow)
        {
            foreach (iTask I in workFlow.GetTasks()) 
            {
                try
                {
                    I.Execute();
                }
                catch (Exception)
                {
                    //Logging
                    //Terminate and persist the state of workflow
                    throw;
                }
                
            }
        }
    }
}
