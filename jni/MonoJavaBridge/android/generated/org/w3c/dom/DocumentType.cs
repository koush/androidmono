namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.DocumentType_))]
	public interface DocumentType : Node
	{
		global::java.lang.String getName();
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		global::java.lang.String getInternalSubset();
		global::org.w3c.dom.NamedNodeMap getEntities();
		global::org.w3c.dom.NamedNodeMap getNotations();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.DocumentType))]
	public sealed partial class DocumentType_ : java.lang.Object, DocumentType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentType_()
		{
			InitJNI();
		}
		internal DocumentType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName27661;
		 global::java.lang.String org.w3c.dom.DocumentType.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getName27661)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getName27661)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId27662;
		 global::java.lang.String org.w3c.dom.DocumentType.getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getPublicId27662)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getPublicId27662)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId27663;
		 global::java.lang.String org.w3c.dom.DocumentType.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getSystemId27663)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getSystemId27663)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInternalSubset27664;
		 global::java.lang.String org.w3c.dom.DocumentType.getInternalSubset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getInternalSubset27664)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getInternalSubset27664)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEntities27665;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.DocumentType.getEntities() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getEntities27665)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getEntities27665)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getNotations27666;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.DocumentType.getNotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getNotations27666)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getNotations27666)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _normalize27667;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._normalize27667);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._normalize27667);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported27668;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._isSupported27668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._isSupported27668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27669;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getAttributes27669)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getAttributes27669)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix27670;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getPrefix27670)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getPrefix27670)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild27671;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getFirstChild27671)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getFirstChild27671)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType27672;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getNodeType27672);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getNodeType27672);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName27673;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getNodeName27673)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getNodeName27673)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue27674;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getNodeValue27674)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getNodeValue27674)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling27675;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getNextSibling27675)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getNextSibling27675)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName27676;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getLocalName27676)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getLocalName27676)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes27677;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._hasAttributes27677);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._hasAttributes27677);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI27678;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getNamespaceURI27678)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getNamespaceURI27678)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes27679;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._hasChildNodes27679);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._hasChildNodes27679);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData27680;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getUserData27680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getUserData27680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData27681;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._setUserData27681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._setUserData27681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature27682;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getFeature27682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getFeature27682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix27683;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._setPrefix27683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._setPrefix27683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue27684;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._setNodeValue27684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._setNodeValue27684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode27685;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getParentNode27685)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getParentNode27685)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes27686;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getChildNodes27686)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getChildNodes27686)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild27687;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getLastChild27687)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getLastChild27687)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling27688;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getPreviousSibling27688)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getPreviousSibling27688)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument27689;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getOwnerDocument27689)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getOwnerDocument27689)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore27690;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._insertBefore27690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._insertBefore27690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild27691;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._replaceChild27691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._replaceChild27691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild27692;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._removeChild27692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._removeChild27692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild27693;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._appendChild27693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._appendChild27693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode27694;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._cloneNode27694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._cloneNode27694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI27695;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getBaseURI27695)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getBaseURI27695)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition27696;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._compareDocumentPosition27696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._compareDocumentPosition27696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent27697;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._getTextContent27697)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._getTextContent27697)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent27698;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._setTextContent27698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._setTextContent27698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode27699;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._isSameNode27699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._isSameNode27699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix27700;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._lookupPrefix27700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._lookupPrefix27700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace27701;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._isDefaultNamespace27701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._isDefaultNamespace27701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI27702;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._lookupNamespaceURI27702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._lookupNamespaceURI27702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode27703;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_._isEqualNode27703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.DocumentType_.staticClass, global::org.w3c.dom.DocumentType_._isEqualNode27703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DocumentType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DocumentType"));
			global::org.w3c.dom.DocumentType_._getName27661 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getPublicId27662 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getSystemId27663 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getInternalSubset27664 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getInternalSubset", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getEntities27665 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getEntities", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.DocumentType_._getNotations27666 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getNotations", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.DocumentType_._normalize27667 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "normalize", "()V");
			global::org.w3c.dom.DocumentType_._isSupported27668 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.DocumentType_._getAttributes27669 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.DocumentType_._getPrefix27670 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getFirstChild27671 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._getNodeType27672 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.DocumentType_._getNodeName27673 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getNodeValue27674 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._getNextSibling27675 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._getLocalName27676 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._hasAttributes27677 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.DocumentType_._getNamespaceURI27678 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._hasChildNodes27679 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.DocumentType_._getUserData27680 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentType_._setUserData27681 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentType_._getFeature27682 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.DocumentType_._setPrefix27683 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentType_._setNodeValue27684 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentType_._getParentNode27685 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._getChildNodes27686 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.DocumentType_._getLastChild27687 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._getPreviousSibling27688 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._getOwnerDocument27689 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.DocumentType_._insertBefore27690 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._replaceChild27691 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._removeChild27692 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._appendChild27693 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._cloneNode27694 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.DocumentType_._getBaseURI27695 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._compareDocumentPosition27696 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.DocumentType_._getTextContent27697 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._setTextContent27698 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.DocumentType_._isSameNode27699 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.DocumentType_._lookupPrefix27700 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._isDefaultNamespace27701 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.DocumentType_._lookupNamespaceURI27702 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.DocumentType_._isEqualNode27703 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DocumentType_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
