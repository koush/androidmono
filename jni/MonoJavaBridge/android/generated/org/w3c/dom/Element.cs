namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Element_))]
	public interface Element : Node
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
	public sealed partial class Element_ : java.lang.Object, Element
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Element_()
		{
			InitJNI();
		}
		internal Element_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute27704;
		 global::java.lang.String org.w3c.dom.Element.getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttribute27704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttribute27704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTagName27705;
		 global::java.lang.String org.w3c.dom.Element.getTagName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getTagName27705)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getTagName27705)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute27706;
		 void org.w3c.dom.Element.removeAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeAttribute27706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeAttribute27706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute27707;
		 void org.w3c.dom.Element.setAttribute(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttribute27707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttribute27707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagName27708;
		 global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getElementsByTagName27708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getElementsByTagName27708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagNameNS27709;
		 global::org.w3c.dom.NodeList org.w3c.dom.Element.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getElementsByTagNameNS27709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getElementsByTagNameNS27709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTypeInfo27710;
		 global::org.w3c.dom.TypeInfo org.w3c.dom.Element.getSchemaTypeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getSchemaTypeInfo27710)) as org.w3c.dom.TypeInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.TypeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getSchemaTypeInfo27710)) as org.w3c.dom.TypeInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNode27711;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributeNode27711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributeNode27711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNode27712;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNode(org.w3c.dom.Attr arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttributeNode27712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttributeNode27712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttributeNode27713;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.removeAttributeNode(org.w3c.dom.Attr arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeAttributeNode27713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeAttributeNode27713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNS27714;
		 global::java.lang.String org.w3c.dom.Element.getAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributeNS27714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributeNS27714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNS27715;
		 void org.w3c.dom.Element.setAttributeNS(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttributeNS27715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttributeNS27715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttributeNS27716;
		 void org.w3c.dom.Element.removeAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeAttributeNS27716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeAttributeNS27716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNodeNS27717;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.getAttributeNodeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributeNodeNS27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributeNodeNS27717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeNodeNS27718;
		 global::org.w3c.dom.Attr org.w3c.dom.Element.setAttributeNodeNS(org.w3c.dom.Attr arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._setAttributeNodeNS27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setAttributeNodeNS27718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttribute27719;
		 bool org.w3c.dom.Element.hasAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasAttribute27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasAttribute27719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributeNS27720;
		 bool org.w3c.dom.Element.hasAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasAttributeNS27720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasAttributeNS27720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttribute27721;
		 void org.w3c.dom.Element.setIdAttribute(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setIdAttribute27721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setIdAttribute27721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttributeNS27722;
		 void org.w3c.dom.Element.setIdAttributeNS(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setIdAttributeNS27722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setIdAttributeNS27722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setIdAttributeNode27723;
		 void org.w3c.dom.Element.setIdAttributeNode(org.w3c.dom.Attr arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setIdAttributeNode27723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setIdAttributeNode27723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _normalize27724;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._normalize27724);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._normalize27724);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported27725;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isSupported27725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isSupported27725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27726;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getAttributes27726)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getAttributes27726)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix27727;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getPrefix27727)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getPrefix27727)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild27728;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getFirstChild27728)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getFirstChild27728)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType27729;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNodeType27729);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNodeType27729);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName27730;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNodeName27730)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNodeName27730)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue27731;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNodeValue27731)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNodeValue27731)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling27732;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNextSibling27732)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNextSibling27732)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName27733;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getLocalName27733)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getLocalName27733)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes27734;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasAttributes27734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasAttributes27734);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI27735;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getNamespaceURI27735)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getNamespaceURI27735)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes27736;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._hasChildNodes27736);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._hasChildNodes27736);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData27737;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getUserData27737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getUserData27737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData27738;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._setUserData27738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setUserData27738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature27739;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getFeature27739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getFeature27739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix27740;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setPrefix27740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setPrefix27740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue27741;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setNodeValue27741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setNodeValue27741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode27742;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getParentNode27742)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getParentNode27742)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes27743;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getChildNodes27743)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getChildNodes27743)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild27744;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getLastChild27744)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getLastChild27744)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling27745;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getPreviousSibling27745)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getPreviousSibling27745)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument27746;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getOwnerDocument27746)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getOwnerDocument27746)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore27747;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._insertBefore27747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._insertBefore27747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild27748;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._replaceChild27748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._replaceChild27748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild27749;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._removeChild27749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._removeChild27749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild27750;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._appendChild27750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._appendChild27750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode27751;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._cloneNode27751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._cloneNode27751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI27752;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getBaseURI27752)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getBaseURI27752)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition27753;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Element_._compareDocumentPosition27753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._compareDocumentPosition27753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent27754;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._getTextContent27754)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._getTextContent27754)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent27755;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_._setTextContent27755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._setTextContent27755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode27756;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isSameNode27756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isSameNode27756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix27757;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._lookupPrefix27757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._lookupPrefix27757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace27758;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isDefaultNamespace27758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isDefaultNamespace27758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI27759;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_._lookupNamespaceURI27759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._lookupNamespaceURI27759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode27760;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_._isEqualNode27760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Element_.staticClass, global::org.w3c.dom.Element_._isEqualNode27760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Element_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Element"));
			global::org.w3c.dom.Element_._getAttribute27704 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._getTagName27705 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getTagName", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._removeAttribute27706 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeAttribute", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._setAttribute27707 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._getElementsByTagName27708 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Element_._getElementsByTagNameNS27709 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Element_._getSchemaTypeInfo27710 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
			global::org.w3c.dom.Element_._getAttributeNode27711 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._setAttributeNode27712 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._removeAttributeNode27713 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._getAttributeNS27714 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._setAttributeNS27715 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._removeAttributeNS27716 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._getAttributeNodeNS27717 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._setAttributeNodeNS27718 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Element_._hasAttribute27719 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasAttribute", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._hasAttributeNS27720 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._setIdAttribute27721 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setIdAttribute", "(Ljava/lang/String;Z)V");
			global::org.w3c.dom.Element_._setIdAttributeNS27722 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::org.w3c.dom.Element_._setIdAttributeNode27723 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V");
			global::org.w3c.dom.Element_._normalize27724 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Element_._isSupported27725 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._getAttributes27726 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Element_._getPrefix27727 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._getFirstChild27728 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getNodeType27729 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Element_._getNodeName27730 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._getNodeValue27731 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._getNextSibling27732 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getLocalName27733 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._hasAttributes27734 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Element_._getNamespaceURI27735 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._hasChildNodes27736 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Element_._getUserData27737 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Element_._setUserData27738 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Element_._getFeature27739 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Element_._setPrefix27740 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._setNodeValue27741 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._getParentNode27742 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getChildNodes27743 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Element_._getLastChild27744 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getPreviousSibling27745 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getOwnerDocument27746 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Element_._insertBefore27747 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._replaceChild27748 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._removeChild27749 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._appendChild27750 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._cloneNode27751 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Element_._getBaseURI27752 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._compareDocumentPosition27753 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Element_._getTextContent27754 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Element_._setTextContent27755 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Element_._isSameNode27756 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Element_._lookupPrefix27757 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._isDefaultNamespace27758 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Element_._lookupNamespaceURI27759 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Element_._isEqualNode27760 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Element_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
