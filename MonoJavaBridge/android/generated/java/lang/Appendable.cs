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
		internal static global::MonoJavaBridge.MethodId _append19707;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Appendable_._append19707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append19708;
		global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Appendable_._append19708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append19709;
		global::java.lang.Appendable java.lang.Appendable.append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Appendable_._append19709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		static Appendable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Appendable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Appendable"));
			global::java.lang.Appendable_._append19707 = @__env.GetMethodIDNoThrow(global::java.lang.Appendable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.lang.Appendable_._append19708 = @__env.GetMethodIDNoThrow(global::java.lang.Appendable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.lang.Appendable_._append19709 = @__env.GetMethodIDNoThrow(global::java.lang.Appendable_.staticClass, "append", "(C)Ljava/lang/Appendable;");
		}
		internal static void InitJNI()
		{
		}
	}
}
