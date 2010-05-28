namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface DTDHandler 
	{ 
		void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3); 
		void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2); 
	} 

	public partial class DTDHandler_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __DTDHandler.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __DTDHandler : java.lang.Object, DTDHandler
	{ 
		internal static global::java.lang.Class staticClass; 
		static __DTDHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.__DTDHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xml.sax.__DTDHandler(@__env); 
			} 
		} 
		internal __DTDHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unparsedEntityDecl13300; 
		 void org.xml.sax.DTDHandler.unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__DTDHandler)) 
				@__env.CallVoidMethod(this, global::org.xml.sax.__DTDHandler._unparsedEntityDecl13300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__DTDHandler.staticClass, global::org.xml.sax.__DTDHandler._unparsedEntityDecl13300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notationDecl13301; 
		 void org.xml.sax.DTDHandler.notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__DTDHandler)) 
				@__env.CallVoidMethod(this, global::org.xml.sax.__DTDHandler._notationDecl13301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__DTDHandler.staticClass, global::org.xml.sax.__DTDHandler._notationDecl13301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.__DTDHandler.staticClass = @__class; 
			global::org.xml.sax.__DTDHandler._unparsedEntityDecl13300 = @__env.GetMethodID(global::org.xml.sax.__DTDHandler.staticClass, "org.xml.sax.DTDHandler.unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::org.xml.sax.__DTDHandler._notationDecl13301 = @__env.GetMethodID(global::org.xml.sax.__DTDHandler.staticClass, "org.xml.sax.DTDHandler.notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
		} 
	} 
} 
