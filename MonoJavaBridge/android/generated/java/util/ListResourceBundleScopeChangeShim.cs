namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ListResourceBundleScopeChangeShim_))]
	public abstract partial class ListResourceBundleScopeChangeShim : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ListResourceBundleScopeChangeShim(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListResourceBundleScopeChangeShim.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.util.ListResourceBundleScopeChangeShim._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static ListResourceBundleScopeChangeShim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundleScopeChangeShim.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundleScopeChangeShim"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ListResourceBundleScopeChangeShim))]
	internal sealed partial class ListResourceBundleScopeChangeShim_ : java.util.ListResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ListResourceBundleScopeChangeShim_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.Enumeration getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.ListResourceBundleScopeChangeShim_.staticClass, "getKeys", "()Ljava/util/Enumeration;", ref global::java.util.ListResourceBundleScopeChangeShim_._m0) as java.util.Enumeration;
		}
		static ListResourceBundleScopeChangeShim_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundleScopeChangeShim_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundleScopeChangeShim"));
		}
	}
}
