namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PixelFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PixelFormat()
		{
			InitJNI();
		}
		protected PixelFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPixelFormatInfo5595;
		public static void getPixelFormatInfo(int arg0, android.graphics.PixelFormat arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.graphics.PixelFormat.staticClass, global::android.graphics.PixelFormat._getPixelFormatInfo5595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatHasAlpha5596;
		public static bool formatHasAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.PixelFormat.staticClass, global::android.graphics.PixelFormat._formatHasAlpha5596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PixelFormat5597;
		public PixelFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PixelFormat.staticClass, global::android.graphics.PixelFormat._PixelFormat5597);
			Init(@__env, handle);
		}
		public static int UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int TRANSLUCENT
		{
			get
			{
				return -3;
			}
		}
		public static int TRANSPARENT
		{
			get
			{
				return -2;
			}
		}
		public static int OPAQUE
		{
			get
			{
				return -1;
			}
		}
		public static int RGBA_8888
		{
			get
			{
				return 1;
			}
		}
		public static int RGBX_8888
		{
			get
			{
				return 2;
			}
		}
		public static int RGB_888
		{
			get
			{
				return 3;
			}
		}
		public static int RGB_565
		{
			get
			{
				return 4;
			}
		}
		public static int RGBA_5551
		{
			get
			{
				return 6;
			}
		}
		public static int RGBA_4444
		{
			get
			{
				return 7;
			}
		}
		public static int A_8
		{
			get
			{
				return 8;
			}
		}
		public static int L_8
		{
			get
			{
				return 9;
			}
		}
		public static int LA_88
		{
			get
			{
				return 10;
			}
		}
		public static int RGB_332
		{
			get
			{
				return 11;
			}
		}
		public static int YCbCr_422_SP
		{
			get
			{
				return 16;
			}
		}
		public static int YCbCr_420_SP
		{
			get
			{
				return 17;
			}
		}
		public static int YCbCr_422_I
		{
			get
			{
				return 20;
			}
		}
		public static int JPEG
		{
			get
			{
				return 256;
			}
		}
		internal static global::MonoJavaBridge.FieldId _bytesPerPixel5616;
		public int bytesPerPixel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bytesPerPixel5616);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bitsPerPixel5617;
		public int bitsPerPixel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bitsPerPixel5617);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PixelFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PixelFormat"));
			global::android.graphics.PixelFormat._getPixelFormatInfo5595 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PixelFormat.staticClass, "getPixelFormatInfo", "(ILandroid/graphics/PixelFormat;)V");
			global::android.graphics.PixelFormat._formatHasAlpha5596 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PixelFormat.staticClass, "formatHasAlpha", "(I)Z");
			global::android.graphics.PixelFormat._PixelFormat5597 = @__env.GetMethodIDNoThrow(global::android.graphics.PixelFormat.staticClass, "<init>", "()V");
			global::android.graphics.PixelFormat._bytesPerPixel5616 = @__env.GetFieldIDNoThrow(global::android.graphics.PixelFormat.staticClass, "bytesPerPixel", "I");
			global::android.graphics.PixelFormat._bitsPerPixel5617 = @__env.GetFieldIDNoThrow(global::android.graphics.PixelFormat.staticClass, "bitsPerPixel", "I");
		}
	}
}
