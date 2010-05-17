namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Config : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Config() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.Config), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.Config(@__env); 
			} 
		} 
		internal Config(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Config7129; 
		public Config()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.Config.staticClass, _Config7129, this); 
		} 
		public static bool DEBUG
		{ 
			get 
			{ 
				return false; 
			} 
		} 
		public static bool RELEASE
		{ 
			get 
			{ 
				return false; 
			} 
		} 
		public static bool PROFILE
		{ 
			get 
			{ 
				return false; 
			} 
		} 
		public static bool LOGV
		{ 
			get 
			{ 
				return false; 
			} 
		} 
		public static bool LOGD
		{ 
			get 
			{ 
				return true; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.Config.staticClass = @__class; 
			global::android.util.Config._Config7129 = @__env.GetMethodID(global::android.util.Config.staticClass, "<init>", "()V"); 
		} 
	} 
} 
