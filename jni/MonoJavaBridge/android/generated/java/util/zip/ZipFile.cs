namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipFile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZipFile()
		{
			InitJNI();
		}
		protected ZipFile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28457;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile._finalize28457);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._finalize28457);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28458;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._getName28458)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getName28458)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size28459;
		public virtual int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipFile._size28459);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._size28459);
		}
		internal static global::MonoJavaBridge.MethodId _close28460;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile._close28460);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._close28460);
		}
		internal static global::MonoJavaBridge.MethodId _getEntry28461;
		public virtual global::java.util.zip.ZipEntry getEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._getEntry28461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getEntry28461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _entries28462;
		public virtual global::java.util.Enumeration entries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._entries28462)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._entries28462)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream28463;
		public virtual global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._getInputStream28463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getInputStream28463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile28464;
		public ZipFile(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile28464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile28465;
		public ZipFile(java.io.File arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile28465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile28466;
		public ZipFile(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile28466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipFile.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipFile"));
			global::java.util.zip.ZipFile._finalize28457 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "finalize", "()V");
			global::java.util.zip.ZipFile._getName28458 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.zip.ZipFile._size28459 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "size", "()I");
			global::java.util.zip.ZipFile._close28460 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "close", "()V");
			global::java.util.zip.ZipFile._getEntry28461 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipFile._entries28462 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::java.util.zip.ZipFile._getInputStream28463 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;");
			global::java.util.zip.ZipFile._ZipFile28464 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.zip.ZipFile._ZipFile28465 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;I)V");
			global::java.util.zip.ZipFile._ZipFile28466 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
