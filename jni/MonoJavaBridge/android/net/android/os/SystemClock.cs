namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class SystemClock : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SystemClock() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.SystemClock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.SystemClock(@__env); 
			} 
		} 
		internal SystemClock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sleep5601; 
		public static void sleep(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.SystemClock.staticClass, _sleep5601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _uptimeMillis5602; 
		public static long uptimeMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, _uptimeMillis5602); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTimeMillis5603; 
		public static bool setCurrentTimeMillis(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.os.SystemClock.staticClass, _setCurrentTimeMillis5603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _elapsedRealtime5604; 
		public static long elapsedRealtime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, _elapsedRealtime5604); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _currentThreadTimeMillis5605; 
		public static long currentThreadTimeMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.SystemClock.staticClass, _currentThreadTimeMillis5605); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.SystemClock.staticClass = @__class; 
			global::android.os.SystemClock._sleep5601 = @__env.GetStaticMethodID(global::android.os.SystemClock.staticClass, "sleep", "(J)V"); 
			global::android.os.SystemClock._uptimeMillis5602 = @__env.GetStaticMethodID(global::android.os.SystemClock.staticClass, "uptimeMillis", "()J"); 
			global::android.os.SystemClock._setCurrentTimeMillis5603 = @__env.GetStaticMethodID(global::android.os.SystemClock.staticClass, "setCurrentTimeMillis", "(J)Z"); 
			global::android.os.SystemClock._elapsedRealtime5604 = @__env.GetStaticMethodID(global::android.os.SystemClock.staticClass, "elapsedRealtime", "()J"); 
			global::android.os.SystemClock._currentThreadTimeMillis5605 = @__env.GetStaticMethodID(global::android.os.SystemClock.staticClass, "currentThreadTimeMillis", "()J"); 
		} 
	} 
} 
