namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ClipboardManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ClipboardManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.ClipboardManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.ClipboardManager(@__env); 
			} 
		} 
		protected ClipboardManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText6439; 
		public virtual void setText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.ClipboardManager)) 
				@__env.CallVoidMethod(this, _setText6439, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.ClipboardManager.staticClass, _setText6439, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText6440; 
		public virtual java.lang.CharSequence getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.ClipboardManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText6440)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.ClipboardManager.staticClass, _getText6440)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasText6441; 
		public virtual bool hasText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.ClipboardManager)) 
				return @__env.CallBooleanMethod(this, _hasText6441); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.ClipboardManager.staticClass, _hasText6441); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.ClipboardManager.staticClass = @__class; 
			global::android.text.ClipboardManager._setText6439 = @__env.GetMethodID(global::android.text.ClipboardManager.staticClass, "setText", "(Ljava/lang/CharSequence;)V"); 
			global::android.text.ClipboardManager._getText6440 = @__env.GetMethodID(global::android.text.ClipboardManager.staticClass, "getText", "()Ljava/lang/CharSequence;"); 
			global::android.text.ClipboardManager._hasText6441 = @__env.GetMethodID(global::android.text.ClipboardManager.staticClass, "hasText", "()Z"); 
		} 
	} 
} 
