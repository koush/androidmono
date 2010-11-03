namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyResourceBundle : java.util.PropertyResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PropertyResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.util.Enumeration Keys
		{
			get
			{
				return getKeys();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.Enumeration getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.PropertyResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;", ref global::java.util.PropertyResourceBundle._m0) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.PropertyResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.util.PropertyResourceBundle._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.util.Set handleKeySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.PropertyResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;", ref global::java.util.PropertyResourceBundle._m2) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PropertyResourceBundle(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PropertyResourceBundle._m3.native == global::System.IntPtr.Zero)
				global::java.util.PropertyResourceBundle._m3 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PropertyResourceBundle(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.PropertyResourceBundle._m4.native == global::System.IntPtr.Zero)
				global::java.util.PropertyResourceBundle._m4 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PropertyResourceBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyResourceBundle"));
		}
	}
}
