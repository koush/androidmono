namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HapticFeedbackConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HapticFeedbackConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static int LONG_PRESS
		{
			get
			{
				return 0;
			}
		}
		public static int VIRTUAL_KEY
		{
			get
			{
				return 1;
			}
		}
		public static int KEYBOARD_TAP
		{
			get
			{
				return 3;
			}
		}
		public static int FLAG_IGNORE_VIEW_SETTING
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_IGNORE_GLOBAL_SETTING
		{
			get
			{
				return 2;
			}
		}
		static HapticFeedbackConstants()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.HapticFeedbackConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/HapticFeedbackConstants"));
		}
		internal static void InitJNI()
		{
		}
	}
}
