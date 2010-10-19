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
		internal static global::MonoJavaBridge.MethodId _valid13417;
		public bool valid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FileDescriptor._valid13417);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._valid13417);
		}
		internal static global::MonoJavaBridge.MethodId _sync13418;
		public void sync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FileDescriptor._sync13418);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._sync13418);
		}
		internal static global::MonoJavaBridge.MethodId _FileDescriptor13419;
		public FileDescriptor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._FileDescriptor13419);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _in13420;
		public static global::java.io.FileDescriptor @in
		{
			get
			{
				return default(global::java.io.FileDescriptor);
			}
		}
		internal static global::MonoJavaBridge.FieldId _out13421;
		public static global::java.io.FileDescriptor @out
		{
			get
			{
				return default(global::java.io.FileDescriptor);
			}
		}
		internal static global::MonoJavaBridge.FieldId _err13422;
		public static global::java.io.FileDescriptor err
		{
			get
			{
				return default(global::java.io.FileDescriptor);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileDescriptor"));
			global::java.io.FileDescriptor._valid13417 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "valid", "()Z");
			global::java.io.FileDescriptor._sync13418 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "sync", "()V");
			global::java.io.FileDescriptor._FileDescriptor13419 = @__env.GetMethodIDNoThrow(global::java.io.FileDescriptor.staticClass, "<init>", "()V");
		}
	}
}
