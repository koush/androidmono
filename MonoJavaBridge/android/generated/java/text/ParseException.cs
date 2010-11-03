namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParseException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int ErrorOffset
		{
			get
			{
				return getErrorOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getErrorOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParseException.staticClass, "getErrorOffset", "()I", ref global::java.text.ParseException._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ParseException(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ParseException._m1.native == global::System.IntPtr.Zero)
				global::java.text.ParseException._m1 = @__env.GetMethodIDNoThrow(global::java.text.ParseException.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParseException.staticClass, global::java.text.ParseException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ParseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParseException"));
		}
	}
}
