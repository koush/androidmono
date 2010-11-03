namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectOutput_))]
	public partial interface ObjectOutput : DataOutput
	{
		void write(int arg0);
		void write(byte[] arg0);
		void write(byte[] arg0, int arg1, int arg2);
		void writeObject(java.lang.Object arg0);
		void flush();
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectOutput))]
	internal sealed partial class ObjectOutput_ : java.lang.Object, ObjectOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ObjectOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.io.ObjectOutput.write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "write", "(I)V", ref global::java.io.ObjectOutput_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.io.ObjectOutput.write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "write", "([B)V", ref global::java.io.ObjectOutput_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.io.ObjectOutput.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "write", "([BII)V", ref global::java.io.ObjectOutput_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.io.ObjectOutput.writeObject(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeObject", "(Ljava/lang/Object;)V", ref global::java.io.ObjectOutput_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.io.ObjectOutput.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "flush", "()V", ref global::java.io.ObjectOutput_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.io.ObjectOutput.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "close", "()V", ref global::java.io.ObjectOutput_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.io.DataOutput.write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "write", "(I)V", ref global::java.io.ObjectOutput_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void java.io.DataOutput.write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "write", "([B)V", ref global::java.io.ObjectOutput_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "write", "([BII)V", ref global::java.io.ObjectOutput_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.io.DataOutput.writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeInt", "(I)V", ref global::java.io.ObjectOutput_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void java.io.DataOutput.writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeChar", "(I)V", ref global::java.io.ObjectOutput_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.io.DataOutput.writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutput_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.io.DataOutput.writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutput_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void java.io.DataOutput.writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeLong", "(J)V", ref global::java.io.ObjectOutput_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void java.io.DataOutput.writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeByte", "(I)V", ref global::java.io.ObjectOutput_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void java.io.DataOutput.writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeShort", "(I)V", ref global::java.io.ObjectOutput_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void java.io.DataOutput.writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeFloat", "(F)V", ref global::java.io.ObjectOutput_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void java.io.DataOutput.writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeDouble", "(D)V", ref global::java.io.ObjectOutput_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void java.io.DataOutput.writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeBoolean", "(Z)V", ref global::java.io.ObjectOutput_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void java.io.DataOutput.writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.ObjectOutput_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ObjectOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutput"));
		}
	}
}
