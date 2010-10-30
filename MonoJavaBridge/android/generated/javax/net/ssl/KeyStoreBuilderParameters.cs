namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStoreBuilderParameters : java.lang.Object, ManagerFactoryParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyStoreBuilderParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.util.List Parameters
		{
			get
			{
				return getParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.util.List getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, "getParameters", "()Ljava/util/List;", ref global::javax.net.ssl.KeyStoreBuilderParameters._m0) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public KeyStoreBuilderParameters(java.security.KeyStore.Builder arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyStoreBuilderParameters._m1.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyStoreBuilderParameters._m1 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, "<init>", "(Ljava/security/KeyStore$Builder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyStoreBuilderParameters.staticClass, global::javax.net.ssl.KeyStoreBuilderParameters._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public KeyStoreBuilderParameters(java.util.List arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyStoreBuilderParameters._m2.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyStoreBuilderParameters._m2 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, "<init>", "(Ljava/util/List;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyStoreBuilderParameters.staticClass, global::javax.net.ssl.KeyStoreBuilderParameters._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static KeyStoreBuilderParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyStoreBuilderParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyStoreBuilderParameters"));
		}
		internal static void InitJNI()
		{
		}
	}
}
