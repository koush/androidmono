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
		internal CDATASection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _splitText34197;
		global::org.w3c.dom.Text org.w3c.dom.Text.splitText(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._splitText34197.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._splitText34197 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "splitText", "(I)Lorg/w3c/dom/Text;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._splitText34197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _isElementContentWhitespace34198;
		bool org.w3c.dom.Text.isElementContentWhitespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._isElementContentWhitespace34198.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._isElementContentWhitespace34198 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isElementContentWhitespace", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isElementContentWhitespace34198);
		}
		internal static global::MonoJavaBridge.MethodId _getWholeText34199;
		global::java.lang.String org.w3c.dom.Text.getWholeText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getWholeText34199.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getWholeText34199 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getWholeText", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getWholeText34199)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWholeText34200;
		global::org.w3c.dom.Text org.w3c.dom.Text.replaceWholeText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._replaceWholeText34200.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._replaceWholeText34200 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "replaceWholeText", "(Ljava/lang/String;)Lorg/w3c/dom/Text;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._replaceWholeText34200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _getLength34201;
		int org.w3c.dom.CharacterData.getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getLength34201.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getLength34201 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getLength", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getLength34201);
		}
		internal static global::MonoJavaBridge.MethodId _getData34202;
		global::java.lang.String org.w3c.dom.CharacterData.getData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getData34202.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getData34202 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getData", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getData34202)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData34203;
		void org.w3c.dom.CharacterData.setData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._setData34203.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._setData34203 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setData", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setData34203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substringData34204;
		global::java.lang.String org.w3c.dom.CharacterData.substringData(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._substringData34204.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._substringData34204 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "substringData", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._substringData34204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendData34205;
		void org.w3c.dom.CharacterData.appendData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._appendData34205.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._appendData34205 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "appendData", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._appendData34205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertData34206;
		void org.w3c.dom.CharacterData.insertData(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._insertData34206.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._insertData34206 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "insertData", "(ILjava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._insertData34206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteData34207;
		void org.w3c.dom.CharacterData.deleteData(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._deleteData34207.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._deleteData34207 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "deleteData", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._deleteData34207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _replaceData34208;
		void org.w3c.dom.CharacterData.replaceData(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._replaceData34208.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._replaceData34208 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "replaceData", "(IILjava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._replaceData34208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34209;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._normalize34209.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._normalize34209 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "normalize", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._normalize34209);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34210;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._isSupported34210.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._isSupported34210 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isSupported34210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34211;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getAttributes34211.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getAttributes34211 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getAttributes34211)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34212;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getPrefix34212.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getPrefix34212 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getPrefix", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getPrefix34212)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34213;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getFirstChild34213.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getFirstChild34213 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getFirstChild34213)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34214;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getNodeType34214.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getNodeType34214 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNodeType", "()S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNodeType34214);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34215;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getNodeName34215.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getNodeName34215 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNodeName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNodeName34215)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34216;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getNodeValue34216.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getNodeValue34216 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNodeValue34216)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34217;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getNextSibling34217.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getNextSibling34217 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNextSibling34217)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34218;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getLocalName34218.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getLocalName34218 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getLocalName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getLocalName34218)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34219;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._hasAttributes34219.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._hasAttributes34219 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "hasAttributes", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._hasAttributes34219);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34220;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getNamespaceURI34220.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getNamespaceURI34220 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getNamespaceURI34220)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34221;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._hasChildNodes34221.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._hasChildNodes34221 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "hasChildNodes", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._hasChildNodes34221);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34222;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getUserData34222.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getUserData34222 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getUserData34222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34223;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._setUserData34223.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._setUserData34223 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setUserData34223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34224;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getFeature34224.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getFeature34224 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getFeature34224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34225;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._setPrefix34225.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._setPrefix34225 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setPrefix34225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34226;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._setNodeValue34226.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._setNodeValue34226 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setNodeValue34226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34227;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getParentNode34227.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getParentNode34227 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getParentNode34227)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34228;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getChildNodes34228.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getChildNodes34228 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getChildNodes34228)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34229;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getLastChild34229.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getLastChild34229 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getLastChild34229)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34230;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getPreviousSibling34230.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getPreviousSibling34230 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getPreviousSibling34230)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34231;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getOwnerDocument34231.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getOwnerDocument34231 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getOwnerDocument34231)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34232;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._insertBefore34232.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._insertBefore34232 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._insertBefore34232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34233;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._replaceChild34233.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._replaceChild34233 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._replaceChild34233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34234;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._removeChild34234.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._removeChild34234 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._removeChild34234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34235;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._appendChild34235.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._appendChild34235 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._appendChild34235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34236;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._cloneNode34236.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._cloneNode34236 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._cloneNode34236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34237;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getBaseURI34237.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getBaseURI34237 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getBaseURI34237)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34238;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._compareDocumentPosition34238.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._compareDocumentPosition34238 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._compareDocumentPosition34238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34239;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._getTextContent34239.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._getTextContent34239 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "getTextContent", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._getTextContent34239)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34240;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._setTextContent34240.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._setTextContent34240 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._setTextContent34240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34241;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._isSameNode34241.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._isSameNode34241 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isSameNode34241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34242;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._lookupPrefix34242.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._lookupPrefix34242 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._lookupPrefix34242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34243;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._isDefaultNamespace34243.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._isDefaultNamespace34243 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isDefaultNamespace34243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34244;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._lookupNamespaceURI34244.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._lookupNamespaceURI34244 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._lookupNamespaceURI34244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34245;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CDATASection_._isEqualNode34245.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CDATASection_._isEqualNode34245 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CDATASection_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CDATASection_._isEqualNode34245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CDATASection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.CDATASection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/CDATASection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
