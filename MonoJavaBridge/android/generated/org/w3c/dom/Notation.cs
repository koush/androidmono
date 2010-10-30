namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Notation_))]
	public partial interface Notation : Node
	{
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Notation))]
	internal sealed partial class Notation_ : java.lang.Object, Notation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Notation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId34741;
		global::java.lang.String org.w3c.dom.Notation.getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getPublicId34741.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getPublicId34741 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getPublicId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getPublicId34741)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId34742;
		global::java.lang.String org.w3c.dom.Notation.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getSystemId34742.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getSystemId34742 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getSystemId34742)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _normalize34743;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._normalize34743.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._normalize34743 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "normalize", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Notation_._normalize34743);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34744;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._isSupported34744.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._isSupported34744 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Notation_._isSupported34744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34745;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getAttributes34745.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getAttributes34745 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getAttributes34745)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34746;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getPrefix34746.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getPrefix34746 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getPrefix", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getPrefix34746)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34747;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getFirstChild34747.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getFirstChild34747 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getFirstChild34747)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34748;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getNodeType34748.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getNodeType34748 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getNodeType", "()S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getNodeType34748);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34749;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getNodeName34749.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getNodeName34749 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getNodeName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getNodeName34749)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34750;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getNodeValue34750.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getNodeValue34750 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getNodeValue34750)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34751;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getNextSibling34751.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getNextSibling34751 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getNextSibling34751)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34752;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getLocalName34752.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getLocalName34752 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getLocalName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getLocalName34752)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34753;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._hasAttributes34753.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._hasAttributes34753 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "hasAttributes", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Notation_._hasAttributes34753);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34754;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getNamespaceURI34754.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getNamespaceURI34754 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getNamespaceURI34754)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34755;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._hasChildNodes34755.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._hasChildNodes34755 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "hasChildNodes", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Notation_._hasChildNodes34755);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34756;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getUserData34756.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getUserData34756 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getUserData34756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34757;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._setUserData34757.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._setUserData34757 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._setUserData34757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34758;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getFeature34758.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getFeature34758 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getFeature34758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34759;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._setPrefix34759.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._setPrefix34759 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Notation_._setPrefix34759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34760;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._setNodeValue34760.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._setNodeValue34760 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Notation_._setNodeValue34760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34761;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getParentNode34761.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getParentNode34761 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getParentNode34761)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34762;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getChildNodes34762.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getChildNodes34762 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getChildNodes34762)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34763;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getLastChild34763.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getLastChild34763 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getLastChild34763)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34764;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getPreviousSibling34764.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getPreviousSibling34764 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getPreviousSibling34764)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34765;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getOwnerDocument34765.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getOwnerDocument34765 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getOwnerDocument34765)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34766;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._insertBefore34766.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._insertBefore34766 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._insertBefore34766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34767;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._replaceChild34767.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._replaceChild34767 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._replaceChild34767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34768;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._removeChild34768.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._removeChild34768 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._removeChild34768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34769;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._appendChild34769.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._appendChild34769 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._appendChild34769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34770;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._cloneNode34770.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._cloneNode34770 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._cloneNode34770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34771;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getBaseURI34771.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getBaseURI34771 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getBaseURI34771)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34772;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._compareDocumentPosition34772.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._compareDocumentPosition34772 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Notation_._compareDocumentPosition34772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34773;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._getTextContent34773.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._getTextContent34773 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "getTextContent", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._getTextContent34773)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34774;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._setTextContent34774.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._setTextContent34774 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Notation_._setTextContent34774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34775;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._isSameNode34775.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._isSameNode34775 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Notation_._isSameNode34775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34776;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._lookupPrefix34776.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._lookupPrefix34776 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._lookupPrefix34776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34777;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._isDefaultNamespace34777.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._isDefaultNamespace34777 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Notation_._isDefaultNamespace34777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34778;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._lookupNamespaceURI34778.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._lookupNamespaceURI34778 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Notation_._lookupNamespaceURI34778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34779;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.Notation_._isEqualNode34779.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.Notation_._isEqualNode34779 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Notation_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Notation_._isEqualNode34779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Notation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Notation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Notation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
