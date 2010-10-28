namespace dalvik.bytecode
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.bytecode.Opcodes_))]
	public partial interface Opcodes  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.bytecode.Opcodes))]
	internal sealed partial class Opcodes_ : java.lang.Object, Opcodes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Opcodes_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Opcodes_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.bytecode.Opcodes_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/bytecode/Opcodes"));
		}
		internal static void InitJNI()
		{
		}
	}
}
