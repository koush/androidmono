namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ThumbnailUtils : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ThumbnailUtils()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.ThumbnailUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.media.ThumbnailUtils(@__env);
			}
		}
		protected ThumbnailUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _createVideoThumbnail4875;
		public static global::android.graphics.Bitmap createVideoThumbnail(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._createVideoThumbnail4875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractThumbnail4876;
		public static global::android.graphics.Bitmap extractThumbnail(android.graphics.Bitmap arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._extractThumbnail4876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractThumbnail4877;
		public static global::android.graphics.Bitmap extractThumbnail(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._extractThumbnail4877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ThumbnailUtils4878;
		public ThumbnailUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.ThumbnailUtils.staticClass, global::android.media.ThumbnailUtils._ThumbnailUtils4878, this);
		}
		public static int OPTIONS_RECYCLE_INPUT
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.ThumbnailUtils.staticClass = @__class;
			global::android.media.ThumbnailUtils._createVideoThumbnail4875 = @__env.GetStaticMethodID(global::android.media.ThumbnailUtils.staticClass, "createVideoThumbnail", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;");
			global::android.media.ThumbnailUtils._extractThumbnail4876 = @__env.GetStaticMethodID(global::android.media.ThumbnailUtils.staticClass, "extractThumbnail", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;");
			global::android.media.ThumbnailUtils._extractThumbnail4877 = @__env.GetStaticMethodID(global::android.media.ThumbnailUtils.staticClass, "extractThumbnail", "(Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;");
			global::android.media.ThumbnailUtils._ThumbnailUtils4878 = @__env.GetMethodID(global::android.media.ThumbnailUtils.staticClass, "<init>", "()V");
		}
	}
}
