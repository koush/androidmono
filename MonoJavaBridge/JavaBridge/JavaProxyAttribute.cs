using System;

namespace MonoJavaBridge
{
    public class JavaProxyAttribute : Attribute
    {
        public Type Proxy
        {
            get
            {
                return mProxy;
            }
        }
        
        Type mProxy;
        
        public JavaProxyAttribute(Type proxy)
        {
            mProxy = proxy;
        }        
    }
}