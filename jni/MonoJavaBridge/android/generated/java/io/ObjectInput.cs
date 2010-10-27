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
		static ObjectInput_()
		{
			InitJNI();
		}
		internal ObjectInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19145;
		void java.io.ObjectInput.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._close19145);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._close19145);
		}
		internal static global::MonoJavaBridge.MethodId _readObject19146;
		global::java.lang.Object java.io.ObjectInput.readObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readObject19146)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readObject19146)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _read19147;
		int java.io.ObjectInput.read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read19147);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read19147);
		}
		internal static global::MonoJavaBridge.MethodId _read19148;
		int java.io.ObjectInput.read(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read19148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read19149;
		int java.io.ObjectInput.read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read19149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19150;
		long java.io.ObjectInput.skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInput_._skip19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._skip19150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19151;
		int java.io.ObjectInput.available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._available19151);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._available19151);
		}
		internal static global::MonoJavaBridge.MethodId _readLine19152;
		global::java.lang.String java.io.DataInput.readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readLine19152)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readLine19152)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt19153;
		int java.io.DataInput.readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readInt19153);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readInt19153);
		}
		internal static global::MonoJavaBridge.MethodId _readChar19154;
		char java.io.DataInput.readChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInput_._readChar19154);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readChar19154);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19155;
		global::java.lang.String java.io.DataInput.readUTF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readUTF19155)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUTF19155)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19156;
		void java.io.DataInput.readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._readFully19156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFully19156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19157;
		void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._readFully19157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFully19157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19158;
		long java.io.DataInput.readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInput_._readLong19158);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readLong19158);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19159;
		byte java.io.DataInput.readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInput_._readByte19159);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readByte19159);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19160;
		short java.io.DataInput.readShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInput_._readShort19160);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readShort19160);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19161;
		float java.io.DataInput.readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInput_._readFloat19161);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFloat19161);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19162;
		int java.io.DataInput.skipBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._skipBytes19162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._skipBytes19162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19163;
		bool java.io.DataInput.readBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInput_._readBoolean19163);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readBoolean19163);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19164;
		int java.io.DataInput.readUnsignedByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readUnsignedByte19164);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUnsignedByte19164);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19165;
		int java.io.DataInput.readUnsignedShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readUnsignedShort19165);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUnsignedShort19165);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19166;
		double java.io.DataInput.readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInput_._readDouble19166);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readDouble19166);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInput"));
			global::java.io.ObjectInput_._close19145 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "close", "()V");
			global::java.io.ObjectInput_._readObject19146 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.io.ObjectInput_._read19147 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "()I");
			global::java.io.ObjectInput_._read19148 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "([B)I");
			global::java.io.ObjectInput_._read19149 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "([BII)I");
			global::java.io.ObjectInput_._skip19150 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "skip", "(J)J");
			global::java.io.ObjectInput_._available19151 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "available", "()I");
			global::java.io.ObjectInput_._readLine19152 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.ObjectInput_._readInt19153 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readInt", "()I");
			global::java.io.ObjectInput_._readChar19154 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readChar", "()C");
			global::java.io.ObjectInput_._readUTF19155 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.ObjectInput_._readFully19156 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFully", "([B)V");
			global::java.io.ObjectInput_._readFully19157 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFully", "([BII)V");
			global::java.io.ObjectInput_._readLong19158 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readLong", "()J");
			global::java.io.ObjectInput_._readByte19159 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readByte", "()B");
			global::java.io.ObjectInput_._readShort19160 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readShort", "()S");
			global::java.io.ObjectInput_._readFloat19161 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFloat", "()F");
			global::java.io.ObjectInput_._skipBytes19162 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "skipBytes", "(I)I");
			global::java.io.ObjectInput_._readBoolean19163 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readBoolean", "()Z");
			global::java.io.ObjectInput_._readUnsignedByte19164 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUnsignedByte", "()I");
			global::java.io.ObjectInput_._readUnsignedShort19165 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUnsignedShort", "()I");
			global::java.io.ObjectInput_._readDouble19166 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readDouble", "()D");
		}
	}
}
