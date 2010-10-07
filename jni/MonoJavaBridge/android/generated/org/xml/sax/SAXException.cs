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
		internal static global::net.sf.jni4net.jni.MethodId _getCause14603;
		public override global::java.lang.Throwable getCause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._getCause14603));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Throwable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getCause14603));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString14604;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._toString14604));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._toString14604));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessage14605;
		public override global::java.lang.String getMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._getMessage14605));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getMessage14605));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getException14606;
		public virtual global::java.lang.Exception getException() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Exception>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.SAXException._getException14606));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Exception>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getException14606));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SAXException14607;
		public SAXException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException14607, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SAXException14608;
		public SAXException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException14608, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SAXException14609;
		public SAXException(java.lang.String arg0, java.lang.Exception arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException14609, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SAXException14610;
		public SAXException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException14610, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.SAXException.staticClass = @__class;
			global::org.xml.sax.SAXException._getCause14603 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::org.xml.sax.SAXException._toString14604 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "toString", "()Ljava/lang/String;");
			global::org.xml.sax.SAXException._getMessage14605 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::org.xml.sax.SAXException._getException14606 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "getException", "()Ljava/lang/Exception;");
			global::org.xml.sax.SAXException._SAXException14607 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xml.sax.SAXException._SAXException14608 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::org.xml.sax.SAXException._SAXException14609 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			global::org.xml.sax.SAXException._SAXException14610 = @__env.GetMethodID(global::org.xml.sax.SAXException.staticClass, "<init>", "()V");
		}
	}
}
