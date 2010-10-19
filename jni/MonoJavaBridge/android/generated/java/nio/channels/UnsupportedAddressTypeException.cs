namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedAddressTypeException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedAddressTypeException()
		{
			InitJNI();
		}
		protected UnsupportedAddressTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedAddressTypeException16939;
		public UnsupportedAddressTypeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.UnsupportedAddressTypeException.staticClass, global::java.nio.channels.UnsupportedAddressTypeException._UnsupportedAddressTypeException16939);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.UnsupportedAddressTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/UnsupportedAddressTypeException"));
			global::java.nio.channels.UnsupportedAddressTypeException._UnsupportedAddressTypeException16939 = @__env.GetMethodIDNoThrow(global::java.nio.channels.UnsupportedAddressTypeException.staticClass, "<init>", "()V");
		}
	}
}
