namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InflaterInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InflaterInputStream()
		{
			InitJNI();
		}
		protected InflaterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28302;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._close28302);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._close28302);
		}
		internal static global::MonoJavaBridge.MethodId _mark28303;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._mark28303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._mark28303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset28304;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._reset28304);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._reset28304);
		}
		internal static global::MonoJavaBridge.MethodId _fill28305;
		protected virtual void fill() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._fill28305);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._fill28305);
		}
		internal static global::MonoJavaBridge.MethodId _read28306;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._read28306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._read28306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read28307;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._read28307);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._read28307);
		}
		internal static global::MonoJavaBridge.MethodId _skip28308;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._skip28308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._skip28308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28309;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._available28309);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._available28309);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported28310;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._markSupported28310);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._markSupported28310);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28311;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28312;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28313;
		public InflaterInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.InflaterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/InflaterInputStream"));
			global::java.util.zip.InflaterInputStream._close28302 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "close", "()V");
			global::java.util.zip.InflaterInputStream._mark28303 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "mark", "(I)V");
			global::java.util.zip.InflaterInputStream._reset28304 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "reset", "()V");
			global::java.util.zip.InflaterInputStream._fill28305 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "fill", "()V");
			global::java.util.zip.InflaterInputStream._read28306 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.InflaterInputStream._read28307 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "read", "()I");
			global::java.util.zip.InflaterInputStream._skip28308 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.InflaterInputStream._available28309 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "available", "()I");
			global::java.util.zip.InflaterInputStream._markSupported28310 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "markSupported", "()Z");
			global::java.util.zip.InflaterInputStream._InflaterInputStream28311 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V");
			global::java.util.zip.InflaterInputStream._InflaterInputStream28312 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V");
			global::java.util.zip.InflaterInputStream._InflaterInputStream28313 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
