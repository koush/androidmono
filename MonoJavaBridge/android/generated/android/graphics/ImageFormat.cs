namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ImageFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int getBitsPerPixel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ImageFormat._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.ImageFormat._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.ImageFormat.staticClass, "getBitsPerPixel", "(I)I");
			return @__env.CallStaticIntMethod(android.graphics.ImageFormat.staticClass, global::android.graphics.ImageFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ImageFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ImageFormat._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.ImageFormat._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.ImageFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ImageFormat.staticClass, global::android.graphics.ImageFormat._m1);
			Init(@__env, handle);
		}
		public static int UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int RGB_565
		{
			get
			{
				return 4;
			}
		}
		public static int NV16
		{
			get
			{
				return 16;
			}
		}
		public static int NV21
		{
			get
			{
				return 17;
			}
		}
		public static int YUY2
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
		static ImageFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ImageFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ImageFormat"));
		}
	}
}
