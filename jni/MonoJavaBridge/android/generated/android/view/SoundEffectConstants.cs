namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SoundEffectConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SoundEffectConstants()
		{
			InitJNI();
		}
		protected SoundEffectConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContantForFocusDirection9543;
		public static int getContantForFocusDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.SoundEffectConstants.staticClass, global::android.view.SoundEffectConstants._getContantForFocusDirection9543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int CLICK
		{
			get
			{
				return 0;
			}
		}
		public static int NAVIGATION_LEFT
		{
			get
			{
				return 1;
			}
		}
		public static int NAVIGATION_UP
		{
			get
			{
				return 2;
			}
		}
		public static int NAVIGATION_RIGHT
		{
			get
			{
				return 3;
			}
		}
		public static int NAVIGATION_DOWN
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SoundEffectConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SoundEffectConstants"));
			global::android.view.SoundEffectConstants._getContantForFocusDirection9543 = @__env.GetStaticMethodIDNoThrow(global::android.view.SoundEffectConstants.staticClass, "getContantForFocusDirection", "(I)I");
		}
	}
}
