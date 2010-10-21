namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidObjectException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidObjectException()
		{
			InitJNI();
		}
		protected InvalidObjectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidObjectException19003;
		public InvalidObjectException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidObjectException.staticClass, global::java.io.InvalidObjectException._InvalidObjectException19003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InvalidObjectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InvalidObjectException"));
			global::java.io.InvalidObjectException._InvalidObjectException19003 = @__env.GetMethodIDNoThrow(global::java.io.InvalidObjectException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
