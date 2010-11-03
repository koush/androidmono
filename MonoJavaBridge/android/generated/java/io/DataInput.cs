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
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String java.io.DataInput.readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.DataInput_.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.DataInput_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.io.DataInput.readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "readInt", "()I", ref global::java.io.DataInput_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		char java.io.DataInput.readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.DataInput_.staticClass, "readChar", "()C", ref global::java.io.DataInput_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.io.DataInput.readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.DataInput_.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.DataInput_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.io.DataInput.readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataInput_.staticClass, "readFully", "([B)V", ref global::java.io.DataInput_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataInput_.staticClass, "readFully", "([BII)V", ref global::java.io.DataInput_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		long java.io.DataInput.readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.DataInput_.staticClass, "readLong", "()J", ref global::java.io.DataInput_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		byte java.io.DataInput.readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.DataInput_.staticClass, "readByte", "()B", ref global::java.io.DataInput_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		short java.io.DataInput.readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.DataInput_.staticClass, "readShort", "()S", ref global::java.io.DataInput_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		float java.io.DataInput.readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.DataInput_.staticClass, "readFloat", "()F", ref global::java.io.DataInput_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int java.io.DataInput.skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "skipBytes", "(I)I", ref global::java.io.DataInput_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.io.DataInput.readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.DataInput_.staticClass, "readBoolean", "()Z", ref global::java.io.DataInput_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int java.io.DataInput.readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "readUnsignedByte", "()I", ref global::java.io.DataInput_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int java.io.DataInput.readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.DataInput_.staticClass, "readUnsignedShort", "()I", ref global::java.io.DataInput_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		double java.io.DataInput.readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.DataInput_.staticClass, "readDouble", "()D", ref global::java.io.DataInput_._m14);
		}
		static DataInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInput"));
		}
	}
}
