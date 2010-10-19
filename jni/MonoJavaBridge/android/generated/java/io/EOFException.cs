namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EOFException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EOFException()
		{
			InitJNI();
		}
		protected EOFException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _EOFException13359;
		public EOFException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.EOFException.staticClass, global::java.io.EOFException._EOFException13359);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EOFException13360;
		public EOFException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.EOFException.staticClass, global::java.io.EOFException._EOFException13360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.EOFException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/EOFException"));
			global::java.io.EOFException._EOFException13359 = @__env.GetMethodIDNoThrow(global::java.io.EOFException.staticClass, "<init>", "()V");
			global::java.io.EOFException._EOFException13360 = @__env.GetMethodIDNoThrow(global::java.io.EOFException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
