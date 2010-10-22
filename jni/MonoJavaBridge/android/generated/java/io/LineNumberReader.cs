namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberReader : java.io.BufferedReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LineNumberReader()
		{
			InitJNI();
		}
		protected LineNumberReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine19013;
		public override global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.LineNumberReader._readLine19013)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._readLine19013)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getLineNumber19014;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberReader._getLineNumber19014);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._getLineNumber19014);
		}
		internal static global::MonoJavaBridge.MethodId _mark19015;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberReader._mark19015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._mark19015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19016;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberReader._reset19016);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._reset19016);
		}
		internal static global::MonoJavaBridge.MethodId _read19017;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberReader._read19017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._read19017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19018;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberReader._read19018);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._read19018);
		}
		internal static global::MonoJavaBridge.MethodId _skip19019;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.LineNumberReader._skip19019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._skip19019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber19020;
		public virtual void setLineNumber(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberReader._setLineNumber19020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._setLineNumber19020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberReader19021;
		public LineNumberReader(java.io.Reader arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._LineNumberReader19021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberReader19022;
		public LineNumberReader(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._LineNumberReader19022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberReader"));
			global::java.io.LineNumberReader._readLine19013 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.LineNumberReader._getLineNumber19014 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "getLineNumber", "()I");
			global::java.io.LineNumberReader._mark19015 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "mark", "(I)V");
			global::java.io.LineNumberReader._reset19016 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "reset", "()V");
			global::java.io.LineNumberReader._read19017 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "read", "([CII)I");
			global::java.io.LineNumberReader._read19018 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "read", "()I");
			global::java.io.LineNumberReader._skip19019 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "skip", "(J)J");
			global::java.io.LineNumberReader._setLineNumber19020 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "setLineNumber", "(I)V");
			global::java.io.LineNumberReader._LineNumberReader19021 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.LineNumberReader._LineNumberReader19022 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
