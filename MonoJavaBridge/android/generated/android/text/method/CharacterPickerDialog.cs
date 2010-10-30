namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharacterPickerDialog : android.app.Dialog, android.widget.AdapterView.OnItemClickListener, android.view.View.OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharacterPickerDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.CharacterPickerDialog.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.text.method.CharacterPickerDialog._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.CharacterPickerDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.text.method.CharacterPickerDialog._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.CharacterPickerDialog.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", ref global::android.text.method.CharacterPickerDialog._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public CharacterPickerDialog(android.content.Context arg0, android.view.View arg1, android.text.Editable arg2, java.lang.String arg3, bool arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.CharacterPickerDialog._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.CharacterPickerDialog._m3 = @__env.GetMethodIDNoThrow(global::android.text.method.CharacterPickerDialog.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/View;Landroid/text/Editable;Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.CharacterPickerDialog.staticClass, global::android.text.method.CharacterPickerDialog._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static CharacterPickerDialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.CharacterPickerDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/CharacterPickerDialog"));
		}
		internal static void InitJNI()
		{
		}
	}
}
