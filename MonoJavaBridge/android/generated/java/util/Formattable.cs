namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Formattable_))]
	public partial interface Formattable  : global::MonoJavaBridge.IJavaObject 
	{
		void formatTo(java.util.Formatter arg0, int arg1, int arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Formattable))]
	internal sealed partial class Formattable_ : java.lang.Object, Formattable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Formattable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _formatTo26182;
		void java.util.Formattable.formatTo(java.util.Formatter arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Formattable_.staticClass, "formatTo", "(Ljava/util/Formatter;III)V", ref global::java.util.Formattable_._formatTo26182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static Formattable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Formattable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formattable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
