namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipFile.staticClass, "finalize", "()V", ref global::java.util.zip.ZipFile._m0);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipFile.staticClass, "getName", "()Ljava/lang/String;", ref global::java.util.zip.ZipFile._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipFile.staticClass, "size", "()I", ref global::java.util.zip.ZipFile._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipFile.staticClass, "close", "()V", ref global::java.util.zip.ZipFile._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.util.zip.ZipEntry getEntry(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", ref global::java.util.zip.ZipFile._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.Enumeration entries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.zip.ZipFile.staticClass, "entries", "()Ljava/util/Enumeration;", ref global::java.util.zip.ZipFile._m5) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", ref global::java.util.zip.ZipFile._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ZipFile(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._m7.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._m7 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ZipFile(java.io.File arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._m8.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._m8 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ZipFile(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._m9.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._m9 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int OPEN_READ
		{
			get
			{
				return 1;
			}
		}
		public static int OPEN_DELETE
		{
			get
			{
				return 4;
			}
		}
		static ZipFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipFile"));
		}
	}
}
