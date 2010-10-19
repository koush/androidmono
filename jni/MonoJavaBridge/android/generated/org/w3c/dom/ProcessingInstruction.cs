namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ProcessingInstruction_))]
	public interface ProcessingInstruction : Node
	{
		global::java.lang.String getData();
		void setData(java.lang.String arg0);
		global::java.lang.String getTarget();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ProcessingInstruction))]
	public sealed partial class ProcessingInstruction_ : java.lang.Object, ProcessingInstruction
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProcessingInstruction_()
		{
			InitJNI();
		}
		internal ProcessingInstruction_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getData27932;
		 global::java.lang.String org.w3c.dom.ProcessingInstruction.getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getData27932)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getData27932)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setData27933;
		 void org.w3c.dom.ProcessingInstruction.setData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setData27933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._setData27933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTarget27934;
		 global::java.lang.String org.w3c.dom.ProcessingInstruction.getTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getTarget27934)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getTarget27934)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _normalize27935;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._normalize27935);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._normalize27935);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported27936;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isSupported27936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._isSupported27936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27937;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getAttributes27937)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getAttributes27937)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix27938;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getPrefix27938)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getPrefix27938)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild27939;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getFirstChild27939)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getFirstChild27939)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType27940;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNodeType27940);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getNodeType27940);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName27941;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNodeName27941)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getNodeName27941)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue27942;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNodeValue27942)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getNodeValue27942)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling27943;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNextSibling27943)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getNextSibling27943)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName27944;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getLocalName27944)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getLocalName27944)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes27945;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._hasAttributes27945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._hasAttributes27945);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI27946;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getNamespaceURI27946)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getNamespaceURI27946)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes27947;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._hasChildNodes27947);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._hasChildNodes27947);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData27948;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getUserData27948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getUserData27948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData27949;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setUserData27949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._setUserData27949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature27950;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getFeature27950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getFeature27950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix27951;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setPrefix27951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._setPrefix27951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue27952;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setNodeValue27952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._setNodeValue27952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode27953;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getParentNode27953)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getParentNode27953)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes27954;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getChildNodes27954)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getChildNodes27954)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild27955;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getLastChild27955)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getLastChild27955)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling27956;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getPreviousSibling27956)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getPreviousSibling27956)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument27957;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getOwnerDocument27957)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getOwnerDocument27957)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore27958;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._insertBefore27958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._insertBefore27958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild27959;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._replaceChild27959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._replaceChild27959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild27960;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._removeChild27960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._removeChild27960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild27961;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._appendChild27961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._appendChild27961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode27962;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._cloneNode27962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._cloneNode27962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI27963;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getBaseURI27963)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getBaseURI27963)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition27964;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._compareDocumentPosition27964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._compareDocumentPosition27964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent27965;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._getTextContent27965)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._getTextContent27965)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent27966;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._setTextContent27966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._setTextContent27966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode27967;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isSameNode27967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._isSameNode27967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix27968;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._lookupPrefix27968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._lookupPrefix27968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace27969;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isDefaultNamespace27969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._isDefaultNamespace27969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI27970;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._lookupNamespaceURI27970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._lookupNamespaceURI27970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode27971;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_._isEqualNode27971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ProcessingInstruction_.staticClass, global::org.w3c.dom.ProcessingInstruction_._isEqualNode27971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ProcessingInstruction_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ProcessingInstruction"));
			global::org.w3c.dom.ProcessingInstruction_._getData27932 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getData", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._setData27933 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._getTarget27934 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getTarget", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._normalize27935 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "normalize", "()V");
			global::org.w3c.dom.ProcessingInstruction_._isSupported27936 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.ProcessingInstruction_._getAttributes27937 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.ProcessingInstruction_._getPrefix27938 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._getFirstChild27939 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getNodeType27940 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.ProcessingInstruction_._getNodeName27941 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._getNodeValue27942 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._getNextSibling27943 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getLocalName27944 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._hasAttributes27945 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.ProcessingInstruction_._getNamespaceURI27946 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._hasChildNodes27947 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.ProcessingInstruction_._getUserData27948 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.ProcessingInstruction_._setUserData27949 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.ProcessingInstruction_._getFeature27950 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.ProcessingInstruction_._setPrefix27951 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._setNodeValue27952 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._getParentNode27953 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getChildNodes27954 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.ProcessingInstruction_._getLastChild27955 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getPreviousSibling27956 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getOwnerDocument27957 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.ProcessingInstruction_._insertBefore27958 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._replaceChild27959 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._removeChild27960 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._appendChild27961 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._cloneNode27962 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.ProcessingInstruction_._getBaseURI27963 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._compareDocumentPosition27964 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.ProcessingInstruction_._getTextContent27965 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._setTextContent27966 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ProcessingInstruction_._isSameNode27967 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.ProcessingInstruction_._lookupPrefix27968 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._isDefaultNamespace27969 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.ProcessingInstruction_._lookupNamespaceURI27970 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.ProcessingInstruction_._isEqualNode27971 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ProcessingInstruction_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
