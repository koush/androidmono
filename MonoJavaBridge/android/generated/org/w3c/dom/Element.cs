namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Element_))]
	public partial interface Element : Node
	{
		global::java.lang.String getAttribute(java.lang.String arg0);
		global::java.lang.String getTagName();
		void removeAttribute(java.lang.String arg0);
		void setAttribute(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.NodeList getElementsByTagName(java.lang.String arg0);
		global::org.w3c.dom.NodeList getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.TypeInfo getSchemaTypeInfo();
		global::org.w3c.dom.Attr getAttributeNode(java.lang.String arg0);
		global::org.w3c.dom.Attr setAttributeNode(org.w3c.dom.Attr arg0);
		global::org.w3c.dom.Attr removeAttributeNode(org.w3c.dom.Attr arg0);
		global::java.lang.String getAttributeNS(java.lang.String arg0, java.lang.String arg1);
		void setAttributeNS(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void removeAttributeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr getAttributeNodeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr setAttributeNodeNS(org.w3c.dom.Attr arg0);
		bool hasAttribute(java.lang.String arg0);
		bool hasAttributeNS(java.lang.String arg0, java.lang.String arg1);
		void setIdAttribute(java.lang.String arg0, bool arg1);
		void setIdAttributeNS(java.lang.String arg0, java.lang.String arg1, bool arg2);
		void setIdAttributeNode(org.w3c.dom.Attr arg0, bool arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Element))]
	internal sealed partial class Element_ : java.lang.Object, Element
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Element_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.w3c.dom.Element.getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.w3c.dom.Element.getTagName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getTagName", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.w3c.dom.Element.removeAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "removeAttribute", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.w3c.dom.Element.setAttribute(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Element_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Element_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Element_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Element_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.w3c.dom.TypeInfo org.w3c.dom.Element.getSchemaTypeInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.TypeInfo>(this, global::org.w3c.dom.Element_.staticClass, "getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;", ref global::org.w3c.dom.Element_._m6) as org.w3c.dom.TypeInfo;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNode(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNode(org.w3c.dom.Attr arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::org.w3c.dom.Attr org.w3c.dom.Element.removeAttributeNode(org.w3c.dom.Attr arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.w3c.dom.Element.getAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void org.w3c.dom.Element.setAttributeNS(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void org.w3c.dom.Element.removeAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNodeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNodeNS(org.w3c.dom.Attr arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Attr>(this, global::org.w3c.dom.Element_.staticClass, "setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", ref global::org.w3c.dom.Element_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Attr;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool org.w3c.dom.Element.hasAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasAttribute", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool org.w3c.dom.Element.hasAttributeNS(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void org.w3c.dom.Element.setIdAttribute(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setIdAttribute", "(Ljava/lang/String;Z)V", ref global::org.w3c.dom.Element_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void org.w3c.dom.Element.setIdAttributeNS(java.lang.String arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V", ref global::org.w3c.dom.Element_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void org.w3c.dom.Element.setIdAttributeNode(org.w3c.dom.Attr arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V", ref global::org.w3c.dom.Element_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "normalize", "()V", ref global::org.w3c.dom.Element_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.Element_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.Element_._m22) as org.w3c.dom.NamedNodeMap;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m23) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m24) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Element_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.Element_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m26) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m27) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m28) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m29) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.Element_._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m31) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.Element_._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Element_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Element_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Element_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.Element_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.Element_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.Element_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m38) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.Element_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.Element_._m39) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m40) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m41) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.Element_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.Element_._m42) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.Element_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.Element_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m48) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.Element_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.Element_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.Element_._m50) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.Element_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.Element_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Element_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.Element_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.Element_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.Element_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.Element_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.Element_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Element_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Element_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Element"));
		}
	}
}
