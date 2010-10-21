namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringReader()
		{
			InitJNI();
		}
		protected StringReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19490;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._close19490);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._close19490);
		}
		internal static global::MonoJavaBridge.MethodId _mark19491;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._mark19491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._mark19491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19492;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._reset19492);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._reset19492);
		}
		internal static global::MonoJavaBridge.MethodId _read19493;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringReader._read19493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._read19493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19494;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringReader._read19494);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._read19494);
		}
		internal static global::MonoJavaBridge.MethodId _skip19495;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.StringReader._skip19495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._skip19495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19496;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.StringReader._markSupported19496);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._markSupported19496);
		}
		internal static global::MonoJavaBridge.MethodId _ready19497;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.StringReader._ready19497);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._ready19497);
		}
		internal static global::MonoJavaBridge.MethodId _StringReader19498;
		public StringReader(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringReader.staticClass, global::java.io.StringReader._StringReader19498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringReader"));
			global::java.io.StringReader._close19490 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "close", "()V");
			global::java.io.StringReader._mark19491 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "mark", "(I)V");
			global::java.io.StringReader._reset19492 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "reset", "()V");
			global::java.io.StringReader._read19493 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "read", "([CII)I");
			global::java.io.StringReader._read19494 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "read", "()I");
			global::java.io.StringReader._skip19495 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "skip", "(J)J");
			global::java.io.StringReader._markSupported19496 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "markSupported", "()Z");
			global::java.io.StringReader._ready19497 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "ready", "()Z");
			global::java.io.StringReader._StringReader19498 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
