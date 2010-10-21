namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatFlagsException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalFormatFlagsException()
		{
			InitJNI();
		}
		protected IllegalFormatFlagsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26200;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatFlagsException._getMessage26200)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatFlagsException.staticClass, global::java.util.IllegalFormatFlagsException._getMessage26200)) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags26201;
		public virtual global::java.lang.String getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatFlagsException._getFlags26201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatFlagsException.staticClass, global::java.util.IllegalFormatFlagsException._getFlags26201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _IllegalFormatFlagsException26202;
		public IllegalFormatFlagsException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatFlagsException.staticClass, global::java.util.IllegalFormatFlagsException._IllegalFormatFlagsException26202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatFlagsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatFlagsException"));
			global::java.util.IllegalFormatFlagsException._getMessage26200 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatFlagsException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.IllegalFormatFlagsException._getFlags26201 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatFlagsException.staticClass, "getFlags", "()Ljava/lang/String;");
			global::java.util.IllegalFormatFlagsException._IllegalFormatFlagsException26202 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatFlagsException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
