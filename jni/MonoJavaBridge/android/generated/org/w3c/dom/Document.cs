namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.Document_))]
	public interface Document : Node
	{
		global::org.w3c.dom.DocumentType getDoctype();
		global::org.w3c.dom.DOMImplementation getImplementation();
		global::java.lang.String getInputEncoding();
		global::org.w3c.dom.Element getDocumentElement();
		global::org.w3c.dom.Element createElement(java.lang.String arg0);
		global::org.w3c.dom.DocumentFragment createDocumentFragment();
		global::org.w3c.dom.Text createTextNode(java.lang.String arg0);
		global::org.w3c.dom.Comment createComment(java.lang.String arg0);
		global::org.w3c.dom.CDATASection createCDATASection(java.lang.String arg0);
		global::org.w3c.dom.ProcessingInstruction createProcessingInstruction(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr createAttribute(java.lang.String arg0);
		global::org.w3c.dom.EntityReference createEntityReference(java.lang.String arg0);
		global::org.w3c.dom.NodeList getElementsByTagName(java.lang.String arg0);
		global::org.w3c.dom.Node importNode(org.w3c.dom.Node arg0, bool arg1);
		global::org.w3c.dom.Element createElementNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Attr createAttributeNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.NodeList getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1);
		global::org.w3c.dom.Element getElementById(java.lang.String arg0);
		global::java.lang.String getXmlEncoding();
		bool getXmlStandalone();
		void setXmlStandalone(bool arg0);
		global::java.lang.String getXmlVersion();
		void setXmlVersion(java.lang.String arg0);
		bool getStrictErrorChecking();
		void setStrictErrorChecking(bool arg0);
		global::java.lang.String getDocumentURI();
		void setDocumentURI(java.lang.String arg0);
		global::org.w3c.dom.Node adoptNode(org.w3c.dom.Node arg0);
		global::org.w3c.dom.DOMConfiguration getDomConfig();
		void normalizeDocument();
		global::org.w3c.dom.Node renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.Document))]
	public sealed partial class Document_ : java.lang.Object, Document
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Document_()
		{
			InitJNI();
		}
		internal Document_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDoctype27556;
		 global::org.w3c.dom.DocumentType org.w3c.dom.Document.getDoctype() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentType>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDoctype27556)) as org.w3c.dom.DocumentType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDoctype27556)) as org.w3c.dom.DocumentType;
		}
		internal static global::MonoJavaBridge.MethodId _getImplementation27557;
		 global::org.w3c.dom.DOMImplementation org.w3c.dom.Document.getImplementation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getImplementation27557)) as org.w3c.dom.DOMImplementation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMImplementation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getImplementation27557)) as org.w3c.dom.DOMImplementation;
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding27558;
		 global::java.lang.String org.w3c.dom.Document.getInputEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getInputEncoding27558)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getInputEncoding27558)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDocumentElement27559;
		 global::org.w3c.dom.Element org.w3c.dom.Document.getDocumentElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDocumentElement27559)) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDocumentElement27559)) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createElement27560;
		 global::org.w3c.dom.Element org.w3c.dom.Document.createElement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createElement27560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createElement27560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createDocumentFragment27561;
		 global::org.w3c.dom.DocumentFragment org.w3c.dom.Document.createDocumentFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentFragment>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createDocumentFragment27561)) as org.w3c.dom.DocumentFragment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DocumentFragment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createDocumentFragment27561)) as org.w3c.dom.DocumentFragment;
		}
		internal static global::MonoJavaBridge.MethodId _createTextNode27562;
		 global::org.w3c.dom.Text org.w3c.dom.Document.createTextNode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createTextNode27562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Text>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createTextNode27562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Text;
		}
		internal static global::MonoJavaBridge.MethodId _createComment27563;
		 global::org.w3c.dom.Comment org.w3c.dom.Document.createComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Comment>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createComment27563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Comment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Comment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createComment27563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Comment;
		}
		internal static global::MonoJavaBridge.MethodId _createCDATASection27564;
		 global::org.w3c.dom.CDATASection org.w3c.dom.Document.createCDATASection(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.CDATASection>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createCDATASection27564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.CDATASection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.CDATASection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createCDATASection27564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.CDATASection;
		}
		internal static global::MonoJavaBridge.MethodId _createProcessingInstruction27565;
		 global::org.w3c.dom.ProcessingInstruction org.w3c.dom.Document.createProcessingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ProcessingInstruction>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createProcessingInstruction27565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.ProcessingInstruction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ProcessingInstruction>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createProcessingInstruction27565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.ProcessingInstruction;
		}
		internal static global::MonoJavaBridge.MethodId _createAttribute27566;
		 global::org.w3c.dom.Attr org.w3c.dom.Document.createAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createAttribute27566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createAttribute27566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _createEntityReference27567;
		 global::org.w3c.dom.EntityReference org.w3c.dom.Document.createEntityReference(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.EntityReference>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createEntityReference27567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.EntityReference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.EntityReference>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createEntityReference27567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.EntityReference;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagName27568;
		 global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getElementsByTagName27568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getElementsByTagName27568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _importNode27569;
		 global::org.w3c.dom.Node org.w3c.dom.Document.importNode(org.w3c.dom.Node arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._importNode27569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._importNode27569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _createElementNS27570;
		 global::org.w3c.dom.Element org.w3c.dom.Document.createElementNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createElementNS27570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createElementNS27570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _createAttributeNS27571;
		 global::org.w3c.dom.Attr org.w3c.dom.Document.createAttributeNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._createAttributeNS27571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Attr>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._createAttributeNS27571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Attr;
		}
		internal static global::MonoJavaBridge.MethodId _getElementsByTagNameNS27572;
		 global::org.w3c.dom.NodeList org.w3c.dom.Document.getElementsByTagNameNS(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getElementsByTagNameNS27572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getElementsByTagNameNS27572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getElementById27573;
		 global::org.w3c.dom.Element org.w3c.dom.Document.getElementById(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getElementById27573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Element>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getElementById27573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlEncoding27574;
		 global::java.lang.String org.w3c.dom.Document.getXmlEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getXmlEncoding27574)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getXmlEncoding27574)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getXmlStandalone27575;
		 bool org.w3c.dom.Document.getXmlStandalone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._getXmlStandalone27575);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getXmlStandalone27575);
		}
		internal static global::MonoJavaBridge.MethodId _setXmlStandalone27576;
		 void org.w3c.dom.Document.setXmlStandalone(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setXmlStandalone27576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setXmlStandalone27576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getXmlVersion27577;
		 global::java.lang.String org.w3c.dom.Document.getXmlVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getXmlVersion27577)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getXmlVersion27577)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setXmlVersion27578;
		 void org.w3c.dom.Document.setXmlVersion(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setXmlVersion27578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setXmlVersion27578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStrictErrorChecking27579;
		 bool org.w3c.dom.Document.getStrictErrorChecking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._getStrictErrorChecking27579);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getStrictErrorChecking27579);
		}
		internal static global::MonoJavaBridge.MethodId _setStrictErrorChecking27580;
		 void org.w3c.dom.Document.setStrictErrorChecking(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setStrictErrorChecking27580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setStrictErrorChecking27580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDocumentURI27581;
		 global::java.lang.String org.w3c.dom.Document.getDocumentURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDocumentURI27581)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDocumentURI27581)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentURI27582;
		 void org.w3c.dom.Document.setDocumentURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setDocumentURI27582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setDocumentURI27582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adoptNode27583;
		 global::org.w3c.dom.Node org.w3c.dom.Document.adoptNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._adoptNode27583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._adoptNode27583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig27584;
		 global::org.w3c.dom.DOMConfiguration org.w3c.dom.Document.getDomConfig() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getDomConfig27584)) as org.w3c.dom.DOMConfiguration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getDomConfig27584)) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _normalizeDocument27585;
		 void org.w3c.dom.Document.normalizeDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._normalizeDocument27585);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._normalizeDocument27585);
		}
		internal static global::MonoJavaBridge.MethodId _renameNode27586;
		 global::org.w3c.dom.Node org.w3c.dom.Document.renameNode(org.w3c.dom.Node arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._renameNode27586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._renameNode27586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _normalize27587;
		 void org.w3c.dom.Node.normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._normalize27587);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._normalize27587);
		}
		internal static global::MonoJavaBridge.MethodId _isSupported27588;
		 bool org.w3c.dom.Node.isSupported(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isSupported27588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isSupported27588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27589;
		 global::org.w3c.dom.NamedNodeMap org.w3c.dom.Node.getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getAttributes27589)) as org.w3c.dom.NamedNodeMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NamedNodeMap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getAttributes27589)) as org.w3c.dom.NamedNodeMap;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix27590;
		 global::java.lang.String org.w3c.dom.Node.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getPrefix27590)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getPrefix27590)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFirstChild27591;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getFirstChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getFirstChild27591)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getFirstChild27591)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeType27592;
		 short org.w3c.dom.Node.getNodeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNodeType27592);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNodeType27592);
		}
		internal static global::MonoJavaBridge.MethodId _getNodeName27593;
		 global::java.lang.String org.w3c.dom.Node.getNodeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNodeName27593)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNodeName27593)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNodeValue27594;
		 global::java.lang.String org.w3c.dom.Node.getNodeValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNodeValue27594)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNodeValue27594)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling27595;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNextSibling27595)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNextSibling27595)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName27596;
		 global::java.lang.String org.w3c.dom.Node.getLocalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getLocalName27596)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getLocalName27596)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasAttributes27597;
		 bool org.w3c.dom.Node.hasAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._hasAttributes27597);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._hasAttributes27597);
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI27598;
		 global::java.lang.String org.w3c.dom.Node.getNamespaceURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getNamespaceURI27598)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getNamespaceURI27598)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildNodes27599;
		 bool org.w3c.dom.Node.hasChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._hasChildNodes27599);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._hasChildNodes27599);
		}
		internal static global::MonoJavaBridge.MethodId _getUserData27600;
		 global::java.lang.Object org.w3c.dom.Node.getUserData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getUserData27600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getUserData27600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setUserData27601;
		 global::java.lang.Object org.w3c.dom.Node.setUserData(java.lang.String arg0, java.lang.Object arg1, org.w3c.dom.UserDataHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._setUserData27601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setUserData27601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getFeature27602;
		 global::java.lang.Object org.w3c.dom.Node.getFeature(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getFeature27602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getFeature27602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix27603;
		 void org.w3c.dom.Node.setPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setPrefix27603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setPrefix27603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNodeValue27604;
		 void org.w3c.dom.Node.setNodeValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setNodeValue27604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setNodeValue27604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParentNode27605;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getParentNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getParentNode27605)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getParentNode27605)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getChildNodes27606;
		 global::org.w3c.dom.NodeList org.w3c.dom.Node.getChildNodes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getChildNodes27606)) as org.w3c.dom.NodeList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.NodeList>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getChildNodes27606)) as org.w3c.dom.NodeList;
		}
		internal static global::MonoJavaBridge.MethodId _getLastChild27607;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getLastChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getLastChild27607)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getLastChild27607)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSibling27608;
		 global::org.w3c.dom.Node org.w3c.dom.Node.getPreviousSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getPreviousSibling27608)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getPreviousSibling27608)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerDocument27609;
		 global::org.w3c.dom.Document org.w3c.dom.Node.getOwnerDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getOwnerDocument27609)) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getOwnerDocument27609)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _insertBefore27610;
		 global::org.w3c.dom.Node org.w3c.dom.Node.insertBefore(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._insertBefore27610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._insertBefore27610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _replaceChild27611;
		 global::org.w3c.dom.Node org.w3c.dom.Node.replaceChild(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._replaceChild27611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._replaceChild27611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _removeChild27612;
		 global::org.w3c.dom.Node org.w3c.dom.Node.removeChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._removeChild27612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._removeChild27612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _appendChild27613;
		 global::org.w3c.dom.Node org.w3c.dom.Node.appendChild(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._appendChild27613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._appendChild27613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _cloneNode27614;
		 global::org.w3c.dom.Node org.w3c.dom.Node.cloneNode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._cloneNode27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._cloneNode27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI27615;
		 global::java.lang.String org.w3c.dom.Node.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getBaseURI27615)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getBaseURI27615)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareDocumentPosition27616;
		 short org.w3c.dom.Node.compareDocumentPosition(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.Document_._compareDocumentPosition27616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._compareDocumentPosition27616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextContent27617;
		 global::java.lang.String org.w3c.dom.Node.getTextContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._getTextContent27617)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._getTextContent27617)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTextContent27618;
		 void org.w3c.dom.Node.setTextContent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_._setTextContent27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._setTextContent27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSameNode27619;
		 bool org.w3c.dom.Node.isSameNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isSameNode27619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isSameNode27619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupPrefix27620;
		 global::java.lang.String org.w3c.dom.Node.lookupPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._lookupPrefix27620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._lookupPrefix27620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefaultNamespace27621;
		 bool org.w3c.dom.Node.isDefaultNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isDefaultNamespace27621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isDefaultNamespace27621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lookupNamespaceURI27622;
		 global::java.lang.String org.w3c.dom.Node.lookupNamespaceURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_._lookupNamespaceURI27622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._lookupNamespaceURI27622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqualNode27623;
		 bool org.w3c.dom.Node.isEqualNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_._isEqualNode27623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.Document_.staticClass, global::org.w3c.dom.Document_._isEqualNode27623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.Document_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/Document"));
			global::org.w3c.dom.Document_._getDoctype27556 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDoctype", "()Lorg/w3c/dom/DocumentType;");
			global::org.w3c.dom.Document_._getImplementation27557 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getImplementation", "()Lorg/w3c/dom/DOMImplementation;");
			global::org.w3c.dom.Document_._getInputEncoding27558 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getDocumentElement27559 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDocumentElement", "()Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._createElement27560 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createElement", "(Ljava/lang/String;)Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._createDocumentFragment27561 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createDocumentFragment", "()Lorg/w3c/dom/DocumentFragment;");
			global::org.w3c.dom.Document_._createTextNode27562 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createTextNode", "(Ljava/lang/String;)Lorg/w3c/dom/Text;");
			global::org.w3c.dom.Document_._createComment27563 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createComment", "(Ljava/lang/String;)Lorg/w3c/dom/Comment;");
			global::org.w3c.dom.Document_._createCDATASection27564 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createCDATASection", "(Ljava/lang/String;)Lorg/w3c/dom/CDATASection;");
			global::org.w3c.dom.Document_._createProcessingInstruction27565 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ProcessingInstruction;");
			global::org.w3c.dom.Document_._createAttribute27566 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createAttribute", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Document_._createEntityReference27567 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createEntityReference", "(Ljava/lang/String;)Lorg/w3c/dom/EntityReference;");
			global::org.w3c.dom.Document_._getElementsByTagName27568 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Document_._importNode27569 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "importNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._createElementNS27570 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createElementNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._createAttributeNS27571 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "createAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;");
			global::org.w3c.dom.Document_._getElementsByTagNameNS27572 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Document_._getElementById27573 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;");
			global::org.w3c.dom.Document_._getXmlEncoding27574 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getXmlEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getXmlStandalone27575 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getXmlStandalone", "()Z");
			global::org.w3c.dom.Document_._setXmlStandalone27576 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setXmlStandalone", "(Z)V");
			global::org.w3c.dom.Document_._getXmlVersion27577 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getXmlVersion", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._setXmlVersion27578 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setXmlVersion", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._getStrictErrorChecking27579 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getStrictErrorChecking", "()Z");
			global::org.w3c.dom.Document_._setStrictErrorChecking27580 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setStrictErrorChecking", "(Z)V");
			global::org.w3c.dom.Document_._getDocumentURI27581 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDocumentURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._setDocumentURI27582 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setDocumentURI", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._adoptNode27583 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "adoptNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getDomConfig27584 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;");
			global::org.w3c.dom.Document_._normalizeDocument27585 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "normalizeDocument", "()V");
			global::org.w3c.dom.Document_._renameNode27586 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "renameNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._normalize27587 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "normalize", "()V");
			global::org.w3c.dom.Document_._isSupported27588 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.w3c.dom.Document_._getAttributes27589 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getAttributes", "()Lorg/w3c/dom/NamedNodeMap;");
			global::org.w3c.dom.Document_._getPrefix27590 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getFirstChild27591 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getFirstChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getNodeType27592 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNodeType", "()S");
			global::org.w3c.dom.Document_._getNodeName27593 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNodeName", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getNodeValue27594 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNodeValue", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._getNextSibling27595 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getLocalName27596 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getLocalName", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._hasAttributes27597 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "hasAttributes", "()Z");
			global::org.w3c.dom.Document_._getNamespaceURI27598 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getNamespaceURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._hasChildNodes27599 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "hasChildNodes", "()Z");
			global::org.w3c.dom.Document_._getUserData27600 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getUserData", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Document_._setUserData27601 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Object;");
			global::org.w3c.dom.Document_._getFeature27602 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::org.w3c.dom.Document_._setPrefix27603 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setPrefix", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._setNodeValue27604 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setNodeValue", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._getParentNode27605 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getParentNode", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getChildNodes27606 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getChildNodes", "()Lorg/w3c/dom/NodeList;");
			global::org.w3c.dom.Document_._getLastChild27607 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getLastChild", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getPreviousSibling27608 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getPreviousSibling", "()Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getOwnerDocument27609 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getOwnerDocument", "()Lorg/w3c/dom/Document;");
			global::org.w3c.dom.Document_._insertBefore27610 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._replaceChild27611 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._removeChild27612 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._appendChild27613 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._cloneNode27614 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "cloneNode", "(Z)Lorg/w3c/dom/Node;");
			global::org.w3c.dom.Document_._getBaseURI27615 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._compareDocumentPosition27616 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "compareDocumentPosition", "(Lorg/w3c/dom/Node;)S");
			global::org.w3c.dom.Document_._getTextContent27617 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "getTextContent", "()Ljava/lang/String;");
			global::org.w3c.dom.Document_._setTextContent27618 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "setTextContent", "(Ljava/lang/String;)V");
			global::org.w3c.dom.Document_._isSameNode27619 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isSameNode", "(Lorg/w3c/dom/Node;)Z");
			global::org.w3c.dom.Document_._lookupPrefix27620 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Document_._isDefaultNamespace27621 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isDefaultNamespace", "(Ljava/lang/String;)Z");
			global::org.w3c.dom.Document_._lookupNamespaceURI27622 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.w3c.dom.Document_._isEqualNode27623 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.Document_.staticClass, "isEqualNode", "(Lorg/w3c/dom/Node;)Z");
		}
	}
}
