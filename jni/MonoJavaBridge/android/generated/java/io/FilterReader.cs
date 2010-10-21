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
		internal static global::MonoJavaBridge.MethodId _close18956;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterReader._close18956);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._close18956);
		}
		internal static global::MonoJavaBridge.MethodId _mark18957;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterReader._mark18957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._mark18957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18958;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterReader._reset18958);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._reset18958);
		}
		internal static global::MonoJavaBridge.MethodId _read18959;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterReader._read18959);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._read18959);
		}
		internal static global::MonoJavaBridge.MethodId _read18960;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterReader._read18960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._read18960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip18961;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.FilterReader._skip18961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._skip18961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18962;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilterReader._markSupported18962);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._markSupported18962);
		}
		internal static global::MonoJavaBridge.MethodId _ready18963;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilterReader._ready18963);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilterReader.staticClass, global::java.io.FilterReader._ready18963);
		}
		internal static global::MonoJavaBridge.MethodId _FilterReader18964;
		protected FilterReader(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterReader.staticClass, global::java.io.FilterReader._FilterReader18964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterReader"));
			global::java.io.FilterReader._close18956 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "close", "()V");
			global::java.io.FilterReader._mark18957 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "mark", "(I)V");
			global::java.io.FilterReader._reset18958 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "reset", "()V");
			global::java.io.FilterReader._read18959 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "read", "()I");
			global::java.io.FilterReader._read18960 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "read", "([CII)I");
			global::java.io.FilterReader._skip18961 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "skip", "(J)J");
			global::java.io.FilterReader._markSupported18962 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "markSupported", "()Z");
			global::java.io.FilterReader._ready18963 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "ready", "()Z");
			global::java.io.FilterReader._FilterReader18964 = @__env.GetMethodIDNoThrow(global::java.io.FilterReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilterReader))]
	public sealed partial class FilterReader_ : java.io.FilterReader
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
