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
		internal static global::MonoJavaBridge.MethodId _getErrorOffset25611;
		public virtual int getErrorOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParseException.staticClass, global::java.text.ParseException._getErrorOffset25611);
		}
		internal static global::MonoJavaBridge.MethodId _ParseException25612;
		public ParseException(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParseException.staticClass, global::java.text.ParseException._ParseException25612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ParseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParseException"));
			global::java.text.ParseException._getErrorOffset25611 = @__env.GetMethodIDNoThrow(global::java.text.ParseException.staticClass, "getErrorOffset", "()I");
			global::java.text.ParseException._ParseException25612 = @__env.GetMethodIDNoThrow(global::java.text.ParseException.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
