namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BadParcelableException : android.util.AndroidRuntimeException
	{
		internal new static global::java.lang.Class staticClass;
		static BadParcelableException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.BadParcelableException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.BadParcelableException(@__env);
			}
		}
		protected BadParcelableException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _BadParcelableException5349;
		public BadParcelableException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.BadParcelableException.staticClass, global::android.os.BadParcelableException._BadParcelableException5349, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BadParcelableException5350;
		public BadParcelableException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.BadParcelableException.staticClass, global::android.os.BadParcelableException._BadParcelableException5350, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.BadParcelableException.staticClass = @__class;
			global::android.os.BadParcelableException._BadParcelableException5349 = @__env.GetMethodID(global::android.os.BadParcelableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.BadParcelableException._BadParcelableException5350 = @__env.GetMethodID(global::android.os.BadParcelableException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
		}
	}
}
