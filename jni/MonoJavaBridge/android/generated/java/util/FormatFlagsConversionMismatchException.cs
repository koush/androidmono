namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FormatFlagsConversionMismatchException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FormatFlagsConversionMismatchException()
		{
			InitJNI();
		}
		protected FormatFlagsConversionMismatchException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage20239;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException._getMessage20239)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._getMessage20239)) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags20240;
		public virtual global::java.lang.String getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException._getFlags20240)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._getFlags20240)) as java.lang.String;
		}
		public new char Conversion
		{
			get
			{
				return getConversion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConversion20241;
		public virtual char getConversion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException._getConversion20241);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._getConversion20241);
		}
		internal static global::MonoJavaBridge.MethodId _FormatFlagsConversionMismatchException20242;
		public FormatFlagsConversionMismatchException(java.lang.String arg0, char arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException20242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.FormatFlagsConversionMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/FormatFlagsConversionMismatchException"));
			global::java.util.FormatFlagsConversionMismatchException._getMessage20239 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.FormatFlagsConversionMismatchException._getFlags20240 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "getFlags", "()Ljava/lang/String;");
			global::java.util.FormatFlagsConversionMismatchException._getConversion20241 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "getConversion", "()C");
			global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException20242 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "<init>", "(Ljava/lang/String;C)V");
		}
	}
}
