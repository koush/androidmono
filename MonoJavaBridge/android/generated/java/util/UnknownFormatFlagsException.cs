namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownFormatFlagsException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownFormatFlagsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26960;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._getMessage26960)) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags26961;
		public virtual global::java.lang.String getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._getFlags26961)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _UnknownFormatFlagsException26962;
		public UnknownFormatFlagsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._UnknownFormatFlagsException26962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownFormatFlagsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UnknownFormatFlagsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UnknownFormatFlagsException"));
			global::java.util.UnknownFormatFlagsException._getMessage26960 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.UnknownFormatFlagsException._getFlags26961 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "getFlags", "()Ljava/lang/String;");
			global::java.util.UnknownFormatFlagsException._UnknownFormatFlagsException26962 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
