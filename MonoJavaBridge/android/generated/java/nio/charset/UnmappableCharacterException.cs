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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.UnmappableCharacterException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.nio.charset.UnmappableCharacterException._m0) as java.lang.String;
		}
		public new int InputLength
		{
			get
			{
				return getInputLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getInputLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.UnmappableCharacterException.staticClass, "getInputLength", "()I", ref global::java.nio.charset.UnmappableCharacterException._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public UnmappableCharacterException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.UnmappableCharacterException._m2.native == global::System.IntPtr.Zero)
				global::java.nio.charset.UnmappableCharacterException._m2 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnmappableCharacterException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.UnmappableCharacterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/UnmappableCharacterException"));
		}
	}
}
