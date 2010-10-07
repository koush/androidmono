namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AndroidException : java.lang.Exception
	{
		internal static global::java.lang.Class staticClass;
		static AndroidException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.AndroidException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.AndroidException(@__env);
			}
		}
		protected AndroidException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidException8133;
		public AndroidException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException8133, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidException8134;
		public AndroidException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException8134, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidException8135;
		public AndroidException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.AndroidException.staticClass, global::android.util.AndroidException._AndroidException8135, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.AndroidException.staticClass = @__class;
			global::android.util.AndroidException._AndroidException8133 = @__env.GetMethodID(global::android.util.AndroidException.staticClass, "<init>", "()V");
			global::android.util.AndroidException._AndroidException8134 = @__env.GetMethodID(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.util.AndroidException._AndroidException8135 = @__env.GetMethodID(global::android.util.AndroidException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
