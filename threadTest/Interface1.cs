using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadTest
{
    public interface IAsyncResult
    {

        object AsyncState { get; }
        WaitHandle AsyncWaitHandle { get; }
        bool CompletedSynchronously { get; }
        bool IsCompleted { get; }

    }
}
