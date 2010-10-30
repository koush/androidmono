namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Runnable_))]
	public partial interface Runnable  : global::MonoJavaBridge.IJavaObject 
	{
		void run();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Runnable))]
	internal sealed partial class Runnable_ : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Runnable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run20428;
		void java.lang.Runnable.run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Runnable_._run20428);
		}
		static Runnable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Runnable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Runnable"));
			global::java.lang.Runnable_._run20428 = @__env.GetMethodIDNoThrow(global::java.lang.Runnable_.staticClass, "run", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void RunnableDelegate();

	internal partial class RunnableDelegateWrapper : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RunnableDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RunnableDelegateWrapper20429;
		public RunnableDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RunnableDelegateWrapper.staticClass, global::java.lang.RunnableDelegateWrapper._RunnableDelegateWrapper20429);
			Init(@__env, handle);
		}
		static RunnableDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RunnableDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("internal/java/lang/RunnableDelegateWrapper"));
			global::java.lang.RunnableDelegateWrapper._RunnableDelegateWrapper20429 = @__env.GetMethodIDNoThrow(global::java.lang.RunnableDelegateWrapper.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class RunnableDelegateWrapper
	{
		private RunnableDelegate myDelegate;
		public void run()
		{
			myDelegate();
		}
		public static implicit operator RunnableDelegateWrapper(RunnableDelegate d)
		{
			global::java.lang.RunnableDelegateWrapper ret = new global::java.lang.RunnableDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
