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
		internal CharSequence_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.CharSequence_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.CharSequence_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.lang.CharSequence.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.CharSequence_.staticClass, "length", "()I", ref global::java.lang.CharSequence_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		char java.lang.CharSequence.charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.CharSequence_.staticClass, "charAt", "(I)C", ref global::java.lang.CharSequence_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::java.lang.CharSequence_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;", ref global::java.lang.CharSequence_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		static CharSequence_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.CharSequence_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/CharSequence"));
		}
		internal static void InitJNI()
		{
		}
	}
}
