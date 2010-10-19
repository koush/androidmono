namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharacterPickerDialog : android.app.Dialog, android.widget.AdapterView.OnItemClickListener, android.view.View.OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharacterPickerDialog()
		{
			InitJNI();
		}
		protected CharacterPickerDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick8589;
		public virtual void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.CharacterPickerDialog._onClick8589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.CharacterPickerDialog.staticClass, global::android.text.method.CharacterPickerDialog._onClick8589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreate8590;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.CharacterPickerDialog._onCreate8590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.CharacterPickerDialog.staticClass, global::android.text.method.CharacterPickerDialog._onCreate8590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onItemClick8591;
		public virtual void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.CharacterPickerDialog._onItemClick8591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.CharacterPickerDialog.staticClass, global::android.text.method.CharacterPickerDialog._onItemClick8591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _CharacterPickerDialog8592;
		public CharacterPickerDialog(android.content.Context arg0, android.view.View arg1, android.text.Editable arg2, java.lang.String arg3, bool arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.CharacterPickerDialog.staticClass, global::android.text.method.CharacterPickerDialog._CharacterPickerDialog8592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.CharacterPickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/CharacterPickerDialog"));
			global::android.text.method.CharacterPickerDialog._onClick8589 = @__env.GetMethodIDNoThrow(global::android.text.method.CharacterPickerDialog.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.text.method.CharacterPickerDialog._onCreate8590 = @__env.GetMethodIDNoThrow(global::android.text.method.CharacterPickerDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.text.method.CharacterPickerDialog._onItemClick8591 = @__env.GetMethodIDNoThrow(global::android.text.method.CharacterPickerDialog.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
			global::android.text.method.CharacterPickerDialog._CharacterPickerDialog8592 = @__env.GetMethodIDNoThrow(global::android.text.method.CharacterPickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/View;Landroid/text/Editable;Ljava/lang/String;Z)V");
		}
	}
}
