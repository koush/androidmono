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
		internal static global::MonoJavaBridge.MethodId _getMessage26059;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException._getMessage26059)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._getMessage26059)) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags26060;
		public virtual global::java.lang.String getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException._getFlags26060)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._getFlags26060)) as java.lang.String;
		}
		public new char Conversion
		{
			get
			{
				return getConversion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConversion26061;
		public virtual char getConversion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException._getConversion26061);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._getConversion26061);
		}
		internal static global::MonoJavaBridge.MethodId _FormatFlagsConversionMismatchException26062;
		public FormatFlagsConversionMismatchException(java.lang.String arg0, char arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException26062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.FormatFlagsConversionMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/FormatFlagsConversionMismatchException"));
			global::java.util.FormatFlagsConversionMismatchException._getMessage26059 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.FormatFlagsConversionMismatchException._getFlags26060 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "getFlags", "()Ljava/lang/String;");
			global::java.util.FormatFlagsConversionMismatchException._getConversion26061 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "getConversion", "()C");
			global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException26062 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "<init>", "(Ljava/lang/String;C)V");
		}
	}
}
