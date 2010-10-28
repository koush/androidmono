using System;
namespace MonoJavaBridge
{
    public class JavaInterfaceAttribute : Attribute
    {
        public Type ProxyType
        {
            get
            {
                return mProxyType;
            }
        }
        
        Type mProxyType;
        
        public JavaInterfaceAttribute(Type proxyType)
        {
            mProxyType = proxyType;
        }
    }
}

