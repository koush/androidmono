namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.DataOutput_))]
	public partial interface DataOutput  : global::MonoJavaBridge.IJavaObject 
	{
		void write(int arg0);
		void write(byte[] arg0);
		void write(byte[] arg0, int arg1, int arg2);
		void writeInt(int arg0);
		void writeChar(int arg0);
		void writeBytes(java.lang.String arg0);
		void writeUTF(java.lang.String arg0);
		void writeLong(long arg0);
		void writeByte(int arg0);
		void writeShort(int arg0);
		void writeFloat(float arg0);
		void writeDouble(double arg0);
		void writeBoolean(bool arg0);
		void writeChars(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.DataOutput))]
	internal sealed partial class DataOutput_ : java.lang.Object, DataOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DataOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.io.DataOutput.write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "write", "(I)V", ref global::java.io.DataOutput_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.io.DataOutput.write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "write", "([B)V", ref global::java.io.DataOutput_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "write", "([BII)V", ref global::java.io.DataOutput_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.io.DataOutput.writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeInt", "(I)V", ref global::java.io.DataOutput_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.io.DataOutput.writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeChar", "(I)V", ref global::java.io.DataOutput_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.io.DataOutput.writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.DataOutput_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.io.DataOutput.writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.DataOutput_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void java.io.DataOutput.writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeLong", "(J)V", ref global::java.io.DataOutput_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void java.io.DataOutput.writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeByte", "(I)V", ref global::java.io.DataOutput_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.io.DataOutput.writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeShort", "(I)V", ref global::java.io.DataOutput_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void java.io.DataOutput.writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeFloat", "(F)V", ref global::java.io.DataOutput_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.io.DataOutput.writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeDouble", "(D)V", ref global::java.io.DataOutput_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.io.DataOutput.writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeBoolean", "(Z)V", ref global::java.io.DataOutput_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void java.io.DataOutput.writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.DataOutput_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DataOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutput"));
		}
	}
}
