namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.FilterReader_))]
	public abstract partial class FilterReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterReader()
		{
			InitJNI();
		}
		protected FilterReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19074;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterReader._close19074);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._close19074);
		}
		internal static global::MonoJavaBridge.MethodId _mark19075;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterReader._mark19075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._mark19075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19076;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterReader._reset19076);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._reset19076);
		}
		internal static global::MonoJavaBridge.MethodId _read19077;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterReader._read19077);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._read19077);
		}
		internal static global::MonoJavaBridge.MethodId _read19078;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterReader._read19078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._read19078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19079;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.FilterReader._skip19079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._skip19079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19080;
		public override bool markSupported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilterReader._markSupported19080);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._markSupported19080);
		}
		internal static global::MonoJavaBridge.MethodId _ready19081;
		public override bool ready()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilterReader._ready19081);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._ready19081);
		}
		internal static global::MonoJavaBridge.MethodId _FilterReader19082;
		protected FilterReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterReader.staticClass, global::java.io.FilterReader._FilterReader19082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilterReader))]
	internal sealed partial class FilterReader_ : java.io.FilterReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterReader_()
		{
			InitJNI();
		}
		internal FilterReader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterReader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterReader"));
		}
	}
}
