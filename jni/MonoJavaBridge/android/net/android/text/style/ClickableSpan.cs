namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ClickableSpan : android.text.style.CharacterStyle, UpdateAppearance
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ClickableSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.ClickableSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ClickableSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick6943; 
		public abstract void onClick(android.view.View arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState6944; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ClickableSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState6944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.ClickableSpan.staticClass, _updateDrawState6944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ClickableSpan6945; 
		public ClickableSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ClickableSpan.staticClass, _ClickableSpan6945, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.ClickableSpan.staticClass = @__class; 
			global::android.text.style.ClickableSpan._onClick6943 = @__env.GetMethodID(global::android.text.style.ClickableSpan.staticClass, "onClick", "(Landroid/view/View;)V"); 
			global::android.text.style.ClickableSpan._updateDrawState6944 = @__env.GetMethodID(global::android.text.style.ClickableSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.ClickableSpan._ClickableSpan6945 = @__env.GetMethodID(global::android.text.style.ClickableSpan.staticClass, "<init>", "()V"); 
		} 
	} 
} 
