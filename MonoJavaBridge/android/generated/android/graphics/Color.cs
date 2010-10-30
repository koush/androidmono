namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Color : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Color(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _alpha5215;
		public static int alpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._alpha5215.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._alpha5215 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "alpha", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._alpha5215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _red5216;
		public static int red(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._red5216.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._red5216 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "red", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._red5216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _green5217;
		public static int green(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._green5217.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._green5217 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "green", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._green5217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _blue5218;
		public static int blue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._blue5218.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._blue5218 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "blue", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._blue5218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rgb5219;
		public static int rgb(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._rgb5219.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._rgb5219 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "rgb", "(III)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._rgb5219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _argb5220;
		public static int argb(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._argb5220.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._argb5220 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "argb", "(IIII)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._argb5220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _parseColor5221;
		public static int parseColor(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._parseColor5221.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._parseColor5221 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "parseColor", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._parseColor5221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RGBToHSV5222;
		public static void RGBToHSV(int arg0, int arg1, int arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._RGBToHSV5222.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._RGBToHSV5222 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "RGBToHSV", "(III[F)V");
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._RGBToHSV5222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _colorToHSV5223;
		public static void colorToHSV(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._colorToHSV5223.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._colorToHSV5223 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "colorToHSV", "(I[F)V");
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._colorToHSV5223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HSVToColor5224;
		public static int HSVToColor(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._HSVToColor5224.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._HSVToColor5224 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "([F)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor5224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HSVToColor5225;
		public static int HSVToColor(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._HSVToColor5225.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._HSVToColor5225 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "(I[F)I");
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor5225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Color5226;
		public Color() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Color._Color5226.native == global::System.IntPtr.Zero)
				global::android.graphics.Color._Color5226 = @__env.GetMethodIDNoThrow(global::android.graphics.Color.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Color.staticClass, global::android.graphics.Color._Color5226);
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
		internal static void InitJNI()
		{
		}
	}
}
