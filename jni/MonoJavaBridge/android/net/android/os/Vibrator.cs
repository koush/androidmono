namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Vibrator : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Vibrator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Vibrator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Vibrator(@__env); 
			} 
		} 
		protected Vibrator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel5888; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Vibrator)) 
				@__env.CallVoidMethod(this, global::android.os.Vibrator._cancel5888); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._cancel5888); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _vibrate5889; 
		public virtual void vibrate(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Vibrator)) 
				@__env.CallVoidMethod(this, global::android.os.Vibrator._vibrate5889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._vibrate5889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _vibrate5890; 
		public virtual void vibrate(long[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Vibrator)) 
				@__env.CallVoidMethod(this, global::android.os.Vibrator._vibrate5890, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._vibrate5890, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Vibrator.staticClass = @__class; 
			global::android.os.Vibrator._cancel5888 = @__env.GetMethodID(global::android.os.Vibrator.staticClass, "cancel", "()V"); 
			global::android.os.Vibrator._vibrate5889 = @__env.GetMethodID(global::android.os.Vibrator.staticClass, "vibrate", "(J)V"); 
			global::android.os.Vibrator._vibrate5890 = @__env.GetMethodID(global::android.os.Vibrator.staticClass, "vibrate", "([JI)V"); 
		} 
	} 
} 
