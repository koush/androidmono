namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MemoryFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MemoryFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MemoryFile.staticClass, "finalize", "()V", ref global::android.os.MemoryFile._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.MemoryFile.staticClass, "length", "()I", ref global::android.os.MemoryFile._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MemoryFile.staticClass, "close", "()V", ref global::android.os.MemoryFile._m2);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.MemoryFile.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.os.MemoryFile._m3) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int readBytes(byte[] arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.MemoryFile.staticClass, "readBytes", "([BIII)I", ref global::android.os.MemoryFile._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeBytes(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MemoryFile.staticClass, "writeBytes", "([BIII)V", ref global::android.os.MemoryFile._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.MemoryFile.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.os.MemoryFile._m6) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isPurgingAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.MemoryFile.staticClass, "isPurgingAllowed", "()Z", ref global::android.os.MemoryFile._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool allowPurging(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.MemoryFile.staticClass, "allowPurging", "(Z)Z", ref global::android.os.MemoryFile._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public MemoryFile(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.MemoryFile._m9.native == global::System.IntPtr.Zero)
				global::android.os.MemoryFile._m9 = @__env.GetMethodIDNoThrow(global::android.os.MemoryFile.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.MemoryFile.staticClass, global::android.os.MemoryFile._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MemoryFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MemoryFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MemoryFile"));
		}
	}
}
