namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Comment_))]
	public partial interface Comment : CharacterData
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Comment))]
	internal sealed partial class Comment_ : java.lang.Object, Comment
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Comment_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34291;
		int org.w3c.dom.CharacterData.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.w3c.dom.Comment_.staticClass, "getLength", "()I", ref global::org.w3c.dom.Comment_._getLength34291);
		}
		internal static global::MonoJavaBridge.MethodId _getData34292;
		global::java.lang.String org.w3c.dom.CharacterData.getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getData", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getData34292) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData34293;
		void org.w3c.dom.CharacterData.setData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "setData", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Comment_._setData34293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substringData34294;
		global::java.lang.String org.w3c.dom.CharacterData.substringData(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "substringData", "(II)Ljava/lang/String;", ref global::org.w3c.dom.Comment_._substringData34294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendData34295;
		void org.w3c.dom.CharacterData.appendData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "appendData", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Comment_._appendData34295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertData34296;
		void org.w3c.dom.CharacterData.insertData(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "insertData", "(ILjava/lang/String;)V", ref global::org.w3c.dom.Comment_._insertData34296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteData34297;
		void org.w3c.dom.CharacterData.deleteData(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "deleteData", "(II)V", ref global::org.w3c.dom.Comment_._deleteData34297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _replaceData34298;
		void org.w3c.dom.CharacterData.replaceData(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "replaceData", "(IILjava/lang/String;)V", ref global::org.w3c.dom.Comment_._replaceData34298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34299;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "normalize", "()V", ref global::org.w3c.dom.Comment_._normalize34299);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34300;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Comment_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Comment_._isSupported34300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34301;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.Comment_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.Comment_._getAttributes34301) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34302;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getPrefix34302) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34303;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._getFirstChild34303) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34304;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Comment_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.Comment_._getNodeType34304);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34305;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getNodeName34305) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34306;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getNodeValue34306) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34307;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._getNextSibling34307) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34308;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getLocalName34308) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34309;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Comment_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.Comment_._hasAttributes34309);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34310;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getNamespaceURI34310) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34311;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Comment_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.Comment_._hasChildNodes34311);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34312;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Comment_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Comment_._getUserData34312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34313;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Comment_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.Comment_._setUserData34313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34314;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Comment_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Comment_._getFeature34314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34315;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Comment_._setPrefix34315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34316;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Comment_._setNodeValue34316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34317;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._getParentNode34317) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34318;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Comment_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Comment_._getChildNodes34318) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34319;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._getLastChild34319) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34320;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._getPreviousSibling34320) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34321;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.Comment_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.Comment_._getOwnerDocument34321) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34322;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._insertBefore34322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34323;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._replaceChild34323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34324;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._removeChild34324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34325;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._appendChild34325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34326;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Comment_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Comment_._cloneNode34326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34327;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getBaseURI34327) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34328;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Comment_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.Comment_._compareDocumentPosition34328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34329;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.Comment_._getTextContent34329) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34330;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Comment_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Comment_._setTextContent34330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34331;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Comment_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Comment_._isSameNode34331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34332;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Comment_._lookupPrefix34332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34333;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Comment_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Comment_._isDefaultNamespace34333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34334;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Comment_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Comment_._lookupNamespaceURI34334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34335;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Comment_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Comment_._isEqualNode34335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Comment_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Comment_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Comment"));
		}
		internal static void InitJNI()
		{
		}
	}
}
