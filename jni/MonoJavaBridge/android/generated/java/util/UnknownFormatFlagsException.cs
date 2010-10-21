namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownFormatFlagsException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnknownFormatFlagsException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMessage26841;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UnknownFormatFlagsException._getMessage26841)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._getMessage26841)) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags26842;
		public virtual global::java.lang.String getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UnknownFormatFlagsException._getFlags26842)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._getFlags26842)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _UnknownFormatFlagsException26843;
		public UnknownFormatFlagsException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._UnknownFormatFlagsException26843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UnknownFormatFlagsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UnknownFormatFlagsException"));
			global::java.util.UnknownFormatFlagsException._getMessage26841 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.UnknownFormatFlagsException._getFlags26842 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "getFlags", "()Ljava/lang/String;");
			global::java.util.UnknownFormatFlagsException._UnknownFormatFlagsException26843 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
