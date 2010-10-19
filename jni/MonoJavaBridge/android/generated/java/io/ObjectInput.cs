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
		internal static global::MonoJavaBridge.MethodId _close13552;
		 void java.io.ObjectInput.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._close13552);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._close13552);
		}
		internal static global::MonoJavaBridge.MethodId _readObject13553;
		 global::java.lang.Object java.io.ObjectInput.readObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readObject13553)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readObject13553)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _read13554;
		 int java.io.ObjectInput.read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read13554);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read13554);
		}
		internal static global::MonoJavaBridge.MethodId _read13555;
		 int java.io.ObjectInput.read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read13555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read13555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read13556;
		 int java.io.ObjectInput.read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._read13556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._read13556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13557;
		 long java.io.ObjectInput.skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInput_._skip13557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._skip13557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13558;
		 int java.io.ObjectInput.available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._available13558);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._available13558);
		}
		internal static global::MonoJavaBridge.MethodId _readLine13559;
		 global::java.lang.String java.io.DataInput.readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readLine13559)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readLine13559)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt13560;
		 int java.io.DataInput.readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readInt13560);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readInt13560);
		}
		internal static global::MonoJavaBridge.MethodId _readChar13561;
		 char java.io.DataInput.readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInput_._readChar13561);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readChar13561);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF13562;
		 global::java.lang.String java.io.DataInput.readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInput_._readUTF13562)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUTF13562)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully13563;
		 void java.io.DataInput.readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._readFully13563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFully13563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully13564;
		 void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInput_._readFully13564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFully13564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong13565;
		 long java.io.DataInput.readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInput_._readLong13565);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readLong13565);
		}
		internal static global::MonoJavaBridge.MethodId _readByte13566;
		 byte java.io.DataInput.readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInput_._readByte13566);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readByte13566);
		}
		internal static global::MonoJavaBridge.MethodId _readShort13567;
		 short java.io.DataInput.readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInput_._readShort13567);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readShort13567);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat13568;
		 float java.io.DataInput.readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInput_._readFloat13568);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readFloat13568);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes13569;
		 int java.io.DataInput.skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._skipBytes13569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._skipBytes13569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean13570;
		 bool java.io.DataInput.readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInput_._readBoolean13570);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readBoolean13570);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte13571;
		 int java.io.DataInput.readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readUnsignedByte13571);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUnsignedByte13571);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort13572;
		 int java.io.DataInput.readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInput_._readUnsignedShort13572);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readUnsignedShort13572);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble13573;
		 double java.io.DataInput.readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInput_._readDouble13573);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInput_.staticClass, global::java.io.ObjectInput_._readDouble13573);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInput"));
			global::java.io.ObjectInput_._close13552 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "close", "()V");
			global::java.io.ObjectInput_._readObject13553 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.io.ObjectInput_._read13554 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "()I");
			global::java.io.ObjectInput_._read13555 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "([B)I");
			global::java.io.ObjectInput_._read13556 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "read", "([BII)I");
			global::java.io.ObjectInput_._skip13557 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "skip", "(J)J");
			global::java.io.ObjectInput_._available13558 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "available", "()I");
			global::java.io.ObjectInput_._readLine13559 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.ObjectInput_._readInt13560 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readInt", "()I");
			global::java.io.ObjectInput_._readChar13561 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readChar", "()C");
			global::java.io.ObjectInput_._readUTF13562 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.ObjectInput_._readFully13563 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFully", "([B)V");
			global::java.io.ObjectInput_._readFully13564 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFully", "([BII)V");
			global::java.io.ObjectInput_._readLong13565 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readLong", "()J");
			global::java.io.ObjectInput_._readByte13566 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readByte", "()B");
			global::java.io.ObjectInput_._readShort13567 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readShort", "()S");
			global::java.io.ObjectInput_._readFloat13568 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readFloat", "()F");
			global::java.io.ObjectInput_._skipBytes13569 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "skipBytes", "(I)I");
			global::java.io.ObjectInput_._readBoolean13570 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readBoolean", "()Z");
			global::java.io.ObjectInput_._readUnsignedByte13571 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUnsignedByte", "()I");
			global::java.io.ObjectInput_._readUnsignedShort13572 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readUnsignedShort", "()I");
			global::java.io.ObjectInput_._readDouble13573 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInput_.staticClass, "readDouble", "()D");
		}
	}
}
