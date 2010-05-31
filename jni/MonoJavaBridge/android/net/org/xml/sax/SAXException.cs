namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SAXException : java.lang.Exception
	{ 
		internal static global::java.lang.Class staticClass; 
		static SAXException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.SAXException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xml.sax.SAXException(@__env); 
			} 
		} 
		protected SAXException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCause13324; 
		public override global::java.lang.Throwable getCause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._getCause13324)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Throwable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getCause13324)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString13325; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._toString13325)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._toString13325)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessage13326; 
		public override global::java.lang.String getMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._getMessage13326)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getMessage13326)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getException13327; 
		public virtual global::java.lang.Exception getException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Exception>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._getException13327)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Exception>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getException13327)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException13328; 
		public SAXException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException13328, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException13329; 
		public SAXException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException13329, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException13330; 
		public SAXException(java.lang.String arg0, java.lang.Exception arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException13330, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException13331; 
		public SAXException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException13331, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.SAXException.staticClass = @__class; 
			global::org.xml.sax.SAXException._getCause13324 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getCause", "()Ljava/lang/Throwable;"); 
			global::org.xml.sax.SAXException._toString13325 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "toString", "()Ljava/lang/String;"); 
			global::org.xml.sax.SAXException._getMessage13326 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getMessage", "()Ljava/lang/String;"); 
			global::org.xml.sax.SAXException._getException13327 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getException", "()Ljava/lang/Exception;"); 
			global::org.xml.sax.SAXException._SAXException13328 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.SAXException._SAXException13329 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/Exception;)V"); 
			global::org.xml.sax.SAXException._SAXException13330 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V"); 
			global::org.xml.sax.SAXException._SAXException13331 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "()V"); 
		} 
	} 
} 
