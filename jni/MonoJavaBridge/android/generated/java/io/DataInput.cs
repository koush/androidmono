namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.DataInput_))]
	public interface DataInput  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _readLine13295;
		 global::java.lang.String java.io.DataInput.readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInput_._readLine13295)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readLine13295)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt13296;
		 int java.io.DataInput.readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readInt13296);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readInt13296);
		}
		internal static global::MonoJavaBridge.MethodId _readChar13297;
		 char java.io.DataInput.readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.DataInput_._readChar13297);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readChar13297);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF13298;
		 global::java.lang.String java.io.DataInput.readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInput_._readUTF13298)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readUTF13298)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully13299;
		 void java.io.DataInput.readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInput_._readFully13299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readFully13299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully13300;
		 void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInput_._readFully13300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readFully13300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong13301;
		 long java.io.DataInput.readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.DataInput_._readLong13301);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readLong13301);
		}
		internal static global::MonoJavaBridge.MethodId _readByte13302;
		 byte java.io.DataInput.readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.DataInput_._readByte13302);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readByte13302);
		}
		internal static global::MonoJavaBridge.MethodId _readShort13303;
		 short java.io.DataInput.readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.DataInput_._readShort13303);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readShort13303);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat13304;
		 float java.io.DataInput.readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.DataInput_._readFloat13304);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readFloat13304);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes13305;
		 int java.io.DataInput.skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._skipBytes13305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._skipBytes13305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean13306;
		 bool java.io.DataInput.readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.DataInput_._readBoolean13306);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readBoolean13306);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte13307;
		 int java.io.DataInput.readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readUnsignedByte13307);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readUnsignedByte13307);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort13308;
		 int java.io.DataInput.readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readUnsignedShort13308);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readUnsignedShort13308);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble13309;
		 double java.io.DataInput.readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.DataInput_._readDouble13309);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.DataInput_.staticClass, global::java.io.DataInput_._readDouble13309);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInput"));
			global::java.io.DataInput_._readLine13295 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.DataInput_._readInt13296 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readInt", "()I");
			global::java.io.DataInput_._readChar13297 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readChar", "()C");
			global::java.io.DataInput_._readUTF13298 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.DataInput_._readFully13299 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFully", "([B)V");
			global::java.io.DataInput_._readFully13300 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFully", "([BII)V");
			global::java.io.DataInput_._readLong13301 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readLong", "()J");
			global::java.io.DataInput_._readByte13302 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readByte", "()B");
			global::java.io.DataInput_._readShort13303 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readShort", "()S");
			global::java.io.DataInput_._readFloat13304 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFloat", "()F");
			global::java.io.DataInput_._skipBytes13305 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "skipBytes", "(I)I");
			global::java.io.DataInput_._readBoolean13306 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readBoolean", "()Z");
			global::java.io.DataInput_._readUnsignedByte13307 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUnsignedByte", "()I");
			global::java.io.DataInput_._readUnsignedShort13308 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUnsignedShort", "()I");
			global::java.io.DataInput_._readDouble13309 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readDouble", "()D");
		}
	}
}
