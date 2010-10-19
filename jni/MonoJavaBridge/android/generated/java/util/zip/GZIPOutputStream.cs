namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GZIPOutputStream : java.util.zip.DeflaterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GZIPOutputStream()
		{
			InitJNI();
		}
		protected GZIPOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22395;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream._write22395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._write22395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _finish22396;
		public override void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream._finish22396);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._finish22396);
		}
		internal static global::MonoJavaBridge.MethodId _GZIPOutputStream22397;
		public GZIPOutputStream(java.io.OutputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._GZIPOutputStream22397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GZIPOutputStream22398;
		public GZIPOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._GZIPOutputStream22398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.GZIPOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/GZIPOutputStream"));
			global::java.util.zip.GZIPOutputStream._write22395 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.GZIPOutputStream._finish22396 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "finish", "()V");
			global::java.util.zip.GZIPOutputStream._GZIPOutputStream22397 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::java.util.zip.GZIPOutputStream._GZIPOutputStream22398 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
