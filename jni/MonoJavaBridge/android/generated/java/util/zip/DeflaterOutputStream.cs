namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeflaterOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DeflaterOutputStream()
		{
			InitJNI();
		}
		protected DeflaterOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22383;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._write22383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._write22383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write22384;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._write22384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._write22384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22385;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._close22385);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._close22385);
		}
		internal static global::MonoJavaBridge.MethodId _finish22386;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._finish22386);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._finish22386);
		}
		internal static global::MonoJavaBridge.MethodId _deflate22387;
		protected virtual void deflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._deflate22387);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._deflate22387);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream22388;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream22388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream22389;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream22389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream22390;
		public DeflaterOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream22390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.DeflaterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/DeflaterOutputStream"));
			global::java.util.zip.DeflaterOutputStream._write22383 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.DeflaterOutputStream._write22384 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "write", "(I)V");
			global::java.util.zip.DeflaterOutputStream._close22385 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "close", "()V");
			global::java.util.zip.DeflaterOutputStream._finish22386 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "finish", "()V");
			global::java.util.zip.DeflaterOutputStream._deflate22387 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "deflate", "()V");
			global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream22388 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V");
			global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream22389 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V");
			global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream22390 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
