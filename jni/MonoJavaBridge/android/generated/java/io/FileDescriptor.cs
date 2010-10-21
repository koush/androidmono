namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class FileDescriptor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileDescriptor()
		{
			InitJNI();
		}
		internal FileDescriptor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _valid18892;
		public bool valid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FileDescriptor._valid18892);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._valid18892);
		}
		internal static global::MonoJavaBridge.MethodId _sync18893;
		public void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileDescriptor._sync18893);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._sync18893);
		}
		internal static global::MonoJavaBridge.MethodId _FileDescriptor18894;
		public FileDescriptor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._FileDescriptor18894);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _in18895;
		public static global::java.io.FileDescriptor @in
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _in18895)) as java.io.FileDescriptor;
			}
		}
		internal static global::MonoJavaBridge.FieldId _out18896;
		public static global::java.io.FileDescriptor @out
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _out18896)) as java.io.FileDescriptor;
			}
		}
		internal static global::MonoJavaBridge.FieldId _err18897;
		public static global::java.io.FileDescriptor err
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.io.FileDescriptor.staticClass, _err18897)) as java.io.FileDescriptor;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileDescriptor"));
			global::java.io.FileDescriptor._valid18892 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "valid", "()Z");
			global::java.io.FileDescriptor._sync18893 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "sync", "()V");
			global::java.io.FileDescriptor._FileDescriptor18894 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "<init>", "()V");
			global::java.io.FileDescriptor._in18895 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "@in", "Ljava/io/FileDescriptor;");
			global::java.io.FileDescriptor._out18896 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "@out", "Ljava/io/FileDescriptor;");
			global::java.io.FileDescriptor._err18897 = @__env.GetStaticFieldIDNoThrow(global::java.io.FileDescriptor.staticClass, "err", "Ljava/io/FileDescriptor;");
		}
	}
}
