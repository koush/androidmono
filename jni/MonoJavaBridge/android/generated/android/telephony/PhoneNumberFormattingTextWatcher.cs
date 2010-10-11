namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneNumberFormattingTextWatcher : java.lang.Object, android.text.TextWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PhoneNumberFormattingTextWatcher()
		{
			InitJNI();
		}
		protected PhoneNumberFormattingTextWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged7359;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged7359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged7359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged7360;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged7360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged7360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged7361;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged7361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged7361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PhoneNumberFormattingTextWatcher7362;
		public PhoneNumberFormattingTextWatcher()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher7362);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneNumberFormattingTextWatcher"));
			global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged7359 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged7360 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged7361 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher7362 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "<init>", "()V");
		}
	}
}
