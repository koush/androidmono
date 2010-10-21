namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.ObjectInput_))]
	public interface ObjectInput : DataInput
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
	public sealed partial class ObjectInput_ : java.lang.Object, ObjectInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectInput_()
		{
			InitJNI();
		}
		internal ObjectInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19027;
		 void java.io.ObjectInput.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._close19027);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._close19027);
		}
		internal static global::MonoJavaBridge.MethodId _readObject19028;
		 global::java.lang.Object java.io.ObjectInput.readObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readObject19028)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readObject19028)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _read19029;
		 int java.io.ObjectInput.read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read19029);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read19029);
		}
		internal static global::MonoJavaBridge.MethodId _read19030;
		 int java.io.ObjectInput.read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read19030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read19030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19031;
		 int java.io.ObjectInput.read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read19031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read19031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19032;
		 long java.io.ObjectInput.skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInput_._skip19032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._skip19032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19033;
		 int java.io.ObjectInput.available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._available19033);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._available19033);
		}
		internal static global::MonoJavaBridge.MethodId _readLine19034;
		 global::java.lang.String java.io.DataInput.readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readLine19034)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readLine19034)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt19035;
		 int java.io.DataInput.readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readInt19035);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readInt19035);
		}
		internal static global::MonoJavaBridge.MethodId _readChar19036;
		 char java.io.DataInput.readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInput_._readChar19036);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readChar19036);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19037;
		 global::java.lang.String java.io.DataInput.readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readUTF19037)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUTF19037)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19038;
		 void java.io.DataInput.readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._readFully19038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFully19038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19039;
		 void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._readFully19039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFully19039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19040;
		 long java.io.DataInput.readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInput_._readLong19040);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readLong19040);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19041;
		 byte java.io.DataInput.readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInput_._readByte19041);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readByte19041);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19042;
		 short java.io.DataInput.readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInput_._readShort19042);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readShort19042);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19043;
		 float java.io.DataInput.readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInput_._readFloat19043);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFloat19043);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19044;
		 int java.io.DataInput.skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._skipBytes19044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._skipBytes19044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19045;
		 bool java.io.DataInput.readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInput_._readBoolean19045);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readBoolean19045);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19046;
		 int java.io.DataInput.readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readUnsignedByte19046);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUnsignedByte19046);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19047;
		 int java.io.DataInput.readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readUnsignedShort19047);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUnsignedShort19047);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19048;
		 double java.io.DataInput.readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInput_._readDouble19048);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readDouble19048);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInput"));
			global::java.io.ObjectInput_._close19027 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "close", "()V");
			global::java.io.ObjectInput_._readObject19028 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.io.ObjectInput_._read19029 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "()I");
			global::java.io.ObjectInput_._read19030 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "([B)I");
			global::java.io.ObjectInput_._read19031 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "([BII)I");
			global::java.io.ObjectInput_._skip19032 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "skip", "(J)J");
			global::java.io.ObjectInput_._available19033 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "available", "()I");
			global::java.io.ObjectInput_._readLine19034 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.ObjectInput_._readInt19035 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readInt", "()I");
			global::java.io.ObjectInput_._readChar19036 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readChar", "()C");
			global::java.io.ObjectInput_._readUTF19037 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.ObjectInput_._readFully19038 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFully", "([B)V");
			global::java.io.ObjectInput_._readFully19039 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFully", "([BII)V");
			global::java.io.ObjectInput_._readLong19040 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readLong", "()J");
			global::java.io.ObjectInput_._readByte19041 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readByte", "()B");
			global::java.io.ObjectInput_._readShort19042 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readShort", "()S");
			global::java.io.ObjectInput_._readFloat19043 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFloat", "()F");
			global::java.io.ObjectInput_._skipBytes19044 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "skipBytes", "(I)I");
			global::java.io.ObjectInput_._readBoolean19045 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readBoolean", "()Z");
			global::java.io.ObjectInput_._readUnsignedByte19046 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUnsignedByte", "()I");
			global::java.io.ObjectInput_._readUnsignedShort19047 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUnsignedShort", "()I");
			global::java.io.ObjectInput_._readDouble19048 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readDouble", "()D");
		}
	}
}
