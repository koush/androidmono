namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SoundEffectConstants : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SoundEffectConstants()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.SoundEffectConstants), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.SoundEffectConstants(@__env);
			}
		}
		protected SoundEffectConstants(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContantForFocusDirection7994;
		public static int getContantForFocusDirection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.SoundEffectConstants.staticClass, global::android.view.SoundEffectConstants._getContantForFocusDirection7994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.SoundEffectConstants.staticClass = @__class;
			global::android.view.SoundEffectConstants._getContantForFocusDirection7994 = @__env.GetStaticMethodID(global::android.view.SoundEffectConstants.staticClass, "getContantForFocusDirection", "(I)I");
		}
	}
}
