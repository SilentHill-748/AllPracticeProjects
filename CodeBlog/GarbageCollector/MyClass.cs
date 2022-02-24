using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public class MyClass : IDisposable
    {
        private bool disposed = false;


        public MyClass()
        {

        }

        ~MyClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {   
            Dispose(true);
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Очистка управляемых ресов.
                }
                // Очистка неуправляемых ресов.

                disposed = true;
            }
        }
    }
}
