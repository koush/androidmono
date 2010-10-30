namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class FileDescriptor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileDescriptor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _valid19010;
		public bool valid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileDescriptor._valid19010.native == global::System.IntPtr.Zero)
				global::java.io.FileDescriptor._valid19010 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "valid", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._valid19010);
		}
		internal static global::MonoJavaBridge.MethodId _sync19011;
		public void sync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileDescriptor._sync19011.native == global::System.IntPtr.Zero)
				global::java.io.FileDescriptor._sync19011 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "sync", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._sync19011);
		}
		internal static global::MonoJavaBridge.MethodId _FileDescriptor19012;
		public FileDescriptor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FileDescriptor._FileDescriptor19012.native == global::System.IntPtr.Zero)
				global::java.io.FileDescriptor._FileDescriptor19012 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._FileDescriptor19012);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _in19013;
		public static global::java.io.FileDescriptor @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _in19013)) as java.io.FileDescriptor;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out19014;
		public static global::java.io.FileDescriptor @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _out19014)) as java.io.FileDescriptor;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err19015;
		public static global::java.io.FileDescriptor err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _err19015)) as java.io.FileDescriptor;
			}
		}
		static FileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileDescriptor"));
			global::java.io.FileDescriptor._in19013 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "@in", "Ljava/io/FileDescriptor;");
			global::java.io.FileDescriptor._out19014 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "@out", "Ljava/io/FileDescriptor;");
			global::java.io.FileDescriptor._err19015 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "err", "Ljava/io/FileDescriptor;");
		}
		internal static void InitJNI()
		{
		}
	}
}
