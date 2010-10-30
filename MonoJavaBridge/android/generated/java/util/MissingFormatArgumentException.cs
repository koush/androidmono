namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingFormatArgumentException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MissingFormatArgumentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26516;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatArgumentException._getMessage26516.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatArgumentException._getMessage26516 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatArgumentException.staticClass, "getMessage", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingFormatArgumentException.staticClass, global::java.util.MissingFormatArgumentException._getMessage26516) as java.lang.String;
		}
		public new global::java.lang.String FormatSpecifier
		{
			get
			{
				return getFormatSpecifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormatSpecifier26517;
		public virtual global::java.lang.String getFormatSpecifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatArgumentException._getFormatSpecifier26517.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatArgumentException._getFormatSpecifier26517 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatArgumentException.staticClass, "getFormatSpecifier", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingFormatArgumentException.staticClass, global::java.util.MissingFormatArgumentException._getFormatSpecifier26517) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingFormatArgumentException26518;
		public MissingFormatArgumentException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatArgumentException._MissingFormatArgumentException26518.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatArgumentException._MissingFormatArgumentException26518 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatArgumentException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingFormatArgumentException.staticClass, global::java.util.MissingFormatArgumentException._MissingFormatArgumentException26518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MissingFormatArgumentException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingFormatArgumentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingFormatArgumentException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
