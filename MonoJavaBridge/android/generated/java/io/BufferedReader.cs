namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BufferedReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine18815;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.BufferedReader.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.BufferedReader._readLine18815) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close18816;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedReader.staticClass, "close", "()V", ref global::java.io.BufferedReader._close18816);
		}
		internal static global::MonoJavaBridge.MethodId _mark18817;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedReader.staticClass, "mark", "(I)V", ref global::java.io.BufferedReader._mark18817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18818;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.BufferedReader.staticClass, "reset", "()V", ref global::java.io.BufferedReader._reset18818);
		}
		internal static global::MonoJavaBridge.MethodId _read18819;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedReader.staticClass, "read", "([CII)I", ref global::java.io.BufferedReader._read18819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18820;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.BufferedReader.staticClass, "read", "()I", ref global::java.io.BufferedReader._read18820);
		}
		internal static global::MonoJavaBridge.MethodId _skip18821;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.BufferedReader.staticClass, "skip", "(J)J", ref global::java.io.BufferedReader._skip18821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18822;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.BufferedReader.staticClass, "markSupported", "()Z", ref global::java.io.BufferedReader._markSupported18822);
		}
		internal static global::MonoJavaBridge.MethodId _ready18823;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.BufferedReader.staticClass, "ready", "()Z", ref global::java.io.BufferedReader._ready18823);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedReader18824;
		public BufferedReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedReader._BufferedReader18824.native == global::System.IntPtr.Zero)
				global::java.io.BufferedReader._BufferedReader18824 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader18824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedReader18825;
		public BufferedReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.BufferedReader._BufferedReader18825.native == global::System.IntPtr.Zero)
				global::java.io.BufferedReader._BufferedReader18825 = @__env.GetMethodIDNoThrow(global::java.io.BufferedReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.BufferedReader.staticClass, global::java.io.BufferedReader._BufferedReader18825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BufferedReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.BufferedReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/BufferedReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
