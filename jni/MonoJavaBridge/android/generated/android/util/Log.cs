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
		internal static global::MonoJavaBridge.MethodId _println13709;
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._println13709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _i13710;
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i13710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _i13711;
		public static int i(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i13711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _e13712;
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e13712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _e13713;
		public static int e(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e13713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _v13714;
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v13714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _v13715;
		public static int v(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v13715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _w13716;
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w13716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _w13717;
		public static int w(java.lang.String arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w13717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _w13718;
		public static int w(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w13718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _d13719;
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d13719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _d13720;
		public static int d(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d13720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable13721;
		public static bool isLoggable(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, global::android.util.Log._isLoggable13721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf13722;
		public static int wtf(java.lang.String arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf13722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf13723;
		public static int wtf(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf13723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf13724;
		public static int wtf(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf13724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getStackTraceString13725;
		public static global::java.lang.String getStackTraceString(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Log.staticClass, global::android.util.Log._getStackTraceString13725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
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
			global::android.util.Log._println13709 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._i13710 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._i13711 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._e13712 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._e13713 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._v13714 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._v13715 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._w13716 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._w13717 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._w13718 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._d13719 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._d13720 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._isLoggable13721 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z");
			global::android.util.Log._wtf13722 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._wtf13723 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._wtf13724 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._getStackTraceString13725 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
		}
	}
}
