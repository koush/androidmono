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
		internal static global::net.sf.jni4net.jni.MethodId _setProperty14670;
		 void org.xmlpull.v1.XmlSerializer.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setProperty14670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setProperty14670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProperty14671;
		 global::java.lang.Object org.xmlpull.v1.XmlSerializer.getProperty(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getProperty14671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getProperty14671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName14672;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getName14672));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getName14672));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush14673;
		 void org.xmlpull.v1.XmlSerializer.flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._flush14673);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._flush14673);
		}
		internal static global::net.sf.jni4net.jni.MethodId _comment14674;
		 void org.xmlpull.v1.XmlSerializer.comment(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._comment14674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._comment14674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrefix14675;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getPrefix(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getPrefix14675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getPrefix14675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _text14676;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._text14676, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._text14676, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _text14677;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._text14677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._text14677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startDocument14678;
		 void org.xmlpull.v1.XmlSerializer.startDocument(java.lang.String arg0, java.lang.Boolean arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._startDocument14678, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._startDocument14678, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _endDocument14679;
		 void org.xmlpull.v1.XmlSerializer.endDocument() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._endDocument14679);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._endDocument14679);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ignorableWhitespace14680;
		 void org.xmlpull.v1.XmlSerializer.ignorableWhitespace(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._ignorableWhitespace14680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._ignorableWhitespace14680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _processingInstruction14681;
		 void org.xmlpull.v1.XmlSerializer.processingInstruction(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._processingInstruction14681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._processingInstruction14681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeature14682;
		 void org.xmlpull.v1.XmlSerializer.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setFeature14682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setFeature14682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFeature14683;
		 bool org.xmlpull.v1.XmlSerializer.getFeature(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.xmlpull.v1.__XmlSerializer._getFeature14683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getFeature14683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace14684;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getNamespace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._getNamespace14684));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getNamespace14684));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDepth14685;
		 int org.xmlpull.v1.XmlSerializer.getDepth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xmlpull.v1.__XmlSerializer._getDepth14685);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._getDepth14685);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutput14686;
		 void org.xmlpull.v1.XmlSerializer.setOutput(java.io.OutputStream arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setOutput14686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setOutput14686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutput14687;
		 void org.xmlpull.v1.XmlSerializer.setOutput(java.io.Writer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setOutput14687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setOutput14687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPrefix14688;
		 void org.xmlpull.v1.XmlSerializer.setPrefix(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._setPrefix14688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._setPrefix14688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startTag14689;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.startTag(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._startTag14689, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._startTag14689, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attribute14690;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._attribute14690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._attribute14690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _endTag14691;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.endTag(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer._endTag14691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._endTag14691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cdsect14692;
		 void org.xmlpull.v1.XmlSerializer.cdsect(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._cdsect14692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._cdsect14692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _entityRef14693;
		 void org.xmlpull.v1.XmlSerializer.entityRef(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._entityRef14693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._entityRef14693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _docdecl14694;
		 void org.xmlpull.v1.XmlSerializer.docdecl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer._docdecl14694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.xmlpull.v1.__XmlSerializer.staticClass, global::org.xmlpull.v1.__XmlSerializer._docdecl14694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xmlpull.v1.__XmlSerializer.staticClass = @__class;
			global::org.xmlpull.v1.__XmlSerializer._setProperty14670 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.__XmlSerializer._getProperty14671 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.__XmlSerializer._getName14672 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlSerializer._flush14673 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.flush", "()V");
			global::org.xmlpull.v1.__XmlSerializer._comment14674 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.comment", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._getPrefix14675 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlSerializer._text14676 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.text", "([CII)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._text14677 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._startDocument14678 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::org.xmlpull.v1.__XmlSerializer._endDocument14679 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.endDocument", "()V");
			global::org.xmlpull.v1.__XmlSerializer._ignorableWhitespace14680 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.ignorableWhitespace", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._processingInstruction14681 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.processingInstruction", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._setFeature14682 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.__XmlSerializer._getFeature14683 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.__XmlSerializer._getNamespace14684 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.__XmlSerializer._getDepth14685 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.getDepth", "()I");
			global::org.xmlpull.v1.__XmlSerializer._setOutput14686 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._setOutput14687 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setOutput", "(Ljava/io/Writer;)V");
			global::org.xmlpull.v1.__XmlSerializer._setPrefix14688 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._startTag14689 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._attribute14690 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._endTag14691 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.__XmlSerializer._cdsect14692 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.cdsect", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._entityRef14693 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.entityRef", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.__XmlSerializer._docdecl14694 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlSerializer.staticClass, "org.xmlpull.v1.XmlSerializer.docdecl", "(Ljava/lang/String;)V");
		}
	}
}
