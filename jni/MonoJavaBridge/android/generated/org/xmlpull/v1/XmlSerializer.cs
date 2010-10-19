namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xmlpull.v1.XmlSerializer_))]
	public interface XmlSerializer  : global::MonoJavaBridge.IJavaObject 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		global::java.lang.String getName();
		void flush();
		void comment(java.lang.String arg0);
		global::java.lang.String getPrefix(java.lang.String arg0, bool arg1);
		global::org.xmlpull.v1.XmlSerializer text(char[] arg0, int arg1, int arg2);
		global::org.xmlpull.v1.XmlSerializer text(java.lang.String arg0);
		void startDocument(java.lang.String arg0, java.lang.Boolean arg1);
		void endDocument();
		void ignorableWhitespace(java.lang.String arg0);
		void processingInstruction(java.lang.String arg0);
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		global::java.lang.String getNamespace();
		int getDepth();
		void setOutput(java.io.OutputStream arg0, java.lang.String arg1);
		void setOutput(java.io.Writer arg0);
		void setPrefix(java.lang.String arg0, java.lang.String arg1);
		global::org.xmlpull.v1.XmlSerializer startTag(java.lang.String arg0, java.lang.String arg1);
		global::org.xmlpull.v1.XmlSerializer attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::org.xmlpull.v1.XmlSerializer endTag(java.lang.String arg0, java.lang.String arg1);
		void cdsect(java.lang.String arg0);
		void entityRef(java.lang.String arg0);
		void docdecl(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xmlpull.v1.XmlSerializer))]
	public sealed partial class XmlSerializer_ : java.lang.Object, XmlSerializer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlSerializer_()
		{
			InitJNI();
		}
		internal XmlSerializer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty28495;
		 void org.xmlpull.v1.XmlSerializer.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setProperty28495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setProperty28495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty28496;
		 global::java.lang.Object org.xmlpull.v1.XmlSerializer.getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getProperty28496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getProperty28496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName28497;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getName28497)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getName28497)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flush28498;
		 void org.xmlpull.v1.XmlSerializer.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._flush28498);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._flush28498);
		}
		internal static global::MonoJavaBridge.MethodId _comment28499;
		 void org.xmlpull.v1.XmlSerializer.comment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._comment28499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._comment28499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix28500;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getPrefix(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getPrefix28500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getPrefix28500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _text28501;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._text28501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._text28501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _text28502;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._text28502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._text28502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _startDocument28503;
		 void org.xmlpull.v1.XmlSerializer.startDocument(java.lang.String arg0, java.lang.Boolean arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._startDocument28503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._startDocument28503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endDocument28504;
		 void org.xmlpull.v1.XmlSerializer.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._endDocument28504);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._endDocument28504);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace28505;
		 void org.xmlpull.v1.XmlSerializer.ignorableWhitespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._ignorableWhitespace28505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._ignorableWhitespace28505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction28506;
		 void org.xmlpull.v1.XmlSerializer.processingInstruction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._processingInstruction28506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._processingInstruction28506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeature28507;
		 void org.xmlpull.v1.XmlSerializer.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setFeature28507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setFeature28507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature28508;
		 bool org.xmlpull.v1.XmlSerializer.getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getFeature28508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getFeature28508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace28509;
		 global::java.lang.String org.xmlpull.v1.XmlSerializer.getNamespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getNamespace28509)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getNamespace28509)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth28510;
		 int org.xmlpull.v1.XmlSerializer.getDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._getDepth28510);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._getDepth28510);
		}
		internal static global::MonoJavaBridge.MethodId _setOutput28511;
		 void org.xmlpull.v1.XmlSerializer.setOutput(java.io.OutputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setOutput28511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setOutput28511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOutput28512;
		 void org.xmlpull.v1.XmlSerializer.setOutput(java.io.Writer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setOutput28512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setOutput28512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrefix28513;
		 void org.xmlpull.v1.XmlSerializer.setPrefix(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._setPrefix28513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._setPrefix28513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startTag28514;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.startTag(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._startTag28514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._startTag28514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _attribute28515;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._attribute28515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._attribute28515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _endTag28516;
		 global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.endTag(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._endTag28516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._endTag28516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _cdsect28517;
		 void org.xmlpull.v1.XmlSerializer.cdsect(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._cdsect28517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._cdsect28517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _entityRef28518;
		 void org.xmlpull.v1.XmlSerializer.entityRef(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._entityRef28518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._entityRef28518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _docdecl28519;
		 void org.xmlpull.v1.XmlSerializer.docdecl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_._docdecl28519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlSerializer_.staticClass, global::org.xmlpull.v1.XmlSerializer_._docdecl28519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlSerializer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlSerializer"));
			global::org.xmlpull.v1.XmlSerializer_._setProperty28495 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.XmlSerializer_._getProperty28496 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.XmlSerializer_._getName28497 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlSerializer_._flush28498 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "flush", "()V");
			global::org.xmlpull.v1.XmlSerializer_._comment28499 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "comment", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._getPrefix28500 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlSerializer_._text28501 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "text", "([CII)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._text28502 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._startDocument28503 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::org.xmlpull.v1.XmlSerializer_._endDocument28504 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "endDocument", "()V");
			global::org.xmlpull.v1.XmlSerializer_._ignorableWhitespace28505 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "ignorableWhitespace", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._processingInstruction28506 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "processingInstruction", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._setFeature28507 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.XmlSerializer_._getFeature28508 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.XmlSerializer_._getNamespace28509 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlSerializer_._getDepth28510 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "getDepth", "()I");
			global::org.xmlpull.v1.XmlSerializer_._setOutput28511 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._setOutput28512 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setOutput", "(Ljava/io/Writer;)V");
			global::org.xmlpull.v1.XmlSerializer_._setPrefix28513 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._startTag28514 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._attribute28515 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._endTag28516 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlSerializer_._cdsect28517 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "cdsect", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._entityRef28518 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "entityRef", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlSerializer_._docdecl28519 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlSerializer_.staticClass, "docdecl", "(Ljava/lang/String;)V");
		}
	}
}
