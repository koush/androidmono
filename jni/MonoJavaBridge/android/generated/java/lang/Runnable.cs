namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Runnable_))]
	public interface Runnable  : global::MonoJavaBridge.IJavaObject 
	{
		void run();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Runnable))]
	public sealed partial class Runnable_ : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Runnable_()
		{
			InitJNI();
		}
		internal Runnable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run14796;
		 void java.lang.Runnable.run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runnable_._run14796);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Runnable_.staticClass, global::java.lang.Runnable_._run14796);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runnable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runnable"));
			global::java.lang.Runnable_._run14796 = @__env.GetMethodIDNoThrow(global::java.lang.Runnable_.staticClass, "run", "()V");
		}
	}
}
