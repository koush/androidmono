namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Appendable_))]
	public partial interface Appendable  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Appendable append(java.lang.CharSequence arg0);
		global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2);
		global::java.lang.Appendable append(char arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Appendable))]
	internal sealed partial class Appendable_ : java.lang.Object, Appendable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Appendable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.Appendable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", ref global::java.lang.Appendable_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.Appendable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", ref global::java.lang.Appendable_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.lang.Appendable_.staticClass, "append", "(C)Ljava/lang/Appendable;", ref global::java.lang.Appendable_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Appendable;
		}
		static Appendable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Appendable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Appendable"));
		}
	}
}
