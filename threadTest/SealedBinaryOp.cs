using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadTest
{
    public sealed class BinaryOp : System.MulticastDelegate
    {

        public BinaryOp(object target, uint functionAddress);
        public int Invoke(int x, int y);

        //Used to invoke a method asynchronously
        public IAsyncResult BeginInvoke(int x, int y,
            AsyncCallback cb, object state);

        //Used to fetcch the return value
        //of the invoked method
        public int EndInvoke(IAsyncResult result);

    }
}
