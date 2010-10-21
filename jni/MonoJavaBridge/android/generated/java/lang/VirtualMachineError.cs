namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.VirtualMachineError_))]
	public abstract partial class VirtualMachineError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VirtualMachineError()
		{
			InitJNI();
		}
		protected VirtualMachineError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _VirtualMachineError20816;
		public VirtualMachineError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VirtualMachineError.staticClass, global::java.lang.VirtualMachineError._VirtualMachineError20816);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VirtualMachineError20817;
		public VirtualMachineError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.VirtualMachineError.staticClass, global::java.lang.VirtualMachineError._VirtualMachineError20817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.VirtualMachineError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/VirtualMachineError"));
			global::java.lang.VirtualMachineError._VirtualMachineError20816 = @__env.GetMethodIDNoThrow(global::java.lang.VirtualMachineError.staticClass, "<init>", "()V");
			global::java.lang.VirtualMachineError._VirtualMachineError20817 = @__env.GetMethodIDNoThrow(global::java.lang.VirtualMachineError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.VirtualMachineError))]
	public sealed partial class VirtualMachineError_ : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VirtualMachineError_()
		{
			InitJNI();
		}
		internal VirtualMachineError_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.VirtualMachineError_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/VirtualMachineError"));
		}
	}
}
