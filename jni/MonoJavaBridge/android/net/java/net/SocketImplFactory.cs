namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SocketImplFactory 
	{ 
		java.net.SocketImpl createSocketImpl(); 
	} 

	public partial class SocketImplFactory_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SocketImplFactory.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SocketImplFactory : java.lang.Object, SocketImplFactory
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SocketImplFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.__SocketImplFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.__SocketImplFactory(@__env); 
			} 
		} 
		internal __SocketImplFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocketImpl11894; 
		 java.net.SocketImpl java.net.SocketImplFactory.createSocketImpl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.__SocketImplFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketImpl>(@__env, @__env.CallObjectMethodPtr(this, _createSocketImpl11894)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.__SocketImplFactory.staticClass, _createSocketImpl11894)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.__SocketImplFactory.staticClass = @__class; 
			global::java.net.__SocketImplFactory._createSocketImpl11894 = @__env.GetMethodID(global::java.net.__SocketImplFactory.staticClass, "java.net.SocketImplFactory.createSocketImpl", "()Ljava/net/SocketImpl;"); 
		} 
	} 
} 
