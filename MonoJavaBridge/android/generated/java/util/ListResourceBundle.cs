namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ListResourceBundle_))]
	public abstract partial class ListResourceBundle : java.util.ListResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ListResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26442;
		public override global::java.util.Enumeration getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.ListResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;", ref global::java.util.ListResourceBundle._getKeys26442) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26443;
		public virtual global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.util.ListResourceBundle._handleGetObject26443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _handleKeySet26444;
		protected override global::java.util.Set handleKeySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.ListResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;", ref global::java.util.ListResourceBundle._handleKeySet26444) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getContents26445;
		protected abstract global::java.lang.Object[][] getContents();
		internal static global::MonoJavaBridge.MethodId _ListResourceBundle26446;
		public ListResourceBundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ListResourceBundle._ListResourceBundle26446.native == global::System.IntPtr.Zero)
				global::java.util.ListResourceBundle._ListResourceBundle26446 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._ListResourceBundle26446);
			Init(@__env, handle);
		}
		static ListResourceBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundle"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ListResourceBundle))]
	internal sealed partial class ListResourceBundle_ : java.util.ListResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ListResourceBundle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContents26447;
		protected override global::java.lang.Object[][] getContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object[]>(this, global::java.util.ListResourceBundle_.staticClass, "getContents", "()[[Ljava/lang/Object;", ref global::java.util.ListResourceBundle_._getContents26447) as java.lang.Object[][];
		}
		static ListResourceBundle_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundle"));
		}
		internal static void InitJNI()
		{
		}
	}
}
