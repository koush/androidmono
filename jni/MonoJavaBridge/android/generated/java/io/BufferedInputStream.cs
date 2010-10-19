namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedInputStream()
		{
			InitJNI();
		}
		protected BufferedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13211;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._close13211);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._close13211);
		}
		internal static global::MonoJavaBridge.MethodId _mark13212;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._mark13212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._mark13212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13213;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream._reset13213);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._reset13213);
		}
		internal static global::MonoJavaBridge.MethodId _read13214;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._read13214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read13214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13215;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._read13215);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._read13215);
		}
		internal static global::MonoJavaBridge.MethodId _skip13216;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.BufferedInputStream._skip13216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._skip13216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13217;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.BufferedInputStream._available13217);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._available13217);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13218;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.BufferedInputStream._markSupported13218);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._markSupported13218);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream13219;
		public BufferedInputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream13219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedInputStream13220;
		public BufferedInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedInputStream.staticClass, global::java.io.BufferedInputStream._BufferedInputStream13220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedInputStream"));
			global::java.io.BufferedInputStream._close13211 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "close", "()V");
			global::java.io.BufferedInputStream._mark13212 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "mark", "(I)V");
			global::java.io.BufferedInputStream._reset13213 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "reset", "()V");
			global::java.io.BufferedInputStream._read13214 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "([BII)I");
			global::java.io.BufferedInputStream._read13215 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "read", "()I");
			global::java.io.BufferedInputStream._skip13216 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "skip", "(J)J");
			global::java.io.BufferedInputStream._available13217 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "available", "()I");
			global::java.io.BufferedInputStream._markSupported13218 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "markSupported", "()Z");
			global::java.io.BufferedInputStream._BufferedInputStream13219 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.io.BufferedInputStream._BufferedInputStream13220 = @__env.GetMethodIDNoThrow(global::java.io.BufferedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
