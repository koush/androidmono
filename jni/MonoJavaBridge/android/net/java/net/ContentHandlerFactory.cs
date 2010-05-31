namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ContentHandlerFactory 
	{ 
		global::java.net.ContentHandler createContentHandler(java.lang.String arg0); 
	} 

	public partial class ContentHandlerFactory_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ContentHandlerFactory.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ContentHandlerFactory : java.lang.Object, ContentHandlerFactory
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ContentHandlerFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.__ContentHandlerFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.__ContentHandlerFactory(@__env); 
			} 
		} 
		internal __ContentHandlerFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createContentHandler11661; 
		 global::java.net.ContentHandler java.net.ContentHandlerFactory.createContentHandler(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.ContentHandler>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.__ContentHandlerFactory._createContentHandler11661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.ContentHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.__ContentHandlerFactory.staticClass, global::java.net.__ContentHandlerFactory._createContentHandler11661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.__ContentHandlerFactory.staticClass = @__class; 
			global::java.net.__ContentHandlerFactory._createContentHandler11661 = @__env.GetMethodID(global::java.net.__ContentHandlerFactory.staticClass, "java.net.ContentHandlerFactory.createContentHandler", "(Ljava/lang/String;)Ljava/net/ContentHandler;"); 
		} 
	} 
} 
