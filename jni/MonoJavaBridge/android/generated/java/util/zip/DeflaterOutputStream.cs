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
		internal static global::MonoJavaBridge.MethodId _write28265;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._write28265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._write28265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write28266;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._write28266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._write28266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close28267;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._close28267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._close28267);
		}
		internal static global::MonoJavaBridge.MethodId _finish28268;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._finish28268);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._finish28268);
		}
		internal static global::MonoJavaBridge.MethodId _deflate28269;
		protected virtual void deflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream._deflate28269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._deflate28269);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream28270;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream28271;
		public DeflaterOutputStream(java.io.OutputStream arg0, java.util.zip.Deflater arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DeflaterOutputStream28272;
		public DeflaterOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DeflaterOutputStream.staticClass, global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.DeflaterOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/DeflaterOutputStream"));
			global::java.util.zip.DeflaterOutputStream._write28265 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.DeflaterOutputStream._write28266 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "write", "(I)V");
			global::java.util.zip.DeflaterOutputStream._close28267 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "close", "()V");
			global::java.util.zip.DeflaterOutputStream._finish28268 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "finish", "()V");
			global::java.util.zip.DeflaterOutputStream._deflate28269 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "deflate", "()V");
			global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28270 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V");
			global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28271 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V");
			global::java.util.zip.DeflaterOutputStream._DeflaterOutputStream28272 = @__env.GetMethodIDNoThrow(global::java.util.zip.DeflaterOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
