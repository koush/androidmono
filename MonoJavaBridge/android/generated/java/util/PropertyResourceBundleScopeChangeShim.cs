namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.PropertyResourceBundleScopeChangeShim_))]
	public abstract partial class PropertyResourceBundleScopeChangeShim : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PropertyResourceBundleScopeChangeShim(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.PropertyResourceBundleScopeChangeShim.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.util.PropertyResourceBundleScopeChangeShim._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static PropertyResourceBundleScopeChangeShim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyResourceBundleScopeChangeShim.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyResourceBundleScopeChangeShim"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.PropertyResourceBundleScopeChangeShim))]
	internal sealed partial class PropertyResourceBundleScopeChangeShim_ : java.util.PropertyResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PropertyResourceBundleScopeChangeShim_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.Enumeration getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.PropertyResourceBundleScopeChangeShim_.staticClass, "getKeys", "()Ljava/util/Enumeration;", ref global::java.util.PropertyResourceBundleScopeChangeShim_._m0) as java.util.Enumeration;
		}
		static PropertyResourceBundleScopeChangeShim_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyResourceBundleScopeChangeShim_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyResourceBundleScopeChangeShim"));
		}
	}
}
