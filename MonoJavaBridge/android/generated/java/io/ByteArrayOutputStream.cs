namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayOutputStream : java.io.OutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteArrayOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18844;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ByteArrayOutputStream.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.ByteArrayOutputStream._toString18844) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString18845;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ByteArrayOutputStream.staticClass, "toString", "(I)Ljava/lang/String;", ref global::java.io.ByteArrayOutputStream._toString18845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString18846;
		public virtual global::java.lang.String toString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ByteArrayOutputStream.staticClass, "toString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.io.ByteArrayOutputStream._toString18846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size18847;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "size", "()I", ref global::java.io.ByteArrayOutputStream._size18847);
		}
		internal static global::MonoJavaBridge.MethodId _write18848;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "write", "([BII)V", ref global::java.io.ByteArrayOutputStream._write18848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18849;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "write", "(I)V", ref global::java.io.ByteArrayOutputStream._write18849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close18850;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "close", "()V", ref global::java.io.ByteArrayOutputStream._close18850);
		}
		internal static global::MonoJavaBridge.MethodId _reset18851;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "reset", "()V", ref global::java.io.ByteArrayOutputStream._reset18851);
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray18852;
		public virtual byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.io.ByteArrayOutputStream.staticClass, "toByteArray", "()[B", ref global::java.io.ByteArrayOutputStream._toByteArray18852) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _writeTo18853;
		public virtual void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ByteArrayOutputStream.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::java.io.ByteArrayOutputStream._writeTo18853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayOutputStream18854;
		public ByteArrayOutputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18854.native == global::System.IntPtr.Zero)
				global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18854 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18854);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayOutputStream18855;
		public ByteArrayOutputStream(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18855.native == global::System.IntPtr.Zero)
				global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18855 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayOutputStream.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayOutputStream.staticClass, global::java.io.ByteArrayOutputStream._ByteArrayOutputStream18855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ByteArrayOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
