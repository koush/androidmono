namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PixelFormat : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PixelFormat() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PixelFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PixelFormat(@__env); 
			} 
		} 
		protected PixelFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPixelFormatInfo3028; 
		public static void getPixelFormatInfo(int arg0, android.graphics.PixelFormat arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.graphics.PixelFormat.staticClass, _getPixelFormatInfo3028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatHasAlpha3029; 
		public static bool formatHasAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.PixelFormat.staticClass, _formatHasAlpha3029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PixelFormat3030; 
		public PixelFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PixelFormat.staticClass, _PixelFormat3030, this); 
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
		internal static global::net.sf.jni4net.jni.FieldId _bytesPerPixel3031; 
		public int bytesPerPixel
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _bitsPerPixel3032; 
		public int bitsPerPixel
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PixelFormat.staticClass = @__class; 
			global::android.graphics.PixelFormat._getPixelFormatInfo3028 = @__env.GetStaticMethodID(global::android.graphics.PixelFormat.staticClass, "getPixelFormatInfo", "(ILandroid/graphics/PixelFormat;)V"); 
			global::android.graphics.PixelFormat._formatHasAlpha3029 = @__env.GetStaticMethodID(global::android.graphics.PixelFormat.staticClass, "formatHasAlpha", "(I)Z"); 
			global::android.graphics.PixelFormat._PixelFormat3030 = @__env.GetMethodID(global::android.graphics.PixelFormat.staticClass, "<init>", "()V"); 
		} 
	} 
} 
