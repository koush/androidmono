namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataInputStream : java.io.FilterInputStream, DataInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataInputStream()
		{
			InitJNI();
		}
		protected DataInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine13310;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInputStream._readLine13310)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readLine13310)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt13311;
		public virtual int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readInt13311);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readInt13311);
		}
		internal static global::MonoJavaBridge.MethodId _readChar13312;
		public virtual char readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.DataInputStream._readChar13312);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readChar13312);
		}
		internal static global::MonoJavaBridge.MethodId _read13313;
		public sealed override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._read13313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._read13313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read13314;
		public sealed override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._read13314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._read13314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readUTF13315;
		public static global::java.lang.String readUTF(java.io.DataInput arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUTF13315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readUTF13316;
		public virtual global::java.lang.String readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInputStream._readUTF13316)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUTF13316)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully13317;
		public virtual void readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInputStream._readFully13317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFully13317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully13318;
		public virtual void readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInputStream._readFully13318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFully13318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong13319;
		public virtual long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.DataInputStream._readLong13319);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readLong13319);
		}
		internal static global::MonoJavaBridge.MethodId _readByte13320;
		public virtual byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.DataInputStream._readByte13320);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readByte13320);
		}
		internal static global::MonoJavaBridge.MethodId _readShort13321;
		public virtual short readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.DataInputStream._readShort13321);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readShort13321);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat13322;
		public virtual float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.DataInputStream._readFloat13322);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFloat13322);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes13323;
		public virtual int skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._skipBytes13323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._skipBytes13323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean13324;
		public virtual bool readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.DataInputStream._readBoolean13324);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readBoolean13324);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte13325;
		public virtual int readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readUnsignedByte13325);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUnsignedByte13325);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort13326;
		public virtual int readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readUnsignedShort13326);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUnsignedShort13326);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble13327;
		public virtual double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.DataInputStream._readDouble13327);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readDouble13327);
		}
		internal static global::MonoJavaBridge.MethodId _DataInputStream13328;
		public DataInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._DataInputStream13328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInputStream"));
			global::java.io.DataInputStream._readLine13310 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.DataInputStream._readInt13311 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readInt", "()I");
			global::java.io.DataInputStream._readChar13312 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readChar", "()C");
			global::java.io.DataInputStream._read13313 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "read", "([B)I");
			global::java.io.DataInputStream._read13314 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "read", "([BII)I");
			global::java.io.DataInputStream._readUTF13315 = @__env.GetStaticMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;");
			global::java.io.DataInputStream._readUTF13316 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.DataInputStream._readFully13317 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFully", "([B)V");
			global::java.io.DataInputStream._readFully13318 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFully", "([BII)V");
			global::java.io.DataInputStream._readLong13319 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readLong", "()J");
			global::java.io.DataInputStream._readByte13320 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readByte", "()B");
			global::java.io.DataInputStream._readShort13321 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readShort", "()S");
			global::java.io.DataInputStream._readFloat13322 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFloat", "()F");
			global::java.io.DataInputStream._skipBytes13323 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "skipBytes", "(I)I");
			global::java.io.DataInputStream._readBoolean13324 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readBoolean", "()Z");
			global::java.io.DataInputStream._readUnsignedByte13325 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUnsignedByte", "()I");
			global::java.io.DataInputStream._readUnsignedShort13326 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUnsignedShort", "()I");
			global::java.io.DataInputStream._readDouble13327 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readDouble", "()D");
			global::java.io.DataInputStream._DataInputStream13328 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
