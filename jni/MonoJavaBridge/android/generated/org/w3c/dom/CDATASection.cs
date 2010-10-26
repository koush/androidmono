namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.CDATASection_))]
	public partial interface CDATASection : Text
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.CDATASection))]
	internal sealed partial class CDATASection_ : java.lang.Object, CDATASection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CDATASection_()
		{
			InitJNI();
		}
		internal CDATASection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _splitText34196;
		 global::org.w3c.dom.Text org.w3c.dom.Text.splitText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._splitText34196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._splitText34196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _isElementContentWhitespace34197;
		 bool org.w3c.dom.Text.isElementContentWhitespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isElementContentWhitespace34197);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._isElementContentWhitespace34197);
		}
		internal static global::MonoJavaBridge.MethodId _getWholeText34198;
		 global::java.lang.String org.w3c.dom.Text.getWholeText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getWholeText34198)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getWholeText34198)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWholeText34199;
		 global::org.w3c.dom.Text org.w3c.dom.Text.replaceWholeText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._replaceWholeText34199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._replaceWholeText34199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _getLength34200;
		 int org.w3c.dom.CharacterData.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getLength34200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getLength34200);
		}
		internal static global::MonoJavaBridge.MethodId _getData34201;
		 global::java.lang.String org.w3c.dom.CharacterData.getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getData34201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getData34201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData34202;
		 void org.w3c.dom.CharacterData.setData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setData34202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._setData34202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substringData34203;
		 global::java.lang.String org.w3c.dom.CharacterData.substringData(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._substringData34203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._substringData34203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendData34204;
		 void org.w3c.dom.CharacterData.appendData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._appendData34204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._appendData34204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertData34205;
		 void org.w3c.dom.CharacterData.insertData(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._insertData34205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._insertData34205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteData34206;
		 void org.w3c.dom.CharacterData.deleteData(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._deleteData34206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._deleteData34206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _replaceData34207;
		 void org.w3c.dom.CharacterData.replaceData(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._replaceData34207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._replaceData34207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34208;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._normalize34208);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._normalize34208);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34209;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isSupported34209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._isSupported34209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34210;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getAttributes34210)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getAttributes34210)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34211;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getPrefix34211)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getPrefix34211)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34212;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getFirstChild34212)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getFirstChild34212)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34213;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNodeType34213);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getNodeType34213);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34214;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNodeName34214)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getNodeName34214)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34215;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNodeValue34215)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getNodeValue34215)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34216;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNextSibling34216)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getNextSibling34216)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34217;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getLocalName34217)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getLocalName34217)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34218;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._hasAttributes34218);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._hasAttributes34218);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34219;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNamespaceURI34219)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getNamespaceURI34219)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34220;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._hasChildNodes34220);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._hasChildNodes34220);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34221;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getUserData34221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getUserData34221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34222;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setUserData34222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._setUserData34222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34223;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getFeature34223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getFeature34223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34224;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setPrefix34224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._setPrefix34224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34225;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setNodeValue34225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._setNodeValue34225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34226;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getParentNode34226)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getParentNode34226)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34227;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getChildNodes34227)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getChildNodes34227)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34228;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getLastChild34228)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getLastChild34228)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34229;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getPreviousSibling34229)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getPreviousSibling34229)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34230;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getOwnerDocument34230)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getOwnerDocument34230)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34231;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._insertBefore34231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._insertBefore34231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34232;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._replaceChild34232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._replaceChild34232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34233;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._removeChild34233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._removeChild34233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34234;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._appendChild34234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._appendChild34234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34235;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._cloneNode34235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._cloneNode34235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34236;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getBaseURI34236)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getBaseURI34236)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34237;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._compareDocumentPosition34237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._compareDocumentPosition34237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34238;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getTextContent34238)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._getTextContent34238)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34239;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setTextContent34239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._setTextContent34239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34240;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isSameNode34240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._isSameNode34240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34241;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._lookupPrefix34241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._lookupPrefix34241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34242;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isDefaultNamespace34242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._isDefaultNamespace34242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34243;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._lookupNamespaceURI34243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._lookupNamespaceURI34243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34244;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isEqualNode34244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_.staticClass, global::org.w3c.dom.CDATASection_._isEqualNode34244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.CDATASection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/CDATASection"));
			global::org.w3c.dom.CDATASection_._splitText34196 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "splitText", "(I)Lorg/w3c/dom/Text;");
			global::org.w3c.dom.CDATASection_._isElementContentWhitespace34197 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isElementContentWhitespace", "()Z");
			global::org.w3c.dom.CDATASection_._getWholeText34198 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getWholeText", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._replaceWholeText34199 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "replaceWholeText", "(Ljava/lang/String;)Lorg/w3c/dom/Text;");
			global::org.w3c.dom.CDATASection_._getLength34200 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getLength", "()I");
			global::org.w3c.dom.CDATASection_._getData34201 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getData", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._setData34202 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._substringData34203 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "substringData", "(II)Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._appendData34204 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "appendData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._insertData34205 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "insertData", "(ILjava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._deleteData34206 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "deleteData", "(II)V");
			global::org.w3c.dom.CDATASection_._replaceData34207 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "replaceData", "(IILjava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._normalize34208 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "normalize", "()V");
			global::org.w3c.dom.CDATASection_._isSupported34209 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.CDATASection_._getAttributes34210 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.CDATASection_._getPrefix34211 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._getFirstChild34212 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._getNodeType34213 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.CDATASection_._getNodeName34214 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._getNodeValue34215 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._getNextSibling34216 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._getLocalName34217 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._hasAttributes34218 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.CDATASection_._getNamespaceURI34219 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._hasChildNodes34220 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.CDATASection_._getUserData34221 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.CDATASection_._setUserData34222 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.CDATASection_._getFeature34223 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.CDATASection_._setPrefix34224 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._setNodeValue34225 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._getParentNode34226 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._getChildNodes34227 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.CDATASection_._getLastChild34228 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._getPreviousSibling34229 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._getOwnerDocument34230 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.CDATASection_._insertBefore34231 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._replaceChild34232 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._removeChild34233 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._appendChild34234 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._cloneNode34235 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.CDATASection_._getBaseURI34236 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._compareDocumentPosition34237 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.CDATASection_._getTextContent34238 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._setTextContent34239 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.CDATASection_._isSameNode34240 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.CDATASection_._lookupPrefix34241 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._isDefaultNamespace34242 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.CDATASection_._lookupNamespaceURI34243 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.CDATASection_._isEqualNode34244 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
