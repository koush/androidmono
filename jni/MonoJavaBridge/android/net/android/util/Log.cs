namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Log : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Log() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.Log), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _println7154; 
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _println7154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _i7155; 
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _i7155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _i7156; 
		public static int i(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _i7156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _e7157; 
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _e7157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _e7158; 
		public static int e(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _e7158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _v7159; 
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _v7159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _v7160; 
		public static int v(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _v7160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _w7161; 
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _w7161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _w7162; 
		public static int w(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _w7162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _w7163; 
		public static int w(java.lang.String arg0, java.lang.Throwable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _w7163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _d7164; 
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _d7164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _d7165; 
		public static int d(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, _d7165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoggable7166; 
		public static bool isLoggable(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, _isLoggable7166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStackTraceString7167; 
		public static java.lang.String getStackTraceString(java.lang.Throwable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Log.staticClass, _getStackTraceString7167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
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
			global::android.util.Log._println7154 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._i7155 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._i7156 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._e7157 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._e7158 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._v7159 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._v7160 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._w7161 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._w7162 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._w7163 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._d7164 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I"); 
			global::android.util.Log._d7165 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.util.Log._isLoggable7166 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z"); 
			global::android.util.Log._getStackTraceString7167 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;"); 
		} 
	} 
} 
