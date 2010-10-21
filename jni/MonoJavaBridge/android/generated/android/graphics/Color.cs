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
		internal static global::MonoJavaBridge.MethodId _alpha5196;
		public static int alpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._alpha5196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _red5197;
		public static int red(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._red5197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _green5198;
		public static int green(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._green5198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _blue5199;
		public static int blue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._blue5199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rgb5200;
		public static int rgb(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._rgb5200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _argb5201;
		public static int argb(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._argb5201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _parseColor5202;
		public static int parseColor(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._parseColor5202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RGBToHSV5203;
		public static void RGBToHSV(int arg0, int arg1, int arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._RGBToHSV5203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _colorToHSV5204;
		public static void colorToHSV(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._colorToHSV5204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HSVToColor5205;
		public static int HSVToColor(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor5205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HSVToColor5206;
		public static int HSVToColor(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor5206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Color5207;
		public Color()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Color.staticClass, global::android.graphics.Color._Color5207);
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
			global::android.graphics.Color._alpha5196 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "alpha", "(I)I");
			global::android.graphics.Color._red5197 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "red", "(I)I");
			global::android.graphics.Color._green5198 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "green", "(I)I");
			global::android.graphics.Color._blue5199 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "blue", "(I)I");
			global::android.graphics.Color._rgb5200 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "rgb", "(III)I");
			global::android.graphics.Color._argb5201 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "argb", "(IIII)I");
			global::android.graphics.Color._parseColor5202 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "parseColor", "(Ljava/lang/String;)I");
			global::android.graphics.Color._RGBToHSV5203 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "RGBToHSV", "(III[F)V");
			global::android.graphics.Color._colorToHSV5204 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "colorToHSV", "(I[F)V");
			global::android.graphics.Color._HSVToColor5205 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "([F)I");
			global::android.graphics.Color._HSVToColor5206 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Color.staticClass, "HSVToColor", "(I[F)I");
			global::android.graphics.Color._Color5207 = @__env.GetMethodIDNoThrow(global::android.graphics.Color.staticClass, "<init>", "()V");
		}
	}
}
