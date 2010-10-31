namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.TextWatcher_))]
	public partial interface TextWatcher : NoCopySpan
	{
		void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3);
		void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3);
		void afterTextChanged(android.text.Editable arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.TextWatcher))]
	internal sealed partial class TextWatcher_ : java.lang.Object, TextWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TextWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.text.TextWatcher.onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextWatcher_.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.text.TextWatcher_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.text.TextWatcher.beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextWatcher_.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.text.TextWatcher_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.text.TextWatcher.afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextWatcher_.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V", ref global::android.text.TextWatcher_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TextWatcher_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextWatcher"));
		}
	}
}
