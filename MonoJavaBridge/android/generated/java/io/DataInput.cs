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
	internal sealed partial class DataInput_ : java.lang.Object, DataInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DataInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine18884;
		global::java.lang.String java.io.DataInput.readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readLine18884.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readLine18884 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readLine", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInput_._readLine18884)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readInt18885;
		int java.io.DataInput.readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readInt18885.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readInt18885 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readInt", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readInt18885);
		}
		internal static global::MonoJavaBridge.MethodId _readChar18886;
		char java.io.DataInput.readChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readChar18886.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readChar18886 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readChar", "()C");
			return @__env.CallCharMethod(this.JvmHandle, global::java.io.DataInput_._readChar18886);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF18887;
		global::java.lang.String java.io.DataInput.readUTF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readUTF18887.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readUTF18887 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUTF", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.DataInput_._readUTF18887)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully18888;
		void java.io.DataInput.readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readFully18888.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readFully18888 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFully", "([B)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInput_._readFully18888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFully18889;
		void java.io.DataInput.readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readFully18889.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readFully18889 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFully", "([BII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataInput_._readFully18889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readLong18890;
		long java.io.DataInput.readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readLong18890.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readLong18890 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readLong", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::java.io.DataInput_._readLong18890);
		}
		internal static global::MonoJavaBridge.MethodId _readByte18891;
		byte java.io.DataInput.readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readByte18891.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readByte18891 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readByte", "()B");
			return @__env.CallByteMethod(this.JvmHandle, global::java.io.DataInput_._readByte18891);
		}
		internal static global::MonoJavaBridge.MethodId _readShort18892;
		short java.io.DataInput.readShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readShort18892.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readShort18892 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readShort", "()S");
			return @__env.CallShortMethod(this.JvmHandle, global::java.io.DataInput_._readShort18892);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat18893;
		float java.io.DataInput.readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readFloat18893.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readFloat18893 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readFloat", "()F");
			return @__env.CallFloatMethod(this.JvmHandle, global::java.io.DataInput_._readFloat18893);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes18894;
		int java.io.DataInput.skipBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._skipBytes18894.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._skipBytes18894 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "skipBytes", "(I)I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._skipBytes18894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean18895;
		bool java.io.DataInput.readBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readBoolean18895.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readBoolean18895 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readBoolean", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.DataInput_._readBoolean18895);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte18896;
		int java.io.DataInput.readUnsignedByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readUnsignedByte18896.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readUnsignedByte18896 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUnsignedByte", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readUnsignedByte18896);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort18897;
		int java.io.DataInput.readUnsignedShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readUnsignedShort18897.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readUnsignedShort18897 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readUnsignedShort", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataInput_._readUnsignedShort18897);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble18898;
		double java.io.DataInput.readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.DataInput_._readDouble18898.native == global::System.IntPtr.Zero)
				global::java.io.DataInput_._readDouble18898 = @__env.GetMethodIDNoThrow(global::java.io.DataInput_.staticClass, "readDouble", "()D");
			return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.DataInput_._readDouble18898);
		}
		static DataInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataInput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
