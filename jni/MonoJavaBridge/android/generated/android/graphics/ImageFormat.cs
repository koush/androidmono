namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ImageFormat()
		{
			InitJNI();
		}
		protected ImageFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBitsPerPixel5267;
		public static int getBitsPerPixel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.ImageFormat.staticClass, global::android.graphics.ImageFormat._getBitsPerPixel5267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageFormat5268;
		public ImageFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ImageFormat.staticClass, global::android.graphics.ImageFormat._ImageFormat5268);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ImageFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ImageFormat"));
			global::android.graphics.ImageFormat._getBitsPerPixel5267 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.ImageFormat.staticClass, "getBitsPerPixel", "(I)I");
			global::android.graphics.ImageFormat._ImageFormat5268 = @__env.GetMethodIDNoThrow(global::android.graphics.ImageFormat.staticClass, "<init>", "()V");
		}
	}
}
