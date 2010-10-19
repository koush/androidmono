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
		internal static global::MonoJavaBridge.MethodId _length13892;
		public virtual long length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.RandomAccessFile._length13892);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._length13892);
		}
		internal static global::MonoJavaBridge.MethodId _write13893;
		public virtual void write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._write13893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._write13893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13894;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._write13894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._write13894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13895;
		public virtual void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._write13895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._write13895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLine13896;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._readLine13896)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readLine13896)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13897;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._close13897);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._close13897);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt13898;
		public virtual void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeInt13898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeInt13898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readInt13899;
		public virtual int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._readInt13899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readInt13899);
		}
		internal static global::MonoJavaBridge.MethodId _setLength13900;
		public virtual void setLength(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._setLength13900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._setLength13900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar13901;
		public virtual void writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeChar13901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeChar13901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readChar13902;
		public virtual char readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.RandomAccessFile._readChar13902);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readChar13902);
		}
		internal static global::MonoJavaBridge.MethodId _read13903;
		public virtual int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._read13903);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._read13903);
		}
		internal static global::MonoJavaBridge.MethodId _read13904;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._read13904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._read13904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13905;
		public virtual int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._read13905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._read13905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor FD
		{
			get
			{
				return getFD();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFD13906;
		public virtual global::java.io.FileDescriptor getFD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._getFD13906)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._getFD13906)) as java.io.FileDescriptor;
		}
		public new global::java.nio.channels.FileChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel13907;
		public virtual global::java.nio.channels.FileChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._getChannel13907)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._getChannel13907)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes13908;
		public virtual void writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeBytes13908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeBytes13908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF13909;
		public virtual void writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeUTF13909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeUTF13909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readUTF13910;
		public virtual global::java.lang.String readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile._readUTF13910)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readUTF13910)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully13911;
		public virtual void readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._readFully13911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readFully13911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully13912;
		public virtual void readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._readFully13912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readFully13912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong13913;
		public virtual long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.RandomAccessFile._readLong13913);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readLong13913);
		}
		internal static global::MonoJavaBridge.MethodId _readByte13914;
		public virtual byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.RandomAccessFile._readByte13914);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readByte13914);
		}
		internal static global::MonoJavaBridge.MethodId _readShort13915;
		public virtual short readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.RandomAccessFile._readShort13915);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readShort13915);
		}
		internal static global::MonoJavaBridge.MethodId _writeLong13916;
		public virtual void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeLong13916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeLong13916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte13917;
		public virtual void writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeByte13917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeByte13917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort13918;
		public virtual void writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeShort13918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeShort13918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat13919;
		public virtual void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeFloat13919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeFloat13919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFloat13920;
		public virtual float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.RandomAccessFile._readFloat13920);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readFloat13920);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes13921;
		public virtual int skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._skipBytes13921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._skipBytes13921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean13922;
		public virtual bool readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.RandomAccessFile._readBoolean13922);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readBoolean13922);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte13923;
		public virtual int readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._readUnsignedByte13923);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readUnsignedByte13923);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort13924;
		public virtual int readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.RandomAccessFile._readUnsignedShort13924);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readUnsignedShort13924);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble13925;
		public virtual double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.RandomAccessFile._readDouble13925);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._readDouble13925);
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble13926;
		public virtual void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeDouble13926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeDouble13926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean13927;
		public virtual void writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeBoolean13927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeBoolean13927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars13928;
		public virtual void writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._writeChars13928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._writeChars13928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long FilePointer
		{
			get
			{
				return getFilePointer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilePointer13929;
		public virtual long getFilePointer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.RandomAccessFile._getFilePointer13929);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._getFilePointer13929);
		}
		internal static global::MonoJavaBridge.MethodId _seek13930;
		public virtual void seek(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile._seek13930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._seek13930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RandomAccessFile13931;
		public RandomAccessFile(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._RandomAccessFile13931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RandomAccessFile13932;
		public RandomAccessFile(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.RandomAccessFile.staticClass, global::java.io.RandomAccessFile._RandomAccessFile13932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.RandomAccessFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/RandomAccessFile"));
			global::java.io.RandomAccessFile._length13892 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "length", "()J");
			global::java.io.RandomAccessFile._write13893 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "write", "([B)V");
			global::java.io.RandomAccessFile._write13894 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "write", "(I)V");
			global::java.io.RandomAccessFile._write13895 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "write", "([BII)V");
			global::java.io.RandomAccessFile._readLine13896 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.RandomAccessFile._close13897 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "close", "()V");
			global::java.io.RandomAccessFile._writeInt13898 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeInt", "(I)V");
			global::java.io.RandomAccessFile._readInt13899 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readInt", "()I");
			global::java.io.RandomAccessFile._setLength13900 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "setLength", "(J)V");
			global::java.io.RandomAccessFile._writeChar13901 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeChar", "(I)V");
			global::java.io.RandomAccessFile._readChar13902 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readChar", "()C");
			global::java.io.RandomAccessFile._read13903 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "read", "()I");
			global::java.io.RandomAccessFile._read13904 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "read", "([BII)I");
			global::java.io.RandomAccessFile._read13905 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "read", "([B)I");
			global::java.io.RandomAccessFile._getFD13906 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "getFD", "()Ljava/io/FileDescriptor;");
			global::java.io.RandomAccessFile._getChannel13907 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "getChannel", "()Ljava/nio/channels/FileChannel;");
			global::java.io.RandomAccessFile._writeBytes13908 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._writeUTF13909 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._readUTF13910 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.RandomAccessFile._readFully13911 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readFully", "([BII)V");
			global::java.io.RandomAccessFile._readFully13912 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readFully", "([B)V");
			global::java.io.RandomAccessFile._readLong13913 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readLong", "()J");
			global::java.io.RandomAccessFile._readByte13914 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readByte", "()B");
			global::java.io.RandomAccessFile._readShort13915 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readShort", "()S");
			global::java.io.RandomAccessFile._writeLong13916 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeLong", "(J)V");
			global::java.io.RandomAccessFile._writeByte13917 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeByte", "(I)V");
			global::java.io.RandomAccessFile._writeShort13918 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeShort", "(I)V");
			global::java.io.RandomAccessFile._writeFloat13919 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeFloat", "(F)V");
			global::java.io.RandomAccessFile._readFloat13920 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readFloat", "()F");
			global::java.io.RandomAccessFile._skipBytes13921 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "skipBytes", "(I)I");
			global::java.io.RandomAccessFile._readBoolean13922 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readBoolean", "()Z");
			global::java.io.RandomAccessFile._readUnsignedByte13923 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readUnsignedByte", "()I");
			global::java.io.RandomAccessFile._readUnsignedShort13924 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readUnsignedShort", "()I");
			global::java.io.RandomAccessFile._readDouble13925 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "readDouble", "()D");
			global::java.io.RandomAccessFile._writeDouble13926 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeDouble", "(D)V");
			global::java.io.RandomAccessFile._writeBoolean13927 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeBoolean", "(Z)V");
			global::java.io.RandomAccessFile._writeChars13928 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._getFilePointer13929 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "getFilePointer", "()J");
			global::java.io.RandomAccessFile._seek13930 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "seek", "(J)V");
			global::java.io.RandomAccessFile._RandomAccessFile13931 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.RandomAccessFile._RandomAccessFile13932 = @__env.GetMethodIDNoThrow(global::java.io.RandomAccessFile.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
	}
}
