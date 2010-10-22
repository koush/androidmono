namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Security : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Security()
		{
			InitJNI();
		}
		internal Security(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty23206;
		public static void setProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.Security.staticClass, global::java.security.Security._setProperty23206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty23207;
		public static global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProperty23207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23208;
		public static global::java.security.Provider getProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProvider23208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithmProperty23209;
		public static global::java.lang.String getAlgorithmProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getAlgorithmProperty23209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _insertProviderAt23210;
		public static int insertProviderAt(java.security.Provider arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.security.Security.staticClass, global::java.security.Security._insertProviderAt23210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addProvider23211;
		public static int addProvider(java.security.Provider arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.security.Security.staticClass, global::java.security.Security._addProvider23211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeProvider23212;
		public static void removeProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.Security.staticClass, global::java.security.Security._removeProvider23212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.security.Provider[] Providers
		{
			get
			{
				return getProviders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProviders23213;
		public static global::java.security.Provider[] getProviders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProviders23213)) as java.security.Provider[];
		}
		internal static global::MonoJavaBridge.MethodId _getProviders23214;
		public static global::java.security.Provider[] getProviders(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProviders23214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider[];
		}
		internal static global::MonoJavaBridge.MethodId _getProviders23215;
		public static global::java.security.Provider[] getProviders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProviders23215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithms23216;
		public static global::java.util.Set getAlgorithms(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getAlgorithms23216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Security.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Security"));
			global::java.security.Security._setProperty23206 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.security.Security._getProperty23207 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Security._getProvider23208 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProvider", "(Ljava/lang/String;)Ljava/security/Provider;");
			global::java.security.Security._getAlgorithmProperty23209 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getAlgorithmProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Security._insertProviderAt23210 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "insertProviderAt", "(Ljava/security/Provider;I)I");
			global::java.security.Security._addProvider23211 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "addProvider", "(Ljava/security/Provider;)I");
			global::java.security.Security._removeProvider23212 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "removeProvider", "(Ljava/lang/String;)V");
			global::java.security.Security._getProviders23213 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "()[Ljava/security/Provider;");
			global::java.security.Security._getProviders23214 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "(Ljava/util/Map;)[Ljava/security/Provider;");
			global::java.security.Security._getProviders23215 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "(Ljava/lang/String;)[Ljava/security/Provider;");
			global::java.security.Security._getAlgorithms23216 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getAlgorithms", "(Ljava/lang/String;)Ljava/util/Set;");
		}
	}
}
