namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Proxy : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Proxy() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.Proxy), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.Proxy(@__env); 
			} 
		} 
		internal Proxy(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort4476; 
		public static int getPort(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, _getPort4476, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultPort4477; 
		public static int getDefaultPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.net.Proxy.staticClass, _getDefaultPort4477); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHost4478; 
		public static java.lang.String getHost(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Proxy.staticClass, _getHost4478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultHost4479; 
		public static java.lang.String getDefaultHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Proxy.staticClass, _getDefaultHost4479)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Proxy4480; 
		public Proxy()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.Proxy.staticClass, _Proxy4480, this); 
		} 
		public static java.lang.String PROXY_CHANGE_ACTION
		{ 
			get 
			{ 
				return "android.intent.action.PROXY_CHANGE"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.Proxy.staticClass = @__class; 
			global::android.net.Proxy._getPort4476 = @__env.GetStaticMethodID(global::android.net.Proxy.staticClass, "getPort", "(Landroid/content/Context;)I"); 
			global::android.net.Proxy._getDefaultPort4477 = @__env.GetStaticMethodID(global::android.net.Proxy.staticClass, "getDefaultPort", "()I"); 
			global::android.net.Proxy._getHost4478 = @__env.GetStaticMethodID(global::android.net.Proxy.staticClass, "getHost", "(Landroid/content/Context;)Ljava/lang/String;"); 
			global::android.net.Proxy._getDefaultHost4479 = @__env.GetStaticMethodID(global::android.net.Proxy.staticClass, "getDefaultHost", "()Ljava/lang/String;"); 
			global::android.net.Proxy._Proxy4480 = @__env.GetMethodID(global::android.net.Proxy.staticClass, "<init>", "()V"); 
		} 
	} 
} 
