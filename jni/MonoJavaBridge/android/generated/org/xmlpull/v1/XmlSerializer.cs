namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xmlpull.v1.XmlSerializer_))]
	public partial interface XmlSerializer  : global::MonoJavaBridge.IJavaObject 
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

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xmlpull.v1.XmlSerializer))]
	internal sealed partial class XmlSerializer_ : java.lang.Object, XmlSerializer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlSerializer_()
		{
			InitJNI();
		}
		internal XmlSerializer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35382;
		void org.xmlpull.v1.XmlSerializer.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setProperty35382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setProperty35382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35383;
		global::java.lang.Object org.xmlpull.v1.XmlSerializer.getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getProperty35383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getProperty35383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName35384;
		global::java.lang.String org.xmlpull.v1.XmlSerializer.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getName35384)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getName35384)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flush35385;
		void org.xmlpull.v1.XmlSerializer.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._flush35385);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._flush35385);
		}
		internal static global::MonoJavaBridge.MethodId _comment35386;
		void org.xmlpull.v1.XmlSerializer.comment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._comment35386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._comment35386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix35387;
		global::java.lang.String org.xmlpull.v1.XmlSerializer.getPrefix(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getPrefix35387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getPrefix35387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _text35388;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._text35388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._text35388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _text35389;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._text35389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._text35389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _startDocument35390;
		void org.xmlpull.v1.XmlSerializer.startDocument(java.lang.String arg0, java.lang.Boolean arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._startDocument35390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._startDocument35390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endDocument35391;
		void org.xmlpull.v1.XmlSerializer.endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._endDocument35391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._endDocument35391);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace35392;
		void org.xmlpull.v1.XmlSerializer.ignorableWhitespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._ignorableWhitespace35392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._ignorableWhitespace35392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction35393;
		void org.xmlpull.v1.XmlSerializer.processingInstruction(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._processingInstruction35393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._processingInstruction35393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35394;
		void org.xmlpull.v1.XmlSerializer.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setFeature35394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setFeature35394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35395;
		bool org.xmlpull.v1.XmlSerializer.getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getFeature35395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getFeature35395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35396;
		global::java.lang.String org.xmlpull.v1.XmlSerializer.getNamespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getNamespace35396)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getNamespace35396)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth35397;
		int org.xmlpull.v1.XmlSerializer.getDepth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getDepth35397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getDepth35397);
		}
		internal static global::MonoJavaBridge.MethodId _setOutput35398;
		void org.xmlpull.v1.XmlSerializer.setOutput(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setOutput35398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setOutput35398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOutput35399;
		void org.xmlpull.v1.XmlSerializer.setOutput(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setOutput35399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setOutput35399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix35400;
		void org.xmlpull.v1.XmlSerializer.setPrefix(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setPrefix35400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setPrefix35400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startTag35401;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.startTag(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._startTag35401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._startTag35401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _attribute35402;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._attribute35402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._attribute35402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _endTag35403;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.endTag(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._endTag35403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._endTag35403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _cdsect35404;
		void org.xmlpull.v1.XmlSerializer.cdsect(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._cdsect35404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._cdsect35404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _entityRef35405;
		void org.xmlpull.v1.XmlSerializer.entityRef(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._entityRef35405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._entityRef35405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _docdecl35406;
		void org.xmlpull.v1.XmlSerializer.docdecl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._docdecl35406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._docdecl35406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlSerializer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlSerializer"));
			global::org.xmlpull.v1.XmlSerializer_._setProperty35382 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.XmlSerializer_._getProperty35383 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.XmlSerializer_._getName35384 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlSerializer_._flush35385 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "flush", "()V");
			global::org.xmlpull.v1.XmlSerializer_._comment35386 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "comment", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._getPrefix35387 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlSerializer_._text35388 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "text", "([CII)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._text35389 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._startDocument35390 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::org.xmlpull.v1.XmlSerializer_._endDocument35391 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "endDocument", "()V");
			global::org.xmlpull.v1.XmlSerializer_._ignorableWhitespace35392 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "ignorableWhitespace", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._processingInstruction35393 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "processingInstruction", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._setFeature35394 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.XmlSerializer_._getFeature35395 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.XmlSerializer_._getNamespace35396 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlSerializer_._getDepth35397 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getDepth", "()I");
			global::org.xmlpull.v1.XmlSerializer_._setOutput35398 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._setOutput35399 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setOutput", "(Ljava/io/Writer;)V");
			global::org.xmlpull.v1.XmlSerializer_._setPrefix35400 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._startTag35401 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._attribute35402 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._endTag35403 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._cdsect35404 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "cdsect", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._entityRef35405 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "entityRef", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._docdecl35406 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "docdecl", "(Ljava/lang/String;)V");
		}
	}
}
