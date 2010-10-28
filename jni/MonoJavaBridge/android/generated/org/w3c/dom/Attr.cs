namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Attr_))]
	public partial interface Attr : Node
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		void setValue(java.lang.String arg0);
		bool getSpecified();
		global::org.w3c.dom.Element getOwnerElement();
		global::org.w3c.dom.TypeInfo getSchemaTypeInfo();
		bool isId();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Attr))]
	internal sealed partial class Attr_ : java.lang.Object, Attr
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Attr_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName34153;
		global::java.lang.String org.w3c.dom.Attr.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getName34153)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getName34153)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34154;
		global::java.lang.String org.w3c.dom.Attr.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getValue34154)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getValue34154)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setValue34155;
		void org.w3c.dom.Attr.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setValue34155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setValue34155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpecified34156;
		bool org.w3c.dom.Attr.getSpecified()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getSpecified34156);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getSpecified34156);
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerElement34157;
		global::org.w3c.dom.Element org.w3c.dom.Attr.getOwnerElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getOwnerElement34157)) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getOwnerElement34157)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTypeInfo34158;
		global::org.w3c.dom.TypeInfo org.w3c.dom.Attr.getSchemaTypeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getSchemaTypeInfo34158)) as org.w3c.dom.TypeInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getSchemaTypeInfo34158)) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isId34159;
		bool org.w3c.dom.Attr.isId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isId34159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isId34159);
		}
		internal static global::MonoJavaBridge.MethodId _normalize34160;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._normalize34160);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._normalize34160);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34161;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isSupported34161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isSupported34161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34162;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getAttributes34162)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getAttributes34162)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34163;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getPrefix34163)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getPrefix34163)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34164;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getFirstChild34164)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getFirstChild34164)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34165;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNodeType34165);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNodeType34165);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34166;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNodeName34166)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNodeName34166)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34167;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNodeValue34167)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNodeValue34167)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34168;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNextSibling34168)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNextSibling34168)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34169;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getLocalName34169)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getLocalName34169)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34170;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._hasAttributes34170);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._hasAttributes34170);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34171;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNamespaceURI34171)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNamespaceURI34171)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34172;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._hasChildNodes34172);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._hasChildNodes34172);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34173;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getUserData34173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getUserData34173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34174;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setUserData34174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setUserData34174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34175;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getFeature34175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getFeature34175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34176;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setPrefix34176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setPrefix34176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34177;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setNodeValue34177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setNodeValue34177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34178;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getParentNode34178)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getParentNode34178)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34179;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getChildNodes34179)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getChildNodes34179)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34180;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getLastChild34180)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getLastChild34180)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34181;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getPreviousSibling34181)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getPreviousSibling34181)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34182;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getOwnerDocument34182)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getOwnerDocument34182)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34183;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._insertBefore34183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._insertBefore34183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34184;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._replaceChild34184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._replaceChild34184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34185;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._removeChild34185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._removeChild34185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34186;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._appendChild34186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._appendChild34186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34187;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._cloneNode34187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._cloneNode34187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34188;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getBaseURI34188)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getBaseURI34188)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34189;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_._compareDocumentPosition34189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._compareDocumentPosition34189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34190;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getTextContent34190)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getTextContent34190)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34191;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setTextContent34191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setTextContent34191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34192;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isSameNode34192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isSameNode34192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34193;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._lookupPrefix34193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._lookupPrefix34193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34194;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isDefaultNamespace34194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isDefaultNamespace34194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34195;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._lookupNamespaceURI34195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._lookupNamespaceURI34195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34196;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isEqualNode34196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isEqualNode34196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Attr_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Attr_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Attr"));
			global::org.w3c.dom.Attr_._getName34153 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getValue34154 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._setValue34155 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._getSpecified34156 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getSpecified", "()Z");
			global::org.w3c.dom.Attr_._getOwnerElement34157 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getOwnerElement", "()Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Attr_._getSchemaTypeInfo34158 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			global::org.w3c.dom.Attr_._isId34159 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isId", "()Z");
			global::org.w3c.dom.Attr_._normalize34160 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Attr_._isSupported34161 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Attr_._getAttributes34162 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Attr_._getPrefix34163 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getFirstChild34164 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getNodeType34165 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Attr_._getNodeName34166 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getNodeValue34167 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getNextSibling34168 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getLocalName34169 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._hasAttributes34170 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Attr_._getNamespaceURI34171 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._hasChildNodes34172 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Attr_._getUserData34173 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Attr_._setUserData34174 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Attr_._getFeature34175 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Attr_._setPrefix34176 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._setNodeValue34177 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._getParentNode34178 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getChildNodes34179 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Attr_._getLastChild34180 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getPreviousSibling34181 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getOwnerDocument34182 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Attr_._insertBefore34183 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._replaceChild34184 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._removeChild34185 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._appendChild34186 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._cloneNode34187 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getBaseURI34188 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._compareDocumentPosition34189 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Attr_._getTextContent34190 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._setTextContent34191 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._isSameNode34192 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Attr_._lookupPrefix34193 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Attr_._isDefaultNamespace34194 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Attr_._lookupNamespaceURI34195 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Attr_._isEqualNode34196 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
