namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.BufferedReader._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedReader.staticClass, "close", "()V", ref global::java.io.BufferedReader._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedReader.staticClass, "mark", "(I)V", ref global::java.io.BufferedReader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedReader.staticClass, "reset", "()V", ref global::java.io.BufferedReader._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedReader.staticClass, "read", "([CII)I", ref global::java.io.BufferedReader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedReader.staticClass, "read", "()I", ref global::java.io.BufferedReader._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.BufferedReader.staticClass, "skip", "(J)J", ref global::java.io.BufferedReader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.BufferedReader.staticClass, "markSupported", "()Z", ref global::java.io.BufferedReader._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.BufferedReader.staticClass, "ready", "()Z", ref global::java.io.BufferedReader._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public BufferedReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedReader._m9.native == global::System.IntPtr.Zero)
				global::java.io.BufferedReader._m9 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public BufferedReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedReader._m10.native == global::System.IntPtr.Zero)
				global::java.io.BufferedReader._m10 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedReader"));
		}
	}
}
