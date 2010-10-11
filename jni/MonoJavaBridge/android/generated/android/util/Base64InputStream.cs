namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64InputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Base64InputStream()
		{
			InitJNI();
		}
		protected Base64InputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close8472;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64InputStream._close8472);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._close8472);
		}
		internal static global::MonoJavaBridge.MethodId _mark8473;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64InputStream._mark8473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._mark8473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset8474;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64InputStream._reset8474);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._reset8474);
		}
		internal static global::MonoJavaBridge.MethodId _read8475;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Base64InputStream._read8475);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._read8475);
		}
		internal static global::MonoJavaBridge.MethodId _read8476;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Base64InputStream._read8476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._read8476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip8477;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.util.Base64InputStream._skip8477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._skip8477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available8478;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Base64InputStream._available8478);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._available8478);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported8479;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.Base64InputStream._markSupported8479);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._markSupported8479);
		}
		internal static global::MonoJavaBridge.MethodId _Base64InputStream8480;
		public Base64InputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._Base64InputStream8480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64InputStream"));
			global::android.util.Base64InputStream._close8472 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "close", "()V");
			global::android.util.Base64InputStream._mark8473 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "mark", "(I)V");
			global::android.util.Base64InputStream._reset8474 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "reset", "()V");
			global::android.util.Base64InputStream._read8475 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "read", "()I");
			global::android.util.Base64InputStream._read8476 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "read", "([BII)I");
			global::android.util.Base64InputStream._skip8477 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "skip", "(J)J");
			global::android.util.Base64InputStream._available8478 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "available", "()I");
			global::android.util.Base64InputStream._markSupported8479 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "markSupported", "()Z");
			global::android.util.Base64InputStream._Base64InputStream8480 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
		}
	}
}
