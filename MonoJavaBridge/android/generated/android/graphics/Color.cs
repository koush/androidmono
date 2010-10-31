namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Color : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Color(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int alpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "alpha", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int red(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "red", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int green(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m2 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "green", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int blue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m3.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m3 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "blue", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int rgb(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m4.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m4 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "rgb", "(III)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int argb(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m5.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m5 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "argb", "(IIII)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static int parseColor(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m6.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m6 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "parseColor", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void RGBToHSV(int arg0, int arg1, int arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m7 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "RGBToHSV", "(III[F)V");
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void colorToHSV(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m8 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "colorToHSV", "(I[F)V");
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static int HSVToColor(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m9 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "([F)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int HSVToColor(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m10 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "(I[F)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Color() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._m11.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._m11 = @__env.GetMethodIDNoThrow(global::android.graphics.Color.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Color.staticClass, global::android.graphics.Color._m11);
			Init(@__env, handle);
		}
		public static int BLACK
		{
			get
			{
				return -16777216;
			}
		}
		public static int DKGRAY
		{
			get
			{
				return -12303292;
			}
		}
		public static int GRAY
		{
			get
			{
				return -7829368;
			}
		}
		public static int LTGRAY
		{
			get
			{
				return -3355444;
			}
		}
		public static int WHITE
		{
			get
			{
				return -1;
			}
		}
		public static int RED
		{
			get
			{
				return -65536;
			}
		}
		public static int GREEN
		{
			get
			{
				return -16711936;
			}
		}
		public static int BLUE
		{
			get
			{
				return -16776961;
			}
		}
		public static int YELLOW
		{
			get
			{
				return -256;
			}
		}
		public static int CYAN
		{
			get
			{
				return -16711681;
			}
		}
		public static int MAGENTA
		{
			get
			{
				return -65281;
			}
		}
		public static int TRANSPARENT
		{
			get
			{
				return 0;
			}
		}
		static Color()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Color.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Color"));
		}
	}
}
