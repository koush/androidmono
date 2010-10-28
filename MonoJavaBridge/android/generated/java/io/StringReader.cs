namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19608;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._close19608);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._close19608);
		}
		internal static global::MonoJavaBridge.MethodId _mark19609;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._mark19609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._mark19609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19610;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringReader._reset19610);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._reset19610);
		}
		internal static global::MonoJavaBridge.MethodId _read19611;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringReader._read19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._read19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19612;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.StringReader._read19612);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._read19612);
		}
		internal static global::MonoJavaBridge.MethodId _skip19613;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.StringReader._skip19613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._skip19613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19614;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.StringReader._markSupported19614);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._markSupported19614);
		}
		internal static global::MonoJavaBridge.MethodId _ready19615;
		public override bool ready()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.StringReader._ready19615);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.StringReader.staticClass, global::java.io.StringReader._ready19615);
		}
		internal static global::MonoJavaBridge.MethodId _StringReader19616;
		public StringReader(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringReader.staticClass, global::java.io.StringReader._StringReader19616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringReader"));
			global::java.io.StringReader._close19608 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "close", "()V");
			global::java.io.StringReader._mark19609 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "mark", "(I)V");
			global::java.io.StringReader._reset19610 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "reset", "()V");
			global::java.io.StringReader._read19611 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "read", "([CII)I");
			global::java.io.StringReader._read19612 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "read", "()I");
			global::java.io.StringReader._skip19613 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "skip", "(J)J");
			global::java.io.StringReader._markSupported19614 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "markSupported", "()Z");
			global::java.io.StringReader._ready19615 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "ready", "()Z");
			global::java.io.StringReader._StringReader19616 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
