using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using NPOI.SS.Formula.Functions;

namespace SyncDelegateReview
{

    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ASynch Delegate Review *****");

            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);




        }

       

            //Invoke Add() in a synchronous manner.

            BinaryOp b = new BinaryOp(Add(10, 10));
        IAsyncResult ar = b.BeginInvoke(10, 10, null, null);

        //Do other work on primary thread...
        Console.WriteLine("Doing more work in Main()!");

            //Obtain the result of the Add()
            //method when ready.
            int answer = b.EndInvoke(ar);
        Console.WriteLine("10 + 10 is {0}.", answer);



            // //could also write 
            b.Invoke(10, 10);
            // int answer = b(10, 10);
            //   
            //   //These lines will not execute until
            //   //the Add() method has completed.
            //   Console.WriteLine("Doing more work in Main()!");
            //   Console.WriteLine("10 + 10 is {0}.", answer);
            //   Console.ReadLine();



            int Add(int x, int y)
        {

            //Print out the ID of the executing thread.
            Console.WriteLine("Add() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);

            //PAUSE TO SIMULATE A LENGTHY OPERATION.
            Thread.Sleep(5);
            return x + y;
        }

        void ExtractExecutingThread()
        {
            Thread currThread = Thread.CurrentThread;
        }

        void ExtractAppDomainHostingThread()
        {
            AppDomain ad = Thread.GetDomain();
        }

        void ExtractCurrentThreadContext()
        {
            System.Runtime.Remoting.Contexts.Context currentContext = Thread.CurrentContext;
            Context ctx = Thread.CurrentContext;

        }





        void ThreadStart(var ManagedThreadID);
            {
                Thread.start();

            }

    void deb()
    {

    }
}
}

