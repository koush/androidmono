namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RandomAccessFile : java.lang.Object, DataOutput, DataInput, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RandomAccessFile()
		{
			InitJNI();
		}
		protected RandomAccessFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length19394;
		public virtual long length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.RandomAccessFile._length19394);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._length19394);
		}
		internal static global::MonoJavaBridge.MethodId _write19395;
		public virtual void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._write19395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._write19395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19396;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._write19396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._write19396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19397;
		public virtual void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._write19397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._write19397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine19398;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._readLine19398)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readLine19398)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close19399;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._close19399);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._close19399);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19400;
		public virtual void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeInt19400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeInt19400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readInt19401;
		public virtual int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._readInt19401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readInt19401);
		}
		internal static global::MonoJavaBridge.MethodId _setLength19402;
		public virtual void setLength(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._setLength19402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._setLength19402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar19403;
		public virtual void writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeChar19403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeChar19403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readChar19404;
		public virtual char readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.RandomAccessFile._readChar19404);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readChar19404);
		}
		internal static global::MonoJavaBridge.MethodId _read19405;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._read19405);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._read19405);
		}
		internal static global::MonoJavaBridge.MethodId _read19406;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._read19406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._read19406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19407;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._read19407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._read19407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD19408;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._getFD19408)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._getFD19408)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel19409;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._getChannel19409)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._getChannel19409)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19410;
		public virtual void writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeBytes19410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeBytes19410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF19411;
		public virtual void writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeUTF19411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeUTF19411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19412;
		public virtual global::java.lang.String readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._readUTF19412)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readUTF19412)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19413;
		public virtual void readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._readFully19413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readFully19413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19414;
		public virtual void readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._readFully19414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readFully19414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19415;
		public virtual long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.RandomAccessFile._readLong19415);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readLong19415);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19416;
		public virtual byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.RandomAccessFile._readByte19416);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readByte19416);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19417;
		public virtual short readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.RandomAccessFile._readShort19417);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readShort19417);
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19418;
		public virtual void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeLong19418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeLong19418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19419;
		public virtual void writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeByte19419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeByte19419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19420;
		public virtual void writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeShort19420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeShort19420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19421;
		public virtual void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeFloat19421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeFloat19421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19422;
		public virtual float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.RandomAccessFile._readFloat19422);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readFloat19422);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19423;
		public virtual int skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._skipBytes19423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._skipBytes19423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19424;
		public virtual bool readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.RandomAccessFile._readBoolean19424);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readBoolean19424);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19425;
		public virtual int readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._readUnsignedByte19425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readUnsignedByte19425);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19426;
		public virtual int readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._readUnsignedShort19426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readUnsignedShort19426);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19427;
		public virtual double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.RandomAccessFile._readDouble19427);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readDouble19427);
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19428;
		public virtual void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeDouble19428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeDouble19428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19429;
		public virtual void writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeBoolean19429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeBoolean19429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars19430;
		public virtual void writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeChars19430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeChars19430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long FilePointer
		{
			get
			{
				return getFilePointer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilePointer19431;
		public virtual long getFilePointer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.RandomAccessFile._getFilePointer19431);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._getFilePointer19431);
		}
		internal static global::MonoJavaBridge.MethodId _seek19432;
		public virtual void seek(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._seek19432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._seek19432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RandomAccessFile19433;
		public RandomAccessFile(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._RandomAccessFile19433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RandomAccessFile19434;
		public RandomAccessFile(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._RandomAccessFile19434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.RandomAccessFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/RandomAccessFile"));
			global::java.io.RandomAccessFile._length19394 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "length", "()J");
			global::java.io.RandomAccessFile._write19395 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "write", "([B)V");
			global::java.io.RandomAccessFile._write19396 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "write", "(I)V");
			global::java.io.RandomAccessFile._write19397 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "write", "([BII)V");
			global::java.io.RandomAccessFile._readLine19398 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.RandomAccessFile._close19399 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "close", "()V");
			global::java.io.RandomAccessFile._writeInt19400 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeInt", "(I)V");
			global::java.io.RandomAccessFile._readInt19401 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readInt", "()I");
			global::java.io.RandomAccessFile._setLength19402 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "setLength", "(J)V");
			global::java.io.RandomAccessFile._writeChar19403 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeChar", "(I)V");
			global::java.io.RandomAccessFile._readChar19404 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readChar", "()C");
			global::java.io.RandomAccessFile._read19405 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "read", "()I");
			global::java.io.RandomAccessFile._read19406 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "read", "([BII)I");
			global::java.io.RandomAccessFile._read19407 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "read", "([B)I");
			global::java.io.RandomAccessFile._getFD19408 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.RandomAccessFile._getChannel19409 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.RandomAccessFile._writeBytes19410 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._writeUTF19411 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._readUTF19412 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.RandomAccessFile._readFully19413 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readFully", "([BII)V");
			global::java.io.RandomAccessFile._readFully19414 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readFully", "([B)V");
			global::java.io.RandomAccessFile._readLong19415 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readLong", "()J");
			global::java.io.RandomAccessFile._readByte19416 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readByte", "()B");
			global::java.io.RandomAccessFile._readShort19417 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readShort", "()S");
			global::java.io.RandomAccessFile._writeLong19418 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeLong", "(J)V");
			global::java.io.RandomAccessFile._writeByte19419 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeByte", "(I)V");
			global::java.io.RandomAccessFile._writeShort19420 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeShort", "(I)V");
			global::java.io.RandomAccessFile._writeFloat19421 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeFloat", "(F)V");
			global::java.io.RandomAccessFile._readFloat19422 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readFloat", "()F");
			global::java.io.RandomAccessFile._skipBytes19423 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "skipBytes", "(I)I");
			global::java.io.RandomAccessFile._readBoolean19424 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readBoolean", "()Z");
			global::java.io.RandomAccessFile._readUnsignedByte19425 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readUnsignedByte", "()I");
			global::java.io.RandomAccessFile._readUnsignedShort19426 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readUnsignedShort", "()I");
			global::java.io.RandomAccessFile._readDouble19427 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readDouble", "()D");
			global::java.io.RandomAccessFile._writeDouble19428 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeDouble", "(D)V");
			global::java.io.RandomAccessFile._writeBoolean19429 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeBoolean", "(Z)V");
			global::java.io.RandomAccessFile._writeChars19430 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._getFilePointer19431 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "getFilePointer", "()J");
			global::java.io.RandomAccessFile._seek19432 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "seek", "(J)V");
			global::java.io.RandomAccessFile._RandomAccessFile19433 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._RandomAccessFile19434 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
	}
}
