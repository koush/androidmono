namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TimeFormatException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static TimeFormatException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.TimeFormatException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.TimeFormatException(@__env); 
			} 
		} 
		protected TimeFormatException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.TimeFormatException.staticClass = @__class; 
		} 
	} 
} 
