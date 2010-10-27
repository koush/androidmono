namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedInputException : java.nio.charset.CharacterCodingException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MalformedInputException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMessage22814;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException._getMessage22814)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException.staticClass, global::java.nio.charset.MalformedInputException._getMessage22814)) as java.lang.String;
		}
		public new int InputLength
		{
			get
			{
				return getInputLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputLength22815;
		public virtual int getInputLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException._getInputLength22815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.MalformedInputException.staticClass, global::java.nio.charset.MalformedInputException._getInputLength22815);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedInputException22816;
		public MalformedInputException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.MalformedInputException.staticClass, global::java.nio.charset.MalformedInputException._MalformedInputException22816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.MalformedInputException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/MalformedInputException"));
			global::java.nio.charset.MalformedInputException._getMessage22814 = @__env.GetMethodIDNoThrow(global::java.nio.charset.MalformedInputException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.nio.charset.MalformedInputException._getInputLength22815 = @__env.GetMethodIDNoThrow(global::java.nio.charset.MalformedInputException.staticClass, "getInputLength", "()I");
			global::java.nio.charset.MalformedInputException._MalformedInputException22816 = @__env.GetMethodIDNoThrow(global::java.nio.charset.MalformedInputException.staticClass, "<init>", "(I)V");
		}
	}
}
