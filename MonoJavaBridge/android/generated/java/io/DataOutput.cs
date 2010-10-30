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
		internal static global::MonoJavaBridge.MethodId _write18918;
		void java.io.DataOutput.write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "write", "(I)V", ref global::java.io.DataOutput_._write18918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18919;
		void java.io.DataOutput.write(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "write", "([B)V", ref global::java.io.DataOutput_._write18919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18920;
		void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "write", "([BII)V", ref global::java.io.DataOutput_._write18920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt18921;
		void java.io.DataOutput.writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeInt", "(I)V", ref global::java.io.DataOutput_._writeInt18921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar18922;
		void java.io.DataOutput.writeChar(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeChar", "(I)V", ref global::java.io.DataOutput_._writeChar18922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes18923;
		void java.io.DataOutput.writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V", ref global::java.io.DataOutput_._writeBytes18923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF18924;
		void java.io.DataOutput.writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V", ref global::java.io.DataOutput_._writeUTF18924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong18925;
		void java.io.DataOutput.writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeLong", "(J)V", ref global::java.io.DataOutput_._writeLong18925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte18926;
		void java.io.DataOutput.writeByte(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeByte", "(I)V", ref global::java.io.DataOutput_._writeByte18926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort18927;
		void java.io.DataOutput.writeShort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeShort", "(I)V", ref global::java.io.DataOutput_._writeShort18927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat18928;
		void java.io.DataOutput.writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeFloat", "(F)V", ref global::java.io.DataOutput_._writeFloat18928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble18929;
		void java.io.DataOutput.writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeDouble", "(D)V", ref global::java.io.DataOutput_._writeDouble18929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean18930;
		void java.io.DataOutput.writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeBoolean", "(Z)V", ref global::java.io.DataOutput_._writeBoolean18930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars18931;
		void java.io.DataOutput.writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.DataOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V", ref global::java.io.DataOutput_._writeChars18931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DataOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
