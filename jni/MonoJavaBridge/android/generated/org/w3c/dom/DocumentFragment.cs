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
		static DocumentFragment_()
		{
			InitJNI();
		}
		internal DocumentFragment_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _normalize34453;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._normalize34453);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._normalize34453);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34454;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isSupported34454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._isSupported34454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34455;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getAttributes34455)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getAttributes34455)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34456;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getPrefix34456)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getPrefix34456)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34457;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getFirstChild34457)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getFirstChild34457)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34458;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNodeType34458);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getNodeType34458);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34459;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNodeName34459)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getNodeName34459)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34460;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNodeValue34460)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getNodeValue34460)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34461;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNextSibling34461)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getNextSibling34461)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34462;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getLocalName34462)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getLocalName34462)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34463;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._hasAttributes34463);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._hasAttributes34463);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34464;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getNamespaceURI34464)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getNamespaceURI34464)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34465;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._hasChildNodes34465);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._hasChildNodes34465);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34466;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getUserData34466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getUserData34466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34467;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setUserData34467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._setUserData34467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34468;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getFeature34468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getFeature34468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34469;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setPrefix34469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._setPrefix34469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34470;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setNodeValue34470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._setNodeValue34470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34471;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getParentNode34471)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getParentNode34471)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34472;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getChildNodes34472)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getChildNodes34472)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34473;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getLastChild34473)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getLastChild34473)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34474;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getPreviousSibling34474)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getPreviousSibling34474)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34475;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getOwnerDocument34475)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getOwnerDocument34475)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34476;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._insertBefore34476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._insertBefore34476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34477;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._replaceChild34477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._replaceChild34477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34478;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._removeChild34478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._removeChild34478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34479;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._appendChild34479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._appendChild34479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34480;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._cloneNode34480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._cloneNode34480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34481;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getBaseURI34481)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getBaseURI34481)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34482;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._compareDocumentPosition34482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._compareDocumentPosition34482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34483;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._getTextContent34483)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._getTextContent34483)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34484;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._setTextContent34484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._setTextContent34484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34485;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isSameNode34485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._isSameNode34485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34486;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._lookupPrefix34486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._lookupPrefix34486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34487;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isDefaultNamespace34487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._isDefaultNamespace34487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34488;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._lookupNamespaceURI34488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._lookupNamespaceURI34488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34489;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_._isEqualNode34489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentFragment_.staticClass, global::org.w3c.dom.DocumentFragment_._isEqualNode34489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DocumentFragment_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DocumentFragment"));
			global::org.w3c.dom.DocumentFragment_._normalize34453 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "normalize", "()V");
			global::org.w3c.dom.DocumentFragment_._isSupported34454 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.DocumentFragment_._getAttributes34455 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.DocumentFragment_._getPrefix34456 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._getFirstChild34457 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getNodeType34458 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.DocumentFragment_._getNodeName34459 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._getNodeValue34460 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._getNextSibling34461 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getLocalName34462 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._hasAttributes34463 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.DocumentFragment_._getNamespaceURI34464 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._hasChildNodes34465 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.DocumentFragment_._getUserData34466 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentFragment_._setUserData34467 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentFragment_._getFeature34468 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentFragment_._setPrefix34469 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentFragment_._setNodeValue34470 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentFragment_._getParentNode34471 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getChildNodes34472 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.DocumentFragment_._getLastChild34473 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getPreviousSibling34474 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getOwnerDocument34475 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.DocumentFragment_._insertBefore34476 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._replaceChild34477 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._removeChild34478 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._appendChild34479 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._cloneNode34480 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentFragment_._getBaseURI34481 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._compareDocumentPosition34482 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.DocumentFragment_._getTextContent34483 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._setTextContent34484 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentFragment_._isSameNode34485 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.DocumentFragment_._lookupPrefix34486 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._isDefaultNamespace34487 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.DocumentFragment_._lookupNamespaceURI34488 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.DocumentFragment_._isEqualNode34489 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentFragment_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
