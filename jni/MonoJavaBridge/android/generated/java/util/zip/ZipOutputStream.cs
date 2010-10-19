namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipOutputStream : java.util.zip.DeflaterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZipOutputStream()
		{
			InitJNI();
		}
		protected ZipOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write22472;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._write22472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._write22472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close22473;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._close22473);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._close22473);
		}
		internal static global::MonoJavaBridge.MethodId _setMethod22474;
		public virtual void setMethod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._setMethod22474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._setMethod22474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment22475;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._setComment22475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._setComment22475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry22476;
		public virtual void closeEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._closeEntry22476);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._closeEntry22476);
		}
		internal static global::MonoJavaBridge.MethodId _setLevel22477;
		public virtual void setLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._setLevel22477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._setLevel22477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish22478;
		public override void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._finish22478);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._finish22478);
		}
		internal static global::MonoJavaBridge.MethodId _putNextEntry22479;
		public virtual void putNextEntry(java.util.zip.ZipEntry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._putNextEntry22479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._putNextEntry22479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZipOutputStream22480;
		public ZipOutputStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._ZipOutputStream22480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int STORED
		{
			get
			{
				return 0;
			}
		}
		public static int DEFLATED
		{
			get
			{
				return 8;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipOutputStream"));
			global::java.util.zip.ZipOutputStream._write22472 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.ZipOutputStream._close22473 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "close", "()V");
			global::java.util.zip.ZipOutputStream._setMethod22474 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "setMethod", "(I)V");
			global::java.util.zip.ZipOutputStream._setComment22475 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::java.util.zip.ZipOutputStream._closeEntry22476 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "closeEntry", "()V");
			global::java.util.zip.ZipOutputStream._setLevel22477 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "setLevel", "(I)V");
			global::java.util.zip.ZipOutputStream._finish22478 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "finish", "()V");
			global::java.util.zip.ZipOutputStream._putNextEntry22479 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V");
			global::java.util.zip.ZipOutputStream._ZipOutputStream22480 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
