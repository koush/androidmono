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
		internal static global::MonoJavaBridge.MethodId _write19224;
		void java.io.ObjectOutput.write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._write19224.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._write19224 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19225;
		void java.io.ObjectOutput.write(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._write19225.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._write19225 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([B)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19226;
		void java.io.ObjectOutput.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._write19226.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._write19226 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([BII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeObject19227;
		void java.io.ObjectOutput.writeObject(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeObject19227.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeObject19227 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeObject", "(Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeObject19227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19228;
		void java.io.ObjectOutput.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._flush19228.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._flush19228 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "flush", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._flush19228);
		}
		internal static global::MonoJavaBridge.MethodId _close19229;
		void java.io.ObjectOutput.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._close19229.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._close19229 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "close", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._close19229);
		}
		internal static global::MonoJavaBridge.MethodId _write19230;
		void java.io.DataOutput.write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._write19230.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._write19230 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19231;
		void java.io.DataOutput.write(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._write19231.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._write19231 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([B)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19232;
		void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._write19232.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._write19232 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([BII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19233;
		void java.io.DataOutput.writeInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeInt19233.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeInt19233 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeInt", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeInt19233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar19234;
		void java.io.DataOutput.writeChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeChar19234.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeChar19234 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeChar", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeChar19234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19235;
		void java.io.DataOutput.writeBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeBytes19235.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeBytes19235 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeBytes19235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF19236;
		void java.io.DataOutput.writeUTF(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeUTF19236.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeUTF19236 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeUTF19236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19237;
		void java.io.DataOutput.writeLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeLong19237.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeLong19237 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeLong", "(J)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeLong19237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19238;
		void java.io.DataOutput.writeByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeByte19238.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeByte19238 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeByte", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeByte19238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19239;
		void java.io.DataOutput.writeShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeShort19239.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeShort19239 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeShort", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeShort19239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19240;
		void java.io.DataOutput.writeFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeFloat19240.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeFloat19240 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeFloat", "(F)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeFloat19240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19241;
		void java.io.DataOutput.writeDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeDouble19241.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeDouble19241 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeDouble", "(D)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeDouble19241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19242;
		void java.io.DataOutput.writeBoolean(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeBoolean19242.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeBoolean19242 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeBoolean", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeBoolean19242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars19243;
		void java.io.DataOutput.writeChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectOutput_._writeChars19243.native == global::System.IntPtr.Zero)
				global::java.io.ObjectOutput_._writeChars19243 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeChars19243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ObjectOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
