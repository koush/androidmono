namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PushbackReader : java.io.FilterReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PushbackReader()
		{
			InitJNI();
		}
		protected PushbackReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19381;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._close19381);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._close19381);
		}
		internal static global::MonoJavaBridge.MethodId _mark19382;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._mark19382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._mark19382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19383;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._reset19383);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._reset19383);
		}
		internal static global::MonoJavaBridge.MethodId _read19384;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackReader._read19384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._read19384);
		}
		internal static global::MonoJavaBridge.MethodId _read19385;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackReader._read19385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._read19385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19386;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.PushbackReader._skip19386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._skip19386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19387;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackReader._markSupported19387);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._markSupported19387);
		}
		internal static global::MonoJavaBridge.MethodId _ready19388;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackReader._ready19388);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._ready19388);
		}
		internal static global::MonoJavaBridge.MethodId _unread19389;
		public virtual void unread(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread19389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread19389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unread19390;
		public virtual void unread(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread19390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread19390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unread19391;
		public virtual void unread(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread19391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread19391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PushbackReader19392;
		public PushbackReader(java.io.Reader arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._PushbackReader19392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PushbackReader19393;
		public PushbackReader(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._PushbackReader19393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackReader"));
			global::java.io.PushbackReader._close19381 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "close", "()V");
			global::java.io.PushbackReader._mark19382 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "mark", "(I)V");
			global::java.io.PushbackReader._reset19383 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "reset", "()V");
			global::java.io.PushbackReader._read19384 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "read", "()I");
			global::java.io.PushbackReader._read19385 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "read", "([CII)I");
			global::java.io.PushbackReader._skip19386 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "skip", "(J)J");
			global::java.io.PushbackReader._markSupported19387 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "markSupported", "()Z");
			global::java.io.PushbackReader._ready19388 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "ready", "()Z");
			global::java.io.PushbackReader._unread19389 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "([C)V");
			global::java.io.PushbackReader._unread19390 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "([CII)V");
			global::java.io.PushbackReader._unread19391 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "(I)V");
			global::java.io.PushbackReader._PushbackReader19392 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.PushbackReader._PushbackReader19393 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
