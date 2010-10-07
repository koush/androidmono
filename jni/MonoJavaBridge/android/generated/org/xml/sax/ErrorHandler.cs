namespace org.xml.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ErrorHandler 
	{
		void fatalError(org.xml.sax.SAXParseException arg0);
		void error(org.xml.sax.SAXParseException arg0);
		void warning(org.xml.sax.SAXParseException arg0);
	}

	public partial class ErrorHandler_
	{
		public static global::java.lang.Class _class
		{
			get { return __ErrorHandler.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ErrorHandler : java.lang.Object, ErrorHandler
	{
		internal static global::java.lang.Class staticClass;
		static __ErrorHandler()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.__ErrorHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xml.sax.__ErrorHandler(@__env);
			}
		}
		internal __ErrorHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _fatalError14582;
		 void org.xml.sax.ErrorHandler.fatalError(org.xml.sax.SAXParseException arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__ErrorHandler._fatalError14582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__ErrorHandler.staticClass, global::org.xml.sax.__ErrorHandler._fatalError14582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _error14583;
		 void org.xml.sax.ErrorHandler.error(org.xml.sax.SAXParseException arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__ErrorHandler._error14583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__ErrorHandler.staticClass, global::org.xml.sax.__ErrorHandler._error14583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _warning14584;
		 void org.xml.sax.ErrorHandler.warning(org.xml.sax.SAXParseException arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__ErrorHandler._warning14584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__ErrorHandler.staticClass, global::org.xml.sax.__ErrorHandler._warning14584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.__ErrorHandler.staticClass = @__class;
			global::org.xml.sax.__ErrorHandler._fatalError14582 = @__env.GetMethodID(global::org.xml.sax.__ErrorHandler.staticClass, "org.xml.sax.ErrorHandler.fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.__ErrorHandler._error14583 = @__env.GetMethodID(global::org.xml.sax.__ErrorHandler.staticClass, "org.xml.sax.ErrorHandler.error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.__ErrorHandler._warning14584 = @__env.GetMethodID(global::org.xml.sax.__ErrorHandler.staticClass, "org.xml.sax.ErrorHandler.warning", "(Lorg/xml/sax/SAXParseException;)V");
		}
	}
}
