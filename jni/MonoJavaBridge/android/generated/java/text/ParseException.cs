namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParseException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParseException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getErrorOffset25492;
		public virtual int getErrorOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParseException._getErrorOffset25492);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParseException.staticClass, global::java.text.ParseException._getErrorOffset25492);
		}
		internal static global::MonoJavaBridge.MethodId _ParseException25493;
		public ParseException(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParseException.staticClass, global::java.text.ParseException._ParseException25493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParseException"));
			global::java.text.ParseException._getErrorOffset25492 = @__env.GetMethodIDNoThrow(global::java.text.ParseException.staticClass, "getErrorOffset", "()I");
			global::java.text.ParseException._ParseException25493 = @__env.GetMethodIDNoThrow(global::java.text.ParseException.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
