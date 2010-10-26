namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Entity_))]
	public partial interface Entity : Node
	{
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		global::java.lang.String getInputEncoding();
		global::java.lang.String getXmlEncoding();
		global::java.lang.String getXmlVersion();
		global::java.lang.String getNotationName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Entity))]
	internal sealed partial class Entity_ : java.lang.Object, Entity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Entity_()
		{
			InitJNI();
		}
		internal Entity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId34590;
		 global::java.lang.String org.w3c.dom.Entity.getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getPublicId34590)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getPublicId34590)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId34591;
		 global::java.lang.String org.w3c.dom.Entity.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getSystemId34591)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getSystemId34591)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding34592;
		 global::java.lang.String org.w3c.dom.Entity.getInputEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getInputEncoding34592)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getInputEncoding34592)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlEncoding34593;
		 global::java.lang.String org.w3c.dom.Entity.getXmlEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getXmlEncoding34593)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getXmlEncoding34593)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlVersion34594;
		 global::java.lang.String org.w3c.dom.Entity.getXmlVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getXmlVersion34594)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getXmlVersion34594)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNotationName34595;
		 global::java.lang.String org.w3c.dom.Entity.getNotationName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getNotationName34595)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getNotationName34595)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _normalize34596;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_._normalize34596);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._normalize34596);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34597;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_._isSupported34597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._isSupported34597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34598;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getAttributes34598)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getAttributes34598)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34599;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getPrefix34599)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getPrefix34599)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34600;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getFirstChild34600)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getFirstChild34600)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34601;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getNodeType34601);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getNodeType34601);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34602;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getNodeName34602)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getNodeName34602)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34603;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getNodeValue34603)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getNodeValue34603)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34604;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getNextSibling34604)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getNextSibling34604)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34605;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getLocalName34605)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getLocalName34605)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34606;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_._hasAttributes34606);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._hasAttributes34606);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34607;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getNamespaceURI34607)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getNamespaceURI34607)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34608;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_._hasChildNodes34608);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._hasChildNodes34608);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34609;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getUserData34609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getUserData34609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34610;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._setUserData34610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._setUserData34610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34611;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getFeature34611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getFeature34611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34612;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_._setPrefix34612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._setPrefix34612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34613;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_._setNodeValue34613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._setNodeValue34613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34614;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getParentNode34614)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getParentNode34614)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34615;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getChildNodes34615)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getChildNodes34615)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34616;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getLastChild34616)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getLastChild34616)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34617;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getPreviousSibling34617)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getPreviousSibling34617)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34618;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getOwnerDocument34618)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getOwnerDocument34618)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34619;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._insertBefore34619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._insertBefore34619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34620;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._replaceChild34620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._replaceChild34620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34621;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._removeChild34621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._removeChild34621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34622;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._appendChild34622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._appendChild34622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34623;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._cloneNode34623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._cloneNode34623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34624;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getBaseURI34624)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getBaseURI34624)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34625;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Entity_._compareDocumentPosition34625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._compareDocumentPosition34625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34626;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._getTextContent34626)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._getTextContent34626)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34627;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_._setTextContent34627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._setTextContent34627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34628;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_._isSameNode34628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._isSameNode34628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34629;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._lookupPrefix34629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._lookupPrefix34629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34630;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_._isDefaultNamespace34630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._isDefaultNamespace34630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34631;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_._lookupNamespaceURI34631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._lookupNamespaceURI34631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34632;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_._isEqualNode34632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Entity_.staticClass, global::org.w3c.dom.Entity_._isEqualNode34632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Entity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Entity"));
			global::org.w3c.dom.Entity_._getPublicId34590 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getSystemId34591 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getInputEncoding34592 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getXmlEncoding34593 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getXmlEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getXmlVersion34594 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getXmlVersion", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getNotationName34595 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getNotationName", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._normalize34596 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Entity_._isSupported34597 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Entity_._getAttributes34598 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Entity_._getPrefix34599 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getFirstChild34600 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._getNodeType34601 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Entity_._getNodeName34602 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getNodeValue34603 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._getNextSibling34604 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._getLocalName34605 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._hasAttributes34606 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Entity_._getNamespaceURI34607 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._hasChildNodes34608 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Entity_._getUserData34609 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Entity_._setUserData34610 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Entity_._getFeature34611 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Entity_._setPrefix34612 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Entity_._setNodeValue34613 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Entity_._getParentNode34614 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._getChildNodes34615 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Entity_._getLastChild34616 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._getPreviousSibling34617 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._getOwnerDocument34618 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Entity_._insertBefore34619 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._replaceChild34620 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._removeChild34621 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._appendChild34622 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._cloneNode34623 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Entity_._getBaseURI34624 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._compareDocumentPosition34625 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Entity_._getTextContent34626 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Entity_._setTextContent34627 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Entity_._isSameNode34628 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Entity_._lookupPrefix34629 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Entity_._isDefaultNamespace34630 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Entity_._lookupNamespaceURI34631 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Entity_._isEqualNode34632 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Entity_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
