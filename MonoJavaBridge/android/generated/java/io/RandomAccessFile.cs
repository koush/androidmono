namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RandomAccessFile : java.lang.Object, DataOutput, DataInput, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RandomAccessFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length19512;
		public virtual long length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.RandomAccessFile.staticClass, "length", "()J", ref global::java.io.RandomAccessFile._length19512);
		}
		internal static global::MonoJavaBridge.MethodId _write19513;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "write", "([B)V", ref global::java.io.RandomAccessFile._write19513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19514;
		public virtual void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "write", "(I)V", ref global::java.io.RandomAccessFile._write19514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19515;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "write", "([BII)V", ref global::java.io.RandomAccessFile._write19515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine19516;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.RandomAccessFile.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.RandomAccessFile._readLine19516) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close19517;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "close", "()V", ref global::java.io.RandomAccessFile._close19517);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19518;
		public virtual void writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeInt", "(I)V", ref global::java.io.RandomAccessFile._writeInt19518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readInt19519;
		public virtual int readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "readInt", "()I", ref global::java.io.RandomAccessFile._readInt19519);
		}
		internal static global::MonoJavaBridge.MethodId _setLength19520;
		public virtual void setLength(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "setLength", "(J)V", ref global::java.io.RandomAccessFile._setLength19520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar19521;
		public virtual void writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeChar", "(I)V", ref global::java.io.RandomAccessFile._writeChar19521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readChar19522;
		public virtual char readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.RandomAccessFile.staticClass, "readChar", "()C", ref global::java.io.RandomAccessFile._readChar19522);
		}
		internal static global::MonoJavaBridge.MethodId _read19523;
		public virtual int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "read", "()I", ref global::java.io.RandomAccessFile._read19523);
		}
		internal static global::MonoJavaBridge.MethodId _read19524;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "read", "([BII)I", ref global::java.io.RandomAccessFile._read19524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19525;
		public virtual int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "read", "([B)I", ref global::java.io.RandomAccessFile._read19525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD19526;
		public virtual global::java.io.FileDescriptor getFD()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::java.io.RandomAccessFile.staticClass, "getFD", "()Ljava/io/FileDescriptor;", ref global::java.io.RandomAccessFile._getFD19526) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel19527;
		public virtual global::java.nio.channels.FileChannel getChannel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.RandomAccessFile.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;", ref global::java.io.RandomAccessFile._getChannel19527) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19528;
		public virtual void writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.RandomAccessFile._writeBytes19528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF19529;
		public virtual void writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.RandomAccessFile._writeUTF19529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19530;
		public virtual global::java.lang.String readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.RandomAccessFile.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.RandomAccessFile._readUTF19530) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19531;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "readFully", "([BII)V", ref global::java.io.RandomAccessFile._readFully19531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19532;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "readFully", "([B)V", ref global::java.io.RandomAccessFile._readFully19532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19533;
		public virtual long readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.RandomAccessFile.staticClass, "readLong", "()J", ref global::java.io.RandomAccessFile._readLong19533);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19534;
		public virtual byte readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.RandomAccessFile.staticClass, "readByte", "()B", ref global::java.io.RandomAccessFile._readByte19534);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19535;
		public virtual short readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.RandomAccessFile.staticClass, "readShort", "()S", ref global::java.io.RandomAccessFile._readShort19535);
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19536;
		public virtual void writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeLong", "(J)V", ref global::java.io.RandomAccessFile._writeLong19536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19537;
		public virtual void writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeByte", "(I)V", ref global::java.io.RandomAccessFile._writeByte19537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19538;
		public virtual void writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeShort", "(I)V", ref global::java.io.RandomAccessFile._writeShort19538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19539;
		public virtual void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeFloat", "(F)V", ref global::java.io.RandomAccessFile._writeFloat19539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19540;
		public virtual float readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.RandomAccessFile.staticClass, "readFloat", "()F", ref global::java.io.RandomAccessFile._readFloat19540);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19541;
		public virtual int skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "skipBytes", "(I)I", ref global::java.io.RandomAccessFile._skipBytes19541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19542;
		public virtual bool readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.RandomAccessFile.staticClass, "readBoolean", "()Z", ref global::java.io.RandomAccessFile._readBoolean19542);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19543;
		public virtual int readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "readUnsignedByte", "()I", ref global::java.io.RandomAccessFile._readUnsignedByte19543);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19544;
		public virtual int readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.RandomAccessFile.staticClass, "readUnsignedShort", "()I", ref global::java.io.RandomAccessFile._readUnsignedShort19544);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19545;
		public virtual double readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.RandomAccessFile.staticClass, "readDouble", "()D", ref global::java.io.RandomAccessFile._readDouble19545);
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19546;
		public virtual void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeDouble", "(D)V", ref global::java.io.RandomAccessFile._writeDouble19546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19547;
		public virtual void writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeBoolean", "(Z)V", ref global::java.io.RandomAccessFile._writeBoolean19547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars19548;
		public virtual void writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.RandomAccessFile._writeChars19548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long FilePointer
		{
			get
			{
				return getFilePointer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilePointer19549;
		public virtual long getFilePointer()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.RandomAccessFile.staticClass, "getFilePointer", "()J", ref global::java.io.RandomAccessFile._getFilePointer19549);
		}
		internal static global::MonoJavaBridge.MethodId _seek19550;
		public virtual void seek(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.RandomAccessFile.staticClass, "seek", "(J)V", ref global::java.io.RandomAccessFile._seek19550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RandomAccessFile19551;
		public RandomAccessFile(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.RandomAccessFile._RandomAccessFile19551.native == global::System.IntPtr.Zero)
				global::java.io.RandomAccessFile._RandomAccessFile19551 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._RandomAccessFile19551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RandomAccessFile19552;
		public RandomAccessFile(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.RandomAccessFile._RandomAccessFile19552.native == global::System.IntPtr.Zero)
				global::java.io.RandomAccessFile._RandomAccessFile19552 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._RandomAccessFile19552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RandomAccessFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.RandomAccessFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/RandomAccessFile"));
		}
		internal static void InitJNI()
		{
		}
	}
}
