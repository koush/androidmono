namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatWidthException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalFormatWidthException()
		{
			InitJNI();
		}
		protected IllegalFormatWidthException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage20381;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException._getMessage20381)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._getMessage20381)) as java.lang.String;
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth20382;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException._getWidth20382);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._getWidth20382);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalFormatWidthException20383;
		public IllegalFormatWidthException(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._IllegalFormatWidthException20383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatWidthException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatWidthException"));
			global::java.util.IllegalFormatWidthException._getMessage20381 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.IllegalFormatWidthException._getWidth20382 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "getWidth", "()I");
			global::java.util.IllegalFormatWidthException._IllegalFormatWidthException20383 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "<init>", "(I)V");
		}
	}
}
