namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnmappableCharacterException : java.nio.charset.CharacterCodingException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnmappableCharacterException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage22818;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.UnmappableCharacterException._getMessage22818.native == global::System.IntPtr.Zero)
				global::java.nio.charset.UnmappableCharacterException._getMessage22818 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "getMessage", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._getMessage22818) as java.lang.String;
		}
		public new int InputLength
		{
			get
			{
				return getInputLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputLength22819;
		public virtual int getInputLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.UnmappableCharacterException._getInputLength22819.native == global::System.IntPtr.Zero)
				global::java.nio.charset.UnmappableCharacterException._getInputLength22819 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "getInputLength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._getInputLength22819);
		}
		internal static global::MonoJavaBridge.MethodId _UnmappableCharacterException22820;
		public UnmappableCharacterException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.UnmappableCharacterException._UnmappableCharacterException22820.native == global::System.IntPtr.Zero)
				global::java.nio.charset.UnmappableCharacterException._UnmappableCharacterException22820 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._UnmappableCharacterException22820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnmappableCharacterException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.UnmappableCharacterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/UnmappableCharacterException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
