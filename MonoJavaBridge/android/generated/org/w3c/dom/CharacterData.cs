namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.CharacterData_))]
	public partial interface CharacterData : Node
	{
		int getLength();
		global::java.lang.String getData();
		void setData(java.lang.String arg0);
		global::java.lang.String substringData(int arg0, int arg1);
		void appendData(java.lang.String arg0);
		void insertData(int arg0, java.lang.String arg1);
		void deleteData(int arg0, int arg1);
		void replaceData(int arg0, int arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.CharacterData))]
	internal sealed partial class CharacterData_ : java.lang.Object, CharacterData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharacterData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34246;
		int org.w3c.dom.CharacterData.getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getLength34246.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getLength34246 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getLength", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getLength34246);
		}
		internal static global::MonoJavaBridge.MethodId _getData34247;
		global::java.lang.String org.w3c.dom.CharacterData.getData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getData34247.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getData34247 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getData", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getData34247)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData34248;
		void org.w3c.dom.CharacterData.setData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._setData34248.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._setData34248 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "setData", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._setData34248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _substringData34249;
		global::java.lang.String org.w3c.dom.CharacterData.substringData(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._substringData34249.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._substringData34249 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "substringData", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._substringData34249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendData34250;
		void org.w3c.dom.CharacterData.appendData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._appendData34250.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._appendData34250 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "appendData", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._appendData34250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertData34251;
		void org.w3c.dom.CharacterData.insertData(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._insertData34251.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._insertData34251 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "insertData", "(ILjava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._insertData34251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteData34252;
		void org.w3c.dom.CharacterData.deleteData(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._deleteData34252.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._deleteData34252 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "deleteData", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._deleteData34252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _replaceData34253;
		void org.w3c.dom.CharacterData.replaceData(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._replaceData34253.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._replaceData34253 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "replaceData", "(IILjava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._replaceData34253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _normalize34254;
		void org.w3c.dom.Node.normalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._normalize34254.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._normalize34254 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "normalize", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._normalize34254);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported34255;
		bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._isSupported34255.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._isSupported34255 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._isSupported34255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes34256;
		global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getAttributes34256.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getAttributes34256 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getAttributes34256)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix34257;
		global::java.lang.String org.w3c.dom.Node.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getPrefix34257.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getPrefix34257 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getPrefix", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getPrefix34257)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild34258;
		global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getFirstChild34258.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getFirstChild34258 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getFirstChild34258)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType34259;
		short org.w3c.dom.Node.getNodeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getNodeType34259.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getNodeType34259 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getNodeType", "()S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getNodeType34259);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName34260;
		global::java.lang.String org.w3c.dom.Node.getNodeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getNodeName34260.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getNodeName34260 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getNodeName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getNodeName34260)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue34261;
		global::java.lang.String org.w3c.dom.Node.getNodeValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getNodeValue34261.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getNodeValue34261 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getNodeValue34261)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling34262;
		global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getNextSibling34262.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getNextSibling34262 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getNextSibling34262)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34263;
		global::java.lang.String org.w3c.dom.Node.getLocalName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getLocalName34263.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getLocalName34263 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getLocalName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getLocalName34263)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes34264;
		bool org.w3c.dom.Node.hasAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._hasAttributes34264.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._hasAttributes34264 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "hasAttributes", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._hasAttributes34264);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI34265;
		global::java.lang.String org.w3c.dom.Node.getNamespaceURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getNamespaceURI34265.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getNamespaceURI34265 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getNamespaceURI34265)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes34266;
		bool org.w3c.dom.Node.hasChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._hasChildNodes34266.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._hasChildNodes34266 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "hasChildNodes", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._hasChildNodes34266);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData34267;
		global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getUserData34267.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getUserData34267 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getUserData34267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData34268;
		global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._setUserData34268.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._setUserData34268 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._setUserData34268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature34269;
		global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getFeature34269.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getFeature34269 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getFeature34269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix34270;
		void org.w3c.dom.Node.setPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._setPrefix34270.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._setPrefix34270 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._setPrefix34270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue34271;
		void org.w3c.dom.Node.setNodeValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._setNodeValue34271.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._setNodeValue34271 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._setNodeValue34271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode34272;
		global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getParentNode34272.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getParentNode34272 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getParentNode34272)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes34273;
		global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getChildNodes34273.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getChildNodes34273 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getChildNodes34273)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild34274;
		global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getLastChild34274.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getLastChild34274 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getLastChild34274)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling34275;
		global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getPreviousSibling34275.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getPreviousSibling34275 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getPreviousSibling34275)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument34276;
		global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getOwnerDocument34276.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getOwnerDocument34276 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getOwnerDocument34276)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore34277;
		global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._insertBefore34277.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._insertBefore34277 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._insertBefore34277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild34278;
		global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._replaceChild34278.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._replaceChild34278 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._replaceChild34278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild34279;
		global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._removeChild34279.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._removeChild34279 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._removeChild34279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild34280;
		global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._appendChild34280.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._appendChild34280 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._appendChild34280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode34281;
		global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._cloneNode34281.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._cloneNode34281 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._cloneNode34281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34282;
		global::java.lang.String org.w3c.dom.Node.getBaseURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getBaseURI34282.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getBaseURI34282 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getBaseURI34282)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition34283;
		short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._compareDocumentPosition34283.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._compareDocumentPosition34283 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._compareDocumentPosition34283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent34284;
		global::java.lang.String org.w3c.dom.Node.getTextContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._getTextContent34284.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._getTextContent34284 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "getTextContent", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._getTextContent34284)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent34285;
		void org.w3c.dom.Node.setTextContent(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._setTextContent34285.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._setTextContent34285 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._setTextContent34285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode34286;
		bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._isSameNode34286.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._isSameNode34286 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._isSameNode34286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix34287;
		global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._lookupPrefix34287.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._lookupPrefix34287 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._lookupPrefix34287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace34288;
		bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._isDefaultNamespace34288.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._isDefaultNamespace34288 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._isDefaultNamespace34288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI34289;
		global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._lookupNamespaceURI34289.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._lookupNamespaceURI34289 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._lookupNamespaceURI34289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode34290;
		bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.CharacterData_._isEqualNode34290.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.CharacterData_._isEqualNode34290 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.CharacterData_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.CharacterData_._isEqualNode34290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CharacterData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.CharacterData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/CharacterData"));
		}
		internal static void InitJNI()
		{
		}
	}
}
