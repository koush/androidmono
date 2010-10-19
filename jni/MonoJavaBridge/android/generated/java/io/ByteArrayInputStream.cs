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
		internal static global::MonoJavaBridge.MethodId _close13245;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._close13245);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._close13245);
		}
		internal static global::MonoJavaBridge.MethodId _mark13246;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._mark13246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._mark13246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13247;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._reset13247);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._reset13247);
		}
		internal static global::MonoJavaBridge.MethodId _read13248;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._read13248);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._read13248);
		}
		internal static global::MonoJavaBridge.MethodId _read13249;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._read13249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._read13249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13250;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._skip13250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._skip13250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13251;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._available13251);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._available13251);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13252;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ByteArrayInputStream._markSupported13252);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._markSupported13252);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayInputStream13253;
		public ByteArrayInputStream(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._ByteArrayInputStream13253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayInputStream13254;
		public ByteArrayInputStream(byte[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ByteArrayInputStream.staticClass, global::java.io.ByteArrayInputStream._ByteArrayInputStream13254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ByteArrayInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ByteArrayInputStream"));
			global::java.io.ByteArrayInputStream._close13245 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "close", "()V");
			global::java.io.ByteArrayInputStream._mark13246 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "mark", "(I)V");
			global::java.io.ByteArrayInputStream._reset13247 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "reset", "()V");
			global::java.io.ByteArrayInputStream._read13248 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "read", "()I");
			global::java.io.ByteArrayInputStream._read13249 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "read", "([BII)I");
			global::java.io.ByteArrayInputStream._skip13250 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "skip", "(J)J");
			global::java.io.ByteArrayInputStream._available13251 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "available", "()I");
			global::java.io.ByteArrayInputStream._markSupported13252 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "markSupported", "()Z");
			global::java.io.ByteArrayInputStream._ByteArrayInputStream13253 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([B)V");
			global::java.io.ByteArrayInputStream._ByteArrayInputStream13254 = @__env.GetMethodIDNoThrow(global::java.io.ByteArrayInputStream.staticClass, "<init>", "([BII)V");
		}
	}
}
