using System;
using System.Collections.Generic;
using System.Text;
using com.koushikdutta.helloworld;

namespace Mono2Jni.Test
{
    public class HelloWorldActivitySub : HelloWorldActivity
    {
        #region Gross Boilerplate
        protected HelloWorldActivitySub(global::net.sf.jni4net.jni.JNIEnv @__env)
            : base(@__env)
        {
        }
        #endregion

        protected override void onCreate(android.os.Bundle arg0)
        {
            base.onCreate(arg0);
        }

        public override void onCreate(string hello)
        {
            base.onCreate(hello);
        }
    }
}
