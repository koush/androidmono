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
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._getKeys26442)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26443;
		public virtual global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._handleGetObject26443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _handleKeySet26444;
		protected override global::java.util.Set handleKeySet()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._handleKeySet26444)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getContents26445;
		protected abstract global::java.lang.Object[][] getContents();
		internal static global::MonoJavaBridge.MethodId _ListResourceBundle26446;
		public ListResourceBundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._ListResourceBundle26446);
			Init(@__env, handle);
		}
		static ListResourceBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundle"));
			global::java.util.ListResourceBundle._getKeys26442 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.ListResourceBundle._handleGetObject26443 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.ListResourceBundle._handleKeySet26444 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;");
			global::java.util.ListResourceBundle._getContents26445 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "getContents", "()[[Ljava/lang/Object;");
			global::java.util.ListResourceBundle._ListResourceBundle26446 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "<init>", "()V");
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle_._getContents26447)) as java.lang.Object[][];
		}
		static ListResourceBundle_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundle"));
			global::java.util.ListResourceBundle_._getContents26447 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle_.staticClass, "getContents", "()[[Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
