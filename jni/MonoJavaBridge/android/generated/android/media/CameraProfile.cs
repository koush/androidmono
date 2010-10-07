namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CameraProfile : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CameraProfile()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.CameraProfile), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.media.CameraProfile(@__env);
			}
		}
		protected CameraProfile(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJpegEncodingQualityParameter4707;
		public static int getJpegEncodingQualityParameter(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.CameraProfile.staticClass, global::android.media.CameraProfile._getJpegEncodingQualityParameter4707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CameraProfile4708;
		public CameraProfile()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.CameraProfile.staticClass, global::android.media.CameraProfile._CameraProfile4708, this);
		}
		public static int QUALITY_LOW
		{
			get
			{
				return 0;
			}
		}
		public static int QUALITY_MEDIUM
		{
			get
			{
				return 1;
			}
		}
		public static int QUALITY_HIGH
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.CameraProfile.staticClass = @__class;
			global::android.media.CameraProfile._getJpegEncodingQualityParameter4707 = @__env.GetStaticMethodID(global::android.media.CameraProfile.staticClass, "getJpegEncodingQualityParameter", "(I)I");
			global::android.media.CameraProfile._CameraProfile4708 = @__env.GetMethodID(global::android.media.CameraProfile.staticClass, "<init>", "()V");
		}
	}
}
