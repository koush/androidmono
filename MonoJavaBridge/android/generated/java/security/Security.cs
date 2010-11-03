namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Security : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Security(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void setProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m0.native == global::System.IntPtr.Zero)
				global::java.security.Security._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.security.Security.staticClass, global::java.security.Security._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m1.native == global::System.IntPtr.Zero)
				global::java.security.Security._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.Provider getProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m2.native == global::System.IntPtr.Zero)
				global::java.security.Security._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProvider", "(Ljava/lang/String;)Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String getAlgorithmProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m3.native == global::System.IntPtr.Zero)
				global::java.security.Security._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getAlgorithmProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int insertProviderAt(java.security.Provider arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m4.native == global::System.IntPtr.Zero)
				global::java.security.Security._m4 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "insertProviderAt", "(Ljava/security/Provider;I)I");
			return @__env.CallStaticIntMethod(java.security.Security.staticClass, global::java.security.Security._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int addProvider(java.security.Provider arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m5.native == global::System.IntPtr.Zero)
				global::java.security.Security._m5 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "addProvider", "(Ljava/security/Provider;)I");
			return @__env.CallStaticIntMethod(java.security.Security.staticClass, global::java.security.Security._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void removeProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m6.native == global::System.IntPtr.Zero)
				global::java.security.Security._m6 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "removeProvider", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.security.Security.staticClass, global::java.security.Security._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.security.Provider[] Providers
		{
			get
			{
				return getProviders();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.security.Provider[] getProviders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m7.native == global::System.IntPtr.Zero)
				global::java.security.Security._m7 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "()[Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m7)) as java.security.Provider[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.security.Provider[] getProviders(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m8.native == global::System.IntPtr.Zero)
				global::java.security.Security._m8 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "(Ljava/util/Map;)[Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.security.Provider[] getProviders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m9.native == global::System.IntPtr.Zero)
				global::java.security.Security._m9 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "(Ljava/lang/String;)[Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.util.Set getAlgorithms(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Security._m10.native == global::System.IntPtr.Zero)
				global::java.security.Security._m10 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getAlgorithms", "(Ljava/lang/String;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		static Security()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Security.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Security"));
		}
	}
}
