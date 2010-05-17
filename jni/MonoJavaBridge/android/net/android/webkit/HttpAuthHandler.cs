namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HttpAuthHandler : android.os.Handler
	{ 
		internal new static global::java.lang.Class staticClass; 
		static HttpAuthHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.HttpAuthHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.HttpAuthHandler(@__env); 
			} 
		} 
		protected HttpAuthHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel8610; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.HttpAuthHandler)) 
				@__env.CallVoidMethod(this, _cancel8610); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.HttpAuthHandler.staticClass, _cancel8610); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage8611; 
		public override void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.HttpAuthHandler)) 
				@__env.CallVoidMethod(this, _handleMessage8611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.HttpAuthHandler.staticClass, _handleMessage8611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _proceed8612; 
		public virtual void proceed(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.HttpAuthHandler)) 
				@__env.CallVoidMethod(this, _proceed8612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.HttpAuthHandler.staticClass, _proceed8612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _useHttpAuthUsernamePassword8613; 
		public virtual bool useHttpAuthUsernamePassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.HttpAuthHandler)) 
				return @__env.CallBooleanMethod(this, _useHttpAuthUsernamePassword8613); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.HttpAuthHandler.staticClass, _useHttpAuthUsernamePassword8613); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.HttpAuthHandler.staticClass = @__class; 
			global::android.webkit.HttpAuthHandler._cancel8610 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "cancel", "()V"); 
			global::android.webkit.HttpAuthHandler._handleMessage8611 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.webkit.HttpAuthHandler._proceed8612 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "proceed", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword8613 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "useHttpAuthUsernamePassword", "()Z"); 
		} 
	} 
} 
