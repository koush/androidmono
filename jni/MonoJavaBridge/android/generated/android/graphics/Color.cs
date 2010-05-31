namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Color : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Color()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Color), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Color(@__env);
			}
		}
		protected Color(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _alpha2898;
		public static int alpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._alpha2898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _red2899;
		public static int red(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._red2899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _green2900;
		public static int green(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._green2900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _blue2901;
		public static int blue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._blue2901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rgb2902;
		public static int rgb(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._rgb2902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _argb2903;
		public static int argb(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._argb2903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseColor2904;
		public static int parseColor(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._parseColor2904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RGBToHSV2905;
		public static void RGBToHSV(int arg0, int arg1, int arg2, float[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._RGBToHSV2905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _colorToHSV2906;
		public static void colorToHSV(int arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.Color.staticClass, global::android.graphics.Color._colorToHSV2906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HSVToColor2907;
		public static int HSVToColor(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor2907, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HSVToColor2908;
		public static int HSVToColor(int arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.Color.staticClass, global::android.graphics.Color._HSVToColor2908, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Color2909;
		public Color()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Color.staticClass, global::android.graphics.Color._Color2909, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Color.staticClass = @__class;
			global::android.graphics.Color._alpha2898 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "alpha", "(I)I");
			global::android.graphics.Color._red2899 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "red", "(I)I");
			global::android.graphics.Color._green2900 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "green", "(I)I");
			global::android.graphics.Color._blue2901 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "blue", "(I)I");
			global::android.graphics.Color._rgb2902 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "rgb", "(III)I");
			global::android.graphics.Color._argb2903 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "argb", "(IIII)I");
			global::android.graphics.Color._parseColor2904 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "parseColor", "(Ljava/lang/String;)I");
			global::android.graphics.Color._RGBToHSV2905 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "RGBToHSV", "(III[F)V");
			global::android.graphics.Color._colorToHSV2906 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "colorToHSV", "(I[F)V");
			global::android.graphics.Color._HSVToColor2907 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "HSVToColor", "([F)I");
			global::android.graphics.Color._HSVToColor2908 = @__env.GetStaticMethodID(global::android.graphics.Color.staticClass, "HSVToColor", "(I[F)I");
			global::android.graphics.Color._Color2909 = @__env.GetMethodID(global::android.graphics.Color.staticClass, "<init>", "()V");
		}
	}
}
