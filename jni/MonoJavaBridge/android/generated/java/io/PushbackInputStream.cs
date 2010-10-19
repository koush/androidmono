namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PushbackInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PushbackInputStream()
		{
			InitJNI();
		}
		protected PushbackInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13866;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._close13866);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._close13866);
		}
		internal static global::MonoJavaBridge.MethodId _mark13867;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._mark13867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._mark13867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13868;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._reset13868);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._reset13868);
		}
		internal static global::MonoJavaBridge.MethodId _read13869;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._read13869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._read13869);
		}
		internal static global::MonoJavaBridge.MethodId _read13870;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._read13870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._read13870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13871;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.PushbackInputStream._skip13871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._skip13871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13872;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._available13872);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._available13872);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13873;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackInputStream._markSupported13873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._markSupported13873);
		}
		internal static global::MonoJavaBridge.MethodId _unread13874;
		public virtual void unread(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread13874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread13874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unread13875;
		public virtual void unread(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread13875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread13875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unread13876;
		public virtual void unread(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread13876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread13876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PushbackInputStream13877;
		public PushbackInputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._PushbackInputStream13877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PushbackInputStream13878;
		public PushbackInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._PushbackInputStream13878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackInputStream"));
			global::java.io.PushbackInputStream._close13866 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "close", "()V");
			global::java.io.PushbackInputStream._mark13867 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "mark", "(I)V");
			global::java.io.PushbackInputStream._reset13868 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "reset", "()V");
			global::java.io.PushbackInputStream._read13869 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "read", "()I");
			global::java.io.PushbackInputStream._read13870 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "read", "([BII)I");
			global::java.io.PushbackInputStream._skip13871 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "skip", "(J)J");
			global::java.io.PushbackInputStream._available13872 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "available", "()I");
			global::java.io.PushbackInputStream._markSupported13873 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "markSupported", "()Z");
			global::java.io.PushbackInputStream._unread13874 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "([B)V");
			global::java.io.PushbackInputStream._unread13875 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "([BII)V");
			global::java.io.PushbackInputStream._unread13876 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "(I)V");
			global::java.io.PushbackInputStream._PushbackInputStream13877 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.io.PushbackInputStream._PushbackInputStream13878 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
