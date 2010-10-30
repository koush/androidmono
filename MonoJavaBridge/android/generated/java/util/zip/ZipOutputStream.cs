namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipOutputStream : java.util.zip.DeflaterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write28478;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "write", "([BII)V", ref global::java.util.zip.ZipOutputStream._write28478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close28479;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "close", "()V", ref global::java.util.zip.ZipOutputStream._close28479);
		}
		public new int Method
		{
			set
			{
				setMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMethod28480;
		public virtual void setMethod(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "setMethod", "(I)V", ref global::java.util.zip.ZipOutputStream._setMethod28480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			set
			{
				setComment(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setComment28481;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::java.util.zip.ZipOutputStream._setComment28481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry28482;
		public virtual void closeEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "closeEntry", "()V", ref global::java.util.zip.ZipOutputStream._closeEntry28482);
		}
		public new int Level
		{
			set
			{
				setLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28483;
		public virtual void setLevel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "setLevel", "(I)V", ref global::java.util.zip.ZipOutputStream._setLevel28483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish28484;
		public override void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "finish", "()V", ref global::java.util.zip.ZipOutputStream._finish28484);
		}
		internal static global::MonoJavaBridge.MethodId _putNextEntry28485;
		public virtual void putNextEntry(java.util.zip.ZipEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V", ref global::java.util.zip.ZipOutputStream._putNextEntry28485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZipOutputStream28486;
		public ZipOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipOutputStream._ZipOutputStream28486.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipOutputStream._ZipOutputStream28486 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._ZipOutputStream28486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static ZipOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipOutputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
