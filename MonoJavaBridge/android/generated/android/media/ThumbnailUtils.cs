namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThumbnailUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThumbnailUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.graphics.Bitmap createVideoThumbnail(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.ThumbnailUtils._m0.native == global::System.IntPtr.Zero)
				global::android.media.ThumbnailUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "createVideoThumbnail", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.graphics.Bitmap extractThumbnail(android.graphics.Bitmap arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.ThumbnailUtils._m1.native == global::System.IntPtr.Zero)
				global::android.media.ThumbnailUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "extractThumbnail", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.graphics.Bitmap extractThumbnail(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.ThumbnailUtils._m2.native == global::System.IntPtr.Zero)
				global::android.media.ThumbnailUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "extractThumbnail", "(Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ThumbnailUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.ThumbnailUtils._m3.native == global::System.IntPtr.Zero)
				global::android.media.ThumbnailUtils._m3 = @__env.GetMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._m3);
			Init(@__env, handle);
		}
		public static int OPTIONS_RECYCLE_INPUT
		{
			get
			{
				return 2;
			}
		}
		static ThumbnailUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.ThumbnailUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/ThumbnailUtils"));
		}
	}
}
