namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Proxy : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Proxy()
		{
			InitJNI();
		}
		protected Proxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isProxyClass21148;
		public static bool isProxyClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._isProxyClass21148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProxyClass21149;
		public static global::java.lang.Class getProxyClass(java.lang.ClassLoader arg0, java.lang.Class[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._getProxyClass21149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _newProxyInstance21150;
		public static global::java.lang.Object newProxyInstance(java.lang.ClassLoader arg0, java.lang.Class[] arg1, java.lang.reflect.InvocationHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._newProxyInstance21150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInvocationHandler21151;
		public static global::java.lang.reflect.InvocationHandler getInvocationHandler(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.InvocationHandler>(@__env.CallStaticObjectMethod(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._getInvocationHandler21151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.InvocationHandler;
		}
		internal static global::MonoJavaBridge.MethodId _Proxy21152;
		protected Proxy(java.lang.reflect.InvocationHandler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.Proxy.staticClass, global::java.lang.reflect.Proxy._Proxy21152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Proxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Proxy"));
			global::java.lang.reflect.Proxy._isProxyClass21148 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "isProxyClass", "(Ljava/lang/Class;)Z");
			global::java.lang.reflect.Proxy._getProxyClass21149 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "getProxyClass", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;)Ljava/lang/Class;");
			global::java.lang.reflect.Proxy._newProxyInstance21150 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "newProxyInstance", "(Ljava/lang/ClassLoader;[Ljava/lang/Class;Ljava/lang/reflect/InvocationHandler;)Ljava/lang/Object;");
			global::java.lang.reflect.Proxy._getInvocationHandler21151 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "getInvocationHandler", "(Ljava/lang/Object;)Ljava/lang/reflect/InvocationHandler;");
			global::java.lang.reflect.Proxy._Proxy21152 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Proxy.staticClass, "<init>", "(Ljava/lang/reflect/InvocationHandler;)V");
		}
	}
}
