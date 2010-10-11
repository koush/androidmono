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
		internal static global::MonoJavaBridge.MethodId _finalize6482;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MemoryFile._finalize6482);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._finalize6482);
		}
		internal static global::MonoJavaBridge.MethodId _length6483;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.MemoryFile._length6483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._length6483);
		}
		internal static global::MonoJavaBridge.MethodId _close6484;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MemoryFile._close6484);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._close6484);
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream6485;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.MemoryFile._getInputStream6485)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._getInputStream6485)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _readBytes6486;
		public virtual int readBytes(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.MemoryFile._readBytes6486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._readBytes6486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _writeBytes6487;
		public virtual void writeBytes(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MemoryFile._writeBytes6487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._writeBytes6487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream6488;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.MemoryFile._getOutputStream6488)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._getOutputStream6488)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _isPurgingAllowed6489;
		public virtual bool isPurgingAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.MemoryFile._isPurgingAllowed6489);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._isPurgingAllowed6489);
		}
		internal static global::MonoJavaBridge.MethodId _allowPurging6490;
		public virtual bool allowPurging(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.MemoryFile._allowPurging6490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.MemoryFile.staticClass, global::android.os.MemoryFile._allowPurging6490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MemoryFile6491;
		public MemoryFile(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.MemoryFile.staticClass, global::android.os.MemoryFile._MemoryFile6491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MemoryFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MemoryFile"));
			global::android.os.MemoryFile._finalize6482 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "finalize", "()V");
			global::android.os.MemoryFile._length6483 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "length", "()I");
			global::android.os.MemoryFile._close6484 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "close", "()V");
			global::android.os.MemoryFile._getInputStream6485 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.os.MemoryFile._readBytes6486 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "readBytes", "([BIII)I");
			global::android.os.MemoryFile._writeBytes6487 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "writeBytes", "([BIII)V");
			global::android.os.MemoryFile._getOutputStream6488 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.os.MemoryFile._isPurgingAllowed6489 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "isPurgingAllowed", "()Z");
			global::android.os.MemoryFile._allowPurging6490 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "allowPurging", "(Z)Z");
			global::android.os.MemoryFile._MemoryFile6491 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
