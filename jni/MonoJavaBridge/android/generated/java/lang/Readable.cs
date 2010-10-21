namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Readable_))]
	public interface Readable  : global::MonoJavaBridge.IJavaObject 
	{
		int read(java.nio.CharBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Readable))]
	public sealed partial class Readable_ : java.lang.Object, Readable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Readable_()
		{
			InitJNI();
		}
		internal Readable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read20309;
		 int java.lang.Readable.read(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Readable_._read20309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Readable_.staticClass, global::java.lang.Readable_._read20309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Readable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Readable"));
			global::java.lang.Readable_._read20309 = @__env.GetMethodIDNoThrow(global::java.lang.Readable_.staticClass, "read", "(Ljava/nio/CharBuffer;)I");
		}
	}
}
