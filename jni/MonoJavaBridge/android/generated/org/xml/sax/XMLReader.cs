namespace org.xml.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface XMLReader 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		void parse(java.lang.String arg0);
		void parse(org.xml.sax.InputSource arg0);
		global::org.xml.sax.ContentHandler getContentHandler();
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		void setEntityResolver(org.xml.sax.EntityResolver arg0);
		global::org.xml.sax.EntityResolver getEntityResolver();
		void setDTDHandler(org.xml.sax.DTDHandler arg0);
		global::org.xml.sax.DTDHandler getDTDHandler();
		void setContentHandler(org.xml.sax.ContentHandler arg0);
		void setErrorHandler(org.xml.sax.ErrorHandler arg0);
		global::org.xml.sax.ErrorHandler getErrorHandler();
	}

	public partial class XMLReader_
	{
		public static global::java.lang.Class _class
		{
			get { return __XMLReader.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __XMLReader : java.lang.Object, XMLReader
	{
		internal static global::java.lang.Class staticClass;
		static __XMLReader()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.__XMLReader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xml.sax.__XMLReader(@__env);
			}
		}
		internal __XMLReader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProperty13340;
		 void org.xml.sax.XMLReader.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._setProperty13340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._setProperty13340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProperty13341;
		 global::java.lang.Object org.xml.sax.XMLReader.getProperty(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__XMLReader._getProperty13341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._getProperty13341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13342;
		 void org.xml.sax.XMLReader.parse(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._parse13342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._parse13342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13343;
		 void org.xml.sax.XMLReader.parse(org.xml.sax.InputSource arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._parse13343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._parse13343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentHandler13344;
		 global::org.xml.sax.ContentHandler org.xml.sax.XMLReader.getContentHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.ContentHandler>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__XMLReader._getContentHandler13344));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.ContentHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._getContentHandler13344));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeature13345;
		 void org.xml.sax.XMLReader.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._setFeature13345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._setFeature13345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFeature13346;
		 bool org.xml.sax.XMLReader.getFeature(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xml.sax.__XMLReader._getFeature13346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._getFeature13346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntityResolver13347;
		 void org.xml.sax.XMLReader.setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._setEntityResolver13347, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._setEntityResolver13347, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntityResolver13348;
		 global::org.xml.sax.EntityResolver org.xml.sax.XMLReader.getEntityResolver() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.EntityResolver>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__XMLReader._getEntityResolver13348));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.EntityResolver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._getEntityResolver13348));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDTDHandler13349;
		 void org.xml.sax.XMLReader.setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._setDTDHandler13349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._setDTDHandler13349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDTDHandler13350;
		 global::org.xml.sax.DTDHandler org.xml.sax.XMLReader.getDTDHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.DTDHandler>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__XMLReader._getDTDHandler13350));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.DTDHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._getDTDHandler13350));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentHandler13351;
		 void org.xml.sax.XMLReader.setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._setContentHandler13351, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._setContentHandler13351, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setErrorHandler13352;
		 void org.xml.sax.XMLReader.setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xml.sax.__XMLReader._setErrorHandler13352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._setErrorHandler13352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getErrorHandler13353;
		 global::org.xml.sax.ErrorHandler org.xml.sax.XMLReader.getErrorHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.ErrorHandler>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__XMLReader._getErrorHandler13353));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xml.sax.ErrorHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__XMLReader.staticClass, global::org.xml.sax.__XMLReader._getErrorHandler13353));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.__XMLReader.staticClass = @__class;
			global::org.xml.sax.__XMLReader._setProperty13340 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xml.sax.__XMLReader._getProperty13341 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xml.sax.__XMLReader._parse13342 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.__XMLReader._parse13343 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.__XMLReader._getContentHandler13344 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xml.sax.__XMLReader._setFeature13345 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.setFeature", "(Ljava/lang/String;Z)V");
			global::org.xml.sax.__XMLReader._getFeature13346 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.getFeature", "(Ljava/lang/String;)Z");
			global::org.xml.sax.__XMLReader._setEntityResolver13347 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.__XMLReader._getEntityResolver13348 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xml.sax.__XMLReader._setDTDHandler13349 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.__XMLReader._getDTDHandler13350 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xml.sax.__XMLReader._setContentHandler13351 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xml.sax.__XMLReader._setErrorHandler13352 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.__XMLReader._getErrorHandler13353 = @__env.GetMethodID(global::org.xml.sax.__XMLReader.staticClass, "org.xml.sax.XMLReader.getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
		}
	}
}
