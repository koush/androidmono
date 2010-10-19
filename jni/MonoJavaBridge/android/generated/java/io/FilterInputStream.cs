namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FilterInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterInputStream()
		{
			InitJNI();
		}
		protected FilterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13465;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterInputStream._close13465);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._close13465);
		}
		internal static global::MonoJavaBridge.MethodId _mark13466;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterInputStream._mark13466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._mark13466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13467;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterInputStream._reset13467);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._reset13467);
		}
		internal static global::MonoJavaBridge.MethodId _read13468;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._read13468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read13468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13469;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._read13469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read13469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read13470;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._read13470);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read13470);
		}
		internal static global::MonoJavaBridge.MethodId _skip13471;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.FilterInputStream._skip13471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._skip13471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13472;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._available13472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._available13472);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13473;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilterInputStream._markSupported13473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._markSupported13473);
		}
		internal static global::MonoJavaBridge.MethodId _FilterInputStream13474;
		protected FilterInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._FilterInputStream13474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterInputStream"));
			global::java.io.FilterInputStream._close13465 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "close", "()V");
			global::java.io.FilterInputStream._mark13466 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "mark", "(I)V");
			global::java.io.FilterInputStream._reset13467 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "reset", "()V");
			global::java.io.FilterInputStream._read13468 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "([BII)I");
			global::java.io.FilterInputStream._read13469 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "([B)I");
			global::java.io.FilterInputStream._read13470 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "()I");
			global::java.io.FilterInputStream._skip13471 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "skip", "(J)J");
			global::java.io.FilterInputStream._available13472 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "available", "()I");
			global::java.io.FilterInputStream._markSupported13473 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "markSupported", "()Z");
			global::java.io.FilterInputStream._FilterInputStream13474 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
