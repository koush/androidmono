namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.DataInput_))]
	public partial interface DataInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String readLine();
		int readInt();
		char readChar();
		global::java.lang.String readUTF();
		void readFully(byte[] arg0);
		void readFully(byte[] arg0, int arg1, int arg2);
		long readLong();
		byte readByte();
		short readShort();
		float readFloat();
		int skipBytes(int arg0);
		bool readBoolean();
		int readUnsignedByte();
		int readUnsignedShort();
		double readDouble();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.DataInput))]
	public sealed partial class DataInput_ : java.lang.Object, DataInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataInput_()
		{
			InitJNI();
		}
		internal DataInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine18766;
		 global::java.lang.String java.io.DataInput.readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInput_._readLine18766)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readLine18766)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt18767;
		 int java.io.DataInput.readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readInt18767);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readInt18767);
		}
		internal static global::MonoJavaBridge.MethodId _readChar18768;
		 char java.io.DataInput.readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.DataInput_._readChar18768);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readChar18768);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18769;
		 global::java.lang.String java.io.DataInput.readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInput_._readUTF18769)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readUTF18769)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully18770;
		 void java.io.DataInput.readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInput_._readFully18770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readFully18770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully18771;
		 void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInput_._readFully18771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readFully18771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong18772;
		 long java.io.DataInput.readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.DataInput_._readLong18772);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readLong18772);
		}
		internal static global::MonoJavaBridge.MethodId _readByte18773;
		 byte java.io.DataInput.readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.DataInput_._readByte18773);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readByte18773);
		}
		internal static global::MonoJavaBridge.MethodId _readShort18774;
		 short java.io.DataInput.readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.DataInput_._readShort18774);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readShort18774);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat18775;
		 float java.io.DataInput.readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.DataInput_._readFloat18775);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readFloat18775);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes18776;
		 int java.io.DataInput.skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._skipBytes18776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._skipBytes18776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean18777;
		 bool java.io.DataInput.readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.DataInput_._readBoolean18777);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readBoolean18777);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte18778;
		 int java.io.DataInput.readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readUnsignedByte18778);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readUnsignedByte18778);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort18779;
		 int java.io.DataInput.readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readUnsignedShort18779);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readUnsignedShort18779);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble18780;
		 double java.io.DataInput.readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.DataInput_._readDouble18780);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readDouble18780);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInput"));
			global::java.io.DataInput_._readLine18766 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.DataInput_._readInt18767 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readInt", "()I");
			global::java.io.DataInput_._readChar18768 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readChar", "()C");
			global::java.io.DataInput_._readUTF18769 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.DataInput_._readFully18770 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFully", "([B)V");
			global::java.io.DataInput_._readFully18771 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFully", "([BII)V");
			global::java.io.DataInput_._readLong18772 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readLong", "()J");
			global::java.io.DataInput_._readByte18773 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readByte", "()B");
			global::java.io.DataInput_._readShort18774 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readShort", "()S");
			global::java.io.DataInput_._readFloat18775 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFloat", "()F");
			global::java.io.DataInput_._skipBytes18776 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "skipBytes", "(I)I");
			global::java.io.DataInput_._readBoolean18777 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readBoolean", "()Z");
			global::java.io.DataInput_._readUnsignedByte18778 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUnsignedByte", "()I");
			global::java.io.DataInput_._readUnsignedShort18779 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUnsignedShort", "()I");
			global::java.io.DataInput_._readDouble18780 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readDouble", "()D");
		}
	}
}
