namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ListResourceBundle_))]
	public abstract partial class ListResourceBundle : java.util.ListResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListResourceBundle()
		{
			InitJNI();
		}
		protected ListResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys20498;
		public override global::java.util.Enumeration getKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle._getKeys20498)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._getKeys20498)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject20499;
		public virtual global::java.lang.Object handleGetObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle._handleGetObject20499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._handleGetObject20499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _handleKeySet20500;
		protected override global::java.util.Set handleKeySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle._handleKeySet20500)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._handleKeySet20500)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getContents20501;
		protected abstract global::java.lang.Object[][] getContents();
		internal static global::MonoJavaBridge.MethodId _ListResourceBundle20502;
		public ListResourceBundle()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ListResourceBundle.staticClass, global::java.util.ListResourceBundle._ListResourceBundle20502);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundle"));
			global::java.util.ListResourceBundle._getKeys20498 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.ListResourceBundle._handleGetObject20499 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.ListResourceBundle._handleKeySet20500 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;");
			global::java.util.ListResourceBundle._getContents20501 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "getContents", "()[[Ljava/lang/Object;");
			global::java.util.ListResourceBundle._ListResourceBundle20502 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ListResourceBundle))]
	public sealed partial class ListResourceBundle_ : java.util.ListResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ListResourceBundle_()
		{
			InitJNI();
		}
		internal ListResourceBundle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContents20503;
		protected override global::java.lang.Object[][] getContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle_._getContents20503)) as java.lang.Object[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ListResourceBundle_.staticClass, global::java.util.ListResourceBundle_._getContents20503)) as java.lang.Object[][];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundle"));
			global::java.util.ListResourceBundle_._getContents20503 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundle_.staticClass, "getContents", "()[[Ljava/lang/Object;");
		}
	}
}
