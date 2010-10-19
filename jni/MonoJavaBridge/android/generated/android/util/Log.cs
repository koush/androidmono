namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Log : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Log()
		{
			InitJNI();
		}
		internal Log(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println9069;
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._println9069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _i9070;
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i9070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _i9071;
		public static int i(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i9071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _e9072;
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e9072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _e9073;
		public static int e(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e9073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _v9074;
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v9074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _v9075;
		public static int v(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v9075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _w9076;
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w9076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _w9077;
		public static int w(java.lang.String arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w9077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _w9078;
		public static int w(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w9078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _d9079;
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d9079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _d9080;
		public static int d(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d9080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable9081;
		public static bool isLoggable(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, global::android.util.Log._isLoggable9081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf9082;
		public static int wtf(java.lang.String arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf9082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf9083;
		public static int wtf(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf9083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf9084;
		public static int wtf(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf9084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getStackTraceString9085;
		public static global::java.lang.String getStackTraceString(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Log.staticClass, global::android.util.Log._getStackTraceString9085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Log.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Log"));
			global::android.util.Log._println9069 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._i9070 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._i9071 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._e9072 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._e9073 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._v9074 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._v9075 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._w9076 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._w9077 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._w9078 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._d9079 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._d9080 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._isLoggable9081 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z");
			global::android.util.Log._wtf9082 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._wtf9083 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._wtf9084 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._getStackTraceString9085 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
		}
	}
}
