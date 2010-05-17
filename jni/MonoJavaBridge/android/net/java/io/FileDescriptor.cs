namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class FileDescriptor : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static FileDescriptor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.io.FileDescriptor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _valid10567; 
		public bool valid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileDescriptor)) 
				return @__env.CallBooleanMethod(this, _valid10567); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.io.FileDescriptor.staticClass, _valid10567); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sync10568; 
		public void sync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.io.FileDescriptor)) 
				@__env.CallVoidMethod(this, _sync10568); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.io.FileDescriptor.staticClass, _sync10568); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileDescriptor10569; 
		public FileDescriptor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.io.FileDescriptor.staticClass, _FileDescriptor10569, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _in10570; 
		public static java.io.FileDescriptor @in
		{ 
			get 
			{ 
				return default(java.io.FileDescriptor); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _out10571; 
		public static java.io.FileDescriptor @out
		{ 
			get 
			{ 
				return default(java.io.FileDescriptor); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _err10572; 
		public static java.io.FileDescriptor err
		{ 
			get 
			{ 
				return default(java.io.FileDescriptor); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.FileDescriptor.staticClass = @__class; 
			global::java.io.FileDescriptor._valid10567 = @__env.GetMethodID(global::java.io.FileDescriptor.staticClass, "valid", "()Z"); 
			global::java.io.FileDescriptor._sync10568 = @__env.GetMethodID(global::java.io.FileDescriptor.staticClass, "sync", "()V"); 
			global::java.io.FileDescriptor._FileDescriptor10569 = @__env.GetMethodID(global::java.io.FileDescriptor.staticClass, "<init>", "()V"); 
		} 
	} 
} 
