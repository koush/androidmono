namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Color : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Color()
		{
			InitJNI();
		}
		protected Color(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _alpha3271;
		public static int alpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._alpha3271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _red3272;
		public static int red(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._red3272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _green3273;
		public static int green(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._green3273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _blue3274;
		public static int blue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._blue3274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rgb3275;
		public static int rgb(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._rgb3275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _argb3276;
		public static int argb(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._argb3276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _parseColor3277;
		public static int parseColor(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._parseColor3277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RGBToHSV3278;
		public static void RGBToHSV(int arg0, int arg1, int arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._RGBToHSV3278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _colorToHSV3279;
		public static void colorToHSV(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._colorToHSV3279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HSVToColor3280;
		public static int HSVToColor(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor3280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HSVToColor3281;
		public static int HSVToColor(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor3281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Color3282;
		public Color()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Color.staticClass, global::android.graphics.Color._Color3282);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Color.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Color"));
			global::android.graphics.Color._alpha3271 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "alpha", "(I)I");
			global::android.graphics.Color._red3272 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "red", "(I)I");
			global::android.graphics.Color._green3273 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "green", "(I)I");
			global::android.graphics.Color._blue3274 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "blue", "(I)I");
			global::android.graphics.Color._rgb3275 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "rgb", "(III)I");
			global::android.graphics.Color._argb3276 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "argb", "(IIII)I");
			global::android.graphics.Color._parseColor3277 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "parseColor", "(Ljava/lang/String;)I");
			global::android.graphics.Color._RGBToHSV3278 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "RGBToHSV", "(III[F)V");
			global::android.graphics.Color._colorToHSV3279 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "colorToHSV", "(I[F)V");
			global::android.graphics.Color._HSVToColor3280 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "([F)I");
			global::android.graphics.Color._HSVToColor3281 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "(I[F)I");
			global::android.graphics.Color._Color3282 = @__env.GetMethodIDNoThrow(global::android.graphics.Color.staticClass, "<init>", "()V");
		}
	}
}
