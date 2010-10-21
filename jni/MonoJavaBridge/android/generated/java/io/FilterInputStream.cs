namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FilterInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterInputStream()
		{
			InitJNI();
		}
		protected FilterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close18940;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterInputStream._close18940);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._close18940);
		}
		internal static global::MonoJavaBridge.MethodId _mark18941;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterInputStream._mark18941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._mark18941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset18942;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterInputStream._reset18942);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._reset18942);
		}
		internal static global::MonoJavaBridge.MethodId _read18943;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._read18943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read18943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read18944;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._read18944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read18944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read18945;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._read18945);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._read18945);
		}
		internal static global::MonoJavaBridge.MethodId _skip18946;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.FilterInputStream._skip18946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._skip18946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available18947;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilterInputStream._available18947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._available18947);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported18948;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilterInputStream._markSupported18948);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._markSupported18948);
		}
		internal static global::MonoJavaBridge.MethodId _FilterInputStream18949;
		protected FilterInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterInputStream.staticClass, global::java.io.FilterInputStream._FilterInputStream18949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterInputStream"));
			global::java.io.FilterInputStream._close18940 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "close", "()V");
			global::java.io.FilterInputStream._mark18941 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "mark", "(I)V");
			global::java.io.FilterInputStream._reset18942 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "reset", "()V");
			global::java.io.FilterInputStream._read18943 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "([BII)I");
			global::java.io.FilterInputStream._read18944 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "([B)I");
			global::java.io.FilterInputStream._read18945 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "read", "()I");
			global::java.io.FilterInputStream._skip18946 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "skip", "(J)J");
			global::java.io.FilterInputStream._available18947 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "available", "()I");
			global::java.io.FilterInputStream._markSupported18948 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "markSupported", "()Z");
			global::java.io.FilterInputStream._FilterInputStream18949 = @__env.GetMethodIDNoThrow(global::java.io.FilterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
