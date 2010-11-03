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
		private static global::MonoJavaBridge.MethodId _m0;
		void java.io.ObjectInput.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInput_.staticClass, "close", "()V", ref global::java.io.ObjectInput_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.io.ObjectInput.readObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInput_.staticClass, "readObject", "()Ljava/lang/Object;", ref global::java.io.ObjectInput_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.io.ObjectInput.read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "read", "()I", ref global::java.io.ObjectInput_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.io.ObjectInput.read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "read", "([B)I", ref global::java.io.ObjectInput_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.io.ObjectInput.read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "read", "([BII)I", ref global::java.io.ObjectInput_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		long java.io.ObjectInput.skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInput_.staticClass, "skip", "(J)J", ref global::java.io.ObjectInput_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int java.io.ObjectInput.available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "available", "()I", ref global::java.io.ObjectInput_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String java.io.DataInput.readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInput_.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.ObjectInput_._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.io.DataInput.readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "readInt", "()I", ref global::java.io.ObjectInput_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		char java.io.DataInput.readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectInput_.staticClass, "readChar", "()C", ref global::java.io.ObjectInput_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String java.io.DataInput.readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInput_.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.ObjectInput_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.io.DataInput.readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInput_.staticClass, "readFully", "([B)V", ref global::java.io.ObjectInput_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInput_.staticClass, "readFully", "([BII)V", ref global::java.io.ObjectInput_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		long java.io.DataInput.readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInput_.staticClass, "readLong", "()J", ref global::java.io.ObjectInput_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		byte java.io.DataInput.readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.ObjectInput_.staticClass, "readByte", "()B", ref global::java.io.ObjectInput_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		short java.io.DataInput.readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.ObjectInput_.staticClass, "readShort", "()S", ref global::java.io.ObjectInput_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		float java.io.DataInput.readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.ObjectInput_.staticClass, "readFloat", "()F", ref global::java.io.ObjectInput_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		int java.io.DataInput.skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "skipBytes", "(I)I", ref global::java.io.ObjectInput_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool java.io.DataInput.readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInput_.staticClass, "readBoolean", "()Z", ref global::java.io.ObjectInput_._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		int java.io.DataInput.readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "readUnsignedByte", "()I", ref global::java.io.ObjectInput_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int java.io.DataInput.readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInput_.staticClass, "readUnsignedShort", "()I", ref global::java.io.ObjectInput_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		double java.io.DataInput.readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.ObjectInput_.staticClass, "readDouble", "()D", ref global::java.io.ObjectInput_._m21);
		}
		static ObjectInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInput"));
		}
	}
}
