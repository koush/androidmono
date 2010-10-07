namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PhoneNumberFormattingTextWatcher : java.lang.Object, android.text.TextWatcher
	{
		internal static global::java.lang.Class staticClass;
		static PhoneNumberFormattingTextWatcher()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.PhoneNumberFormattingTextWatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.PhoneNumberFormattingTextWatcher(@__env);
			}
		}
		protected PhoneNumberFormattingTextWatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged7079;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged7079, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged7079, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged7080;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged7080, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged7080, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged7081;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged7081, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged7081, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PhoneNumberFormattingTextWatcher7082;
		public PhoneNumberFormattingTextWatcher()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.PhoneNumberFormattingTextWatcher.staticClass, global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher7082, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass = @__class;
			global::android.telephony.PhoneNumberFormattingTextWatcher._onTextChanged7079 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._beforeTextChanged7080 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._afterTextChanged7081 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberFormattingTextWatcher._PhoneNumberFormattingTextWatcher7082 = @__env.GetMethodID(global::android.telephony.PhoneNumberFormattingTextWatcher.staticClass, "<init>", "()V");
		}
	}
}
