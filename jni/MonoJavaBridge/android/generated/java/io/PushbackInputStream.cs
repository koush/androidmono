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
		internal static global::MonoJavaBridge.MethodId _close19368;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._close19368);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._close19368);
		}
		internal static global::MonoJavaBridge.MethodId _mark19369;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._mark19369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._mark19369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19370;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._reset19370);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._reset19370);
		}
		internal static global::MonoJavaBridge.MethodId _read19371;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._read19371);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._read19371);
		}
		internal static global::MonoJavaBridge.MethodId _read19372;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._read19372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._read19372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19373;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.PushbackInputStream._skip19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._skip19373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19374;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackInputStream._available19374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._available19374);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19375;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackInputStream._markSupported19375);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._markSupported19375);
		}
		internal static global::MonoJavaBridge.MethodId _unread19376;
		public virtual void unread(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread19376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread19376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unread19377;
		public virtual void unread(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread19377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread19377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unread19378;
		public virtual void unread(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream._unread19378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._unread19378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PushbackInputStream19379;
		public PushbackInputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._PushbackInputStream19379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PushbackInputStream19380;
		public PushbackInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackInputStream.staticClass, global::java.io.PushbackInputStream._PushbackInputStream19380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackInputStream"));
			global::java.io.PushbackInputStream._close19368 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "close", "()V");
			global::java.io.PushbackInputStream._mark19369 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "mark", "(I)V");
			global::java.io.PushbackInputStream._reset19370 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "reset", "()V");
			global::java.io.PushbackInputStream._read19371 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "read", "()I");
			global::java.io.PushbackInputStream._read19372 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "read", "([BII)I");
			global::java.io.PushbackInputStream._skip19373 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "skip", "(J)J");
			global::java.io.PushbackInputStream._available19374 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "available", "()I");
			global::java.io.PushbackInputStream._markSupported19375 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "markSupported", "()Z");
			global::java.io.PushbackInputStream._unread19376 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "([B)V");
			global::java.io.PushbackInputStream._unread19377 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "([BII)V");
			global::java.io.PushbackInputStream._unread19378 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "unread", "(I)V");
			global::java.io.PushbackInputStream._PushbackInputStream19379 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::java.io.PushbackInputStream._PushbackInputStream19380 = @__env.GetMethodIDNoThrow(global::java.io.PushbackInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
