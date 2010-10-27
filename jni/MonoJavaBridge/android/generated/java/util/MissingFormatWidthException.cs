namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingFormatWidthException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MissingFormatWidthException()
		{
			InitJNI();
		}
		protected MissingFormatWidthException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26518;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingFormatWidthException._getMessage26518)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._getMessage26518)) as java.lang.String;
		}
		public new global::java.lang.String FormatSpecifier
		{
			get
			{
				return getFormatSpecifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormatSpecifier26519;
		public virtual global::java.lang.String getFormatSpecifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingFormatWidthException._getFormatSpecifier26519)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._getFormatSpecifier26519)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingFormatWidthException26520;
		public MissingFormatWidthException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._MissingFormatWidthException26520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingFormatWidthException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingFormatWidthException"));
			global::java.util.MissingFormatWidthException._getMessage26518 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.MissingFormatWidthException._getFormatSpecifier26519 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "getFormatSpecifier", "()Ljava/lang/String;");
			global::java.util.MissingFormatWidthException._MissingFormatWidthException26520 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
