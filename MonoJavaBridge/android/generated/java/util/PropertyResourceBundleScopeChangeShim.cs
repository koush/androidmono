namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.PropertyResourceBundleScopeChangeShim_))]
	public abstract partial class PropertyResourceBundleScopeChangeShim : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PropertyResourceBundleScopeChangeShim(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26584;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PropertyResourceBundleScopeChangeShim._handleGetObject26584.native == global::System.IntPtr.Zero)
				global::java.util.PropertyResourceBundleScopeChangeShim._handleGetObject26584 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundleScopeChangeShim.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.PropertyResourceBundleScopeChangeShim.staticClass, global::java.util.PropertyResourceBundleScopeChangeShim._handleGetObject26584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static PropertyResourceBundleScopeChangeShim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyResourceBundleScopeChangeShim.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyResourceBundleScopeChangeShim"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.PropertyResourceBundleScopeChangeShim))]
	internal sealed partial class PropertyResourceBundleScopeChangeShim_ : java.util.PropertyResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PropertyResourceBundleScopeChangeShim_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26585;
		public override global::java.util.Enumeration getKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PropertyResourceBundleScopeChangeShim_._getKeys26585.native == global::System.IntPtr.Zero)
				global::java.util.PropertyResourceBundleScopeChangeShim_._getKeys26585 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundleScopeChangeShim_.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundleScopeChangeShim_._getKeys26585)) as java.util.Enumeration;
		}
		static PropertyResourceBundleScopeChangeShim_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyResourceBundleScopeChangeShim_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyResourceBundleScopeChangeShim"));
		}
		internal static void InitJNI()
		{
		}
	}
}
