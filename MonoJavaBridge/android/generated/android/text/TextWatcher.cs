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
		internal static global::MonoJavaBridge.MethodId _onTextChanged13099;
		void android.text.TextWatcher.onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextWatcher_._onTextChanged13099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged13100;
		void android.text.TextWatcher.beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextWatcher_._beforeTextChanged13100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged13101;
		void android.text.TextWatcher.afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextWatcher_._afterTextChanged13101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TextWatcher_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextWatcher"));
			global::android.text.TextWatcher_._onTextChanged13099 = @__env.GetMethodIDNoThrow(global::android.text.TextWatcher_.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.text.TextWatcher_._beforeTextChanged13100 = @__env.GetMethodIDNoThrow(global::android.text.TextWatcher_.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.text.TextWatcher_._afterTextChanged13101 = @__env.GetMethodIDNoThrow(global::android.text.TextWatcher_.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
