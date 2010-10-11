namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CameraProfile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CameraProfile()
		{
			InitJNI();
		}
		protected CameraProfile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getJpegEncodingQualityParameter4940;
		public static int getJpegEncodingQualityParameter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.CameraProfile.staticClass, global::android.media.CameraProfile._getJpegEncodingQualityParameter4940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CameraProfile4941;
		public CameraProfile()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.CameraProfile.staticClass, global::android.media.CameraProfile._CameraProfile4941);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.CameraProfile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/CameraProfile"));
			global::android.media.CameraProfile._getJpegEncodingQualityParameter4940 = @__env.GetStaticMethodIDNoThrow(global::android.media.CameraProfile.staticClass, "getJpegEncodingQualityParameter", "(I)I");
			global::android.media.CameraProfile._CameraProfile4941 = @__env.GetMethodIDNoThrow(global::android.media.CameraProfile.staticClass, "<init>", "()V");
		}
	}
}
