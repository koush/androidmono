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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringReader.staticClass, "close", "()V", ref global::java.io.StringReader._close19608);
		}
		internal static global::MonoJavaBridge.MethodId _mark19609;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringReader.staticClass, "mark", "(I)V", ref global::java.io.StringReader._mark19609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19610;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringReader.staticClass, "reset", "()V", ref global::java.io.StringReader._reset19610);
		}
		internal static global::MonoJavaBridge.MethodId _read19611;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringReader.staticClass, "read", "([CII)I", ref global::java.io.StringReader._read19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19612;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringReader.staticClass, "read", "()I", ref global::java.io.StringReader._read19612);
		}
		internal static global::MonoJavaBridge.MethodId _skip19613;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.StringReader.staticClass, "skip", "(J)J", ref global::java.io.StringReader._skip19613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19614;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.StringReader.staticClass, "markSupported", "()Z", ref global::java.io.StringReader._markSupported19614);
		}
		internal static global::MonoJavaBridge.MethodId _ready19615;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.StringReader.staticClass, "ready", "()Z", ref global::java.io.StringReader._ready19615);
		}
		internal static global::MonoJavaBridge.MethodId _StringReader19616;
		public StringReader(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringReader._StringReader19616.native == global::System.IntPtr.Zero)
				global::java.io.StringReader._StringReader19616 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringReader.staticClass, global::java.io.StringReader._StringReader19616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
