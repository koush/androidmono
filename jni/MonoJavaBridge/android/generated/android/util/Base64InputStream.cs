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
		internal static global::MonoJavaBridge.MethodId _close13649;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64InputStream._close13649);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._close13649);
		}
		internal static global::MonoJavaBridge.MethodId _mark13650;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64InputStream._mark13650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._mark13650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13651;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64InputStream._reset13651);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._reset13651);
		}
		internal static global::MonoJavaBridge.MethodId _read13652;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Base64InputStream._read13652);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._read13652);
		}
		internal static global::MonoJavaBridge.MethodId _read13653;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Base64InputStream._read13653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._read13653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13654;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.util.Base64InputStream._skip13654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._skip13654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13655;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.Base64InputStream._available13655);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._available13655);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13656;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.Base64InputStream._markSupported13656);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._markSupported13656);
		}
		internal static global::MonoJavaBridge.MethodId _Base64InputStream13657;
		public Base64InputStream(java.io.InputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._Base64InputStream13657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64InputStream"));
			global::android.util.Base64InputStream._close13649 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "close", "()V");
			global::android.util.Base64InputStream._mark13650 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "mark", "(I)V");
			global::android.util.Base64InputStream._reset13651 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "reset", "()V");
			global::android.util.Base64InputStream._read13652 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "read", "()I");
			global::android.util.Base64InputStream._read13653 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "read", "([BII)I");
			global::android.util.Base64InputStream._skip13654 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "skip", "(J)J");
			global::android.util.Base64InputStream._available13655 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "available", "()I");
			global::android.util.Base64InputStream._markSupported13656 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "markSupported", "()Z");
			global::android.util.Base64InputStream._Base64InputStream13657 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
		}
	}
}
