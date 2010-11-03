namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharArrayReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharArrayReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayReader.staticClass, "close", "()V", ref global::java.io.CharArrayReader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayReader.staticClass, "mark", "(I)V", ref global::java.io.CharArrayReader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayReader.staticClass, "reset", "()V", ref global::java.io.CharArrayReader._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.CharArrayReader.staticClass, "read", "([CII)I", ref global::java.io.CharArrayReader._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.CharArrayReader.staticClass, "read", "()I", ref global::java.io.CharArrayReader._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.CharArrayReader.staticClass, "skip", "(J)J", ref global::java.io.CharArrayReader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.CharArrayReader.staticClass, "markSupported", "()Z", ref global::java.io.CharArrayReader._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.CharArrayReader.staticClass, "ready", "()Z", ref global::java.io.CharArrayReader._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public CharArrayReader(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.CharArrayReader._m8.native == global::System.IntPtr.Zero)
				global::java.io.CharArrayReader._m8 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public CharArrayReader(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.CharArrayReader._m9.native == global::System.IntPtr.Zero)
				global::java.io.CharArrayReader._m9 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([CII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CharArrayReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayReader"));
		}
	}
}
