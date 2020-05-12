using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WFCode
{

    class Program
    {
        static void Main(string[] args)
        {
            //Activity workflow1 = new WriteLine { Text = "Hello World!" };


            Variable<string> OutputString = new Variable<string>
            {
                Name = "OutputString"
            };
            Activity workflow2 = new Sequence
            {
                

                Activities =
                {
                    //new WriteLine { Text = "Hello World!" },
                    //new WriteLine { Text = "Hello World2!" }

                }
                
            };
            WorkflowInvoker.Invoke(workflow2);
            Console.ReadKey();
        }
    }
}
