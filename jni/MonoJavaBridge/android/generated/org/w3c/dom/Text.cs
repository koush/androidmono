namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Text_))]
	public partial interface Text : CharacterData
	{
		global::org.w3c.dom.Text splitText(int arg0);
		bool isElementContentWhitespace();
		global::java.lang.String getWholeText();
		global::org.w3c.dom.Text replaceWholeText(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Text))]
	internal sealed partial class Text_ : java.lang.Object, Text
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Text_()
		{
			InitJNI();
		}
		internal Text_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _splitText34819;
		 global::org.w3c.dom.Text org.w3c.dom.Text.splitText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._splitText34819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._splitText34819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _isElementContentWhitespace34820;
		 bool org.w3c.dom.Text.isElementContentWhitespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._isElementContentWhitespace34820);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._isElementContentWhitespace34820);
		}
		internal static global::MonoJavaBridge.MethodId _getWholeText34821;
		 global::java.lang.String org.w3c.dom.Text.getWholeText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getWholeText34821)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getWholeText34821)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWholeText34822;
		 global::org.w3c.dom.Text org.w3c.dom.Text.replaceWholeText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._replaceWholeText34822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._replaceWholeText34822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _getLength34823;
		 int org.w3c.dom.CharacterData.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.Text_._getLength34823);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getLength34823);
		}
		internal static global::MonoJavaBridge.MethodId _getData34824;
		 global::java.lang.String org.w3c.dom.CharacterData.getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getData34824)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getData34824)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData34825;
		 void org.w3c.dom.CharacterData.setData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._setData34825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._setData34825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substringData34826;
		 global::java.lang.String org.w3c.dom.CharacterData.substringData(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._substringData34826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._substringData34826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendData34827;
		 void org.w3c.dom.CharacterData.appendData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._appendData34827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._appendData34827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertData34828;
		 void org.w3c.dom.CharacterData.insertData(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._insertData34828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._insertData34828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteData34829;
		 void org.w3c.dom.CharacterData.deleteData(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._deleteData34829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._deleteData34829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _replaceData34830;
		 void org.w3c.dom.CharacterData.replaceData(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._replaceData34830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._replaceData34830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34831;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._normalize34831);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._normalize34831);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34832;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._isSupported34832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._isSupported34832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34833;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getAttributes34833)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getAttributes34833)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34834;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getPrefix34834)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getPrefix34834)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34835;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getFirstChild34835)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getFirstChild34835)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34836;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Text_._getNodeType34836);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getNodeType34836);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34837;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getNodeName34837)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getNodeName34837)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34838;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getNodeValue34838)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getNodeValue34838)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34839;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getNextSibling34839)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getNextSibling34839)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34840;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getLocalName34840)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getLocalName34840)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34841;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._hasAttributes34841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._hasAttributes34841);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34842;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getNamespaceURI34842)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getNamespaceURI34842)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34843;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._hasChildNodes34843);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._hasChildNodes34843);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34844;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getUserData34844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getUserData34844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34845;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._setUserData34845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._setUserData34845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34846;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getFeature34846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getFeature34846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34847;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._setPrefix34847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._setPrefix34847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34848;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._setNodeValue34848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._setNodeValue34848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34849;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getParentNode34849)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getParentNode34849)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34850;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getChildNodes34850)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getChildNodes34850)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34851;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getLastChild34851)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getLastChild34851)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34852;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getPreviousSibling34852)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getPreviousSibling34852)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34853;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getOwnerDocument34853)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getOwnerDocument34853)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34854;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._insertBefore34854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._insertBefore34854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34855;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._replaceChild34855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._replaceChild34855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34856;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._removeChild34856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._removeChild34856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34857;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._appendChild34857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._appendChild34857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34858;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._cloneNode34858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._cloneNode34858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34859;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getBaseURI34859)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getBaseURI34859)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34860;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Text_._compareDocumentPosition34860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._compareDocumentPosition34860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34861;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._getTextContent34861)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._getTextContent34861)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34862;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_._setTextContent34862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._setTextContent34862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34863;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._isSameNode34863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._isSameNode34863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34864;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._lookupPrefix34864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._lookupPrefix34864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34865;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._isDefaultNamespace34865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._isDefaultNamespace34865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34866;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_._lookupNamespaceURI34866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._lookupNamespaceURI34866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34867;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_._isEqualNode34867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Text_.staticClass, global::org.w3c.dom.Text_._isEqualNode34867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Text_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Text"));
			global::org.w3c.dom.Text_._splitText34819 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "splitText", "(I)Lorg/w3c/dom/Text;");
			global::org.w3c.dom.Text_._isElementContentWhitespace34820 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "isElementContentWhitespace", "()Z");
			global::org.w3c.dom.Text_._getWholeText34821 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getWholeText", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._replaceWholeText34822 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "replaceWholeText", "(Ljava/lang/String;)Lorg/w3c/dom/Text;");
			global::org.w3c.dom.Text_._getLength34823 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getLength", "()I");
			global::org.w3c.dom.Text_._getData34824 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getData", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._setData34825 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "setData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Text_._substringData34826 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "substringData", "(II)Ljava/lang/String;");
			global::org.w3c.dom.Text_._appendData34827 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "appendData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Text_._insertData34828 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "insertData", "(ILjava/lang/String;)V");
			global::org.w3c.dom.Text_._deleteData34829 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "deleteData", "(II)V");
			global::org.w3c.dom.Text_._replaceData34830 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "replaceData", "(IILjava/lang/String;)V");
			global::org.w3c.dom.Text_._normalize34831 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Text_._isSupported34832 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Text_._getAttributes34833 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Text_._getPrefix34834 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._getFirstChild34835 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._getNodeType34836 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Text_._getNodeName34837 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._getNodeValue34838 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._getNextSibling34839 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._getLocalName34840 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._hasAttributes34841 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Text_._getNamespaceURI34842 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._hasChildNodes34843 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Text_._getUserData34844 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Text_._setUserData34845 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Text_._getFeature34846 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Text_._setPrefix34847 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Text_._setNodeValue34848 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Text_._getParentNode34849 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._getChildNodes34850 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Text_._getLastChild34851 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._getPreviousSibling34852 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._getOwnerDocument34853 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Text_._insertBefore34854 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._replaceChild34855 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._removeChild34856 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._appendChild34857 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._cloneNode34858 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Text_._getBaseURI34859 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._compareDocumentPosition34860 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Text_._getTextContent34861 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Text_._setTextContent34862 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Text_._isSameNode34863 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Text_._lookupPrefix34864 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Text_._isDefaultNamespace34865 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Text_._lookupNamespaceURI34866 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Text_._isEqualNode34867 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Text_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
