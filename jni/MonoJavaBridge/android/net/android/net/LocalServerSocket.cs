namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalServerSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalServerSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.LocalServerSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.LocalServerSocket(@__env); 
			} 
		} 
		protected LocalServerSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close4637; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.LocalServerSocket._close4637); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._close4637); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept4638; 
		public virtual global::android.net.LocalSocket accept() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocket>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalServerSocket._accept4638)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._accept4638)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor4639; 
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalServerSocket._getFileDescriptor4639)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._getFileDescriptor4639)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress4640; 
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.LocalServerSocket._getLocalSocketAddress4640)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._getLocalSocketAddress4640)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalServerSocket4641; 
		public LocalServerSocket(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._LocalServerSocket4641, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalServerSocket4642; 
		public LocalServerSocket(java.io.FileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalServerSocket.staticClass, global::android.net.LocalServerSocket._LocalServerSocket4642, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.LocalServerSocket.staticClass = @__class; 
			global::android.net.LocalServerSocket._close4637 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "close", "()V"); 
			global::android.net.LocalServerSocket._accept4638 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "accept", "()Landroid/net/LocalSocket;"); 
			global::android.net.LocalServerSocket._getFileDescriptor4639 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::android.net.LocalServerSocket._getLocalSocketAddress4640 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;"); 
			global::android.net.LocalServerSocket._LocalServerSocket4641 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.net.LocalServerSocket._LocalServerSocket4642 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V"); 
		} 
	} 
} 
