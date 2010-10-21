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
		internal static global::MonoJavaBridge.MethodId _toggle17427;
		public override void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RadioButton._toggle17427);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RadioButton.staticClass, global::android.widget.RadioButton._toggle17427);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton17428;
		public RadioButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton17428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton17429;
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton17429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RadioButton17430;
		public RadioButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RadioButton.staticClass, global::android.widget.RadioButton._RadioButton17430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RadioButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RadioButton"));
			global::android.widget.RadioButton._toggle17427 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "toggle", "()V");
			global::android.widget.RadioButton._RadioButton17428 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RadioButton._RadioButton17429 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RadioButton._RadioButton17430 = @__env.GetMethodIDNoThrow(global::android.widget.RadioButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
