namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingFormatWidthException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getMessage26519;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatWidthException._getMessage26519.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatWidthException._getMessage26519 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "getMessage", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._getMessage26519) as java.lang.String;
		}
		public new global::java.lang.String FormatSpecifier
		{
			get
			{
				return getFormatSpecifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormatSpecifier26520;
		public virtual global::java.lang.String getFormatSpecifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatWidthException._getFormatSpecifier26520.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatWidthException._getFormatSpecifier26520 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "getFormatSpecifier", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._getFormatSpecifier26520) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingFormatWidthException26521;
		public MissingFormatWidthException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatWidthException._MissingFormatWidthException26521.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatWidthException._MissingFormatWidthException26521 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._MissingFormatWidthException26521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MissingFormatWidthException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingFormatWidthException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingFormatWidthException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
