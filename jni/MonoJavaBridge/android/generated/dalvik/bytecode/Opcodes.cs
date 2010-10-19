namespace dalvik.bytecode
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.bytecode.Opcodes_))]
	public interface Opcodes  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.bytecode.Opcodes))]
	public sealed partial class Opcodes_ : java.lang.Object, Opcodes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Opcodes_()
		{
			InitJNI();
		}
		internal Opcodes_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.bytecode.Opcodes_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/bytecode/Opcodes"));
		}
	}
}
