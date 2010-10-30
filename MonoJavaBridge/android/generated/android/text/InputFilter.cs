namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.InputFilter_))]
	public partial interface InputFilter  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.InputFilter))]
	internal sealed partial class InputFilter_ : java.lang.Object, InputFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _filter12785;
		global::java.lang.CharSequence android.text.InputFilter.filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.InputFilter_.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", ref global::android.text.InputFilter_._filter12785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.lang.CharSequence;
		}
		static InputFilter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.InputFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/InputFilter"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate java.lang.CharSequence InputFilterDelegate(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5);

	internal partial class InputFilterDelegateWrapper : java.lang.Object, InputFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputFilterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InputFilterDelegateWrapper12786;
		public InputFilterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.InputFilterDelegateWrapper._InputFilterDelegateWrapper12786.native == global::System.IntPtr.Zero)
				global::android.text.InputFilterDelegateWrapper._InputFilterDelegateWrapper12786 = @__env.GetMethodIDNoThrow(global::android.text.InputFilterDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.InputFilterDelegateWrapper.staticClass, global::android.text.InputFilterDelegateWrapper._InputFilterDelegateWrapper12786);
			Init(@__env, handle);
		}
		static InputFilterDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.InputFilterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/InputFilterDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class InputFilterDelegateWrapper
	{
		private InputFilterDelegate myDelegate;
		public java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return myDelegate(arg0, arg1, arg2, arg3, arg4, arg5);
		}
		public static implicit operator InputFilterDelegateWrapper(InputFilterDelegate d)
		{
			global::android.text.InputFilterDelegateWrapper ret = new global::android.text.InputFilterDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
