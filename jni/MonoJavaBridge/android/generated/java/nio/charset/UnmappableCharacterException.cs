namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnmappableCharacterException : java.nio.charset.CharacterCodingException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnmappableCharacterException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMessage22699;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.UnmappableCharacterException._getMessage22699)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._getMessage22699)) as java.lang.String;
		}
		public new int InputLength
		{
			get
			{
				return getInputLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputLength22700;
		public virtual int getInputLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.UnmappableCharacterException._getInputLength22700);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._getInputLength22700);
		}
		internal static global::MonoJavaBridge.MethodId _UnmappableCharacterException22701;
		public UnmappableCharacterException(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.UnmappableCharacterException.staticClass, global::java.nio.charset.UnmappableCharacterException._UnmappableCharacterException22701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.UnmappableCharacterException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/UnmappableCharacterException"));
			global::java.nio.charset.UnmappableCharacterException._getMessage22699 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.nio.charset.UnmappableCharacterException._getInputLength22700 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "getInputLength", "()I");
			global::java.nio.charset.UnmappableCharacterException._UnmappableCharacterException22701 = @__env.GetMethodIDNoThrow(global::java.nio.charset.UnmappableCharacterException.staticClass, "<init>", "(I)V");
		}
	}
}
