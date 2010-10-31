namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneNumberFormattingTextWatcher : java.lang.Object, android.text.TextWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PhoneNumberFormattingTextWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.telephony.PhoneNumberFormattingTextWatcher._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.telephony.PhoneNumberFormattingTextWatcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V", ref global::android.telephony.PhoneNumberFormattingTextWatcher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PhoneNumberFormattingTextWatcher() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberFormattingTextWatcher._m3.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberFormattingTextWatcher._m3 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._m3);
			Init(@__env, handle);
		}
		static PhoneNumberFormattingTextWatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneNumberFormattingTextWatcher"));
		}
	}
}
