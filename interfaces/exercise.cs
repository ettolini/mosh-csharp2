using System;
using System.Collections.Generic;

namespace DesignWorkflowEngine
{
    public interface IWorkflow
    {
        void Execute(string activity);
    }

    public class Workflow : IWorkflow
    {
        public List<string> Activities { get; private set; }

        public Workflow(List<string> activities)
        {
            Activities = activities;
        }
    
        public void Execute(string activity)
        {
            System.Console.WriteLine("Executing: " + activity);
        }
    }

    public class WorkflowEngine
    {   
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.Activities)
                workflow.Execute(activity);
        }
    }

    class Program
    {
        static void Main(string []args)
        {
            List<string> activities = new List<string>();
            activities.Add("Ready.");
            activities.Add("Set.");
            activities.Add("Go!");
            
            Workflow workflow = new Workflow(activities);
            WorkflowEngine workflowEngine = new WorkflowEngine();

            workflowEngine.Run(workflow);
        }
    }
}