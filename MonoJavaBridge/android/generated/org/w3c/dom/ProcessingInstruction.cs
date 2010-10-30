namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ProcessingInstruction_))]
	public partial interface ProcessingInstruction : Node
	{
		global::java.lang.String getData();
		void setData(java.lang.String arg0);
		global::java.lang.String getTarget();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ProcessingInstruction))]
	internal sealed partial class ProcessingInstruction_ : java.lang.Object, ProcessingInstruction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProcessingInstruction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.w3c.dom.ProcessingInstruction.getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getData", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.w3c.dom.ProcessingInstruction.setData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "setData", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ProcessingInstruction_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.w3c.dom.ProcessingInstruction.getTarget()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getTarget", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "normalize", "()V", ref global::org.w3c.dom.ProcessingInstruction_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.w3c.dom.ProcessingInstruction_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NamedNodeMap>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", ref global::org.w3c.dom.ProcessingInstruction_._m5) as org.w3c.dom.NamedNodeMap;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m7) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		short org.w3c.dom.Node.getNodeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeType", "()S", ref global::org.w3c.dom.ProcessingInstruction_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeName", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeValue", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m11) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getLocalName", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool org.w3c.dom.Node.hasAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "hasAttributes", "()Z", ref global::org.w3c.dom.ProcessingInstruction_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNamespaceURI", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "hasChildNodes", "()Z", ref global::org.w3c.dom.ProcessingInstruction_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.ProcessingInstruction_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;", ref global::org.w3c.dom.ProcessingInstruction_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", ref global::org.w3c.dom.ProcessingInstruction_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "setPrefix", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ProcessingInstruction_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "setNodeValue", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ProcessingInstruction_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m21) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.NodeList>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;", ref global::org.w3c.dom.ProcessingInstruction_._m22) as org.w3c.dom.NodeList;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m23) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m24) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;", ref global::org.w3c.dom.ProcessingInstruction_._m25) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ProcessingInstruction_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m31) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", ref global::org.w3c.dom.ProcessingInstruction_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "getTextContent", "()Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m33) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "setTextContent", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ProcessingInstruction_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.ProcessingInstruction_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z", ref global::org.w3c.dom.ProcessingInstruction_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.w3c.dom.ProcessingInstruction_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ProcessingInstruction_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z", ref global::org.w3c.dom.ProcessingInstruction_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ProcessingInstruction_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ProcessingInstruction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ProcessingInstruction"));
		}
		internal static void InitJNI()
		{
		}
	}
}
