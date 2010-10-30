namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getLineNumber19122;
		public virtual int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._getLineNumber19122.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._getLineNumber19122 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "getLineNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._getLineNumber19122);
		}
		internal static global::MonoJavaBridge.MethodId _mark19123;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._mark19123.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._mark19123 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "mark", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._mark19123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19124;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._reset19124.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._reset19124 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "reset", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._reset19124);
		}
		internal static global::MonoJavaBridge.MethodId _read19125;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._read19125.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._read19125 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._read19125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19126;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._read19126.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._read19126 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._read19126);
		}
		internal static global::MonoJavaBridge.MethodId _skip19127;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._skip19127.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._skip19127 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "skip", "(J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._skip19127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19128;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._available19128.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._available19128 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "available", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._available19128);
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber19129;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._setLineNumber19129.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._setLineNumber19129 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "setLineNumber", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._setLineNumber19129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberInputStream19130;
		public LineNumberInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.LineNumberInputStream._LineNumberInputStream19130.native == global::System.IntPtr.Zero)
				global::java.io.LineNumberInputStream._LineNumberInputStream19130 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._LineNumberInputStream19130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LineNumberInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
