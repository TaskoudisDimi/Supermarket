using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Locker : IDisposable
    {
        private object locker = new object();
        private static int lockTimeOut = -1;

        private static int LockTimeOut
        {
            get
            {
                if (lockTimeOut < 0)
                {
                    lockTimeOut = 30000;
                }
                else
                {
                    lockTimeOut = 40000;
                }
                return lockTimeOut;
            }
            set
            {
                lockTimeOut = value;
            }
        }

        public Locker(object _locker)
        {
            locker = _locker;
        }

        public static Locker Lock(object syncObject)
        {
            if (Monitor.TryEnter(syncObject, lockTimeOut))
            {
                return new Locker(syncObject);
            }
            else
            {
                // throw exception, log message, etc.
                Exception ex = new System.TimeoutException(string.Format("(class) failed to acquire the lock in {0}", LockTimeOut));

                throw ex;
            }
        }

        public void Dispose()
        {
            Monitor.Exit(locker);
        }
    }
}
