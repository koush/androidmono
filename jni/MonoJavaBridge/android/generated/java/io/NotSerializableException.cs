namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotSerializableException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NotSerializableException()
		{
			InitJNI();
		}
		protected NotSerializableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotSerializableException13550;
		public NotSerializableException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotSerializableException.staticClass, global::java.io.NotSerializableException._NotSerializableException13550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NotSerializableException13551;
		public NotSerializableException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotSerializableException.staticClass, global::java.io.NotSerializableException._NotSerializableException13551);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.NotSerializableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/NotSerializableException"));
			global::java.io.NotSerializableException._NotSerializableException13550 = @__env.GetMethodIDNoThrow(global::java.io.NotSerializableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.NotSerializableException._NotSerializableException13551 = @__env.GetMethodIDNoThrow(global::java.io.NotSerializableException.staticClass, "<init>", "()V");
		}
	}
}
