using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MonoDalvikBridge
{
    public sealed class DalvikObject : IDisposable
    {
        internal int myObjectId;
        internal DalvikObject(int objectId)
        {
            myObjectId = objectId;
        }

        public void Invoke(string methodName, params object[] args)
        {
            DalvikBridge.Invoke<int>(null, myObjectId, false, typeof(void), methodName, args, null);
        }

        public void Invoke(string methodName, object[] args, RuntimeType[] runtimeTypes)
        {
            DalvikBridge.Invoke<int>(null, myObjectId, false, typeof(void), methodName, args, runtimeTypes);
        }

        public T Invoke<T>(string methodName, params object[] args)
        {
            return DalvikBridge.Invoke<T>(null, myObjectId, false, typeof(T), methodName, args, null);
        }

        public T Invoke<T>(string methodName, object[] args, RuntimeType[] runtimeTypes)
        {
            return DalvikBridge.Invoke<T>(null, myObjectId, false, typeof(T), methodName, args, runtimeTypes);
        }

        ~DalvikObject()
        {
            Dispose();
        }

        bool myDisposed = false;
        #region IDisposable Members

        public void Dispose()
        {
            if (myDisposed)
                return;
            myDisposed = true;
            DalvikBridge.Invoke("com.koushikdutta.mono.MonoRuntime", "removeJavaReference", myObjectId);
        }

        #endregion
    }
}
