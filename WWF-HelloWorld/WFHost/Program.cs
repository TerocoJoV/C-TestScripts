using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using HelloWorldActivities;
using System.Threading;

namespace WFHost
{

    class Program
    {
        static void Main(string[] args)
        {
            //Activity workflow1 = new HelloWorldActivities.HelloWorldActivity();
            //Activity workflow1 = new HelloWorldActivities.SayitTwice();
            //Activity workflow1 = new HelloWorldActivities.RandomLooper();
            Activity workflow1 = new HelloWorldActivities.TrafficLight();
            WorkflowInvoker.Invoke(workflow1);
            Console.ReadLine();
        }
    }
}

