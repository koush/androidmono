namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Appendable_))]
	public interface Appendable  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Appendable append(java.lang.CharSequence arg0);
		global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2);
		global::java.lang.Appendable append(char arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Appendable))]
	public sealed partial class Appendable_ : java.lang.Object, Appendable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Appendable_()
		{
			InitJNI();
		}
		internal Appendable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append19589;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Appendable_._append19589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Appendable_.staticClass, global::java.lang.Appendable_._append19589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append19590;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Appendable_._append19590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Appendable_.staticClass, global::java.lang.Appendable_._append19590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _append19591;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Appendable_._append19591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Appendable_.staticClass, global::java.lang.Appendable_._append19591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Appendable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Appendable"));
			global::java.lang.Appendable_._append19589 = @__env.GetMethodIDNoThrow(global::java.lang.Appendable_.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.lang.Appendable_._append19590 = @__env.GetMethodIDNoThrow(global::java.lang.Appendable_.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.lang.Appendable_._append19591 = @__env.GetMethodIDNoThrow(global::java.lang.Appendable_.staticClass, "append", "(C)Ljava/lang/Appendable;");
		}
	}
}
