namespace org.xmlpull.v1
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface XmlSerializer 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		global::java.lang.String getName();
		void flush();
		void comment(java.lang.String arg0);
		global::java.lang.String getPrefix(java.lang.String arg0, bool arg1);
		global::org.xmlpull.v1.XmlSerializer text(char[] arg0, int arg1, int arg2);
		global::org.xmlpull.v1.XmlSerializer text(java.lang.String arg0);
		void startDocument(java.lang.String arg0, java.lang.Boolean arg1);
		void endDocument();
		void ignorableWhitespace(java.lang.String arg0);
		void processingInstruction(java.lang.String arg0);
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		global::java.lang.String getNamespace();
		int getDepth();
		void setOutput(java.io.OutputStream arg0, java.lang.String arg1);
		void setOutput(java.io.Writer arg0);
		void setPrefix(java.lang.String arg0, java.lang.String arg1);
		global::org.xmlpull.v1.XmlSerializer startTag(java.lang.String arg0, java.lang.String arg1);
		global::org.xmlpull.v1.XmlSerializer attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::org.xmlpull.v1.XmlSerializer endTag(java.lang.String arg0, java.lang.String arg1);
		void cdsect(java.lang.String arg0);
		void entityRef(java.lang.String arg0);
		void docdecl(java.lang.String arg0);
	}

	public partial class XmlSerializer_
	{
		public static global::java.lang.Class _class
		{
			get { return __XmlSerializer.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __XmlSerializer : java.lang.Object, XmlSerializer
	{
		internal static global::java.lang.Class staticClass;
		static __XmlSerializer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xmlpull.v1.__XmlSerializer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xmlpull.v1.__XmlSerializer(@__env);
			}
		}
		internal __XmlSerializer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProperty13391;
		 void org.xmlpull.v1.XmlSerializer.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setProperty13391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setProperty13391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProperty13392;
		 global::java.lang.Object org.xmlpull.v1.XmlSerializer.getProperty(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getProperty13392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getProperty13392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13393;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getName13393));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getName13393));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush13394;
		 void org.xmlpull.v1.XmlSerializer.flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._flush13394);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._flush13394);
		}
		internal static global::net.sf.jni4net.jni.MethodId _comment13395;
		 void org.xmlpull.v1.XmlSerializer.comment(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._comment13395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._comment13395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrefix13396;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getPrefix(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getPrefix13396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getPrefix13396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _text13397;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._text13397, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._text13397, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _text13398;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._text13398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._text13398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startDocument13399;
		 void org.xmlpull.v1.XmlSerializer.startDocument(java.lang.String arg0, java.lang.Boolean arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._startDocument13399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._startDocument13399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _endDocument13400;
		 void org.xmlpull.v1.XmlSerializer.endDocument() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._endDocument13400);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._endDocument13400);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ignorableWhitespace13401;
		 void org.xmlpull.v1.XmlSerializer.ignorableWhitespace(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._ignorableWhitespace13401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._ignorableWhitespace13401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _processingInstruction13402;
		 void org.xmlpull.v1.XmlSerializer.processingInstruction(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._processingInstruction13402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._processingInstruction13402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeature13403;
		 void org.xmlpull.v1.XmlSerializer.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setFeature13403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setFeature13403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFeature13404;
		 bool org.xmlpull.v1.XmlSerializer.getFeature(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xmlpull.v1.__XmlSerializer._getFeature13404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getFeature13404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace13405;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getNamespace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getNamespace13405));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getNamespace13405));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDepth13406;
		 int org.xmlpull.v1.XmlSerializer.getDepth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlSerializer._getDepth13406);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getDepth13406);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutput13407;
		 void org.xmlpull.v1.XmlSerializer.setOutput(java.io.OutputStream arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setOutput13407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setOutput13407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutput13408;
		 void org.xmlpull.v1.XmlSerializer.setOutput(java.io.Writer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setOutput13408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setOutput13408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPrefix13409;
		 void org.xmlpull.v1.XmlSerializer.setPrefix(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setPrefix13409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setPrefix13409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startTag13410;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.startTag(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._startTag13410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._startTag13410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attribute13411;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._attribute13411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._attribute13411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _endTag13412;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.endTag(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._endTag13412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._endTag13412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cdsect13413;
		 void org.xmlpull.v1.XmlSerializer.cdsect(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._cdsect13413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._cdsect13413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _entityRef13414;
		 void org.xmlpull.v1.XmlSerializer.entityRef(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._entityRef13414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._entityRef13414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _docdecl13415;
		 void org.xmlpull.v1.XmlSerializer.docdecl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._docdecl13415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._docdecl13415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xmlpull.v1.__XmlSerializer.staticClass = @__class;
			global::org.xmlpull.v1.__XmlSerializer._setProperty13391 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.__XmlSerializer._getProperty13392 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.__XmlSerializer._getName13393 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlSerializer._flush13394 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.flush", "()V");
			global::org.xmlpull.v1.__XmlSerializer._comment13395 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.comment", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._getPrefix13396 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlSerializer._text13397 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.text", "([CII)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._text13398 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._startDocument13399 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::org.xmlpull.v1.__XmlSerializer._endDocument13400 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.endDocument", "()V");
			global::org.xmlpull.v1.__XmlSerializer._ignorableWhitespace13401 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.ignorableWhitespace", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._processingInstruction13402 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.processingInstruction", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._setFeature13403 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.__XmlSerializer._getFeature13404 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.__XmlSerializer._getNamespace13405 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlSerializer._getDepth13406 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getDepth", "()I");
			global::org.xmlpull.v1.__XmlSerializer._setOutput13407 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._setOutput13408 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setOutput", "(Ljava/io/Writer;)V");
			global::org.xmlpull.v1.__XmlSerializer._setPrefix13409 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._startTag13410 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._attribute13411 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._endTag13412 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._cdsect13413 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.cdsect", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._entityRef13414 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.entityRef", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._docdecl13415 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.docdecl", "(Ljava/lang/String;)V");
		}
	}
}
