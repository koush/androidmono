namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.DataOutput_))]
	public interface DataOutput  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class DataOutput_ : java.lang.Object, DataOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataOutput_()
		{
			InitJNI();
		}
		internal DataOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write18800;
		 void java.io.DataOutput.write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._write18800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._write18800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18801;
		 void java.io.DataOutput.write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._write18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._write18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18802;
		 void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._write18802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._write18802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt18803;
		 void java.io.DataOutput.writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeInt18803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeInt18803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar18804;
		 void java.io.DataOutput.writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeChar18804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeChar18804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes18805;
		 void java.io.DataOutput.writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeBytes18805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeBytes18805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF18806;
		 void java.io.DataOutput.writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeUTF18806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeUTF18806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong18807;
		 void java.io.DataOutput.writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeLong18807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeLong18807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte18808;
		 void java.io.DataOutput.writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeByte18808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeByte18808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort18809;
		 void java.io.DataOutput.writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeShort18809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeShort18809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat18810;
		 void java.io.DataOutput.writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeFloat18810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeFloat18810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble18811;
		 void java.io.DataOutput.writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeDouble18811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeDouble18811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean18812;
		 void java.io.DataOutput.writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeBoolean18812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeBoolean18812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars18813;
		 void java.io.DataOutput.writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutput_._writeChars18813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutput_.staticClass, global::java.io.DataOutput_._writeChars18813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutput"));
			global::java.io.DataOutput_._write18800 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "write", "(I)V");
			global::java.io.DataOutput_._write18801 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "write", "([B)V");
			global::java.io.DataOutput_._write18802 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "write", "([BII)V");
			global::java.io.DataOutput_._writeInt18803 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeInt", "(I)V");
			global::java.io.DataOutput_._writeChar18804 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeChar", "(I)V");
			global::java.io.DataOutput_._writeBytes18805 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.DataOutput_._writeUTF18806 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.DataOutput_._writeLong18807 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeLong", "(J)V");
			global::java.io.DataOutput_._writeByte18808 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeByte", "(I)V");
			global::java.io.DataOutput_._writeShort18809 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeShort", "(I)V");
			global::java.io.DataOutput_._writeFloat18810 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeFloat", "(F)V");
			global::java.io.DataOutput_._writeDouble18811 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeDouble", "(D)V");
			global::java.io.DataOutput_._writeBoolean18812 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeBoolean", "(Z)V");
			global::java.io.DataOutput_._writeChars18813 = @__env.GetMethodIDNoThrow(global::java.io.DataOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V");
		}
	}
}
