namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipOutputStream : java.util.zip.DeflaterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "write", "([BII)V", ref global::java.util.zip.ZipOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "close", "()V", ref global::java.util.zip.ZipOutputStream._m1);
		}
		public new int Method
		{
			set
			{
				setMethod(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setMethod(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "setMethod", "(I)V", ref global::java.util.zip.ZipOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			set
			{
				setComment(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::java.util.zip.ZipOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void closeEntry()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "closeEntry", "()V", ref global::java.util.zip.ZipOutputStream._m4);
		}
		public new int Level
		{
			set
			{
				setLevel(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setLevel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "setLevel", "(I)V", ref global::java.util.zip.ZipOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "finish", "()V", ref global::java.util.zip.ZipOutputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void putNextEntry(java.util.zip.ZipEntry arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipOutputStream.staticClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V", ref global::java.util.zip.ZipOutputStream._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ZipOutputStream(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipOutputStream._m8.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipOutputStream._m8 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipOutputStream.staticClass, global::java.util.zip.ZipOutputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}
}
