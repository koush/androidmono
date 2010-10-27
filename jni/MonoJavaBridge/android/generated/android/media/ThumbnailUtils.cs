namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThumbnailUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThumbnailUtils()
		{
			InitJNI();
		}
		protected ThumbnailUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createVideoThumbnail7506;
		public static global::android.graphics.Bitmap createVideoThumbnail(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._createVideoThumbnail7506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _extractThumbnail7507;
		public static global::android.graphics.Bitmap extractThumbnail(android.graphics.Bitmap arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._extractThumbnail7507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _extractThumbnail7508;
		public static global::android.graphics.Bitmap extractThumbnail(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._extractThumbnail7508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _ThumbnailUtils7509;
		public ThumbnailUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._ThumbnailUtils7509);
			Init(@__env, handle);
		}
		public static int OPTIONS_RECYCLE_INPUT
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.ThumbnailUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/ThumbnailUtils"));
			global::android.media.ThumbnailUtils._createVideoThumbnail7506 = @__env.GetStaticMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "createVideoThumbnail", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;");
			global::android.media.ThumbnailUtils._extractThumbnail7507 = @__env.GetStaticMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "extractThumbnail", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			global::android.media.ThumbnailUtils._extractThumbnail7508 = @__env.GetStaticMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "extractThumbnail", "(Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;");
			global::android.media.ThumbnailUtils._ThumbnailUtils7509 = @__env.GetMethodIDNoThrow(global::android.media.ThumbnailUtils.staticClass, "<init>", "()V");
		}
	}
}
