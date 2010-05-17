namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ActivityNotFoundException : java.lang.RuntimeException
	{ 
		internal static global::java.lang.Class staticClass; 
		static ActivityNotFoundException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ActivityNotFoundException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ActivityNotFoundException(@__env); 
			} 
		} 
		protected ActivityNotFoundException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ActivityNotFoundException900; 
		public ActivityNotFoundException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ActivityNotFoundException.staticClass, _ActivityNotFoundException900, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ActivityNotFoundException901; 
		public ActivityNotFoundException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ActivityNotFoundException.staticClass, _ActivityNotFoundException901, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ActivityNotFoundException.staticClass = @__class; 
			global::android.content.ActivityNotFoundException._ActivityNotFoundException900 = @__env.GetMethodID(global::android.content.ActivityNotFoundException.staticClass, "<init>", "()V"); 
			global::android.content.ActivityNotFoundException._ActivityNotFoundException901 = @__env.GetMethodID(global::android.content.ActivityNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
