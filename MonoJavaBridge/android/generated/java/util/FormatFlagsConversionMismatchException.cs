namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FormatFlagsConversionMismatchException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getMessage26178;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.FormatFlagsConversionMismatchException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.FormatFlagsConversionMismatchException._getMessage26178) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags26179;
		public virtual global::java.lang.String getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.FormatFlagsConversionMismatchException.staticClass, "getFlags", "()Ljava/lang/String;", ref global::java.util.FormatFlagsConversionMismatchException._getFlags26179) as java.lang.String;
		}
		public new char Conversion
		{
			get
			{
				return getConversion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConversion26180;
		public virtual char getConversion()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.util.FormatFlagsConversionMismatchException.staticClass, "getConversion", "()C", ref global::java.util.FormatFlagsConversionMismatchException._getConversion26180);
		}
		internal static global::MonoJavaBridge.MethodId _FormatFlagsConversionMismatchException26181;
		public FormatFlagsConversionMismatchException(java.lang.String arg0, char arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException26181.native == global::System.IntPtr.Zero)
				global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException26181 = @__env.GetMethodIDNoThrow(global::java.util.FormatFlagsConversionMismatchException.staticClass, "<init>", "(Ljava/lang/String;C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.FormatFlagsConversionMismatchException.staticClass, global::java.util.FormatFlagsConversionMismatchException._FormatFlagsConversionMismatchException26181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FormatFlagsConversionMismatchException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.FormatFlagsConversionMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/FormatFlagsConversionMismatchException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
