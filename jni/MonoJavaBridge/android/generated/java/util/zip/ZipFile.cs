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
		internal static global::MonoJavaBridge.MethodId _finalize22454;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile._finalize22454);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._finalize22454);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName22455;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._getName22455)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getName22455)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size22456;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipFile._size22456);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._size22456);
		}
		internal static global::MonoJavaBridge.MethodId _close22457;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile._close22457);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._close22457);
		}
		internal static global::MonoJavaBridge.MethodId _getEntry22458;
		public virtual global::java.util.zip.ZipEntry getEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._getEntry22458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getEntry22458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _entries22459;
		public virtual global::java.util.Enumeration entries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._entries22459)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._entries22459)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream22460;
		public virtual global::java.io.InputStream getInputStream(java.util.zip.ZipEntry arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile._getInputStream22460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._getInputStream22460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile22461;
		public ZipFile(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile22461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile22462;
		public ZipFile(java.io.File arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile22462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZipFile22463;
		public ZipFile(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipFile.staticClass, global::java.util.zip.ZipFile._ZipFile22463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.util.zip.ZipFile._finalize22454 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "finalize", "()V");
			global::java.util.zip.ZipFile._getName22455 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getName", "()Ljava/lang/String;");
			global::java.util.zip.ZipFile._size22456 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "size", "()I");
			global::java.util.zip.ZipFile._close22457 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "close", "()V");
			global::java.util.zip.ZipFile._getEntry22458 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipFile._entries22459 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "entries", "()Ljava/util/Enumeration;");
			global::java.util.zip.ZipFile._getInputStream22460 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;");
			global::java.util.zip.ZipFile._ZipFile22461 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.zip.ZipFile._ZipFile22462 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/io/File;I)V");
			global::java.util.zip.ZipFile._ZipFile22463 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipFile.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
