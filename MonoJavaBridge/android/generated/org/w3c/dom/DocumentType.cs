namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DocumentType_))]
	public partial interface DocumentType : Node
	{
		global::java.lang.String getName();
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		global::java.lang.String getInternalSubset();
		global::org.w3c.dom.NamedNodeMap getEntities();
		global::org.w3c.dom.NamedNodeMap getNotations();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DocumentType))]
	internal sealed partial class DocumentType_ : java.lang.Object, DocumentType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DocumentType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName34491;
		global::java.lang.String org.w3c.dom.DocumentType.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getName34491) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId34492;
		global::java.lang.String org.w3c.dom.DocumentType.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getPublicId34492) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId34493;
		global::java.lang.String org.w3c.dom.DocumentType.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getSystemId34493) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInternalSubset34494;
		global::java.lang.String org.w3c.dom.DocumentType.getInternalSubset()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getInternalSubset", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getInternalSubset34494) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEntities34495;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.DocumentType.getEntities()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.DocumentType_.staticClass, "getEntities", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.DocumentType_._getEntities34495) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getNotations34496;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.DocumentType.getNotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.DocumentType_.staticClass, "getNotations", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.DocumentType_._getNotations34496) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _normalize34497;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "normalize", "()V", ref global::org.w3c.dom.DocumentType_._normalize34497);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34498;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.DocumentType_._isSupported34498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34499;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.DocumentType_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.DocumentType_._getAttributes34499) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34500;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getPrefix34500) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34501;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._getFirstChild34501) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34502;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.DocumentType_._getNodeType34502);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34503;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getNodeName34503) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34504;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getNodeValue34504) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34505;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._getNextSibling34505) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34506;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getLocalName34506) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34507;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.DocumentType_._hasAttributes34507);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34508;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getNamespaceURI34508) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34509;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.DocumentType_._hasChildNodes34509);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34510;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.DocumentType_._getUserData34510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34511;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.DocumentType_._setUserData34511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34512;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.DocumentType_._getFeature34512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34513;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.DocumentType_._setPrefix34513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34514;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.DocumentType_._setNodeValue34514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34515;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._getParentNode34515) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34516;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.DocumentType_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.DocumentType_._getChildNodes34516) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34517;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._getLastChild34517) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34518;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._getPreviousSibling34518) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34519;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.DocumentType_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.DocumentType_._getOwnerDocument34519) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34520;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._insertBefore34520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34521;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._replaceChild34521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34522;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._removeChild34522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34523;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._appendChild34523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34524;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.DocumentType_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.DocumentType_._cloneNode34524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34525;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getBaseURI34525) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34526;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.DocumentType_._compareDocumentPosition34526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34527;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._getTextContent34527) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34528;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.DocumentType_._setTextContent34528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34529;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.DocumentType_._isSameNode34529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34530;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._lookupPrefix34530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34531;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.DocumentType_._isDefaultNamespace34531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34532;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.DocumentType_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.DocumentType_._lookupNamespaceURI34532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34533;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.DocumentType_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.DocumentType_._isEqualNode34533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DocumentType_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DocumentType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DocumentType"));
		}
		internal static void InitJNI()
		{
		}
	}
}
