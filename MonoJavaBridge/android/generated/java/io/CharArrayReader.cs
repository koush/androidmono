namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharArrayReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharArrayReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close18856;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayReader.staticClass, "close", "()V", ref global::java.io.CharArrayReader._close18856);
		}
		internal static global::MonoJavaBridge.MethodId _mark18857;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayReader.staticClass, "mark", "(I)V", ref global::java.io.CharArrayReader._mark18857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18858;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayReader.staticClass, "reset", "()V", ref global::java.io.CharArrayReader._reset18858);
		}
		internal static global::MonoJavaBridge.MethodId _read18859;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.CharArrayReader.staticClass, "read", "([CII)I", ref global::java.io.CharArrayReader._read18859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18860;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.CharArrayReader.staticClass, "read", "()I", ref global::java.io.CharArrayReader._read18860);
		}
		internal static global::MonoJavaBridge.MethodId _skip18861;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.CharArrayReader.staticClass, "skip", "(J)J", ref global::java.io.CharArrayReader._skip18861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18862;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.CharArrayReader.staticClass, "markSupported", "()Z", ref global::java.io.CharArrayReader._markSupported18862);
		}
		internal static global::MonoJavaBridge.MethodId _ready18863;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.CharArrayReader.staticClass, "ready", "()Z", ref global::java.io.CharArrayReader._ready18863);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayReader18864;
		public CharArrayReader(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.CharArrayReader._CharArrayReader18864.native == global::System.IntPtr.Zero)
				global::java.io.CharArrayReader._CharArrayReader18864 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._CharArrayReader18864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayReader18865;
		public CharArrayReader(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.CharArrayReader._CharArrayReader18865.native == global::System.IntPtr.Zero)
				global::java.io.CharArrayReader._CharArrayReader18865 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayReader.staticClass, "<init>", "([CII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayReader.staticClass, global::java.io.CharArrayReader._CharArrayReader18865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CharArrayReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
