namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SAXException : java.lang.Exception
	{ 
		internal static global::java.lang.Class staticClass; 
		static SAXException() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(org.xml.sax.SAXException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getCause12191; 
		public override java.lang.Throwable getCause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXException)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, _getCause12191)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Throwable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.SAXException.staticClass, _getCause12191)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12192; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXException)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12192)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.SAXException.staticClass, _toString12192)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessage12193; 
		public override java.lang.String getMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXException)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getMessage12193)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.SAXException.staticClass, _getMessage12193)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getException12194; 
		public virtual java.lang.Exception getException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.SAXException)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Exception>(@__env, @__env.CallObjectMethodPtr(this, _getException12194)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Exception>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xml.sax.SAXException.staticClass, _getException12194)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException12195; 
		public SAXException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, _SAXException12195, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException12196; 
		public SAXException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, _SAXException12196, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException12197; 
		public SAXException(java.lang.String arg0, java.lang.Exception arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, _SAXException12197, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SAXException12198; 
		public SAXException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(org.xml.sax.SAXException.staticClass, _SAXException12198, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.SAXException.staticClass = @__class; 
			global::org.xml.sax.SAXException._getCause12191 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getCause", "()Ljava/lang/Throwable;"); 
			global::org.xml.sax.SAXException._toString12192 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "toString", "()Ljava/lang/String;"); 
			global::org.xml.sax.SAXException._getMessage12193 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getMessage", "()Ljava/lang/String;"); 
			global::org.xml.sax.SAXException._getException12194 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getException", "()Ljava/lang/Exception;"); 
			global::org.xml.sax.SAXException._SAXException12195 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.SAXException._SAXException12196 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/Exception;)V"); 
			global::org.xml.sax.SAXException._SAXException12197 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V"); 
			global::org.xml.sax.SAXException._SAXException12198 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "()V"); 
		} 
	} 
} 
