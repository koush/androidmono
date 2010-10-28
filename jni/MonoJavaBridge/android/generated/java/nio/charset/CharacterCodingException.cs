namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharacterCodingException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharacterCodingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CharacterCodingException22721;
		public CharacterCodingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharacterCodingException.staticClass, global::java.nio.charset.CharacterCodingException._CharacterCodingException22721);
			Init(@__env, handle);
		}
		static CharacterCodingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharacterCodingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharacterCodingException"));
			global::java.nio.charset.CharacterCodingException._CharacterCodingException22721 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharacterCodingException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
