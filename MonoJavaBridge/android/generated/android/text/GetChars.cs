namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.GetChars_))]
	public partial interface GetChars : java.lang.CharSequence
	{
		void getChars(int arg0, int arg1, char[] arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.GetChars))]
	internal sealed partial class GetChars_ : java.lang.Object, GetChars
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GetChars_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChars12769;
		void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.GetChars_._getChars12769.native == global::System.IntPtr.Zero)
				global::android.text.GetChars_._getChars12769 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "getChars", "(II[CI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.GetChars_._getChars12769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _toString12770;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.GetChars_._toString12770.native == global::System.IntPtr.Zero)
				global::android.text.GetChars_._toString12770 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.GetChars_._toString12770)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12771;
		int java.lang.CharSequence.length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.GetChars_._length12771.native == global::System.IntPtr.Zero)
				global::android.text.GetChars_._length12771 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "length", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.GetChars_._length12771);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12772;
		char java.lang.CharSequence.charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.GetChars_._charAt12772.native == global::System.IntPtr.Zero)
				global::android.text.GetChars_._charAt12772 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "charAt", "(I)C");
			return @__env.CallCharMethod(this.JvmHandle, global::android.text.GetChars_._charAt12772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12773;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.GetChars_._subSequence12773.native == global::System.IntPtr.Zero)
				global::android.text.GetChars_._subSequence12773 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.GetChars_._subSequence12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		static GetChars_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.GetChars_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/GetChars"));
		}
		internal static void InitJNI()
		{
		}
	}
}
