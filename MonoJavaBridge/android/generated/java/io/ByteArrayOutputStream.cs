namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteArrayOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ByteArrayOutputStream.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.ByteArrayOutputStream._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ByteArrayOutputStream.staticClass, "toString", "(I)Ljava/lang/String;", ref global::java.io.ByteArrayOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String toString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ByteArrayOutputStream.staticClass, "toString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.io.ByteArrayOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "size", "()I", ref global::java.io.ByteArrayOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "write", "([BII)V", ref global::java.io.ByteArrayOutputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "write", "(I)V", ref global::java.io.ByteArrayOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "close", "()V", ref global::java.io.ByteArrayOutputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "reset", "()V", ref global::java.io.ByteArrayOutputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.io.ByteArrayOutputStream.staticClass, "toByteArray", "()[B", ref global::java.io.ByteArrayOutputStream._m8) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::java.io.ByteArrayOutputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ByteArrayOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ByteArrayOutputStream._m10.native == global::System.IntPtr.Zero)
				global::java.io.ByteArrayOutputStream._m10 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._m10);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ByteArrayOutputStream(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ByteArrayOutputStream._m11.native == global::System.IntPtr.Zero)
				global::java.io.ByteArrayOutputStream._m11 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayOutputStream"));
		}
	}
}
