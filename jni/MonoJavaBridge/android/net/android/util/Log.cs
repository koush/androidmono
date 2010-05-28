namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Log : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Log() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Log), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.Log(@__env); 
			} 
		} 
		internal Log(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _println7556; 
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._println7556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _i7557; 
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i7557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _i7558; 
		public static int i(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i7558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _e7559; 
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e7559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _e7560; 
		public static int e(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e7560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _v7561; 
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v7561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _v7562; 
		public static int v(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v7562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _w7563; 
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w7563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _w7564; 
		public static int w(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w7564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _w7565; 
		public static int w(java.lang.String arg0, java.lang.Throwable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w7565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _d7566; 
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d7566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _d7567; 
		public static int d(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d7567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoggable7568; 
		public static bool isLoggable(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, global::android.util.Log._isLoggable7568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStackTraceString7569; 
		public static global::java.lang.String getStackTraceString(java.lang.Throwable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Log.staticClass, global::android.util.Log._getStackTraceString7569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		public static int VERBOSE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DEBUG
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int INFO
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int WARN
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int ERROR
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int ASSERT
		{ 
			get 
			{ 
				return 7; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.Log.staticClass = @__class; 
			global::android.util.Log._println7556 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._i7557 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._i7558 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._e7559 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._e7560 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._v7561 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._v7562 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._w7563 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._w7564 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._w7565 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._d7566 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._d7567 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._isLoggable7568 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z"); 
			global::android.util.Log._getStackTraceString7569 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;"); 
		} 
	} 
} 
