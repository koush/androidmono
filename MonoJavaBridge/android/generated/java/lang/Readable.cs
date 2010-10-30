namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Readable_))]
	public partial interface Readable  : global::MonoJavaBridge.IJavaObject 
	{
		int read(java.nio.CharBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Readable))]
	internal sealed partial class Readable_ : java.lang.Object, Readable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Readable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int java.lang.Readable.read(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Readable_.staticClass, "read", "(Ljava/nio/CharBuffer;)I", ref global::java.lang.Readable_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Readable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Readable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Readable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
