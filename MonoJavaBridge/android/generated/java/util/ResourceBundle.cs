namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ResourceBundle_))]
	public abstract partial class ResourceBundle : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object getObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ResourceBundle.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.util.ResourceBundle._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.ResourceBundle.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.ResourceBundle._m1) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool containsKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ResourceBundle.staticClass, "containsKey", "(Ljava/lang/String;)Z", ref global::java.util.ResourceBundle._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void setParent(java.util.ResourceBundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ResourceBundle.staticClass, "setParent", "(Ljava/util/ResourceBundle;)V", ref global::java.util.ResourceBundle._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._m4.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ResourceBundle;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._m5.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.ResourceBundle;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._m6.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.ResourceBundle;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.ResourceBundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.ResourceBundle._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void clearCache(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._m8.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "(Ljava/lang/ClassLoader;)V");
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void clearCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._m9.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "()V");
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String[] getStringArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.ResourceBundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", ref global::java.util.ResourceBundle._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::java.util.Enumeration getKeys();
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.Locale getLocale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.util.ResourceBundle.staticClass, "getLocale", "()Ljava/util/Locale;", ref global::java.util.ResourceBundle._m12) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected abstract global::java.lang.Object handleGetObject(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::java.util.Set handleKeySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.ResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;", ref global::java.util.ResourceBundle._m14) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public ResourceBundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._m15.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._m15 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._m15);
			Init(@__env, handle);
		}
		static ResourceBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ResourceBundle))]
	internal sealed partial class ResourceBundle_ : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResourceBundle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.util.Enumeration getKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.ResourceBundle_.staticClass, "getKeys", "()Ljava/util/Enumeration;", ref global::java.util.ResourceBundle_._m0) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ResourceBundle_.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.util.ResourceBundle_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static ResourceBundle_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
		}
	}
}
