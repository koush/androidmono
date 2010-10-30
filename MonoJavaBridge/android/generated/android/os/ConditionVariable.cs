namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConditionVariable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConditionVariable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close9682;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ConditionVariable.staticClass, "close", "()V", ref global::android.os.ConditionVariable._close9682);
		}
		internal static global::MonoJavaBridge.MethodId _open9683;
		public virtual void open()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ConditionVariable.staticClass, "open", "()V", ref global::android.os.ConditionVariable._open9683);
		}
		internal static global::MonoJavaBridge.MethodId _block9684;
		public virtual void block()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ConditionVariable.staticClass, "block", "()V", ref global::android.os.ConditionVariable._block9684);
		}
		internal static global::MonoJavaBridge.MethodId _block9685;
		public virtual bool block(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.ConditionVariable.staticClass, "block", "(J)Z", ref global::android.os.ConditionVariable._block9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConditionVariable9686;
		public ConditionVariable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ConditionVariable._ConditionVariable9686.native == global::System.IntPtr.Zero)
				global::android.os.ConditionVariable._ConditionVariable9686 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._ConditionVariable9686);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConditionVariable9687;
		public ConditionVariable(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ConditionVariable._ConditionVariable9687.native == global::System.IntPtr.Zero)
				global::android.os.ConditionVariable._ConditionVariable9687 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._ConditionVariable9687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConditionVariable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ConditionVariable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ConditionVariable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
