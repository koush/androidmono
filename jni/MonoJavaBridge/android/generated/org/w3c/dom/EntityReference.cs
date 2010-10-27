namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.EntityReference_))]
	public partial interface EntityReference : Node
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.EntityReference))]
	internal sealed partial class EntityReference_ : java.lang.Object, EntityReference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntityReference_()
		{
			InitJNI();
		}
		internal EntityReference_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _normalize34633;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._normalize34633);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._normalize34633);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34634;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._isSupported34634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._isSupported34634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34635;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getAttributes34635)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getAttributes34635)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34636;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getPrefix34636)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getPrefix34636)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34637;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getFirstChild34637)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getFirstChild34637)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34638;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getNodeType34638);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getNodeType34638);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34639;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getNodeName34639)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getNodeName34639)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34640;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getNodeValue34640)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getNodeValue34640)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34641;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getNextSibling34641)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getNextSibling34641)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34642;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getLocalName34642)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getLocalName34642)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34643;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._hasAttributes34643);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._hasAttributes34643);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34644;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getNamespaceURI34644)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getNamespaceURI34644)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34645;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._hasChildNodes34645);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._hasChildNodes34645);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34646;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getUserData34646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getUserData34646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34647;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._setUserData34647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._setUserData34647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34648;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getFeature34648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getFeature34648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34649;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._setPrefix34649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._setPrefix34649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34650;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._setNodeValue34650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._setNodeValue34650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34651;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getParentNode34651)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getParentNode34651)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34652;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getChildNodes34652)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getChildNodes34652)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34653;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getLastChild34653)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getLastChild34653)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34654;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getPreviousSibling34654)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getPreviousSibling34654)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34655;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getOwnerDocument34655)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getOwnerDocument34655)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34656;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._insertBefore34656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._insertBefore34656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34657;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._replaceChild34657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._replaceChild34657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34658;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._removeChild34658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._removeChild34658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34659;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._appendChild34659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._appendChild34659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34660;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._cloneNode34660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._cloneNode34660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34661;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getBaseURI34661)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getBaseURI34661)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34662;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._compareDocumentPosition34662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._compareDocumentPosition34662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34663;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._getTextContent34663)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._getTextContent34663)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34664;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._setTextContent34664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._setTextContent34664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34665;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._isSameNode34665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._isSameNode34665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34666;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._lookupPrefix34666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._lookupPrefix34666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34667;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._isDefaultNamespace34667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._isDefaultNamespace34667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34668;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._lookupNamespaceURI34668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._lookupNamespaceURI34668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34669;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_._isEqualNode34669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.EntityReference_.staticClass, global::org.w3c.dom.EntityReference_._isEqualNode34669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.EntityReference_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/EntityReference"));
			global::org.w3c.dom.EntityReference_._normalize34633 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "normalize", "()V");
			global::org.w3c.dom.EntityReference_._isSupported34634 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.EntityReference_._getAttributes34635 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.EntityReference_._getPrefix34636 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._getFirstChild34637 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._getNodeType34638 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.EntityReference_._getNodeName34639 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._getNodeValue34640 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._getNextSibling34641 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._getLocalName34642 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._hasAttributes34643 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.EntityReference_._getNamespaceURI34644 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._hasChildNodes34645 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.EntityReference_._getUserData34646 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.EntityReference_._setUserData34647 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.EntityReference_._getFeature34648 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.EntityReference_._setPrefix34649 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.EntityReference_._setNodeValue34650 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.EntityReference_._getParentNode34651 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._getChildNodes34652 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.EntityReference_._getLastChild34653 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._getPreviousSibling34654 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._getOwnerDocument34655 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.EntityReference_._insertBefore34656 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._replaceChild34657 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._removeChild34658 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._appendChild34659 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._cloneNode34660 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.EntityReference_._getBaseURI34661 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._compareDocumentPosition34662 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.EntityReference_._getTextContent34663 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._setTextContent34664 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.EntityReference_._isSameNode34665 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.EntityReference_._lookupPrefix34666 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._isDefaultNamespace34667 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.EntityReference_._lookupNamespaceURI34668 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.EntityReference_._isEqualNode34669 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.EntityReference_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
