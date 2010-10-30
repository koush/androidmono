namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneNumberFormattingTextWatcher : java.lang.Object, android.text.TextWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PhoneNumberFormattingTextWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged11793;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged11793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged11794;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged11794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged11795;
		public virtual void afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged11795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PhoneNumberFormattingTextWatcher11796;
		public PhoneNumberFormattingTextWatcher() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher11796);
			Init(@__env, handle);
		}
		static PhoneNumberFormattingTextWatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneNumberFormattingTextWatcher"));
			global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged11793 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged11794 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged11795 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher11796 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
