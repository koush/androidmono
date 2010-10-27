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
		internal static global::MonoJavaBridge.MethodId _write13722;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream._write13722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write13722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13723;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream._write13723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._write13723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close13724;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream._close13724);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._close13724);
		}
		internal static global::MonoJavaBridge.MethodId _Base64OutputStream13725;
		public Base64OutputStream(java.io.OutputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64OutputStream.staticClass, global::android.util.Base64OutputStream._Base64OutputStream13725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64OutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64OutputStream"));
			global::android.util.Base64OutputStream._write13722 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "write", "(I)V");
			global::android.util.Base64OutputStream._write13723 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "write", "([BII)V");
			global::android.util.Base64OutputStream._close13724 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "close", "()V");
			global::android.util.Base64OutputStream._Base64OutputStream13725 = @__env.GetMethodIDNoThrow(global::android.util.Base64OutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
		}
	}
}
