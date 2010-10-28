namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.VirtualMachineError_))]
	public abstract partial class VirtualMachineError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected VirtualMachineError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _VirtualMachineError20935;
		public VirtualMachineError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VirtualMachineError.staticClass, global::java.lang.VirtualMachineError._VirtualMachineError20935);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VirtualMachineError20936;
		public VirtualMachineError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VirtualMachineError.staticClass, global::java.lang.VirtualMachineError._VirtualMachineError20936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static VirtualMachineError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.VirtualMachineError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/VirtualMachineError"));
			global::java.lang.VirtualMachineError._VirtualMachineError20935 = @__env.GetMethodIDNoThrow(global::java.lang.VirtualMachineError.staticClass, "<init>", "()V");
			global::java.lang.VirtualMachineError._VirtualMachineError20936 = @__env.GetMethodIDNoThrow(global::java.lang.VirtualMachineError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
