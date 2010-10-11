namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RadioButton : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RadioButton()
		{
			InitJNI();
		}
		protected RadioButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toggle11713;
		public override void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioButton._toggle11713);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioButton.staticClass, global::android.widget.RadioButton._toggle11713);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton11714;
		public RadioButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton11714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton11715;
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton11715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton11716;
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton11716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RadioButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioButton"));
			global::android.widget.RadioButton._toggle11713 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "toggle", "()V");
			global::android.widget.RadioButton._RadioButton11714 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RadioButton._RadioButton11715 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RadioButton._RadioButton11716 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
