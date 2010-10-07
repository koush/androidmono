namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ImageFormat : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ImageFormat()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.ImageFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.ImageFormat(@__env);
			}
		}
		protected ImageFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBitsPerPixel3133;
		public static int getBitsPerPixel(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.ImageFormat.staticClass, global::android.graphics.ImageFormat._getBitsPerPixel3133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ImageFormat3134;
		public ImageFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ImageFormat.staticClass, global::android.graphics.ImageFormat._ImageFormat3134, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.ImageFormat.staticClass = @__class;
			global::android.graphics.ImageFormat._getBitsPerPixel3133 = @__env.GetStaticMethodID(global::android.graphics.ImageFormat.staticClass, "getBitsPerPixel", "(I)I");
			global::android.graphics.ImageFormat._ImageFormat3134 = @__env.GetMethodID(global::android.graphics.ImageFormat.staticClass, "<init>", "()V");
		}
	}
}
