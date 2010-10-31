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
		internal Document_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.w3c.dom.DocumentType org.w3c.dom.Document.getDoctype()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DocumentType>(this, global::org.w3c.dom.Document_.staticClass, "getDoctype", "()Lorg/w3c/dom/DocumentType;", ref global::org.w3c.dom.Document_._m0) as org.w3c.dom.DocumentType;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.DOMImplementation org.w3c.dom.Document.getImplementation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMImplementation>(this, global::org.w3c.dom.Document_.staticClass, "getImplementation", "()Lorg/w3c/dom/DOMImplementation;", ref global::org.w3c.dom.Document_._m1) as org.w3c.dom.DOMImplementation;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.w3c.dom.Document.getInputEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getInputEncoding", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.w3c.dom.Element org.w3c.dom.Document.getDocumentElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "getDocumentElement", "()Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._m3) as org.w3c.dom.Element;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.w3c.dom.Element org.w3c.dom.Document.createElement(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "createElement", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Element;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.w3c.dom.DocumentFragment org.w3c.dom.Document.createDocumentFragment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DocumentFragment>(this, global::org.w3c.dom.Document_.staticClass, "createDocumentFragment", "()Lorg/w3c/dom/DocumentFragment;", ref global::org.w3c.dom.Document_._m5) as org.w3c.dom.DocumentFragment;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.w3c.dom.Text org.w3c.dom.Document.createTextNode(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Text>(this, global::org.w3c.dom.Document_.staticClass, "createTextNode", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", ref global::org.w3c.dom.Document_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Text;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.w3c.dom.Comment org.w3c.dom.Document.createComment(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Comment>(this, global::org.w3c.dom.Document_.staticClass, "createComment", "(Ljava/lang/String;)Lorg/w3c/dom/Comment;", ref global::org.w3c.dom.Document_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Comment;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::org.w3c.dom.CDATASection org.w3c.dom.Document.createCDATASection(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.CDATASection>(this, global::org.w3c.dom.Document_.staticClass, "createCDATASection", "(Ljava/lang/String;)Lorg/w3c/dom/CDATASection;", ref global::org.w3c.dom.Document_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.CDATASection;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::org.w3c.dom.ProcessingInstruction org.w3c.dom.Document.createProcessingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ProcessingInstruction>(this, global::org.w3c.dom.Document_.staticClass, "createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ProcessingInstruction;", ref global::org.w3c.dom.Document_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.ProcessingInstruction;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::org.w3c.dom.Attr org.w3c.dom.Document.createAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Document_.staticClass, "createAttribute", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Document_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::org.w3c.dom.EntityReference org.w3c.dom.Document.createEntityReference(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.EntityReference>(this, global::org.w3c.dom.Document_.staticClass, "createEntityReference", "(Ljava/lang/String;)Lorg/w3c/dom/EntityReference;", ref global::org.w3c.dom.Document_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.EntityReference;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Document_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Document_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::org.w3c.dom.Node org.w3c.dom.Document.importNode(org.w3c.dom.Node arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "importNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::org.w3c.dom.Element org.w3c.dom.Document.createElementNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "createElementNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Element;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::org.w3c.dom.Attr org.w3c.dom.Document.createAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Document_.staticClass, "createAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Document_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Document_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Document_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::org.w3c.dom.Element org.w3c.dom.Document.getElementById(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Element>(this, global::org.w3c.dom.Document_.staticClass, "getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", ref global::org.w3c.dom.Document_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Element;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String org.w3c.dom.Document.getXmlEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getXmlEncoding", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool org.w3c.dom.Document.getXmlStandalone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "getXmlStandalone", "()Z", ref global::org.w3c.dom.Document_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void org.w3c.dom.Document.setXmlStandalone(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setXmlStandalone", "(Z)V", ref global::org.w3c.dom.Document_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::java.lang.String org.w3c.dom.Document.getXmlVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getXmlVersion", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void org.w3c.dom.Document.setXmlVersion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setXmlVersion", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool org.w3c.dom.Document.getStrictErrorChecking()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "getStrictErrorChecking", "()Z", ref global::org.w3c.dom.Document_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void org.w3c.dom.Document.setStrictErrorChecking(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setStrictErrorChecking", "(Z)V", ref global::org.w3c.dom.Document_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.lang.String org.w3c.dom.Document.getDocumentURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getDocumentURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m25) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void org.w3c.dom.Document.setDocumentURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setDocumentURI", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		global::org.w3c.dom.Node org.w3c.dom.Document.adoptNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "adoptNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.Document.getDomConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMConfiguration>(this, global::org.w3c.dom.Document_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", ref global::org.w3c.dom.Document_._m28) as org.w3c.dom.DOMConfiguration;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void org.w3c.dom.Document.normalizeDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "normalizeDocument", "()V", ref global::org.w3c.dom.Document_._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::org.w3c.dom.Node org.w3c.dom.Document.renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "renameNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "normalize", "()V", ref global::org.w3c.dom.Document_._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Document_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.Document_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.Document_._m33) as org.w3c.dom.NamedNodeMap;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m34) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m35) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Document_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.Document_._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m37) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m38) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m39) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m40) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.Document_._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m42) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.Document_._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Document_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Document_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Document_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.Document_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Document_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Document_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m49) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Document_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Document_._m50) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m51) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m52) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.Document_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.Document_._m53) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m57;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m58;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Document_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Document_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m59;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m59) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m60;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Document_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.Document_._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.Document_._m61) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m62;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Document_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Document_._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Document_._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Document_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m65;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Document_._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Document_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Document_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m67;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Document_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Document_._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Document_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Document_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Document"));
		}
	}
}
