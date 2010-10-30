namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberReader : java.io.BufferedReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LineNumberReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine19131;
		public override global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.LineNumberReader.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.LineNumberReader._readLine19131) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getLineNumber19132;
		public virtual int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberReader.staticClass, "getLineNumber", "()I", ref global::java.io.LineNumberReader._getLineNumber19132);
		}
		internal static global::MonoJavaBridge.MethodId _mark19133;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberReader.staticClass, "mark", "(I)V", ref global::java.io.LineNumberReader._mark19133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19134;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberReader.staticClass, "reset", "()V", ref global::java.io.LineNumberReader._reset19134);
		}
		internal static global::MonoJavaBridge.MethodId _read19135;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberReader.staticClass, "read", "([CII)I", ref global::java.io.LineNumberReader._read19135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19136;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberReader.staticClass, "read", "()I", ref global::java.io.LineNumberReader._read19136);
		}
		internal static global::MonoJavaBridge.MethodId _skip19137;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.LineNumberReader.staticClass, "skip", "(J)J", ref global::java.io.LineNumberReader._skip19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber19138;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberReader.staticClass, "setLineNumber", "(I)V", ref global::java.io.LineNumberReader._setLineNumber19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberReader19139;
		public LineNumberReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberReader._LineNumberReader19139.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberReader._LineNumberReader19139 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._LineNumberReader19139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberReader19140;
		public LineNumberReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberReader._LineNumberReader19140.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberReader._LineNumberReader19140 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._LineNumberReader19140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LineNumberReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberReader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
