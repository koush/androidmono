namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConditionVariable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConditionVariable()
		{
			InitJNI();
		}
		protected ConditionVariable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close9682;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ConditionVariable._close9682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._close9682);
		}
		internal static global::MonoJavaBridge.MethodId _open9683;
		public virtual void open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ConditionVariable._open9683);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._open9683);
		}
		internal static global::MonoJavaBridge.MethodId _block9684;
		public virtual void block()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ConditionVariable._block9684);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._block9684);
		}
		internal static global::MonoJavaBridge.MethodId _block9685;
		public virtual bool block(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.ConditionVariable._block9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._block9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConditionVariable9686;
		public ConditionVariable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._ConditionVariable9686);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConditionVariable9687;
		public ConditionVariable(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ConditionVariable.staticClass, global::android.os.ConditionVariable._ConditionVariable9687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ConditionVariable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ConditionVariable"));
			global::android.os.ConditionVariable._close9682 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "close", "()V");
			global::android.os.ConditionVariable._open9683 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "open", "()V");
			global::android.os.ConditionVariable._block9684 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "block", "()V");
			global::android.os.ConditionVariable._block9685 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "block", "(J)Z");
			global::android.os.ConditionVariable._ConditionVariable9686 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "<init>", "()V");
			global::android.os.ConditionVariable._ConditionVariable9687 = @__env.GetMethodIDNoThrow(global::android.os.ConditionVariable.staticClass, "<init>", "(Z)V");
		}
	}
}
