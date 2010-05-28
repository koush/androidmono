namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RadioButton : android.widget.CompoundButton
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RadioButton() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RadioButton), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.RadioButton(@__env); 
			} 
		} 
		protected RadioButton(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggle10623; 
		public override void toggle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioButton)) 
				@__env.CallVoidMethod(this, global::android.widget.RadioButton._toggle10623); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RadioButton.staticClass, global::android.widget.RadioButton._toggle10623); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadioButton10624; 
		public RadioButton(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton10624, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadioButton10625; 
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton10625, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadioButton10626; 
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton10626, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.RadioButton.staticClass = @__class; 
			global::android.widget.RadioButton._toggle10623 = @__env.GetMethodID(global::android.widget.RadioButton.staticClass, "toggle", "()V"); 
			global::android.widget.RadioButton._RadioButton10624 = @__env.GetMethodID(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.RadioButton._RadioButton10625 = @__env.GetMethodID(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.RadioButton._RadioButton10626 = @__env.GetMethodID(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
