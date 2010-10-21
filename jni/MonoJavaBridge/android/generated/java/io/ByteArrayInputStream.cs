namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteArrayInputStream()
		{
			InitJNI();
		}
		protected ByteArrayInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close18716;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._close18716);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._close18716);
		}
		internal static global::MonoJavaBridge.MethodId _mark18717;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._mark18717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._mark18717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18718;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._reset18718);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._reset18718);
		}
		internal static global::MonoJavaBridge.MethodId _read18719;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._read18719);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._read18719);
		}
		internal static global::MonoJavaBridge.MethodId _read18720;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._read18720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._read18720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip18721;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._skip18721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._skip18721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18722;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._available18722);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._available18722);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18723;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._markSupported18723);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._markSupported18723);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayInputStream18724;
		public ByteArrayInputStream(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._ByteArrayInputStream18724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayInputStream18725;
		public ByteArrayInputStream(byte[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._ByteArrayInputStream18725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayInputStream"));
			global::java.io.ByteArrayInputStream._close18716 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "close", "()V");
			global::java.io.ByteArrayInputStream._mark18717 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "mark", "(I)V");
			global::java.io.ByteArrayInputStream._reset18718 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "reset", "()V");
			global::java.io.ByteArrayInputStream._read18719 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "read", "()I");
			global::java.io.ByteArrayInputStream._read18720 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "read", "([BII)I");
			global::java.io.ByteArrayInputStream._skip18721 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "skip", "(J)J");
			global::java.io.ByteArrayInputStream._available18722 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "available", "()I");
			global::java.io.ByteArrayInputStream._markSupported18723 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "markSupported", "()Z");
			global::java.io.ByteArrayInputStream._ByteArrayInputStream18724 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([B)V");
			global::java.io.ByteArrayInputStream._ByteArrayInputStream18725 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([BII)V");
		}
	}
}
