namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EOFException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EOFException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _EOFException18948;
		public EOFException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.EOFException.staticClass, global::java.io.EOFException._EOFException18948);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EOFException18949;
		public EOFException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.EOFException.staticClass, global::java.io.EOFException._EOFException18949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EOFException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.EOFException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/EOFException"));
			global::java.io.EOFException._EOFException18948 = @__env.GetMethodIDNoThrow(global::java.io.EOFException.staticClass, "<init>", "()V");
			global::java.io.EOFException._EOFException18949 = @__env.GetMethodIDNoThrow(global::java.io.EOFException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
