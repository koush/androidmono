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
		internal static global::MonoJavaBridge.MethodId _size13343;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.DataOutputStream._size13343);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._size13343);
		}
		internal static global::MonoJavaBridge.MethodId _write13344;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._write13344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._write13344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13345;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._write13345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._write13345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush13346;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._flush13346);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._flush13346);
		}
		internal static global::MonoJavaBridge.MethodId _writeInt13347;
		public virtual void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeInt13347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeInt13347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChar13348;
		public virtual void writeChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeChar13348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeChar13348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes13349;
		public virtual void writeBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeBytes13349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeBytes13349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeUTF13350;
		public virtual void writeUTF(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeUTF13350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeUTF13350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLong13351;
		public virtual void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeLong13351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeLong13351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte13352;
		public virtual void writeByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeByte13352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeByte13352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeShort13353;
		public virtual void writeShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeShort13353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeShort13353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat13354;
		public virtual void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeFloat13354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeFloat13354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble13355;
		public virtual void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeDouble13355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeDouble13355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBoolean13356;
		public virtual void writeBoolean(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeBoolean13356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeBoolean13356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeChars13357;
		public virtual void writeChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.DataOutputStream._writeChars13357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._writeChars13357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DataOutputStream13358;
		public DataOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.DataOutputStream.staticClass, global::java.io.DataOutputStream._DataOutputStream13358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.DataOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/DataOutputStream"));
			global::java.io.DataOutputStream._size13343 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "size", "()I");
			global::java.io.DataOutputStream._write13344 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "write", "(I)V");
			global::java.io.DataOutputStream._write13345 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "write", "([BII)V");
			global::java.io.DataOutputStream._flush13346 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "flush", "()V");
			global::java.io.DataOutputStream._writeInt13347 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeInt", "(I)V");
			global::java.io.DataOutputStream._writeChar13348 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeChar", "(I)V");
			global::java.io.DataOutputStream._writeBytes13349 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeBytes", "(Ljava/lang/String;)V");
			global::java.io.DataOutputStream._writeUTF13350 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeUTF", "(Ljava/lang/String;)V");
			global::java.io.DataOutputStream._writeLong13351 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeLong", "(J)V");
			global::java.io.DataOutputStream._writeByte13352 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeByte", "(I)V");
			global::java.io.DataOutputStream._writeShort13353 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeShort", "(I)V");
			global::java.io.DataOutputStream._writeFloat13354 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeFloat", "(F)V");
			global::java.io.DataOutputStream._writeDouble13355 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeDouble", "(D)V");
			global::java.io.DataOutputStream._writeBoolean13356 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeBoolean", "(Z)V");
			global::java.io.DataOutputStream._writeChars13357 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "writeChars", "(Ljava/lang/String;)V");
			global::java.io.DataOutputStream._DataOutputStream13358 = @__env.GetMethodIDNoThrow(global::java.io.DataOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
