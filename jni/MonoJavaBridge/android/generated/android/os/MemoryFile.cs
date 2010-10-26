namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MemoryFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MemoryFile()
		{
			InitJNI();
		}
		protected MemoryFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize9924;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MemoryFile._finalize9924);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._finalize9924);
		}
		internal static global::MonoJavaBridge.MethodId _length9925;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.MemoryFile._length9925);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._length9925);
		}
		internal static global::MonoJavaBridge.MethodId _close9926;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MemoryFile._close9926);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._close9926);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.MemoryFile._getInputStream9927)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._getInputStream9927)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBytes9928;
		public virtual int readBytes(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.MemoryFile._readBytes9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._readBytes9928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes9929;
		public virtual void writeBytes(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MemoryFile._writeBytes9929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._writeBytes9929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.MemoryFile._getOutputStream9930)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._getOutputStream9930)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _isPurgingAllowed9931;
		public virtual bool isPurgingAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.MemoryFile._isPurgingAllowed9931);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._isPurgingAllowed9931);
		}
		internal static global::MonoJavaBridge.MethodId _allowPurging9932;
		public virtual bool allowPurging(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.MemoryFile._allowPurging9932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._allowPurging9932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MemoryFile9933;
		public MemoryFile(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.MemoryFile.staticClass, global::android.os.MemoryFile._MemoryFile9933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MemoryFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MemoryFile"));
			global::android.os.MemoryFile._finalize9924 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "finalize", "()V");
			global::android.os.MemoryFile._length9925 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "length", "()I");
			global::android.os.MemoryFile._close9926 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "close", "()V");
			global::android.os.MemoryFile._getInputStream9927 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.os.MemoryFile._readBytes9928 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "readBytes", "([BIII)I");
			global::android.os.MemoryFile._writeBytes9929 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "writeBytes", "([BIII)V");
			global::android.os.MemoryFile._getOutputStream9930 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.os.MemoryFile._isPurgingAllowed9931 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "isPurgingAllowed", "()Z");
			global::android.os.MemoryFile._allowPurging9932 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "allowPurging", "(Z)Z");
			global::android.os.MemoryFile._MemoryFile9933 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
