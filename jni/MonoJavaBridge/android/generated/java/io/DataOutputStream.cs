namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataOutputStream : java.io.FilterOutputStream, DataOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataOutputStream()
		{
			InitJNI();
		}
		protected DataOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size18814;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataOutputStream._size18814);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._size18814);
		}
		internal static global::MonoJavaBridge.MethodId _write18815;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._write18815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._write18815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18816;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._write18816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._write18816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush18817;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._flush18817);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._flush18817);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt18818;
		public virtual void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeInt18818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeInt18818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar18819;
		public virtual void writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeChar18819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeChar18819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes18820;
		public virtual void writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeBytes18820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeBytes18820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF18821;
		public virtual void writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeUTF18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeUTF18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong18822;
		public virtual void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeLong18822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeLong18822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte18823;
		public virtual void writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeByte18823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeByte18823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort18824;
		public virtual void writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeShort18824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeShort18824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat18825;
		public virtual void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeFloat18825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeFloat18825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble18826;
		public virtual void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeDouble18826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeDouble18826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean18827;
		public virtual void writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeBoolean18827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeBoolean18827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars18828;
		public virtual void writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeChars18828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeChars18828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DataOutputStream18829;
		public DataOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._DataOutputStream18829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutputStream"));
			global::java.io.DataOutputStream._size18814 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "size", "()I");
			global::java.io.DataOutputStream._write18815 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "write", "(I)V");
			global::java.io.DataOutputStream._write18816 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "write", "([BII)V");
			global::java.io.DataOutputStream._flush18817 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "flush", "()V");
			global::java.io.DataOutputStream._writeInt18818 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeInt", "(I)V");
			global::java.io.DataOutputStream._writeChar18819 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeChar", "(I)V");
			global::java.io.DataOutputStream._writeBytes18820 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.DataOutputStream._writeUTF18821 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.DataOutputStream._writeLong18822 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeLong", "(J)V");
			global::java.io.DataOutputStream._writeByte18823 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeByte", "(I)V");
			global::java.io.DataOutputStream._writeShort18824 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeShort", "(I)V");
			global::java.io.DataOutputStream._writeFloat18825 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeFloat", "(F)V");
			global::java.io.DataOutputStream._writeDouble18826 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeDouble", "(D)V");
			global::java.io.DataOutputStream._writeBoolean18827 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeBoolean", "(Z)V");
			global::java.io.DataOutputStream._writeChars18828 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::java.io.DataOutputStream._DataOutputStream18829 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
