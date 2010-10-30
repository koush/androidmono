namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConditionVariable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConditionVariable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ConditionVariable.staticClass, "close", "()V", ref global::android.os.ConditionVariable._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void open()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ConditionVariable.staticClass, "open", "()V", ref global::android.os.ConditionVariable._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void block()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ConditionVariable.staticClass, "block", "()V", ref global::android.os.ConditionVariable._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool block(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.ConditionVariable.staticClass, "block", "(J)Z", ref global::android.os.ConditionVariable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ConditionVariable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ConditionVariable._m4.native == global::System.IntPtr.Zero)
				global::android.os.ConditionVariable._m4 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ConditionVariable(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ConditionVariable._m5.native == global::System.IntPtr.Zero)
				global::android.os.ConditionVariable._m5 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
