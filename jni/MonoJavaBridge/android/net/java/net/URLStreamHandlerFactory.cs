namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface URLStreamHandlerFactory 
	{ 
		global::java.net.URLStreamHandler createURLStreamHandler(java.lang.String arg0); 
	} 

	public partial class URLStreamHandlerFactory_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __URLStreamHandlerFactory.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __URLStreamHandlerFactory : java.lang.Object, URLStreamHandlerFactory
	{ 
		internal static global::java.lang.Class staticClass; 
		static __URLStreamHandlerFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.__URLStreamHandlerFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.__URLStreamHandlerFactory(@__env); 
			} 
		} 
		internal __URLStreamHandlerFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createURLStreamHandler11995; 
		 global::java.net.URLStreamHandler java.net.URLStreamHandlerFactory.createURLStreamHandler(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.__URLStreamHandlerFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URLStreamHandler>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.__URLStreamHandlerFactory._createURLStreamHandler11995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URLStreamHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.__URLStreamHandlerFactory.staticClass, global::java.net.__URLStreamHandlerFactory._createURLStreamHandler11995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.__URLStreamHandlerFactory.staticClass = @__class; 
			global::java.net.__URLStreamHandlerFactory._createURLStreamHandler11995 = @__env.GetMethodID(global::java.net.__URLStreamHandlerFactory.staticClass, "java.net.URLStreamHandlerFactory.createURLStreamHandler", "(Ljava/lang/String;)Ljava/net/URLStreamHandler;"); 
		} 
	} 
} 
