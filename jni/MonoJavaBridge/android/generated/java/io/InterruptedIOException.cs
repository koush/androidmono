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
		internal static global::MonoJavaBridge.MethodId _InterruptedIOException13521;
		public InterruptedIOException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InterruptedIOException.staticClass, global::java.io.InterruptedIOException._InterruptedIOException13521);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InterruptedIOException13522;
		public InterruptedIOException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InterruptedIOException.staticClass, global::java.io.InterruptedIOException._InterruptedIOException13522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bytesTransferred13523;
		public int bytesTransferred
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InterruptedIOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InterruptedIOException"));
			global::java.io.InterruptedIOException._InterruptedIOException13521 = @__env.GetMethodIDNoThrow(global::java.io.InterruptedIOException.staticClass, "<init>", "()V");
			global::java.io.InterruptedIOException._InterruptedIOException13522 = @__env.GetMethodIDNoThrow(global::java.io.InterruptedIOException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
