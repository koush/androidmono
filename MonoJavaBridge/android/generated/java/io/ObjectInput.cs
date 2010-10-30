namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectInput_))]
	public partial interface ObjectInput : DataInput
	{
		void close();
		global::java.lang.Object readObject();
		int read();
		int read(byte[] arg0);
		int read(byte[] arg0, int arg1, int arg2);
		long skip(long arg0);
		int available();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInput))]
	internal sealed partial class ObjectInput_ : java.lang.Object, ObjectInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ObjectInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19145;
		void java.io.ObjectInput.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInput_.staticClass, "close", "()V", ref global::java.io.ObjectInput_._close19145);
		}
		internal static global::MonoJavaBridge.MethodId _readObject19146;
		global::java.lang.Object java.io.ObjectInput.readObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInput_.staticClass, "readObject", "()Ljava/lang/Object;", ref global::java.io.ObjectInput_._readObject19146) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _read19147;
		int java.io.ObjectInput.read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "read", "()I", ref global::java.io.ObjectInput_._read19147);
		}
		internal static global::MonoJavaBridge.MethodId _read19148;
		int java.io.ObjectInput.read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "read", "([B)I", ref global::java.io.ObjectInput_._read19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19149;
		int java.io.ObjectInput.read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "read", "([BII)I", ref global::java.io.ObjectInput_._read19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19150;
		long java.io.ObjectInput.skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInput_.staticClass, "skip", "(J)J", ref global::java.io.ObjectInput_._skip19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19151;
		int java.io.ObjectInput.available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "available", "()I", ref global::java.io.ObjectInput_._available19151);
		}
		internal static global::MonoJavaBridge.MethodId _readLine19152;
		global::java.lang.String java.io.DataInput.readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInput_.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.ObjectInput_._readLine19152) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt19153;
		int java.io.DataInput.readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "readInt", "()I", ref global::java.io.ObjectInput_._readInt19153);
		}
		internal static global::MonoJavaBridge.MethodId _readChar19154;
		char java.io.DataInput.readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectInput_.staticClass, "readChar", "()C", ref global::java.io.ObjectInput_._readChar19154);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19155;
		global::java.lang.String java.io.DataInput.readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInput_.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.ObjectInput_._readUTF19155) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19156;
		void java.io.DataInput.readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInput_.staticClass, "readFully", "([B)V", ref global::java.io.ObjectInput_._readFully19156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19157;
		void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInput_.staticClass, "readFully", "([BII)V", ref global::java.io.ObjectInput_._readFully19157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19158;
		long java.io.DataInput.readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInput_.staticClass, "readLong", "()J", ref global::java.io.ObjectInput_._readLong19158);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19159;
		byte java.io.DataInput.readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.ObjectInput_.staticClass, "readByte", "()B", ref global::java.io.ObjectInput_._readByte19159);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19160;
		short java.io.DataInput.readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.ObjectInput_.staticClass, "readShort", "()S", ref global::java.io.ObjectInput_._readShort19160);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19161;
		float java.io.DataInput.readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.ObjectInput_.staticClass, "readFloat", "()F", ref global::java.io.ObjectInput_._readFloat19161);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19162;
		int java.io.DataInput.skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "skipBytes", "(I)I", ref global::java.io.ObjectInput_._skipBytes19162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19163;
		bool java.io.DataInput.readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInput_.staticClass, "readBoolean", "()Z", ref global::java.io.ObjectInput_._readBoolean19163);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19164;
		int java.io.DataInput.readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "readUnsignedByte", "()I", ref global::java.io.ObjectInput_._readUnsignedByte19164);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19165;
		int java.io.DataInput.readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "readUnsignedShort", "()I", ref global::java.io.ObjectInput_._readUnsignedShort19165);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19166;
		double java.io.DataInput.readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.ObjectInput_.staticClass, "readDouble", "()D", ref global::java.io.ObjectInput_._readDouble19166);
		}
		static ObjectInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
