namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownFormatConversionException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownFormatConversionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26957;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UnknownFormatConversionException._getMessage26957.native == global::System.IntPtr.Zero)
				global::java.util.UnknownFormatConversionException._getMessage26957 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatConversionException.staticClass, "getMessage", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.UnknownFormatConversionException.staticClass, global::java.util.UnknownFormatConversionException._getMessage26957) as java.lang.String;
		}
		public new global::java.lang.String Conversion
		{
			get
			{
				return getConversion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConversion26958;
		public virtual global::java.lang.String getConversion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UnknownFormatConversionException._getConversion26958.native == global::System.IntPtr.Zero)
				global::java.util.UnknownFormatConversionException._getConversion26958 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatConversionException.staticClass, "getConversion", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.UnknownFormatConversionException.staticClass, global::java.util.UnknownFormatConversionException._getConversion26958) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _UnknownFormatConversionException26959;
		public UnknownFormatConversionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UnknownFormatConversionException._UnknownFormatConversionException26959.native == global::System.IntPtr.Zero)
				global::java.util.UnknownFormatConversionException._UnknownFormatConversionException26959 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatConversionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UnknownFormatConversionException.staticClass, global::java.util.UnknownFormatConversionException._UnknownFormatConversionException26959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownFormatConversionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UnknownFormatConversionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UnknownFormatConversionException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
