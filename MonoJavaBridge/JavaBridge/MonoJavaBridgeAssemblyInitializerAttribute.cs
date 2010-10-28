using System;
using System.Reflection;

namespace MonoJavaBridge
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class MonoJavaBridgeAssemblyInitializerAttribute : Attribute
    {
        public Type Type
        {
            get
            {
                return mType;
            }
        }
        
        Type mType;
        
        public MonoJavaBridgeAssemblyInitializerAttribute (Type type)
        {
            mType = type;
        }
    }
}

