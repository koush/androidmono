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
		internal static global::net.sf.jni4net.jni.MethodId _println8219;
		public static int println(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._println8219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _i8220;
		public static int i(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i8220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _i8221;
		public static int i(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._i8221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _e8222;
		public static int e(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e8222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _e8223;
		public static int e(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._e8223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _v8224;
		public static int v(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v8224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _v8225;
		public static int v(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._v8225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _w8226;
		public static int w(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w8226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _w8227;
		public static int w(java.lang.String arg0, java.lang.Throwable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w8227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _w8228;
		public static int w(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._w8228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _d8229;
		public static int d(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d8229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _d8230;
		public static int d(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._d8230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLoggable8231;
		public static bool isLoggable(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.Log.staticClass, global::android.util.Log._isLoggable8231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wtf8232;
		public static int wtf(java.lang.String arg0, java.lang.Throwable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf8232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wtf8233;
		public static int wtf(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf8233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _wtf8234;
		public static int wtf(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.Log.staticClass, global::android.util.Log._wtf8234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStackTraceString8235;
		public static global::java.lang.String getStackTraceString(java.lang.Throwable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Log.staticClass, global::android.util.Log._getStackTraceString8235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
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
			global::android.util.Log._println8219 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "println", "(ILjava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._i8220 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._i8221 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "i", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._e8222 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._e8223 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "e", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._v8224 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._v8225 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "v", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._w8226 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._w8227 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._w8228 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "w", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._d8229 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._d8230 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "d", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._isLoggable8231 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "isLoggable", "(Ljava/lang/String;I)Z");
			global::android.util.Log._wtf8232 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._wtf8233 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.util.Log._wtf8234 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "wtf", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I");
			global::android.util.Log._getStackTraceString8235 = @__env.GetStaticMethodID(global::android.util.Log.staticClass, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
		}
	}
}
