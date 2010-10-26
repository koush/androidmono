namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStoreBuilderParameters : java.lang.Object, ManagerFactoryParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyStoreBuilderParameters()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getParameters29878;
		public virtual global::java.util.List getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyStoreBuilderParameters._getParameters29878)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, global::javax.net.ssl.KeyStoreBuilderParameters._getParameters29878)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreBuilderParameters29879;
		public KeyStoreBuilderParameters(java.security.KeyStore.Builder arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyStoreBuilderParameters.staticClass, global::javax.net.ssl.KeyStoreBuilderParameters._KeyStoreBuilderParameters29879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreBuilderParameters29880;
		public KeyStoreBuilderParameters(java.util.List arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyStoreBuilderParameters.staticClass, global::javax.net.ssl.KeyStoreBuilderParameters._KeyStoreBuilderParameters29880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyStoreBuilderParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyStoreBuilderParameters"));
			global::javax.net.ssl.KeyStoreBuilderParameters._getParameters29878 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, "getParameters", "()Ljava/util/List;");
			global::javax.net.ssl.KeyStoreBuilderParameters._KeyStoreBuilderParameters29879 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, "<init>", "(Ljava/security/KeyStore$Builder;)V");
			global::javax.net.ssl.KeyStoreBuilderParameters._KeyStoreBuilderParameters29880 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyStoreBuilderParameters.staticClass, "<init>", "(Ljava/util/List;)V");
		}
	}
}
