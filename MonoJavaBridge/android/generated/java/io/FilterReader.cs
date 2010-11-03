namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.FilterReader_))]
	public abstract partial class FilterReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterReader.staticClass, "close", "()V", ref global::java.io.FilterReader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterReader.staticClass, "mark", "(I)V", ref global::java.io.FilterReader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterReader.staticClass, "reset", "()V", ref global::java.io.FilterReader._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterReader.staticClass, "read", "()I", ref global::java.io.FilterReader._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterReader.staticClass, "read", "([CII)I", ref global::java.io.FilterReader._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.FilterReader.staticClass, "skip", "(J)J", ref global::java.io.FilterReader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilterReader.staticClass, "markSupported", "()Z", ref global::java.io.FilterReader._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilterReader.staticClass, "ready", "()Z", ref global::java.io.FilterReader._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected FilterReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilterReader._m8.native == global::System.IntPtr.Zero)
				global::java.io.FilterReader._m8 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterReader.staticClass, global::java.io.FilterReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterReader"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilterReader))]
	internal sealed partial class FilterReader_ : java.io.FilterReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FilterReader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static FilterReader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterReader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterReader"));
		}
	}
}
