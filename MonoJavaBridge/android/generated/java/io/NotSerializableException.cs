namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotSerializableException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NotSerializableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotSerializableException19143;
		public NotSerializableException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.NotSerializableException._NotSerializableException19143.native == global::System.IntPtr.Zero)
				global::java.io.NotSerializableException._NotSerializableException19143 = @__env.GetMethodIDNoThrow(global::java.io.NotSerializableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotSerializableException.staticClass, global::java.io.NotSerializableException._NotSerializableException19143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NotSerializableException19144;
		public NotSerializableException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.NotSerializableException._NotSerializableException19144.native == global::System.IntPtr.Zero)
				global::java.io.NotSerializableException._NotSerializableException19144 = @__env.GetMethodIDNoThrow(global::java.io.NotSerializableException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotSerializableException.staticClass, global::java.io.NotSerializableException._NotSerializableException19144);
			Init(@__env, handle);
		}
		static NotSerializableException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.NotSerializableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/NotSerializableException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
