namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ReceiverCallNotAllowedException : android.util.AndroidRuntimeException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ReceiverCallNotAllowedException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ReceiverCallNotAllowedException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ReceiverCallNotAllowedException(@__env); 
			} 
		} 
		protected ReceiverCallNotAllowedException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ReceiverCallNotAllowedException1482; 
		public ReceiverCallNotAllowedException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ReceiverCallNotAllowedException.staticClass, global::android.content.ReceiverCallNotAllowedException._ReceiverCallNotAllowedException1482, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ReceiverCallNotAllowedException.staticClass = @__class; 
			global::android.content.ReceiverCallNotAllowedException._ReceiverCallNotAllowedException1482 = @__env.GetMethodID(global::android.content.ReceiverCallNotAllowedException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
