namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Log : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Log(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println13773;
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._println13773.native == global::System.IntPtr.Zero)
				global::android.util.Log._println13773 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._println13773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _i13774;
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._i13774.native == global::System.IntPtr.Zero)
				global::android.util.Log._i13774 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i13774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _i13775;
		public static int i(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._i13775.native == global::System.IntPtr.Zero)
				global::android.util.Log._i13775 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i13775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _e13776;
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._e13776.native == global::System.IntPtr.Zero)
				global::android.util.Log._e13776 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e13776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _e13777;
		public static int e(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._e13777.native == global::System.IntPtr.Zero)
				global::android.util.Log._e13777 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e13777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _v13778;
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._v13778.native == global::System.IntPtr.Zero)
				global::android.util.Log._v13778 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v13778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _v13779;
		public static int v(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._v13779.native == global::System.IntPtr.Zero)
				global::android.util.Log._v13779 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v13779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _w13780;
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._w13780.native == global::System.IntPtr.Zero)
				global::android.util.Log._w13780 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w13780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _w13781;
		public static int w(java.lang.String arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._w13781.native == global::System.IntPtr.Zero)
				global::android.util.Log._w13781 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w13781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _w13782;
		public static int w(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._w13782.native == global::System.IntPtr.Zero)
				global::android.util.Log._w13782 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w13782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _d13783;
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._d13783.native == global::System.IntPtr.Zero)
				global::android.util.Log._d13783 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d13783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _d13784;
		public static int d(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._d13784.native == global::System.IntPtr.Zero)
				global::android.util.Log._d13784 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d13784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable13785;
		public static bool isLoggable(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._isLoggable13785.native == global::System.IntPtr.Zero)
				global::android.util.Log._isLoggable13785 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z");
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, global::android.util.Log._isLoggable13785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf13786;
		public static int wtf(java.lang.String arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._wtf13786.native == global::System.IntPtr.Zero)
				global::android.util.Log._wtf13786 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf13786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf13787;
		public static int wtf(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._wtf13787.native == global::System.IntPtr.Zero)
				global::android.util.Log._wtf13787 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wtf13788;
		public static int wtf(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._wtf13788.native == global::System.IntPtr.Zero)
				global::android.util.Log._wtf13788 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf13788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getStackTraceString13789;
		public static global::java.lang.String getStackTraceString(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Log._getStackTraceString13789.native == global::System.IntPtr.Zero)
				global::android.util.Log._getStackTraceString13789 = @__env.GetStaticMethodIDNoThrow(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Log.staticClass, global::android.util.Log._getStackTraceString13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
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
		static Log()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Log.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Log"));
		}
		internal static void InitJNI()
		{
		}
	}
}
