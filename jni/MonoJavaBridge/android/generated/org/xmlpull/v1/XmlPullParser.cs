namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xmlpull.v1.XmlPullParser_))]
	public partial interface XmlPullParser  : global::MonoJavaBridge.IJavaObject 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		global::java.lang.String getName();
		int next();
		int getLineNumber();
		bool isWhitespace();
		int nextToken();
		void setInput(java.io.InputStream arg0, java.lang.String arg1);
		void setInput(java.io.Reader arg0);
		global::java.lang.String getPrefix();
		global::java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getAttributeValue(int arg0);
		int getColumnNumber();
		global::java.lang.String getText();
		int getEventType();
		int getAttributeCount();
		global::java.lang.String getAttributeName(int arg0);
		global::java.lang.String getPositionDescription();
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		global::java.lang.String getInputEncoding();
		void defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1);
		int getNamespaceCount(int arg0);
		global::java.lang.String getNamespacePrefix(int arg0);
		global::java.lang.String getNamespaceUri(int arg0);
		global::java.lang.String getNamespace();
		global::java.lang.String getNamespace(java.lang.String arg0);
		int getDepth();
		char[] getTextCharacters(int[] arg0);
		bool isEmptyElementTag();
		global::java.lang.String getAttributeNamespace(int arg0);
		global::java.lang.String getAttributePrefix(int arg0);
		global::java.lang.String getAttributeType(int arg0);
		bool isAttributeDefault(int arg0);
		void require(int arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.lang.String nextText();
		int nextTag();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xmlpull.v1.XmlPullParser))]
	public sealed partial class XmlPullParser_ : java.lang.Object, XmlPullParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlPullParser_()
		{
			InitJNI();
		}
		internal XmlPullParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35192;
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setProperty35192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setProperty35192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35193;
		 global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getProperty35193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getProperty35193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName35194;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getName35194)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getName35194)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next35195;
		 int org.xmlpull.v1.XmlPullParser.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._next35195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._next35195);
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35196;
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getLineNumber35196);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getLineNumber35196);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace35197;
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isWhitespace35197);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._isWhitespace35197);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken35198;
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextToken35198);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._nextToken35198);
		}
		internal static global::MonoJavaBridge.MethodId _setInput35199;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setInput35199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setInput35199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInput35200;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setInput35200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setInput35200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix35201;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getPrefix35201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getPrefix35201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue35202;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue35203;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35204;
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35204);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35204);
		}
		internal static global::MonoJavaBridge.MethodId _getText35205;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getText35205)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getText35205)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEventType35206;
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getEventType35206);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getEventType35206);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount35207;
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35207);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35207);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName35208;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeName35208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeName35208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription35209;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35209)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35209)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35210;
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setFeature35210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setFeature35210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35211;
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getFeature35211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getFeature35211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding35212;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35212)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35212)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _defineEntityReplacementText35213;
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceCount35214;
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespacePrefix35215;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceUri35216;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35217;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespace35217)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespace35217)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35218;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespace35218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespace35218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth35219;
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getDepth35219);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getDepth35219);
		}
		internal static global::MonoJavaBridge.MethodId _getTextCharacters35220;
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isEmptyElementTag35221;
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35221);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35221);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNamespace35222;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributePrefix35223;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeType35224;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeType35224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeType35224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAttributeDefault35225;
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _require35226;
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._require35226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._require35226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _nextText35227;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextText35227)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._nextText35227)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTag35228;
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextTag35228);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._nextTag35228);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParser"));
			global::org.xmlpull.v1.XmlPullParser_._setProperty35192 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.XmlPullParser_._getProperty35193 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.XmlPullParser_._getName35194 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._next35195 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "next", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getLineNumber35196 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getLineNumber", "()I");
			global::org.xmlpull.v1.XmlPullParser_._isWhitespace35197 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isWhitespace", "()Z");
			global::org.xmlpull.v1.XmlPullParser_._nextToken35198 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextToken", "()I");
			global::org.xmlpull.v1.XmlPullParser_._setInput35199 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParser_._setInput35200 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/Reader;)V");
			global::org.xmlpull.v1.XmlPullParser_._getPrefix35201 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35202 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35203 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35204 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getColumnNumber", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getText35205 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getText", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getEventType35206 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getEventType", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35207 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeCount", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeName35208 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35209 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._setFeature35210 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.XmlPullParser_._getFeature35211 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35212 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35213 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35214 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceCount", "(I)I");
			global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35215 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35216 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getNamespace35217 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getNamespace35218 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getDepth35219 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getDepth", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35220 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getTextCharacters", "([I)[C");
			global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35221 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isEmptyElementTag", "()Z");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35222 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35223 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeType35224 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35225 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isAttributeDefault", "(I)Z");
			global::org.xmlpull.v1.XmlPullParser_._require35226 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParser_._nextText35227 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextText", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._nextTag35228 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextTag", "()I");
		}
	}
}
