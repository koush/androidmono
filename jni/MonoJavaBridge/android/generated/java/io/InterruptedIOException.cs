namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InterruptedIOException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InterruptedIOException()
		{
			InitJNI();
		}
		protected InterruptedIOException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InterruptedIOException18996;
		public InterruptedIOException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InterruptedIOException.staticClass, global::java.io.InterruptedIOException._InterruptedIOException18996);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InterruptedIOException18997;
		public InterruptedIOException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InterruptedIOException.staticClass, global::java.io.InterruptedIOException._InterruptedIOException18997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bytesTransferred18998;
		public int bytesTransferred
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bytesTransferred18998);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InterruptedIOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InterruptedIOException"));
			global::java.io.InterruptedIOException._InterruptedIOException18996 = @__env.GetMethodIDNoThrow(global::java.io.InterruptedIOException.staticClass, "<init>", "()V");
			global::java.io.InterruptedIOException._InterruptedIOException18997 = @__env.GetMethodIDNoThrow(global::java.io.InterruptedIOException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.InterruptedIOException._bytesTransferred18998 = @__env.GetFieldIDNoThrow(global::java.io.InterruptedIOException.staticClass, "bytesTransferred", "I");
		}
	}
}
