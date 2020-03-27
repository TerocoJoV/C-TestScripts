using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            CancellationTokenSource cts = new CancellationTokenSource();

            // Use ParallelOptions instance to store the CancellationToken
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;
            //po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
            Console.WriteLine("Press any key to start. Press 'c' to cancel.");
            Console.ReadKey();

            // Run a task so that we can cancel from another thread.
            Task.Factory.StartNew(() =>
            {
                bool abort=false;
                while(abort == false)
                {
                    if (Console.ReadKey().KeyChar == 'c')
                    {
                        cts.Cancel();
                        abort = true;
                    }

                }

                Console.WriteLine();
                Console.WriteLine("press any key to exit");
            });

            try
            {
                Parallel.ForEach(nums, po, (num) =>
                {
                    Random rd = new Random(); //Math.Sqrt(num);
                    //Console.WriteLine("{0} on {1}", d, Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("{0}", rd.Next(0,1000));
                    Thread.Sleep(1000);

                    //po.CancellationToken.IsCancellationRequested.ToString();
                    //Console.WriteLine(po.CancellationToken.IsCancellationRequested.ToString());
                });
            }
            catch (OperationCanceledException e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                cts.Dispose();
            }

            Console.ReadKey();
        }
    }
}
