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
		internal static global::MonoJavaBridge.MethodId _readLine18781;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInputStream._readLine18781)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readLine18781)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt18782;
		public virtual int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readInt18782);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readInt18782);
		}
		internal static global::MonoJavaBridge.MethodId _readChar18783;
		public virtual char readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.DataInputStream._readChar18783);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readChar18783);
		}
		internal static global::MonoJavaBridge.MethodId _read18784;
		public sealed override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._read18784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._read18784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read18785;
		public sealed override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._read18785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._read18785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18786;
		public static global::java.lang.String readUTF(java.io.DataInput arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUTF18786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18787;
		public virtual global::java.lang.String readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInputStream._readUTF18787)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUTF18787)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully18788;
		public virtual void readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInputStream._readFully18788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFully18788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully18789;
		public virtual void readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInputStream._readFully18789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFully18789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong18790;
		public virtual long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.DataInputStream._readLong18790);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readLong18790);
		}
		internal static global::MonoJavaBridge.MethodId _readByte18791;
		public virtual byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.DataInputStream._readByte18791);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readByte18791);
		}
		internal static global::MonoJavaBridge.MethodId _readShort18792;
		public virtual short readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.DataInputStream._readShort18792);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readShort18792);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat18793;
		public virtual float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.DataInputStream._readFloat18793);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFloat18793);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes18794;
		public virtual int skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._skipBytes18794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._skipBytes18794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean18795;
		public virtual bool readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.DataInputStream._readBoolean18795);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readBoolean18795);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte18796;
		public virtual int readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readUnsignedByte18796);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUnsignedByte18796);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort18797;
		public virtual int readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readUnsignedShort18797);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUnsignedShort18797);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble18798;
		public virtual double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.DataInputStream._readDouble18798);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readDouble18798);
		}
		internal static global::MonoJavaBridge.MethodId _DataInputStream18799;
		public DataInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._DataInputStream18799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInputStream"));
			global::java.io.DataInputStream._readLine18781 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.DataInputStream._readInt18782 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readInt", "()I");
			global::java.io.DataInputStream._readChar18783 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readChar", "()C");
			global::java.io.DataInputStream._read18784 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "read", "([B)I");
			global::java.io.DataInputStream._read18785 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "read", "([BII)I");
			global::java.io.DataInputStream._readUTF18786 = @__env.GetStaticMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;");
			global::java.io.DataInputStream._readUTF18787 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.DataInputStream._readFully18788 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFully", "([B)V");
			global::java.io.DataInputStream._readFully18789 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFully", "([BII)V");
			global::java.io.DataInputStream._readLong18790 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readLong", "()J");
			global::java.io.DataInputStream._readByte18791 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readByte", "()B");
			global::java.io.DataInputStream._readShort18792 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readShort", "()S");
			global::java.io.DataInputStream._readFloat18793 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFloat", "()F");
			global::java.io.DataInputStream._skipBytes18794 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "skipBytes", "(I)I");
			global::java.io.DataInputStream._readBoolean18795 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readBoolean", "()Z");
			global::java.io.DataInputStream._readUnsignedByte18796 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUnsignedByte", "()I");
			global::java.io.DataInputStream._readUnsignedShort18797 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUnsignedShort", "()I");
			global::java.io.DataInputStream._readDouble18798 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readDouble", "()D");
			global::java.io.DataInputStream._DataInputStream18799 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
