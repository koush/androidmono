namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class InflateException : java.lang.RuntimeException
	{
		internal static global::java.lang.Class staticClass;
		static InflateException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.InflateException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.InflateException(@__env);
			}
		}
		protected InflateException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _InflateException7782;
		public InflateException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException7782, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _InflateException7783;
		public InflateException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException7783, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InflateException7784;
		public InflateException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException7784, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InflateException7785;
		public InflateException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.InflateException.staticClass, global::android.view.InflateException._InflateException7785, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.InflateException.staticClass = @__class;
			global::android.view.InflateException._InflateException7782 = @__env.GetMethodID(global::android.view.InflateException.staticClass, "<init>", "()V");
			global::android.view.InflateException._InflateException7783 = @__env.GetMethodID(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.view.InflateException._InflateException7784 = @__env.GetMethodID(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.view.InflateException._InflateException7785 = @__env.GetMethodID(global::android.view.InflateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
