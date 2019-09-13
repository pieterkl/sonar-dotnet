using System;

namespace Tests.Diagnostics
{
    class Program
    {
        // from https://devblogs.microsoft.com/dotnet/understanding-the-whys-whats-and-whens-of-valuetask/
        // and from https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1?view=netstandard-2.1

        /**
         *
         * The following operations should never be performed on a ValueTask<TResult> instance:

    Awaiting the instance multiple times.
    Calling AsTask multiple times.
    Using .Result or .GetAwaiter().GetResult() when the operation hasn't yet completed, or using them multiple times.
    Using more than one of these techniques to consume the instance.

If you do any of the above, the results are undefined.
         *
         */
    }
}
