namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SocketAddress : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static SocketAddress() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.SocketAddress), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SocketAddress(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SocketAddress11041; 
		public SocketAddress()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.SocketAddress.staticClass, _SocketAddress11041, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.SocketAddress.staticClass = @__class; 
			global::java.net.SocketAddress._SocketAddress11041 = @__env.GetMethodID(global::java.net.SocketAddress.staticClass, "<init>", "()V"); 
		} 
	} 
} 
