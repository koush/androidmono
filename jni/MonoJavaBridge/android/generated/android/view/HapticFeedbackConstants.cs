namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class HapticFeedbackConstants : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static HapticFeedbackConstants()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.HapticFeedbackConstants), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.HapticFeedbackConstants(@__env);
			}
		}
		protected HapticFeedbackConstants(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.HapticFeedbackConstants.staticClass = @__class;
		}
	}
}
