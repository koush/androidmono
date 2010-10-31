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
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xmlpull.v1.XmlPullParser_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xmlpull.v1.XmlPullParser_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.xmlpull.v1.XmlPullParser.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "next", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int org.xmlpull.v1.XmlPullParser.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getLineNumber", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool org.xmlpull.v1.XmlPullParser.isWhitespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "isWhitespace", "()Z", ref global::org.xmlpull.v1.XmlPullParser_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int org.xmlpull.v1.XmlPullParser.nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextToken", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlPullParser_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/Reader;)V", ref global::org.xmlpull.v1.XmlPullParser_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int org.xmlpull.v1.XmlPullParser.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getColumnNumber", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getText", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		int org.xmlpull.v1.XmlPullParser.getEventType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getEventType", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		int org.xmlpull.v1.XmlPullParser.getAttributeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeCount", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m17) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xmlpull.v1.XmlPullParser_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xmlpull.v1.XmlPullParser_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m20) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlPullParser_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceCount", "(I)I", ref global::org.xmlpull.v1.XmlPullParser_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m25) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		int org.xmlpull.v1.XmlPullParser.getDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getDepth", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getTextCharacters", "([I)[C", ref global::org.xmlpull.v1.XmlPullParser_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "isEmptyElementTag", "()Z", ref global::org.xmlpull.v1.XmlPullParser_._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "isAttributeDefault", "(I)Z", ref global::org.xmlpull.v1.XmlPullParser_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlPullParser_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextText", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlPullParser_._m35) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		int org.xmlpull.v1.XmlPullParser.nextTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextTag", "()I", ref global::org.xmlpull.v1.XmlPullParser_._m36);
		}
		static XmlPullParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParser"));
		}
	}
}
