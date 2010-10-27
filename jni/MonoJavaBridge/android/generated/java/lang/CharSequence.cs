namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.CharSequence_))]
	public partial interface CharSequence  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String toString();
		int length();
		char charAt(int arg0);
		global::java.lang.CharSequence subSequence(int arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.CharSequence))]
	internal sealed partial class CharSequence_ : java.lang.Object, CharSequence
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharSequence_()
		{
			InitJNI();
		}
		internal CharSequence_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19761;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.CharSequence_._toString19761)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.CharSequence_.staticClass, global::java.lang.CharSequence_._toString19761)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length19762;
		int java.lang.CharSequence.length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.CharSequence_._length19762);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.CharSequence_.staticClass, global::java.lang.CharSequence_._length19762);
		}
		internal static global::MonoJavaBridge.MethodId _charAt19763;
		char java.lang.CharSequence.charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.CharSequence_._charAt19763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.CharSequence_.staticClass, global::java.lang.CharSequence_._charAt19763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence19764;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.CharSequence_._subSequence19764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.CharSequence_.staticClass, global::java.lang.CharSequence_._subSequence19764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.CharSequence_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/CharSequence"));
			global::java.lang.CharSequence_._toString19761 = @__env.GetMethodIDNoThrow(global::java.lang.CharSequence_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.CharSequence_._length19762 = @__env.GetMethodIDNoThrow(global::java.lang.CharSequence_.staticClass, "length", "()I");
			global::java.lang.CharSequence_._charAt19763 = @__env.GetMethodIDNoThrow(global::java.lang.CharSequence_.staticClass, "charAt", "(I)C");
			global::java.lang.CharSequence_._subSequence19764 = @__env.GetMethodIDNoThrow(global::java.lang.CharSequence_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
		}
	}
}
