namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class JsResult : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static JsResult() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.JsResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.JsResult(@__env); 
			} 
		} 
		protected JsResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel8615; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.JsResult)) 
				@__env.CallVoidMethod(this, _cancel8615); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.JsResult.staticClass, _cancel8615); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _confirm8616; 
		public virtual void confirm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.JsResult)) 
				@__env.CallVoidMethod(this, _confirm8616); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.JsResult.staticClass, _confirm8616); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wakeUp8617; 
		protected virtual void wakeUp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.JsResult)) 
				@__env.CallVoidMethod(this, _wakeUp8617); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.JsResult.staticClass, _wakeUp8617); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.JsResult.staticClass = @__class; 
			global::android.webkit.JsResult._cancel8615 = @__env.GetMethodID(global::android.webkit.JsResult.staticClass, "cancel", "()V"); 
			global::android.webkit.JsResult._confirm8616 = @__env.GetMethodID(global::android.webkit.JsResult.staticClass, "confirm", "()V"); 
			global::android.webkit.JsResult._wakeUp8617 = @__env.GetMethodID(global::android.webkit.JsResult.staticClass, "wakeUp", "()V"); 
		} 
	} 
} 
