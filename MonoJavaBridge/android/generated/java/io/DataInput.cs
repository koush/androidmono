namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.DataInput_))]
	public partial interface DataInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String readLine();
		int readInt();
		char readChar();
		global::java.lang.String readUTF();
		void readFully(byte[] arg0);
		void readFully(byte[] arg0, int arg1, int arg2);
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		int skipBytes(int arg0);
		bool readBoolean();
		int readUnsignedByte();
		int readUnsignedShort();
		double readDouble();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.DataInput))]
	internal sealed partial class DataInput_ : java.lang.Object, DataInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DataInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine18884;
		global::java.lang.String java.io.DataInput.readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.DataInput_.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.DataInput_._readLine18884) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt18885;
		int java.io.DataInput.readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "readInt", "()I", ref global::java.io.DataInput_._readInt18885);
		}
		internal static global::MonoJavaBridge.MethodId _readChar18886;
		char java.io.DataInput.readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.DataInput_.staticClass, "readChar", "()C", ref global::java.io.DataInput_._readChar18886);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18887;
		global::java.lang.String java.io.DataInput.readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.DataInput_.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.DataInput_._readUTF18887) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully18888;
		void java.io.DataInput.readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataInput_.staticClass, "readFully", "([B)V", ref global::java.io.DataInput_._readFully18888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully18889;
		void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataInput_.staticClass, "readFully", "([BII)V", ref global::java.io.DataInput_._readFully18889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong18890;
		long java.io.DataInput.readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.DataInput_.staticClass, "readLong", "()J", ref global::java.io.DataInput_._readLong18890);
		}
		internal static global::MonoJavaBridge.MethodId _readByte18891;
		byte java.io.DataInput.readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.DataInput_.staticClass, "readByte", "()B", ref global::java.io.DataInput_._readByte18891);
		}
		internal static global::MonoJavaBridge.MethodId _readShort18892;
		short java.io.DataInput.readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.DataInput_.staticClass, "readShort", "()S", ref global::java.io.DataInput_._readShort18892);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat18893;
		float java.io.DataInput.readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.DataInput_.staticClass, "readFloat", "()F", ref global::java.io.DataInput_._readFloat18893);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes18894;
		int java.io.DataInput.skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "skipBytes", "(I)I", ref global::java.io.DataInput_._skipBytes18894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean18895;
		bool java.io.DataInput.readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.DataInput_.staticClass, "readBoolean", "()Z", ref global::java.io.DataInput_._readBoolean18895);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte18896;
		int java.io.DataInput.readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "readUnsignedByte", "()I", ref global::java.io.DataInput_._readUnsignedByte18896);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort18897;
		int java.io.DataInput.readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "readUnsignedShort", "()I", ref global::java.io.DataInput_._readUnsignedShort18897);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble18898;
		double java.io.DataInput.readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.DataInput_.staticClass, "readDouble", "()D", ref global::java.io.DataInput_._readDouble18898);
		}
		static DataInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
