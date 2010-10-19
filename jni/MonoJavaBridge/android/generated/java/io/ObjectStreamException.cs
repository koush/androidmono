namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectStreamException_))]
	public abstract partial class ObjectStreamException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectStreamException()
		{
			InitJNI();
		}
		protected ObjectStreamException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ObjectStreamException13716;
		protected ObjectStreamException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamException.staticClass, global::java.io.ObjectStreamException._ObjectStreamException13716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectStreamException13717;
		protected ObjectStreamException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamException.staticClass, global::java.io.ObjectStreamException._ObjectStreamException13717);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamException"));
			global::java.io.ObjectStreamException._ObjectStreamException13716 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.ObjectStreamException._ObjectStreamException13717 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamException.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectStreamException))]
	public sealed partial class ObjectStreamException_ : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectStreamException_()
		{
			InitJNI();
		}
		internal ObjectStreamException_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamException_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamException"));
		}
	}
}
