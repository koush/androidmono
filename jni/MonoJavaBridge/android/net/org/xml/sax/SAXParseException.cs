namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SAXParseException : org.xml.sax.SAXException
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SAXParseException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(org.xml.sax.SAXParseException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xml.sax.SAXParseException(@__env); 
			} 
		} 
		protected SAXParseException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber12199; 
		public virtual int getLineNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXParseException)) 
				return @__env.CallIntMethod(this, _getLineNumber12199); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xml.sax.SAXParseException.staticClass, _getLineNumber12199); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPublicId12200; 
		public virtual java.lang.String getPublicId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXParseException)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPublicId12200)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.SAXParseException.staticClass, _getPublicId12200)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId12201; 
		public virtual java.lang.String getSystemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXParseException)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSystemId12201)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.SAXParseException.staticClass, _getSystemId12201)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber12202; 
		public virtual int getColumnNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXParseException)) 
				return @__env.CallIntMethod(this, _getColumnNumber12202); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xml.sax.SAXParseException.staticClass, _getColumnNumber12202); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXParseException12203; 
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXParseException.staticClass, _SAXParseException12203, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXParseException12204; 
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1, java.lang.Exception arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXParseException.staticClass, _SAXParseException12204, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXParseException12205; 
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXParseException.staticClass, _SAXParseException12205, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXParseException12206; 
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, java.lang.Exception arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXParseException.staticClass, _SAXParseException12206, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.SAXParseException.staticClass = @__class; 
			global::org.xml.sax.SAXParseException._getLineNumber12199 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "getLineNumber", "()I"); 
			global::org.xml.sax.SAXParseException._getPublicId12200 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "getPublicId", "()Ljava/lang/String;"); 
			global::org.xml.sax.SAXParseException._getSystemId12201 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "getSystemId", "()Ljava/lang/String;"); 
			global::org.xml.sax.SAXParseException._getColumnNumber12202 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "getColumnNumber", "()I"); 
			global::org.xml.sax.SAXParseException._SAXParseException12203 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V"); 
			global::org.xml.sax.SAXParseException._SAXParseException12204 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V"); 
			global::org.xml.sax.SAXParseException._SAXParseException12205 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V"); 
			global::org.xml.sax.SAXParseException._SAXParseException12206 = @__env.GetMethodID(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V"); 
		} 
	} 
} 
