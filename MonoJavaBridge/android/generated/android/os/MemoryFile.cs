namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MemoryFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MemoryFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize9924;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MemoryFile.staticClass, "finalize", "()V", ref global::android.os.MemoryFile._finalize9924);
		}
		internal static global::MonoJavaBridge.MethodId _length9925;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.MemoryFile.staticClass, "length", "()I", ref global::android.os.MemoryFile._length9925);
		}
		internal static global::MonoJavaBridge.MethodId _close9926;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MemoryFile.staticClass, "close", "()V", ref global::android.os.MemoryFile._close9926);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream9927;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.MemoryFile.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.os.MemoryFile._getInputStream9927) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBytes9928;
		public virtual int readBytes(byte[] arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.MemoryFile.staticClass, "readBytes", "([BIII)I", ref global::android.os.MemoryFile._readBytes9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes9929;
		public virtual void writeBytes(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MemoryFile.staticClass, "writeBytes", "([BIII)V", ref global::android.os.MemoryFile._writeBytes9929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream9930;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.MemoryFile.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.os.MemoryFile._getOutputStream9930) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _isPurgingAllowed9931;
		public virtual bool isPurgingAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.MemoryFile.staticClass, "isPurgingAllowed", "()Z", ref global::android.os.MemoryFile._isPurgingAllowed9931);
		}
		internal static global::MonoJavaBridge.MethodId _allowPurging9932;
		public virtual bool allowPurging(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.MemoryFile.staticClass, "allowPurging", "(Z)Z", ref global::android.os.MemoryFile._allowPurging9932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MemoryFile9933;
		public MemoryFile(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.MemoryFile._MemoryFile9933.native == global::System.IntPtr.Zero)
				global::android.os.MemoryFile._MemoryFile9933 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.MemoryFile.staticClass, global::android.os.MemoryFile._MemoryFile9933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MemoryFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MemoryFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MemoryFile"));
		}
		internal static void InitJNI()
		{
		}
	}
}
