namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Proxy : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isProxyClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Proxy._m0.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Proxy._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "isProxyClass", "(Ljava/lang/Class;)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.Class getProxyClass(java.lang.ClassLoader arg0, java.lang.Class[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Proxy._m1.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Proxy._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "getProxyClass", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;)Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.Object newProxyInstance(java.lang.ClassLoader arg0, java.lang.Class[] arg1, java.lang.reflect.InvocationHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Proxy._m2.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Proxy._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "newProxyInstance", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;Ljava/lang/reflect/InvocationHandler;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.reflect.InvocationHandler getInvocationHandler(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Proxy._m3.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Proxy._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "getInvocationHandler", "(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.InvocationHandler>(@__env.CallStaticObjectMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.InvocationHandler;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected Proxy(java.lang.reflect.InvocationHandler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Proxy._m4.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Proxy._m4 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "<init>", "(Ljava/lang/reflect/InvocationHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Proxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Proxy"));
		}
	}
}
