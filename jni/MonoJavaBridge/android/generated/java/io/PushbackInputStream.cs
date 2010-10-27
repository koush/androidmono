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
		internal static global::MonoJavaBridge.MethodId _close19486;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._close19486);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._close19486);
		}
		internal static global::MonoJavaBridge.MethodId _mark19487;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._mark19487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._mark19487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19488;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._reset19488);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._reset19488);
		}
		internal static global::MonoJavaBridge.MethodId _read19489;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._read19489);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._read19489);
		}
		internal static global::MonoJavaBridge.MethodId _read19490;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._read19490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._read19490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19491;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.PushbackInputStream._skip19491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._skip19491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19492;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._available19492);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._available19492);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19493;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackInputStream._markSupported19493);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._markSupported19493);
		}
		internal static global::MonoJavaBridge.MethodId _unread19494;
		public virtual void unread(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread19494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread19494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unread19495;
		public virtual void unread(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread19495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread19495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unread19496;
		public virtual void unread(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread19496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread19496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PushbackInputStream19497;
		public PushbackInputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._PushbackInputStream19497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PushbackInputStream19498;
		public PushbackInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._PushbackInputStream19498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackInputStream"));
			global::java.io.PushbackInputStream._close19486 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "close", "()V");
			global::java.io.PushbackInputStream._mark19487 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "mark", "(I)V");
			global::java.io.PushbackInputStream._reset19488 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "reset", "()V");
			global::java.io.PushbackInputStream._read19489 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "read", "()I");
			global::java.io.PushbackInputStream._read19490 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "read", "([BII)I");
			global::java.io.PushbackInputStream._skip19491 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "skip", "(J)J");
			global::java.io.PushbackInputStream._available19492 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "available", "()I");
			global::java.io.PushbackInputStream._markSupported19493 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "markSupported", "()Z");
			global::java.io.PushbackInputStream._unread19494 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "([B)V");
			global::java.io.PushbackInputStream._unread19495 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "([BII)V");
			global::java.io.PushbackInputStream._unread19496 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "(I)V");
			global::java.io.PushbackInputStream._PushbackInputStream19497 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.io.PushbackInputStream._PushbackInputStream19498 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
