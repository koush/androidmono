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
	internal sealed partial class XmlPullParser_ : java.lang.Object, XmlPullParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XmlPullParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35311;
		void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xmlpull.v1.XmlPullParser_._setProperty35311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35312;
		global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xmlpull.v1.XmlPullParser_._getProperty35312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName35313;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getName35313) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next35314;
		int org.xmlpull.v1.XmlPullParser.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "next", "()I", ref global::org.xmlpull.v1.XmlPullParser_._next35314);
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35315;
		int org.xmlpull.v1.XmlPullParser.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getLineNumber", "()I", ref global::org.xmlpull.v1.XmlPullParser_._getLineNumber35315);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace35316;
		bool org.xmlpull.v1.XmlPullParser.isWhitespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "isWhitespace", "()Z", ref global::org.xmlpull.v1.XmlPullParser_._isWhitespace35316);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken35317;
		int org.xmlpull.v1.XmlPullParser.nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextToken", "()I", ref global::org.xmlpull.v1.XmlPullParser_._nextToken35317);
		}
		internal static global::MonoJavaBridge.MethodId _setInput35318;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlPullParser_._setInput35318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInput35319;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/Reader;)V", ref global::org.xmlpull.v1.XmlPullParser_._setInput35319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix35320;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getPrefix35320) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue35321;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue35322;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35323;
		int org.xmlpull.v1.XmlPullParser.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getColumnNumber", "()I", ref global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35323);
		}
		internal static global::MonoJavaBridge.MethodId _getText35324;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getText", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getText35324) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEventType35325;
		int org.xmlpull.v1.XmlPullParser.getEventType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getEventType", "()I", ref global::org.xmlpull.v1.XmlPullParser_._getEventType35325);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount35326;
		int org.xmlpull.v1.XmlPullParser.getAttributeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeCount", "()I", ref global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35326);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName35327;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getAttributeName35327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription35328;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35328) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35329;
		void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xmlpull.v1.XmlPullParser_._setFeature35329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35330;
		bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xmlpull.v1.XmlPullParser_._getFeature35330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding35331;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35331) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _defineEntityReplacementText35332;
		void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceCount35333;
		int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceCount", "(I)I", ref global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespacePrefix35334;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceUri35335;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35336;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getNamespace35336) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35337;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getNamespace35337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth35338;
		int org.xmlpull.v1.XmlPullParser.getDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getDepth", "()I", ref global::org.xmlpull.v1.XmlPullParser_._getDepth35338);
		}
		internal static global::MonoJavaBridge.MethodId _getTextCharacters35339;
		char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getTextCharacters", "([I)[C", ref global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isEmptyElementTag35340;
		bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "isEmptyElementTag", "()Z", ref global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35340);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNamespace35341;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributePrefix35342;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeType35343;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._getAttributeType35343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAttributeDefault35344;
		bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "isAttributeDefault", "(I)Z", ref global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _require35345;
		void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlPullParser_._require35345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _nextText35346;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextText", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._nextText35346) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTag35347;
		int org.xmlpull.v1.XmlPullParser.nextTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextTag", "()I", ref global::org.xmlpull.v1.XmlPullParser_._nextTag35347);
		}
		static XmlPullParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
