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
		internal static global::MonoJavaBridge.MethodId _setProperty23324;
		public static void setProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.Security.staticClass, global::java.security.Security._setProperty23324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty23325;
		public static global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProperty23325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23326;
		public static global::java.security.Provider getProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProvider23326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithmProperty23327;
		public static global::java.lang.String getAlgorithmProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getAlgorithmProperty23327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _insertProviderAt23328;
		public static int insertProviderAt(java.security.Provider arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.security.Security.staticClass, global::java.security.Security._insertProviderAt23328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addProvider23329;
		public static int addProvider(java.security.Provider arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.security.Security.staticClass, global::java.security.Security._addProvider23329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeProvider23330;
		public static void removeProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.security.Security.staticClass, global::java.security.Security._removeProvider23330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.security.Provider[] Providers
		{
			get
			{
				return getProviders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProviders23331;
		public static global::java.security.Provider[] getProviders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProviders23331)) as java.security.Provider[];
		}
		internal static global::MonoJavaBridge.MethodId _getProviders23332;
		public static global::java.security.Provider[] getProviders(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProviders23332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider[];
		}
		internal static global::MonoJavaBridge.MethodId _getProviders23333;
		public static global::java.security.Provider[] getProviders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.Provider>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getProviders23333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Provider[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithms23334;
		public static global::java.util.Set getAlgorithms(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.security.Security.staticClass, global::java.security.Security._getAlgorithms23334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Security.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Security"));
			global::java.security.Security._setProperty23324 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.security.Security._getProperty23325 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Security._getProvider23326 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProvider", "(Ljava/lang/String;)Ljava/security/Provider;");
			global::java.security.Security._getAlgorithmProperty23327 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getAlgorithmProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Security._insertProviderAt23328 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "insertProviderAt", "(Ljava/security/Provider;I)I");
			global::java.security.Security._addProvider23329 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "addProvider", "(Ljava/security/Provider;)I");
			global::java.security.Security._removeProvider23330 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "removeProvider", "(Ljava/lang/String;)V");
			global::java.security.Security._getProviders23331 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "()[Ljava/security/Provider;");
			global::java.security.Security._getProviders23332 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "(Ljava/util/Map;)[Ljava/security/Provider;");
			global::java.security.Security._getProviders23333 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getProviders", "(Ljava/lang/String;)[Ljava/security/Provider;");
			global::java.security.Security._getAlgorithms23334 = @__env.GetStaticMethodIDNoThrow(global::java.security.Security.staticClass, "getAlgorithms", "(Ljava/lang/String;)Ljava/util/Set;");
		}
	}
}
