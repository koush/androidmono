namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataInputStream : java.io.FilterInputStream, DataInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine18899;
		public virtual global::java.lang.String readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInputStream._readLine18899)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readLine18899)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt18900;
		public virtual int readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readInt18900);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readInt18900);
		}
		internal static global::MonoJavaBridge.MethodId _readChar18901;
		public virtual char readChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.DataInputStream._readChar18901);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readChar18901);
		}
		internal static global::MonoJavaBridge.MethodId _read18902;
		public sealed override int read(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._read18902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._read18902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read18903;
		public sealed override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._read18903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._read18903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18904;
		public static global::java.lang.String readUTF(java.io.DataInput arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUTF18904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18905;
		public virtual global::java.lang.String readUTF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInputStream._readUTF18905)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUTF18905)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully18906;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInputStream._readFully18906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFully18906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully18907;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInputStream._readFully18907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFully18907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong18908;
		public virtual long readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.DataInputStream._readLong18908);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readLong18908);
		}
		internal static global::MonoJavaBridge.MethodId _readByte18909;
		public virtual byte readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.DataInputStream._readByte18909);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readByte18909);
		}
		internal static global::MonoJavaBridge.MethodId _readShort18910;
		public virtual short readShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.DataInputStream._readShort18910);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readShort18910);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat18911;
		public virtual float readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.DataInputStream._readFloat18911);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readFloat18911);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes18912;
		public virtual int skipBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._skipBytes18912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._skipBytes18912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean18913;
		public virtual bool readBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.DataInputStream._readBoolean18913);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readBoolean18913);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte18914;
		public virtual int readUnsignedByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readUnsignedByte18914);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUnsignedByte18914);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort18915;
		public virtual int readUnsignedShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInputStream._readUnsignedShort18915);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readUnsignedShort18915);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble18916;
		public virtual double readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.DataInputStream._readDouble18916);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.DataInputStream.staticClass, global::java.io.DataInputStream._readDouble18916);
		}
		internal static global::MonoJavaBridge.MethodId _DataInputStream18917;
		public DataInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataInputStream.staticClass, global::java.io.DataInputStream._DataInputStream18917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DataInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInputStream"));
			global::java.io.DataInputStream._readLine18899 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.DataInputStream._readInt18900 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readInt", "()I");
			global::java.io.DataInputStream._readChar18901 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readChar", "()C");
			global::java.io.DataInputStream._read18902 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "read", "([B)I");
			global::java.io.DataInputStream._read18903 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "read", "([BII)I");
			global::java.io.DataInputStream._readUTF18904 = @__env.GetStaticMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;");
			global::java.io.DataInputStream._readUTF18905 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.DataInputStream._readFully18906 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFully", "([B)V");
			global::java.io.DataInputStream._readFully18907 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFully", "([BII)V");
			global::java.io.DataInputStream._readLong18908 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readLong", "()J");
			global::java.io.DataInputStream._readByte18909 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readByte", "()B");
			global::java.io.DataInputStream._readShort18910 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readShort", "()S");
			global::java.io.DataInputStream._readFloat18911 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readFloat", "()F");
			global::java.io.DataInputStream._skipBytes18912 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "skipBytes", "(I)I");
			global::java.io.DataInputStream._readBoolean18913 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readBoolean", "()Z");
			global::java.io.DataInputStream._readUnsignedByte18914 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUnsignedByte", "()I");
			global::java.io.DataInputStream._readUnsignedShort18915 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readUnsignedShort", "()I");
			global::java.io.DataInputStream._readDouble18916 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "readDouble", "()D");
			global::java.io.DataInputStream._DataInputStream18917 = @__env.GetMethodIDNoThrow(global::java.io.DataInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
