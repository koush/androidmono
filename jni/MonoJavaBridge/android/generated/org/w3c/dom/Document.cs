namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Document_))]
	public partial interface Document : Node
	{
		global::org.w3c.dom.DocumentType getDoctype();
		global::org.w3c.dom.DOMImplementation getImplementation();
		global::java.lang.String getInputEncoding();
		global::org.w3c.dom.Element getDocumentElement();
		global::org.w3c.dom.Element createElement(java.lang.String arg0);
		global::org.w3c.dom.DocumentFragment createDocumentFragment();
		global::org.w3c.dom.Text createTextNode(java.lang.String arg0);
		global::org.w3c.dom.Comment createComment(java.lang.String arg0);
		global::org.w3c.dom.CDATASection createCDATASection(java.lang.String arg0);
		global::org.w3c.dom.ProcessingInstruction createProcessingInstruction(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr createAttribute(java.lang.String arg0);
		global::org.w3c.dom.EntityReference createEntityReference(java.lang.String arg0);
		global::org.w3c.dom.NodeList getElementsByTagName(java.lang.String arg0);
		global::org.w3c.dom.Node importNode(org.w3c.dom.Node arg0, bool arg1);
		global::org.w3c.dom.Element createElementNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr createAttributeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.NodeList getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Element getElementById(java.lang.String arg0);
		global::java.lang.String getXmlEncoding();
		bool getXmlStandalone();
		void setXmlStandalone(bool arg0);
		global::java.lang.String getXmlVersion();
		void setXmlVersion(java.lang.String arg0);
		bool getStrictErrorChecking();
		void setStrictErrorChecking(bool arg0);
		global::java.lang.String getDocumentURI();
		void setDocumentURI(java.lang.String arg0);
		global::org.w3c.dom.Node adoptNode(org.w3c.dom.Node arg0);
		global::org.w3c.dom.DOMConfiguration getDomConfig();
		void normalizeDocument();
		global::org.w3c.dom.Node renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Document))]
	internal sealed partial class Document_ : java.lang.Object, Document
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Document_()
		{
			InitJNI();
		}
		internal Document_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDoctype34385;
		 global::org.w3c.dom.DocumentType org.w3c.dom.Document.getDoctype() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentType>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDoctype34385)) as org.w3c.dom.DocumentType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDoctype34385)) as org.w3c.dom.DocumentType;
		}
		internal static global::MonoJavaBridge.MethodId _getImplementation34386;
		 global::org.w3c.dom.DOMImplementation org.w3c.dom.Document.getImplementation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getImplementation34386)) as org.w3c.dom.DOMImplementation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getImplementation34386)) as org.w3c.dom.DOMImplementation;
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding34387;
		 global::java.lang.String org.w3c.dom.Document.getInputEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getInputEncoding34387)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getInputEncoding34387)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDocumentElement34388;
		 global::org.w3c.dom.Element org.w3c.dom.Document.getDocumentElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDocumentElement34388)) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDocumentElement34388)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createElement34389;
		 global::org.w3c.dom.Element org.w3c.dom.Document.createElement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createElement34389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createElement34389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createDocumentFragment34390;
		 global::org.w3c.dom.DocumentFragment org.w3c.dom.Document.createDocumentFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentFragment>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createDocumentFragment34390)) as org.w3c.dom.DocumentFragment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentFragment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createDocumentFragment34390)) as org.w3c.dom.DocumentFragment;
		}
		internal static global::MonoJavaBridge.MethodId _createTextNode34391;
		 global::org.w3c.dom.Text org.w3c.dom.Document.createTextNode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createTextNode34391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createTextNode34391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _createComment34392;
		 global::org.w3c.dom.Comment org.w3c.dom.Document.createComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Comment>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createComment34392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Comment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Comment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createComment34392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Comment;
		}
		internal static global::MonoJavaBridge.MethodId _createCDATASection34393;
		 global::org.w3c.dom.CDATASection org.w3c.dom.Document.createCDATASection(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.CDATASection>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createCDATASection34393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.CDATASection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.CDATASection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createCDATASection34393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.CDATASection;
		}
		internal static global::MonoJavaBridge.MethodId _createProcessingInstruction34394;
		 global::org.w3c.dom.ProcessingInstruction org.w3c.dom.Document.createProcessingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ProcessingInstruction>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createProcessingInstruction34394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.ProcessingInstruction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ProcessingInstruction>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createProcessingInstruction34394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.ProcessingInstruction;
		}
		internal static global::MonoJavaBridge.MethodId _createAttribute34395;
		 global::org.w3c.dom.Attr org.w3c.dom.Document.createAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createAttribute34395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createAttribute34395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _createEntityReference34396;
		 global::org.w3c.dom.EntityReference org.w3c.dom.Document.createEntityReference(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.EntityReference>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createEntityReference34396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.EntityReference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.EntityReference>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createEntityReference34396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.EntityReference;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagName34397;
		 global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getElementsByTagName34397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getElementsByTagName34397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _importNode34398;
		 global::org.w3c.dom.Node org.w3c.dom.Document.importNode(org.w3c.dom.Node arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._importNode34398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._importNode34398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _createElementNS34399;
		 global::org.w3c.dom.Element org.w3c.dom.Document.createElementNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createElementNS34399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createElementNS34399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createAttributeNS34400;
		 global::org.w3c.dom.Attr org.w3c.dom.Document.createAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createAttributeNS34400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createAttributeNS34400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagNameNS34401;
		 global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getElementsByTagNameNS34401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getElementsByTagNameNS34401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getElementById34402;
		 global::org.w3c.dom.Element org.w3c.dom.Document.getElementById(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getElementById34402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getElementById34402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlEncoding34403;
		 global::java.lang.String org.w3c.dom.Document.getXmlEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getXmlEncoding34403)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getXmlEncoding34403)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlStandalone34404;
		 bool org.w3c.dom.Document.getXmlStandalone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._getXmlStandalone34404);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getXmlStandalone34404);
		}
		internal static global::MonoJavaBridge.MethodId _setXmlStandalone34405;
		 void org.w3c.dom.Document.setXmlStandalone(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setXmlStandalone34405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setXmlStandalone34405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXmlVersion34406;
		 global::java.lang.String org.w3c.dom.Document.getXmlVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getXmlVersion34406)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getXmlVersion34406)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setXmlVersion34407;
		 void org.w3c.dom.Document.setXmlVersion(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setXmlVersion34407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setXmlVersion34407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStrictErrorChecking34408;
		 bool org.w3c.dom.Document.getStrictErrorChecking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._getStrictErrorChecking34408);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getStrictErrorChecking34408);
		}
		internal static global::MonoJavaBridge.MethodId _setStrictErrorChecking34409;
		 void org.w3c.dom.Document.setStrictErrorChecking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setStrictErrorChecking34409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setStrictErrorChecking34409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDocumentURI34410;
		 global::java.lang.String org.w3c.dom.Document.getDocumentURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDocumentURI34410)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDocumentURI34410)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentURI34411;
		 void org.w3c.dom.Document.setDocumentURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setDocumentURI34411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setDocumentURI34411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adoptNode34412;
		 global::org.w3c.dom.Node org.w3c.dom.Document.adoptNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._adoptNode34412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._adoptNode34412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34413;
		 global::org.w3c.dom.DOMConfiguration org.w3c.dom.Document.getDomConfig() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDomConfig34413)) as org.w3c.dom.DOMConfiguration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDomConfig34413)) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _normalizeDocument34414;
		 void org.w3c.dom.Document.normalizeDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._normalizeDocument34414);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._normalizeDocument34414);
		}
		internal static global::MonoJavaBridge.MethodId _renameNode34415;
		 global::org.w3c.dom.Node org.w3c.dom.Document.renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._renameNode34415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._renameNode34415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _normalize34416;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._normalize34416);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._normalize34416);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34417;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isSupported34417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isSupported34417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34418;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getAttributes34418)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getAttributes34418)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34419;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getPrefix34419)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getPrefix34419)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34420;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getFirstChild34420)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getFirstChild34420)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34421;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNodeType34421);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNodeType34421);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34422;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNodeName34422)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNodeName34422)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34423;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNodeValue34423)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNodeValue34423)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34424;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNextSibling34424)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNextSibling34424)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34425;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getLocalName34425)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getLocalName34425)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34426;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._hasAttributes34426);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._hasAttributes34426);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34427;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNamespaceURI34427)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNamespaceURI34427)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34428;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._hasChildNodes34428);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._hasChildNodes34428);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34429;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getUserData34429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getUserData34429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34430;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._setUserData34430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setUserData34430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34431;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getFeature34431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getFeature34431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34432;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setPrefix34432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setPrefix34432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34433;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setNodeValue34433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setNodeValue34433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34434;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getParentNode34434)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getParentNode34434)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34435;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getChildNodes34435)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getChildNodes34435)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34436;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getLastChild34436)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getLastChild34436)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34437;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getPreviousSibling34437)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getPreviousSibling34437)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34438;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getOwnerDocument34438)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getOwnerDocument34438)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34439;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._insertBefore34439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._insertBefore34439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34440;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._replaceChild34440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._replaceChild34440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34441;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._removeChild34441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._removeChild34441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34442;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._appendChild34442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._appendChild34442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34443;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._cloneNode34443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._cloneNode34443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34444;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getBaseURI34444)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getBaseURI34444)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34445;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Document_._compareDocumentPosition34445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._compareDocumentPosition34445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34446;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getTextContent34446)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getTextContent34446)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34447;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setTextContent34447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setTextContent34447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34448;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isSameNode34448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isSameNode34448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34449;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._lookupPrefix34449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._lookupPrefix34449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34450;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isDefaultNamespace34450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isDefaultNamespace34450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34451;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._lookupNamespaceURI34451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._lookupNamespaceURI34451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34452;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isEqualNode34452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isEqualNode34452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Document_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Document"));
			global::org.w3c.dom.Document_._getDoctype34385 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDoctype", "()Lorg/w3c/dom/DocumentType;");
			global::org.w3c.dom.Document_._getImplementation34386 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getImplementation", "()Lorg/w3c/dom/DOMImplementation;");
			global::org.w3c.dom.Document_._getInputEncoding34387 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getDocumentElement34388 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDocumentElement", "()Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._createElement34389 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createElement", "(Ljava/lang/String;)Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._createDocumentFragment34390 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createDocumentFragment", "()Lorg/w3c/dom/DocumentFragment;");
			global::org.w3c.dom.Document_._createTextNode34391 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createTextNode", "(Ljava/lang/String;)Lorg/w3c/dom/Text;");
			global::org.w3c.dom.Document_._createComment34392 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createComment", "(Ljava/lang/String;)Lorg/w3c/dom/Comment;");
			global::org.w3c.dom.Document_._createCDATASection34393 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createCDATASection", "(Ljava/lang/String;)Lorg/w3c/dom/CDATASection;");
			global::org.w3c.dom.Document_._createProcessingInstruction34394 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ProcessingInstruction;");
			global::org.w3c.dom.Document_._createAttribute34395 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createAttribute", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Document_._createEntityReference34396 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createEntityReference", "(Ljava/lang/String;)Lorg/w3c/dom/EntityReference;");
			global::org.w3c.dom.Document_._getElementsByTagName34397 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Document_._importNode34398 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "importNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._createElementNS34399 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createElementNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._createAttributeNS34400 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Document_._getElementsByTagNameNS34401 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Document_._getElementById34402 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._getXmlEncoding34403 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getXmlEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getXmlStandalone34404 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getXmlStandalone", "()Z");
			global::org.w3c.dom.Document_._setXmlStandalone34405 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setXmlStandalone", "(Z)V");
			global::org.w3c.dom.Document_._getXmlVersion34406 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getXmlVersion", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._setXmlVersion34407 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setXmlVersion", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._getStrictErrorChecking34408 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getStrictErrorChecking", "()Z");
			global::org.w3c.dom.Document_._setStrictErrorChecking34409 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setStrictErrorChecking", "(Z)V");
			global::org.w3c.dom.Document_._getDocumentURI34410 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDocumentURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._setDocumentURI34411 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setDocumentURI", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._adoptNode34412 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "adoptNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getDomConfig34413 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;");
			global::org.w3c.dom.Document_._normalizeDocument34414 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "normalizeDocument", "()V");
			global::org.w3c.dom.Document_._renameNode34415 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "renameNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._normalize34416 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Document_._isSupported34417 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Document_._getAttributes34418 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Document_._getPrefix34419 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getFirstChild34420 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getNodeType34421 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Document_._getNodeName34422 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getNodeValue34423 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getNextSibling34424 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getLocalName34425 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._hasAttributes34426 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Document_._getNamespaceURI34427 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._hasChildNodes34428 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Document_._getUserData34429 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Document_._setUserData34430 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Document_._getFeature34431 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Document_._setPrefix34432 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._setNodeValue34433 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._getParentNode34434 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getChildNodes34435 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Document_._getLastChild34436 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getPreviousSibling34437 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getOwnerDocument34438 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Document_._insertBefore34439 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._replaceChild34440 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._removeChild34441 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._appendChild34442 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._cloneNode34443 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getBaseURI34444 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._compareDocumentPosition34445 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Document_._getTextContent34446 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._setTextContent34447 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._isSameNode34448 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Document_._lookupPrefix34449 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Document_._isDefaultNamespace34450 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Document_._lookupNamespaceURI34451 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Document_._isEqualNode34452 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
