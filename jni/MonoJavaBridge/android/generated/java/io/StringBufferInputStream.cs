namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringBufferInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringBufferInputStream()
		{
			InitJNI();
		}
		protected StringBufferInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset19602;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringBufferInputStream._reset19602);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._reset19602);
		}
		internal static global::MonoJavaBridge.MethodId _read19603;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringBufferInputStream._read19603);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._read19603);
		}
		internal static global::MonoJavaBridge.MethodId _read19604;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringBufferInputStream._read19604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._read19604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19605;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.StringBufferInputStream._skip19605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._skip19605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19606;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringBufferInputStream._available19606);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._available19606);
		}
		internal static global::MonoJavaBridge.MethodId _StringBufferInputStream19607;
		public StringBufferInputStream(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringBufferInputStream.staticClass, global::java.io.StringBufferInputStream._StringBufferInputStream19607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringBufferInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringBufferInputStream"));
			global::java.io.StringBufferInputStream._reset19602 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "reset", "()V");
			global::java.io.StringBufferInputStream._read19603 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "read", "()I");
			global::java.io.StringBufferInputStream._read19604 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "read", "([BII)I");
			global::java.io.StringBufferInputStream._skip19605 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "skip", "(J)J");
			global::java.io.StringBufferInputStream._available19606 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "available", "()I");
			global::java.io.StringBufferInputStream._StringBufferInputStream19607 = @__env.GetMethodIDNoThrow(global::java.io.StringBufferInputStream.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
