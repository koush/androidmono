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
		internal static global::MonoJavaBridge.MethodId _close22419;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._close22419);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._close22419);
		}
		internal static global::MonoJavaBridge.MethodId _mark22420;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._mark22420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._mark22420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset22421;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._reset22421);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._reset22421);
		}
		internal static global::MonoJavaBridge.MethodId _fill22422;
		protected virtual void fill() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._fill22422);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._fill22422);
		}
		internal static global::MonoJavaBridge.MethodId _read22423;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._read22423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._read22423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22424;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._read22424);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._read22424);
		}
		internal static global::MonoJavaBridge.MethodId _skip22425;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._skip22425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._skip22425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available22426;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._available22426);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._available22426);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported22427;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._markSupported22427);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._markSupported22427);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream22428;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream22428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream22429;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream22429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream22430;
		public InflaterInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream22430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.InflaterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/InflaterInputStream"));
			global::java.util.zip.InflaterInputStream._close22419 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "close", "()V");
			global::java.util.zip.InflaterInputStream._mark22420 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "mark", "(I)V");
			global::java.util.zip.InflaterInputStream._reset22421 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "reset", "()V");
			global::java.util.zip.InflaterInputStream._fill22422 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "fill", "()V");
			global::java.util.zip.InflaterInputStream._read22423 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.InflaterInputStream._read22424 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "read", "()I");
			global::java.util.zip.InflaterInputStream._skip22425 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.InflaterInputStream._available22426 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "available", "()I");
			global::java.util.zip.InflaterInputStream._markSupported22427 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "markSupported", "()Z");
			global::java.util.zip.InflaterInputStream._InflaterInputStream22428 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V");
			global::java.util.zip.InflaterInputStream._InflaterInputStream22429 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V");
			global::java.util.zip.InflaterInputStream._InflaterInputStream22430 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
