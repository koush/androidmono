namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DocumentFragment_))]
	public partial interface DocumentFragment : Node
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DocumentFragment))]
	internal sealed partial class DocumentFragment_ : java.lang.Object, DocumentFragment
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DocumentFragment_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _normalize34454;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._normalize34454);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34455;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isSupported34455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34456;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getAttributes34456)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34457;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getPrefix34457)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34458;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getFirstChild34458)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34459;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNodeType34459);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34460;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNodeName34460)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34461;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNodeValue34461)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34462;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNextSibling34462)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34463;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getLocalName34463)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34464;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._hasAttributes34464);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34465;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNamespaceURI34465)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34466;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._hasChildNodes34466);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34467;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getUserData34467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34468;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setUserData34468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34469;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getFeature34469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34470;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setPrefix34470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34471;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setNodeValue34471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34472;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getParentNode34472)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34473;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getChildNodes34473)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34474;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getLastChild34474)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34475;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getPreviousSibling34475)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34476;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getOwnerDocument34476)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34477;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._insertBefore34477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34478;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._replaceChild34478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34479;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._removeChild34479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34480;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._appendChild34480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34481;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._cloneNode34481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34482;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getBaseURI34482)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34483;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._compareDocumentPosition34483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34484;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getTextContent34484)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34485;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setTextContent34485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34486;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isSameNode34486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34487;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._lookupPrefix34487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34488;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isDefaultNamespace34488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34489;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._lookupNamespaceURI34489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34490;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isEqualNode34490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DocumentFragment_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DocumentFragment_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DocumentFragment"));
			global::org.w3c.dom.DocumentFragment_._normalize34454 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "normalize", "()V");
			global::org.w3c.dom.DocumentFragment_._isSupported34455 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.DocumentFragment_._getAttributes34456 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.DocumentFragment_._getPrefix34457 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._getFirstChild34458 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getNodeType34459 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.DocumentFragment_._getNodeName34460 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._getNodeValue34461 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._getNextSibling34462 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getLocalName34463 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._hasAttributes34464 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.DocumentFragment_._getNamespaceURI34465 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._hasChildNodes34466 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.DocumentFragment_._getUserData34467 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentFragment_._setUserData34468 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentFragment_._getFeature34469 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentFragment_._setPrefix34470 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentFragment_._setNodeValue34471 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentFragment_._getParentNode34472 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getChildNodes34473 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.DocumentFragment_._getLastChild34474 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getPreviousSibling34475 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getOwnerDocument34476 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.DocumentFragment_._insertBefore34477 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._replaceChild34478 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._removeChild34479 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._appendChild34480 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._cloneNode34481 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getBaseURI34482 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._compareDocumentPosition34483 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.DocumentFragment_._getTextContent34484 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._setTextContent34485 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentFragment_._isSameNode34486 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.DocumentFragment_._lookupPrefix34487 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._isDefaultNamespace34488 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.DocumentFragment_._lookupNamespaceURI34489 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._isEqualNode34490 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
