namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.VirtualMachineError_))]
	public abstract partial class VirtualMachineError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected VirtualMachineError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public VirtualMachineError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.VirtualMachineError._m0.native == global::System.IntPtr.Zero)
				global::java.lang.VirtualMachineError._m0 = @__env.GetMethodIDNoThrow(global::java.lang.VirtualMachineError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VirtualMachineError.staticClass, global::java.lang.VirtualMachineError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public VirtualMachineError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.VirtualMachineError._m1.native == global::System.IntPtr.Zero)
				global::java.lang.VirtualMachineError._m1 = @__env.GetMethodIDNoThrow(global::java.lang.VirtualMachineError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VirtualMachineError.staticClass, global::java.lang.VirtualMachineError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static VirtualMachineError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.VirtualMachineError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/VirtualMachineError"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.VirtualMachineError))]
	internal sealed partial class VirtualMachineError_ : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VirtualMachineError_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static VirtualMachineError_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.VirtualMachineError_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/VirtualMachineError"));
		}
	}
}
