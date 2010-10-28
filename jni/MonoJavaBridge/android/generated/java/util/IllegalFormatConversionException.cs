namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatConversionException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalFormatConversionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26315;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatConversionException._getMessage26315)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatConversionException.staticClass, global::java.util.IllegalFormatConversionException._getMessage26315)) as java.lang.String;
		}
		public new char Conversion
		{
			get
			{
				return getConversion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConversion26316;
		public virtual char getConversion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.util.IllegalFormatConversionException._getConversion26316);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.util.IllegalFormatConversionException.staticClass, global::java.util.IllegalFormatConversionException._getConversion26316);
		}
		public new global::java.lang.Class ArgumentClass
		{
			get
			{
				return getArgumentClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getArgumentClass26317;
		public virtual global::java.lang.Class getArgumentClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatConversionException._getArgumentClass26317)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatConversionException.staticClass, global::java.util.IllegalFormatConversionException._getArgumentClass26317)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _IllegalFormatConversionException26318;
		public IllegalFormatConversionException(char arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatConversionException.staticClass, global::java.util.IllegalFormatConversionException._IllegalFormatConversionException26318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static IllegalFormatConversionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatConversionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatConversionException"));
			global::java.util.IllegalFormatConversionException._getMessage26315 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatConversionException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.IllegalFormatConversionException._getConversion26316 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatConversionException.staticClass, "getConversion", "()C");
			global::java.util.IllegalFormatConversionException._getArgumentClass26317 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatConversionException.staticClass, "getArgumentClass", "()Ljava/lang/Class;");
			global::java.util.IllegalFormatConversionException._IllegalFormatConversionException26318 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatConversionException.staticClass, "<init>", "(CLjava/lang/Class;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
