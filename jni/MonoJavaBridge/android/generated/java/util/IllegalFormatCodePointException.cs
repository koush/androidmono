namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatCodePointException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalFormatCodePointException()
		{
			InitJNI();
		}
		protected IllegalFormatCodePointException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage20368;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.IllegalFormatCodePointException._getMessage20368)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.IllegalFormatCodePointException.staticClass, global::java.util.IllegalFormatCodePointException._getMessage20368)) as java.lang.String;
		}
		public new int CodePoint
		{
			get
			{
				return getCodePoint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCodePoint20369;
		public virtual int getCodePoint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.IllegalFormatCodePointException._getCodePoint20369);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.IllegalFormatCodePointException.staticClass, global::java.util.IllegalFormatCodePointException._getCodePoint20369);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalFormatCodePointException20370;
		public IllegalFormatCodePointException(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatCodePointException.staticClass, global::java.util.IllegalFormatCodePointException._IllegalFormatCodePointException20370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatCodePointException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatCodePointException"));
			global::java.util.IllegalFormatCodePointException._getMessage20368 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatCodePointException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.IllegalFormatCodePointException._getCodePoint20369 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatCodePointException.staticClass, "getCodePoint", "()I");
			global::java.util.IllegalFormatCodePointException._IllegalFormatCodePointException20370 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatCodePointException.staticClass, "<init>", "(I)V");
		}
	}
}
