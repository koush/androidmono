namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RandomAccessFile : java.lang.Object, DataOutput, DataInput, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RandomAccessFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.RandomAccessFile.staticClass, "length", "()J", ref global::java.io.RandomAccessFile._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "write", "([B)V", ref global::java.io.RandomAccessFile._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "write", "(I)V", ref global::java.io.RandomAccessFile._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "write", "([BII)V", ref global::java.io.RandomAccessFile._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.RandomAccessFile.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.RandomAccessFile._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "close", "()V", ref global::java.io.RandomAccessFile._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeInt", "(I)V", ref global::java.io.RandomAccessFile._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "readInt", "()I", ref global::java.io.RandomAccessFile._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setLength(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "setLength", "(J)V", ref global::java.io.RandomAccessFile._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeChar", "(I)V", ref global::java.io.RandomAccessFile._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual char readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.RandomAccessFile.staticClass, "readChar", "()C", ref global::java.io.RandomAccessFile._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "read", "()I", ref global::java.io.RandomAccessFile._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "read", "([BII)I", ref global::java.io.RandomAccessFile._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "read", "([B)I", ref global::java.io.RandomAccessFile._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.io.FileDescriptor getFD()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.io.RandomAccessFile.staticClass, "getFD", "()Ljava/io/FileDescriptor;", ref global::java.io.RandomAccessFile._m14) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.nio.channels.FileChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.RandomAccessFile.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;", ref global::java.io.RandomAccessFile._m15) as java.nio.channels.FileChannel;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.RandomAccessFile._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.RandomAccessFile._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.RandomAccessFile.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.RandomAccessFile._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "readFully", "([BII)V", ref global::java.io.RandomAccessFile._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "readFully", "([B)V", ref global::java.io.RandomAccessFile._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual long readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.RandomAccessFile.staticClass, "readLong", "()J", ref global::java.io.RandomAccessFile._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual byte readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.RandomAccessFile.staticClass, "readByte", "()B", ref global::java.io.RandomAccessFile._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual short readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.RandomAccessFile.staticClass, "readShort", "()S", ref global::java.io.RandomAccessFile._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeLong", "(J)V", ref global::java.io.RandomAccessFile._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeByte", "(I)V", ref global::java.io.RandomAccessFile._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeShort", "(I)V", ref global::java.io.RandomAccessFile._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeFloat", "(F)V", ref global::java.io.RandomAccessFile._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual float readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.RandomAccessFile.staticClass, "readFloat", "()F", ref global::java.io.RandomAccessFile._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "skipBytes", "(I)I", ref global::java.io.RandomAccessFile._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.RandomAccessFile.staticClass, "readBoolean", "()Z", ref global::java.io.RandomAccessFile._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "readUnsignedByte", "()I", ref global::java.io.RandomAccessFile._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual int readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "readUnsignedShort", "()I", ref global::java.io.RandomAccessFile._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual double readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.RandomAccessFile.staticClass, "readDouble", "()D", ref global::java.io.RandomAccessFile._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeDouble", "(D)V", ref global::java.io.RandomAccessFile._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeBoolean", "(Z)V", ref global::java.io.RandomAccessFile._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.RandomAccessFile._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long FilePointer
		{
			get
			{
				return getFilePointer();
			}
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual long getFilePointer()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.RandomAccessFile.staticClass, "getFilePointer", "()J", ref global::java.io.RandomAccessFile._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void seek(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "seek", "(J)V", ref global::java.io.RandomAccessFile._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public RandomAccessFile(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.RandomAccessFile._m39.native == global::System.IntPtr.Zero)
				global::java.io.RandomAccessFile._m39 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public RandomAccessFile(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.RandomAccessFile._m40.native == global::System.IntPtr.Zero)
				global::java.io.RandomAccessFile._m40 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RandomAccessFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.RandomAccessFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/RandomAccessFile"));
		}
	}
}
