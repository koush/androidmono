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
		static Attr_()
		{
			InitJNI();
		}
		internal Attr_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName34152;
		global::java.lang.String org.w3c.dom.Attr.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getName34152)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getName34152)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34153;
		global::java.lang.String org.w3c.dom.Attr.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getValue34153)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getValue34153)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setValue34154;
		void org.w3c.dom.Attr.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setValue34154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setValue34154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpecified34155;
		bool org.w3c.dom.Attr.getSpecified()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getSpecified34155);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getSpecified34155);
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerElement34156;
		global::org.w3c.dom.Element org.w3c.dom.Attr.getOwnerElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getOwnerElement34156)) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getOwnerElement34156)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTypeInfo34157;
		global::org.w3c.dom.TypeInfo org.w3c.dom.Attr.getSchemaTypeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getSchemaTypeInfo34157)) as org.w3c.dom.TypeInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getSchemaTypeInfo34157)) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isId34158;
		bool org.w3c.dom.Attr.isId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isId34158);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isId34158);
		}
		internal static global::MonoJavaBridge.MethodId _normalize34159;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._normalize34159);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._normalize34159);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34160;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isSupported34160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isSupported34160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34161;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getAttributes34161)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getAttributes34161)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34162;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getPrefix34162)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getPrefix34162)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34163;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getFirstChild34163)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getFirstChild34163)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34164;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNodeType34164);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNodeType34164);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34165;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNodeName34165)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNodeName34165)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34166;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNodeValue34166)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNodeValue34166)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34167;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNextSibling34167)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNextSibling34167)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34168;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getLocalName34168)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getLocalName34168)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34169;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._hasAttributes34169);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._hasAttributes34169);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34170;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getNamespaceURI34170)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getNamespaceURI34170)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34171;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._hasChildNodes34171);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._hasChildNodes34171);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34172;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getUserData34172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getUserData34172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34173;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setUserData34173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setUserData34173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34174;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getFeature34174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getFeature34174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34175;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setPrefix34175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setPrefix34175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34176;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setNodeValue34176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setNodeValue34176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34177;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getParentNode34177)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getParentNode34177)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34178;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getChildNodes34178)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getChildNodes34178)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34179;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getLastChild34179)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getLastChild34179)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34180;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getPreviousSibling34180)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getPreviousSibling34180)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34181;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getOwnerDocument34181)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getOwnerDocument34181)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34182;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._insertBefore34182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._insertBefore34182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34183;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._replaceChild34183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._replaceChild34183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34184;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._removeChild34184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._removeChild34184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34185;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._appendChild34185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._appendChild34185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34186;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._cloneNode34186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._cloneNode34186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34187;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getBaseURI34187)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getBaseURI34187)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34188;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_._compareDocumentPosition34188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._compareDocumentPosition34188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34189;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._getTextContent34189)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._getTextContent34189)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34190;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_._setTextContent34190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._setTextContent34190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34191;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isSameNode34191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isSameNode34191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34192;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._lookupPrefix34192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._lookupPrefix34192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34193;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isDefaultNamespace34193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isDefaultNamespace34193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34194;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_._lookupNamespaceURI34194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._lookupNamespaceURI34194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34195;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_._isEqualNode34195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Attr_.staticClass, global::org.w3c.dom.Attr_._isEqualNode34195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Attr_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Attr"));
			global::org.w3c.dom.Attr_._getName34152 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getValue34153 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._setValue34154 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._getSpecified34155 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getSpecified", "()Z");
			global::org.w3c.dom.Attr_._getOwnerElement34156 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getOwnerElement", "()Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Attr_._getSchemaTypeInfo34157 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			global::org.w3c.dom.Attr_._isId34158 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isId", "()Z");
			global::org.w3c.dom.Attr_._normalize34159 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Attr_._isSupported34160 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Attr_._getAttributes34161 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Attr_._getPrefix34162 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getFirstChild34163 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getNodeType34164 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Attr_._getNodeName34165 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getNodeValue34166 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._getNextSibling34167 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getLocalName34168 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._hasAttributes34169 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Attr_._getNamespaceURI34170 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._hasChildNodes34171 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Attr_._getUserData34172 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Attr_._setUserData34173 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Attr_._getFeature34174 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Attr_._setPrefix34175 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._setNodeValue34176 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._getParentNode34177 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getChildNodes34178 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Attr_._getLastChild34179 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getPreviousSibling34180 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getOwnerDocument34181 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Attr_._insertBefore34182 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._replaceChild34183 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._removeChild34184 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._appendChild34185 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._cloneNode34186 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Attr_._getBaseURI34187 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._compareDocumentPosition34188 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Attr_._getTextContent34189 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Attr_._setTextContent34190 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Attr_._isSameNode34191 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Attr_._lookupPrefix34192 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Attr_._isDefaultNamespace34193 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Attr_._lookupNamespaceURI34194 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Attr_._isEqualNode34195 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Attr_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
