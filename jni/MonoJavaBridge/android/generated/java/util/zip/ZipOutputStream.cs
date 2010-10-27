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
		internal static global::MonoJavaBridge.MethodId _write28477;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._write28477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._write28477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close28478;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._close28478);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._close28478);
		}
		public new int Method
		{
			set
			{
				setMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMethod28479;
		public virtual void setMethod(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._setMethod28479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._setMethod28479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			set
			{
				setComment(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setComment28480;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._setComment28480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._setComment28480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry28481;
		public virtual void closeEntry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._closeEntry28481);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._closeEntry28481);
		}
		public new int Level
		{
			set
			{
				setLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28482;
		public virtual void setLevel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._setLevel28482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._setLevel28482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish28483;
		public override void finish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._finish28483);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._finish28483);
		}
		internal static global::MonoJavaBridge.MethodId _putNextEntry28484;
		public virtual void putNextEntry(java.util.zip.ZipEntry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream._putNextEntry28484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._putNextEntry28484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZipOutputStream28485;
		public ZipOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._ZipOutputStream28485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.util.zip.ZipOutputStream._write28477 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.ZipOutputStream._close28478 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "close", "()V");
			global::java.util.zip.ZipOutputStream._setMethod28479 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "setMethod", "(I)V");
			global::java.util.zip.ZipOutputStream._setComment28480 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::java.util.zip.ZipOutputStream._closeEntry28481 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "closeEntry", "()V");
			global::java.util.zip.ZipOutputStream._setLevel28482 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "setLevel", "(I)V");
			global::java.util.zip.ZipOutputStream._finish28483 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "finish", "()V");
			global::java.util.zip.ZipOutputStream._putNextEntry28484 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V");
			global::java.util.zip.ZipOutputStream._ZipOutputStream28485 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
