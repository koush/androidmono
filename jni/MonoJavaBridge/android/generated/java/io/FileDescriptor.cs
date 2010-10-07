namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class FileDescriptor : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FileDescriptor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.FileDescriptor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.io.FileDescriptor(@__env);
			}
		}
		internal FileDescriptor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _valid12107;
		public bool valid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.FileDescriptor._valid12107);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._valid12107);
		}
		internal static global::net.sf.jni4net.jni.MethodId _sync12108;
		public void sync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.FileDescriptor._sync12108);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._sync12108);
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileDescriptor12109;
		public FileDescriptor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.FileDescriptor.staticClass, global::java.io.FileDescriptor._FileDescriptor12109, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _in12110;
		public static global::java.io.FileDescriptor @in
		{
			get
			{
				return default(global::java.io.FileDescriptor);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _out12111;
		public static global::java.io.FileDescriptor @out
		{
			get
			{
				return default(global::java.io.FileDescriptor);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _err12112;
		public static global::java.io.FileDescriptor err
		{
			get
			{
				return default(global::java.io.FileDescriptor);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.FileDescriptor.staticClass = @__class;
			global::java.io.FileDescriptor._valid12107 = @__env.GetMethodID(global::java.io.FileDescriptor.staticClass, "valid", "()Z");
			global::java.io.FileDescriptor._sync12108 = @__env.GetMethodID(global::java.io.FileDescriptor.staticClass, "sync", "()V");
			global::java.io.FileDescriptor._FileDescriptor12109 = @__env.GetMethodID(global::java.io.FileDescriptor.staticClass, "<init>", "()V");
		}
	}
}
