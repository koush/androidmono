namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringReader.staticClass, "close", "()V", ref global::java.io.StringReader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringReader.staticClass, "mark", "(I)V", ref global::java.io.StringReader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.StringReader.staticClass, "reset", "()V", ref global::java.io.StringReader._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringReader.staticClass, "read", "([CII)I", ref global::java.io.StringReader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.StringReader.staticClass, "read", "()I", ref global::java.io.StringReader._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.StringReader.staticClass, "skip", "(J)J", ref global::java.io.StringReader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.StringReader.staticClass, "markSupported", "()Z", ref global::java.io.StringReader._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.StringReader.staticClass, "ready", "()Z", ref global::java.io.StringReader._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public StringReader(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.StringReader._m8.native == global::System.IntPtr.Zero)
				global::java.io.StringReader._m8 = @__env.GetMethodIDNoThrow(global::java.io.StringReader.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringReader.staticClass, global::java.io.StringReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringReader"));
		}
	}
}
