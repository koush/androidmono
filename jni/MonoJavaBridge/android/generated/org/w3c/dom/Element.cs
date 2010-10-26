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
		static Element_()
		{
			InitJNI();
		}
		internal Element_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute34533;
		 global::java.lang.String org.w3c.dom.Element.getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttribute34533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttribute34533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTagName34534;
		 global::java.lang.String org.w3c.dom.Element.getTagName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getTagName34534)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getTagName34534)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute34535;
		 void org.w3c.dom.Element.removeAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeAttribute34535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeAttribute34535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute34536;
		 void org.w3c.dom.Element.setAttribute(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttribute34536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttribute34536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagName34537;
		 global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getElementsByTagName34537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getElementsByTagName34537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagNameNS34538;
		 global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getElementsByTagNameNS34538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getElementsByTagNameNS34538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTypeInfo34539;
		 global::org.w3c.dom.TypeInfo org.w3c.dom.Element.getSchemaTypeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getSchemaTypeInfo34539)) as org.w3c.dom.TypeInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getSchemaTypeInfo34539)) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNode34540;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributeNode34540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributeNode34540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNode34541;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNode(org.w3c.dom.Attr arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttributeNode34541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttributeNode34541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttributeNode34542;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.removeAttributeNode(org.w3c.dom.Attr arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeAttributeNode34542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeAttributeNode34542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNS34543;
		 global::java.lang.String org.w3c.dom.Element.getAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributeNS34543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributeNS34543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNS34544;
		 void org.w3c.dom.Element.setAttributeNS(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttributeNS34544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttributeNS34544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttributeNS34545;
		 void org.w3c.dom.Element.removeAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeAttributeNS34545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeAttributeNS34545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNodeNS34546;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNodeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributeNodeNS34546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributeNodeNS34546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNodeNS34547;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNodeNS(org.w3c.dom.Attr arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttributeNodeNS34547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttributeNodeNS34547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttribute34548;
		 bool org.w3c.dom.Element.hasAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasAttribute34548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasAttribute34548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributeNS34549;
		 bool org.w3c.dom.Element.hasAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasAttributeNS34549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasAttributeNS34549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttribute34550;
		 void org.w3c.dom.Element.setIdAttribute(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setIdAttribute34550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setIdAttribute34550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttributeNS34551;
		 void org.w3c.dom.Element.setIdAttributeNS(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setIdAttributeNS34551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setIdAttributeNS34551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttributeNode34552;
		 void org.w3c.dom.Element.setIdAttributeNode(org.w3c.dom.Attr arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setIdAttributeNode34552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setIdAttributeNode34552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34553;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._normalize34553);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._normalize34553);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34554;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isSupported34554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isSupported34554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34555;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributes34555)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributes34555)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34556;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getPrefix34556)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getPrefix34556)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34557;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getFirstChild34557)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getFirstChild34557)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34558;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNodeType34558);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNodeType34558);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34559;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNodeName34559)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNodeName34559)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34560;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNodeValue34560)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNodeValue34560)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34561;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNextSibling34561)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNextSibling34561)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34562;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getLocalName34562)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getLocalName34562)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34563;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasAttributes34563);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasAttributes34563);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34564;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNamespaceURI34564)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNamespaceURI34564)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34565;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasChildNodes34565);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasChildNodes34565);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34566;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getUserData34566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getUserData34566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34567;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._setUserData34567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setUserData34567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34568;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getFeature34568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getFeature34568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34569;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setPrefix34569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setPrefix34569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34570;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setNodeValue34570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setNodeValue34570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34571;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getParentNode34571)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getParentNode34571)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34572;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getChildNodes34572)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getChildNodes34572)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34573;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getLastChild34573)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getLastChild34573)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34574;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getPreviousSibling34574)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getPreviousSibling34574)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34575;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getOwnerDocument34575)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getOwnerDocument34575)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34576;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._insertBefore34576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._insertBefore34576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34577;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._replaceChild34577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._replaceChild34577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34578;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeChild34578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeChild34578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34579;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._appendChild34579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._appendChild34579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34580;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._cloneNode34580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._cloneNode34580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34581;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getBaseURI34581)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getBaseURI34581)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34582;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Element_._compareDocumentPosition34582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._compareDocumentPosition34582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34583;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getTextContent34583)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getTextContent34583)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34584;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setTextContent34584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setTextContent34584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34585;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isSameNode34585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isSameNode34585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34586;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._lookupPrefix34586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._lookupPrefix34586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34587;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isDefaultNamespace34587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isDefaultNamespace34587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34588;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._lookupNamespaceURI34588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._lookupNamespaceURI34588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34589;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isEqualNode34589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isEqualNode34589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Element_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Element"));
			global::org.w3c.dom.Element_._getAttribute34533 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._getTagName34534 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getTagName", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._removeAttribute34535 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeAttribute", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._setAttribute34536 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._getElementsByTagName34537 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Element_._getElementsByTagNameNS34538 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Element_._getSchemaTypeInfo34539 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			global::org.w3c.dom.Element_._getAttributeNode34540 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._setAttributeNode34541 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._removeAttributeNode34542 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._getAttributeNS34543 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._setAttributeNS34544 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._removeAttributeNS34545 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._getAttributeNodeNS34546 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._setAttributeNodeNS34547 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._hasAttribute34548 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasAttribute", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._hasAttributeNS34549 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._setIdAttribute34550 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setIdAttribute", "(Ljava/lang/String;Z)V");
			global::org.w3c.dom.Element_._setIdAttributeNS34551 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::org.w3c.dom.Element_._setIdAttributeNode34552 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V");
			global::org.w3c.dom.Element_._normalize34553 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Element_._isSupported34554 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._getAttributes34555 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Element_._getPrefix34556 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._getFirstChild34557 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getNodeType34558 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Element_._getNodeName34559 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._getNodeValue34560 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._getNextSibling34561 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getLocalName34562 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._hasAttributes34563 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Element_._getNamespaceURI34564 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._hasChildNodes34565 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Element_._getUserData34566 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Element_._setUserData34567 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Element_._getFeature34568 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Element_._setPrefix34569 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._setNodeValue34570 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._getParentNode34571 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getChildNodes34572 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Element_._getLastChild34573 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getPreviousSibling34574 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getOwnerDocument34575 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Element_._insertBefore34576 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._replaceChild34577 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._removeChild34578 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._appendChild34579 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._cloneNode34580 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getBaseURI34581 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._compareDocumentPosition34582 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Element_._getTextContent34583 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._setTextContent34584 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._isSameNode34585 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Element_._lookupPrefix34586 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._isDefaultNamespace34587 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._lookupNamespaceURI34588 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._isEqualNode34589 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
