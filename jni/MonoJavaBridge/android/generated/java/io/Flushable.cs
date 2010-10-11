namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Flushable_))]
	public interface Flushable  : global::MonoJavaBridge.IJavaObject 
	{
		void flush();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Flushable))]
	public sealed partial class Flushable_ : java.lang.Object, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Flushable_()
		{
			InitJNI();
		}
		internal Flushable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush12597;
		 void java.io.Flushable.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Flushable_._flush12597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Flushable_.staticClass, global::java.io.Flushable_._flush12597);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Flushable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Flushable"));
			global::java.io.Flushable_._flush12597 = @__env.GetMethodIDNoThrow(global::java.io.Flushable_.staticClass, "flush", "()V");
		}
	}
}
