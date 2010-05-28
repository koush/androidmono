namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface DatagramSocketImplFactory 
	{ 
		global::java.net.DatagramSocketImpl createDatagramSocketImpl(); 
	} 

	public partial class DatagramSocketImplFactory_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __DatagramSocketImplFactory.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __DatagramSocketImplFactory : java.lang.Object, DatagramSocketImplFactory
	{ 
		internal static global::java.lang.Class staticClass; 
		static __DatagramSocketImplFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.__DatagramSocketImplFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.__DatagramSocketImplFactory(@__env); 
			} 
		} 
		internal __DatagramSocketImplFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createDatagramSocketImpl11737; 
		 global::java.net.DatagramSocketImpl java.net.DatagramSocketImplFactory.createDatagramSocketImpl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.__DatagramSocketImplFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.DatagramSocketImpl>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.__DatagramSocketImplFactory._createDatagramSocketImpl11737)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.DatagramSocketImpl>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.__DatagramSocketImplFactory.staticClass, global::java.net.__DatagramSocketImplFactory._createDatagramSocketImpl11737)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.__DatagramSocketImplFactory.staticClass = @__class; 
			global::java.net.__DatagramSocketImplFactory._createDatagramSocketImpl11737 = @__env.GetMethodID(global::java.net.__DatagramSocketImplFactory.staticClass, "java.net.DatagramSocketImplFactory.createDatagramSocketImpl", "()Ljava/net/DatagramSocketImpl;"); 
		} 
	} 
} 
