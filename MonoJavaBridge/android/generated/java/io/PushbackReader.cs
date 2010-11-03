namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PushbackReader : java.io.FilterReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PushbackReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackReader.staticClass, "close", "()V", ref global::java.io.PushbackReader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackReader.staticClass, "mark", "(I)V", ref global::java.io.PushbackReader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackReader.staticClass, "reset", "()V", ref global::java.io.PushbackReader._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PushbackReader.staticClass, "read", "()I", ref global::java.io.PushbackReader._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.PushbackReader.staticClass, "read", "([CII)I", ref global::java.io.PushbackReader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.PushbackReader.staticClass, "skip", "(J)J", ref global::java.io.PushbackReader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PushbackReader.staticClass, "markSupported", "()Z", ref global::java.io.PushbackReader._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.PushbackReader.staticClass, "ready", "()Z", ref global::java.io.PushbackReader._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void unread(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackReader.staticClass, "unread", "([C)V", ref global::java.io.PushbackReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void unread(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackReader.staticClass, "unread", "([CII)V", ref global::java.io.PushbackReader._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void unread(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.PushbackReader.staticClass, "unread", "(I)V", ref global::java.io.PushbackReader._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public PushbackReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PushbackReader._m11.native == global::System.IntPtr.Zero)
				global::java.io.PushbackReader._m11 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public PushbackReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.PushbackReader._m12.native == global::System.IntPtr.Zero)
				global::java.io.PushbackReader._m12 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PushbackReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackReader"));
		}
	}
}
