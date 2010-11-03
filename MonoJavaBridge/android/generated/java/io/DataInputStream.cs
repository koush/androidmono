namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataInputStream : java.io.FilterInputStream, DataInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.DataInputStream.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.DataInputStream._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInputStream.staticClass, "readInt", "()I", ref global::java.io.DataInputStream._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual char readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.DataInputStream.staticClass, "readChar", "()C", ref global::java.io.DataInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInputStream.staticClass, "read", "([B)I", ref global::java.io.DataInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInputStream.staticClass, "read", "([BII)I", ref global::java.io.DataInputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String readUTF(java.io.DataInput arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInputStream._m5.native == global::System.IntPtr.Zero)
				global::java.io.DataInputStream._m5 = @__env.GetStaticMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.DataInputStream.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.DataInputStream._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataInputStream.staticClass, "readFully", "([B)V", ref global::java.io.DataInputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataInputStream.staticClass, "readFully", "([BII)V", ref global::java.io.DataInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.DataInputStream.staticClass, "readLong", "()J", ref global::java.io.DataInputStream._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual byte readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.DataInputStream.staticClass, "readByte", "()B", ref global::java.io.DataInputStream._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual short readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.DataInputStream.staticClass, "readShort", "()S", ref global::java.io.DataInputStream._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual float readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.DataInputStream.staticClass, "readFloat", "()F", ref global::java.io.DataInputStream._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInputStream.staticClass, "skipBytes", "(I)I", ref global::java.io.DataInputStream._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.DataInputStream.staticClass, "readBoolean", "()Z", ref global::java.io.DataInputStream._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInputStream.staticClass, "readUnsignedByte", "()I", ref global::java.io.DataInputStream._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInputStream.staticClass, "readUnsignedShort", "()I", ref global::java.io.DataInputStream._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual double readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.DataInputStream.staticClass, "readDouble", "()D", ref global::java.io.DataInputStream._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public DataInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInputStream._m18.native == global::System.IntPtr.Zero)
				global::java.io.DataInputStream._m18 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DataInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInputStream"));
		}
	}
}
