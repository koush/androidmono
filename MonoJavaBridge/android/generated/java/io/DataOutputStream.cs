namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataOutputStream : java.io.FilterOutputStream, DataOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size18932;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._size18932.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._size18932 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._size18932);
		}
		internal static global::MonoJavaBridge.MethodId _write18933;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._write18933.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._write18933 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._write18933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18934;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._write18934.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._write18934 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "write", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._write18934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush18935;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._flush18935.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._flush18935 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._flush18935);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt18936;
		public virtual void writeInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeInt18936.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeInt18936 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeInt", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeInt18936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar18937;
		public virtual void writeChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeChar18937.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeChar18937 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeChar", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeChar18937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes18938;
		public virtual void writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeBytes18938.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeBytes18938 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeBytes18938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF18939;
		public virtual void writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeUTF18939.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeUTF18939 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeUTF18939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong18940;
		public virtual void writeLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeLong18940.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeLong18940 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeLong", "(J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeLong18940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte18941;
		public virtual void writeByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeByte18941.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeByte18941 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeByte", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeByte18941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort18942;
		public virtual void writeShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeShort18942.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeShort18942 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeShort", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeShort18942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat18943;
		public virtual void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeFloat18943.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeFloat18943 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeFloat", "(F)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeFloat18943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble18944;
		public virtual void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeDouble18944.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeDouble18944 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeDouble", "(D)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeDouble18944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean18945;
		public virtual void writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeBoolean18945.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeBoolean18945 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeBoolean", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeBoolean18945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars18946;
		public virtual void writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._writeChars18946.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._writeChars18946 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeChars18946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DataOutputStream18947;
		public DataOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataOutputStream._DataOutputStream18947.native == global::System.IntPtr.Zero)
				global::java.io.DataOutputStream._DataOutputStream18947 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._DataOutputStream18947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DataOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
