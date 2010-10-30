namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Node_))]
	public partial interface Node  : global::MonoJavaBridge.IJavaObject 
	{
		void normalize();
		bool isSupported(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.NamedNodeMap getAttributes();
		global::java.lang.String getPrefix();
		global::org.w3c.dom.Node getFirstChild();
		short getNodeType();
		global::java.lang.String getNodeName();
		global::java.lang.String getNodeValue();
		global::org.w3c.dom.Node getNextSibling();
		global::java.lang.String getLocalName();
		bool hasAttributes();
		global::java.lang.String getNamespaceURI();
		bool hasChildNodes();
		global::java.lang.Object getUserData(java.lang.String arg0);
		global::java.lang.Object setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2);
		global::java.lang.Object getFeature(java.lang.String arg0, java.lang.String arg1);
		void setPrefix(java.lang.String arg0);
		void setNodeValue(java.lang.String arg0);
		global::org.w3c.dom.Node getParentNode();
		global::org.w3c.dom.NodeList getChildNodes();
		global::org.w3c.dom.Node getLastChild();
		global::org.w3c.dom.Node getPreviousSibling();
		global::org.w3c.dom.Document getOwnerDocument();
		global::org.w3c.dom.Node insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1);
		global::org.w3c.dom.Node replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1);
		global::org.w3c.dom.Node removeChild(org.w3c.dom.Node arg0);
		global::org.w3c.dom.Node appendChild(org.w3c.dom.Node arg0);
		global::org.w3c.dom.Node cloneNode(bool arg0);
		global::java.lang.String getBaseURI();
		short compareDocumentPosition(org.w3c.dom.Node arg0);
		global::java.lang.String getTextContent();
		void setTextContent(java.lang.String arg0);
		bool isSameNode(org.w3c.dom.Node arg0);
		global::java.lang.String lookupPrefix(java.lang.String arg0);
		bool isDefaultNamespace(java.lang.String arg0);
		global::java.lang.String lookupNamespaceURI(java.lang.String arg0);
		bool isEqualNode(org.w3c.dom.Node arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Node))]
	internal sealed partial class Node_ : java.lang.Object, Node
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Node_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _normalize34684;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Node_.staticClass, "normalize", "()V", ref global::org.w3c.dom.Node_._normalize34684);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34685;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Node_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Node_._isSupported34685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34686;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.Node_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.Node_._getAttributes34686) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34687;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getPrefix34687) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34688;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._getFirstChild34688) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34689;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Node_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.Node_._getNodeType34689);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34690;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getNodeName34690) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34691;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getNodeValue34691) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34692;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._getNextSibling34692) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34693;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getLocalName34693) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34694;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Node_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.Node_._hasAttributes34694);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34695;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getNamespaceURI34695) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34696;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Node_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.Node_._hasChildNodes34696);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34697;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Node_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Node_._getUserData34697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34698;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Node_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.Node_._setUserData34698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34699;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Node_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Node_._getFeature34699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34700;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Node_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Node_._setPrefix34700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34701;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Node_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Node_._setNodeValue34701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34702;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._getParentNode34702) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34703;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Node_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Node_._getChildNodes34703) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34704;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._getLastChild34704) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34705;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._getPreviousSibling34705) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34706;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.Node_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.Node_._getOwnerDocument34706) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34707;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._insertBefore34707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34708;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._replaceChild34708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34709;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._removeChild34709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34710;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._appendChild34710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34711;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Node_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Node_._cloneNode34711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34712;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getBaseURI34712) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34713;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Node_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.Node_._compareDocumentPosition34713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34714;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.Node_._getTextContent34714) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34715;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Node_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Node_._setTextContent34715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34716;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Node_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Node_._isSameNode34716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34717;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Node_._lookupPrefix34717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34718;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Node_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Node_._isDefaultNamespace34718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34719;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Node_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Node_._lookupNamespaceURI34719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34720;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Node_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Node_._isEqualNode34720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Node_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Node_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Node"));
		}
		internal static void InitJNI()
		{
		}
	}
}
