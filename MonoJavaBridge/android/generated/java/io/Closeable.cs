namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Closeable_))]
	public partial interface Closeable  : global::MonoJavaBridge.IJavaObject 
	{
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Closeable))]
	internal sealed partial class Closeable_ : java.lang.Object, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Closeable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Closeable_.staticClass, "close", "()V", ref global::java.io.Closeable_._m0);
		}
		static Closeable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Closeable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Closeable"));
		}
	}
}
