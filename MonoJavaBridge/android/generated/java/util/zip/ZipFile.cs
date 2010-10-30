namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZipFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28458;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._finalize28458.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._finalize28458 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._finalize28458);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28459;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._getName28459.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._getName28459 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getName28459) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size28460;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._size28460.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._size28460 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._size28460);
		}
		internal static global::MonoJavaBridge.MethodId _close28461;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._close28461.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._close28461 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._close28461);
		}
		internal static global::MonoJavaBridge.MethodId _getEntry28462;
		public virtual global::java.util.zip.ZipEntry getEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._getEntry28462.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._getEntry28462 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getEntry28462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _entries28463;
		public virtual global::java.util.Enumeration entries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._entries28463.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._entries28463 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._entries28463) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream28464;
		public virtual global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._getInputStream28464.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._getInputStream28464 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getInputStream28464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile28465;
		public ZipFile(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._ZipFile28465.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._ZipFile28465 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile28465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile28466;
		public ZipFile(java.io.File arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._ZipFile28466.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._ZipFile28466 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile28466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile28467;
		public ZipFile(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.ZipFile._ZipFile28467.native == global::System.IntPtr.Zero)
				global::java.util.zip.ZipFile._ZipFile28467 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile28467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static void InitJNI()
		{
		}
	}
}
