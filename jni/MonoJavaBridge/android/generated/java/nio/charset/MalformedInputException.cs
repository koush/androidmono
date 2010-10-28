namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedInputException : java.nio.charset.CharacterCodingException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedInputException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage22815;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException._getMessage22815)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException.staticClass, global::java.nio.charset.MalformedInputException._getMessage22815)) as java.lang.String;
		}
		public new int InputLength
		{
			get
			{
				return getInputLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputLength22816;
		public virtual int getInputLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException._getInputLength22816);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException.staticClass, global::java.nio.charset.MalformedInputException._getInputLength22816);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedInputException22817;
		public MalformedInputException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.MalformedInputException.staticClass, global::java.nio.charset.MalformedInputException._MalformedInputException22817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MalformedInputException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.MalformedInputException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/MalformedInputException"));
			global::java.nio.charset.MalformedInputException._getMessage22815 = @__env.GetMethodIDNoThrow(global::java.nio.charset.MalformedInputException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.nio.charset.MalformedInputException._getInputLength22816 = @__env.GetMethodIDNoThrow(global::java.nio.charset.MalformedInputException.staticClass, "getInputLength", "()I");
			global::java.nio.charset.MalformedInputException._MalformedInputException22817 = @__env.GetMethodIDNoThrow(global::java.nio.charset.MalformedInputException.staticClass, "<init>", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
