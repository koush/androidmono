namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.FilterReader_))]
	public abstract partial class FilterReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FilterReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19074;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._close19074);
		}
		internal static global::MonoJavaBridge.MethodId _mark19075;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._mark19075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19076;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._reset19076);
		}
		internal static global::MonoJavaBridge.MethodId _read19077;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._read19077);
		}
		internal static global::MonoJavaBridge.MethodId _read19078;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._read19078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19079;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._skip19079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19080;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._markSupported19080);
		}
		internal static global::MonoJavaBridge.MethodId _ready19081;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._ready19081);
		}
		internal static global::MonoJavaBridge.MethodId _FilterReader19082;
		protected FilterReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterReader.staticClass, global::java.io.FilterReader._FilterReader19082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FilterReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterReader"));
			global::java.io.FilterReader._close19074 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "close", "()V");
			global::java.io.FilterReader._mark19075 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "mark", "(I)V");
			global::java.io.FilterReader._reset19076 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "reset", "()V");
			global::java.io.FilterReader._read19077 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "read", "()I");
			global::java.io.FilterReader._read19078 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "read", "([CII)I");
			global::java.io.FilterReader._skip19079 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "skip", "(J)J");
			global::java.io.FilterReader._markSupported19080 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "markSupported", "()Z");
			global::java.io.FilterReader._ready19081 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "ready", "()Z");
			global::java.io.FilterReader._FilterReader19082 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
