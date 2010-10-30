namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class FileDescriptor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileDescriptor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public bool valid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FileDescriptor.staticClass, "valid", "()Z", ref global::java.io.FileDescriptor._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void sync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.FileDescriptor.staticClass, "sync", "()V", ref global::java.io.FileDescriptor._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public FileDescriptor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileDescriptor._m2.native == global::System.IntPtr.Zero)
				global::java.io.FileDescriptor._m2 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._m2);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _in6379;
		public static global::java.io.FileDescriptor @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _in6379)) as java.io.FileDescriptor;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out6380;
		public static global::java.io.FileDescriptor @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _out6380)) as java.io.FileDescriptor;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err6381;
		public static global::java.io.FileDescriptor err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _err6381)) as java.io.FileDescriptor;
			}
		}
		static FileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileDescriptor"));
			global::java.io.FileDescriptor._in6379 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "@in", "Ljava/io/FileDescriptor;");
			global::java.io.FileDescriptor._out6380 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "@out", "Ljava/io/FileDescriptor;");
			global::java.io.FileDescriptor._err6381 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "err", "Ljava/io/FileDescriptor;");
		}
		internal static void InitJNI()
		{
		}
	}
}
