namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LineNumberInputStream()
		{
			InitJNI();
		}
		protected LineNumberInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
			set
			{
				setLineNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber13529;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._getLineNumber13529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._getLineNumber13529);
		}
		internal static global::MonoJavaBridge.MethodId _mark13530;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream._mark13530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._mark13530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13531;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream._reset13531);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._reset13531);
		}
		internal static global::MonoJavaBridge.MethodId _read13532;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._read13532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._read13532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read13533;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._read13533);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._read13533);
		}
		internal static global::MonoJavaBridge.MethodId _skip13534;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.LineNumberInputStream._skip13534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._skip13534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13535;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._available13535);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._available13535);
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber13536;
		public virtual void setLineNumber(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream._setLineNumber13536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._setLineNumber13536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberInputStream13537;
		public LineNumberInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._LineNumberInputStream13537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberInputStream"));
			global::java.io.LineNumberInputStream._getLineNumber13529 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "getLineNumber", "()I");
			global::java.io.LineNumberInputStream._mark13530 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "mark", "(I)V");
			global::java.io.LineNumberInputStream._reset13531 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "reset", "()V");
			global::java.io.LineNumberInputStream._read13532 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "read", "([BII)I");
			global::java.io.LineNumberInputStream._read13533 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "read", "()I");
			global::java.io.LineNumberInputStream._skip13534 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "skip", "(J)J");
			global::java.io.LineNumberInputStream._available13535 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "available", "()I");
			global::java.io.LineNumberInputStream._setLineNumber13536 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "setLineNumber", "(I)V");
			global::java.io.LineNumberInputStream._LineNumberInputStream13537 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
