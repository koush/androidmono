namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectOutput_))]
	public interface ObjectOutput : DataOutput
	{
		void write(int arg0);
		void write(byte[] arg0);
		void write(byte[] arg0, int arg1, int arg2);
		void writeObject(java.lang.Object arg0);
		void flush();
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectOutput))]
	public sealed partial class ObjectOutput_ : java.lang.Object, ObjectOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectOutput_()
		{
			InitJNI();
		}
		internal ObjectOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write13631;
		 void java.io.ObjectOutput.write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13632;
		 void java.io.ObjectOutput.write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write13632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write13632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13633;
		 void java.io.ObjectOutput.write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write13633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write13633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeObject13634;
		 void java.io.ObjectOutput.writeObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeObject13634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeObject13634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush13635;
		 void java.io.ObjectOutput.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._flush13635);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._flush13635);
		}
		internal static global::MonoJavaBridge.MethodId _close13636;
		 void java.io.ObjectOutput.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._close13636);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._close13636);
		}
		internal static global::MonoJavaBridge.MethodId _write13637;
		 void java.io.DataOutput.write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write13637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write13637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13638;
		 void java.io.DataOutput.write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write13638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write13638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13639;
		 void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write13639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write13639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt13640;
		 void java.io.DataOutput.writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeInt13640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeInt13640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar13641;
		 void java.io.DataOutput.writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeChar13641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeChar13641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes13642;
		 void java.io.DataOutput.writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeBytes13642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeBytes13642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF13643;
		 void java.io.DataOutput.writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeUTF13643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeUTF13643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong13644;
		 void java.io.DataOutput.writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeLong13644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeLong13644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte13645;
		 void java.io.DataOutput.writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeByte13645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeByte13645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort13646;
		 void java.io.DataOutput.writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeShort13646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeShort13646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat13647;
		 void java.io.DataOutput.writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeFloat13647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeFloat13647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble13648;
		 void java.io.DataOutput.writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeDouble13648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeDouble13648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean13649;
		 void java.io.DataOutput.writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeBoolean13649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeBoolean13649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars13650;
		 void java.io.DataOutput.writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeChars13650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeChars13650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutput"));
			global::java.io.ObjectOutput_._write13631 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "(I)V");
			global::java.io.ObjectOutput_._write13632 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([B)V");
			global::java.io.ObjectOutput_._write13633 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([BII)V");
			global::java.io.ObjectOutput_._writeObject13634 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeObject", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutput_._flush13635 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "flush", "()V");
			global::java.io.ObjectOutput_._close13636 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "close", "()V");
			global::java.io.ObjectOutput_._write13637 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "(I)V");
			global::java.io.ObjectOutput_._write13638 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([B)V");
			global::java.io.ObjectOutput_._write13639 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([BII)V");
			global::java.io.ObjectOutput_._writeInt13640 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeInt", "(I)V");
			global::java.io.ObjectOutput_._writeChar13641 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeChar", "(I)V");
			global::java.io.ObjectOutput_._writeBytes13642 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutput_._writeUTF13643 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutput_._writeLong13644 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeLong", "(J)V");
			global::java.io.ObjectOutput_._writeByte13645 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeByte", "(I)V");
			global::java.io.ObjectOutput_._writeShort13646 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeShort", "(I)V");
			global::java.io.ObjectOutput_._writeFloat13647 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeFloat", "(F)V");
			global::java.io.ObjectOutput_._writeDouble13648 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeDouble", "(D)V");
			global::java.io.ObjectOutput_._writeBoolean13649 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeBoolean", "(Z)V");
			global::java.io.ObjectOutput_._writeChars13650 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V");
		}
	}
}
