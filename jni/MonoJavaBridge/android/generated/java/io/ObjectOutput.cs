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
		internal static global::MonoJavaBridge.MethodId _write19106;
		 void java.io.ObjectOutput.write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write19106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19107;
		 void java.io.ObjectOutput.write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write19107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19108;
		 void java.io.ObjectOutput.write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write19108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeObject19109;
		 void java.io.ObjectOutput.writeObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeObject19109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeObject19109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19110;
		 void java.io.ObjectOutput.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._flush19110);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._flush19110);
		}
		internal static global::MonoJavaBridge.MethodId _close19111;
		 void java.io.ObjectOutput.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._close19111);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._close19111);
		}
		internal static global::MonoJavaBridge.MethodId _write19112;
		 void java.io.DataOutput.write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write19112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19113;
		 void java.io.DataOutput.write(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write19113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19114;
		 void java.io.DataOutput.write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._write19114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._write19114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInt19115;
		 void java.io.DataOutput.writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeInt19115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeInt19115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar19116;
		 void java.io.DataOutput.writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeChar19116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeChar19116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes19117;
		 void java.io.DataOutput.writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeBytes19117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeBytes19117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF19118;
		 void java.io.DataOutput.writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeUTF19118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeUTF19118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong19119;
		 void java.io.DataOutput.writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeLong19119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeLong19119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte19120;
		 void java.io.DataOutput.writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeByte19120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeByte19120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort19121;
		 void java.io.DataOutput.writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeShort19121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeShort19121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat19122;
		 void java.io.DataOutput.writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeFloat19122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeFloat19122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble19123;
		 void java.io.DataOutput.writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeDouble19123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeDouble19123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean19124;
		 void java.io.DataOutput.writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeBoolean19124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeBoolean19124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars19125;
		 void java.io.DataOutput.writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_._writeChars19125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectOutput_.staticClass, global::java.io.ObjectOutput_._writeChars19125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectOutput"));
			global::java.io.ObjectOutput_._write19106 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "(I)V");
			global::java.io.ObjectOutput_._write19107 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([B)V");
			global::java.io.ObjectOutput_._write19108 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([BII)V");
			global::java.io.ObjectOutput_._writeObject19109 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeObject", "(Ljava/lang/Object;)V");
			global::java.io.ObjectOutput_._flush19110 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "flush", "()V");
			global::java.io.ObjectOutput_._close19111 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "close", "()V");
			global::java.io.ObjectOutput_._write19112 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "(I)V");
			global::java.io.ObjectOutput_._write19113 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([B)V");
			global::java.io.ObjectOutput_._write19114 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "write", "([BII)V");
			global::java.io.ObjectOutput_._writeInt19115 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeInt", "(I)V");
			global::java.io.ObjectOutput_._writeChar19116 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeChar", "(I)V");
			global::java.io.ObjectOutput_._writeBytes19117 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutput_._writeUTF19118 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.ObjectOutput_._writeLong19119 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeLong", "(J)V");
			global::java.io.ObjectOutput_._writeByte19120 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeByte", "(I)V");
			global::java.io.ObjectOutput_._writeShort19121 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeShort", "(I)V");
			global::java.io.ObjectOutput_._writeFloat19122 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeFloat", "(F)V");
			global::java.io.ObjectOutput_._writeDouble19123 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeDouble", "(D)V");
			global::java.io.ObjectOutput_._writeBoolean19124 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeBoolean", "(Z)V");
			global::java.io.ObjectOutput_._writeChars19125 = @__env.GetMethodIDNoThrow(global::java.io.ObjectOutput_.staticClass, "writeChars", "(Ljava/lang/String;)V");
		}
	}
}
