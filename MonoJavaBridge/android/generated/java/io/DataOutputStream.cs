namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataOutputStream : java.io.FilterOutputStream, DataOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataOutputStream.staticClass, "size", "()I", ref global::java.io.DataOutputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "write", "(I)V", ref global::java.io.DataOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "write", "([BII)V", ref global::java.io.DataOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "flush", "()V", ref global::java.io.DataOutputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeInt", "(I)V", ref global::java.io.DataOutputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeChar", "(I)V", ref global::java.io.DataOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.DataOutputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.DataOutputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeLong", "(J)V", ref global::java.io.DataOutputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeByte", "(I)V", ref global::java.io.DataOutputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeShort", "(I)V", ref global::java.io.DataOutputStream._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeFloat", "(F)V", ref global::java.io.DataOutputStream._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeDouble", "(D)V", ref global::java.io.DataOutputStream._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeBoolean", "(Z)V", ref global::java.io.DataOutputStream._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.DataOutputStream._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public DataOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._m15.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._m15 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DataOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutputStream"));
		}
	}
}
