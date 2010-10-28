using System;
namespace MonoJavaBridge
{
    public class JavaClassAttribute : Attribute
    {
        public Type ProxyType
        {
            get
            {
                return mProxyType;
            }
        }
        
        Type mProxyType;
        
        public JavaClassAttribute(Type proxyType)
        {
            mProxyType = proxyType;
        }
        
        public JavaClassAttribute()
        {
        }
    }
}

