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
		internal static global::MonoJavaBridge.MethodId _write28278;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream._write28278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._write28278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _finish28279;
		public override void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream._finish28279);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._finish28279);
		}
		internal static global::MonoJavaBridge.MethodId _GZIPOutputStream28280;
		public GZIPOutputStream(java.io.OutputStream arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._GZIPOutputStream28280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GZIPOutputStream28281;
		public GZIPOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.GZIPOutputStream.staticClass, global::java.util.zip.GZIPOutputStream._GZIPOutputStream28281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.GZIPOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/GZIPOutputStream"));
			global::java.util.zip.GZIPOutputStream._write28278 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.GZIPOutputStream._finish28279 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "finish", "()V");
			global::java.util.zip.GZIPOutputStream._GZIPOutputStream28280 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;I)V");
			global::java.util.zip.GZIPOutputStream._GZIPOutputStream28281 = @__env.GetMethodIDNoThrow(global::java.util.zip.GZIPOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
