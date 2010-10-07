namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class WindowManager_BadTokenException : java.lang.RuntimeException
	{
		internal static global::java.lang.Class staticClass;
		static WindowManager_BadTokenException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.WindowManager_BadTokenException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.WindowManager_BadTokenException(@__env);
			}
		}
		protected WindowManager_BadTokenException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_BadTokenException9451;
		public WindowManager_BadTokenException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_BadTokenException.staticClass, global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException9451, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_BadTokenException9452;
		public WindowManager_BadTokenException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_BadTokenException.staticClass, global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException9452, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.WindowManager_BadTokenException.staticClass = @__class;
			global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException9451 = @__env.GetMethodID(global::android.view.WindowManager_BadTokenException.staticClass, "<init>", "()V");
			global::android.view.WindowManager_BadTokenException._WindowManager_BadTokenException9452 = @__env.GetMethodID(global::android.view.WindowManager_BadTokenException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
