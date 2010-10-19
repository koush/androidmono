namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64OutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Base64OutputStream()
		{
			InitJNI();
		}
		protected Base64OutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write9027;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream._write9027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write9027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write9028;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream._write9028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write9028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close9029;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream._close9029);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._close9029);
		}
		internal static global::MonoJavaBridge.MethodId _Base64OutputStream9030;
		public Base64OutputStream(java.io.OutputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._Base64OutputStream9030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64OutputStream"));
			global::android.util.Base64OutputStream._write9027 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "write", "(I)V");
			global::android.util.Base64OutputStream._write9028 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "write", "([BII)V");
			global::android.util.Base64OutputStream._close9029 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "close", "()V");
			global::android.util.Base64OutputStream._Base64OutputStream9030 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
		}
	}
}
