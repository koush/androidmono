namespace android.content.res
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.res.XmlResourceParser_))]
	public partial interface XmlResourceParser : org.xmlpull.v1.XmlPullParser, android.util.AttributeSet
	{
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.res.XmlResourceParser))]
	internal sealed partial class XmlResourceParser_ : java.lang.Object, XmlResourceParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XmlResourceParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.content.res.XmlResourceParser.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "close", "()V", ref global::android.content.res.XmlResourceParser_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::android.content.res.XmlResourceParser_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.content.res.XmlResourceParser_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getName", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int org.xmlpull.v1.XmlPullParser.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "next", "()I", ref global::android.content.res.XmlResourceParser_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int org.xmlpull.v1.XmlPullParser.getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getLineNumber", "()I", ref global::android.content.res.XmlResourceParser_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool org.xmlpull.v1.XmlPullParser.isWhitespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "isWhitespace", "()Z", ref global::android.content.res.XmlResourceParser_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int org.xmlpull.v1.XmlPullParser.nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "nextToken", "()I", ref global::android.content.res.XmlResourceParser_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V", ref global::android.content.res.XmlResourceParser_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "setInput", "(Ljava/io/Reader;)V", ref global::android.content.res.XmlResourceParser_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getPrefix", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int org.xmlpull.v1.XmlPullParser.getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getColumnNumber", "()I", ref global::android.content.res.XmlResourceParser_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getText", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		int org.xmlpull.v1.XmlPullParser.getEventType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getEventType", "()I", ref global::android.content.res.XmlResourceParser_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		int org.xmlpull.v1.XmlPullParser.getAttributeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeCount", "()I", ref global::android.content.res.XmlResourceParser_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::android.content.res.XmlResourceParser_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::android.content.res.XmlResourceParser_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.res.XmlResourceParser_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getNamespaceCount", "(I)I", ref global::android.content.res.XmlResourceParser_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getNamespace", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m26) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		int org.xmlpull.v1.XmlPullParser.getDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getDepth", "()I", ref global::android.content.res.XmlResourceParser_._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.res.XmlResourceParser_.staticClass, "getTextCharacters", "([I)[C", ref global::android.content.res.XmlResourceParser_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "isEmptyElementTag", "()Z", ref global::android.content.res.XmlResourceParser_._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "isAttributeDefault", "(I)Z", ref global::android.content.res.XmlResourceParser_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V", ref global::android.content.res.XmlResourceParser_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "nextText", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m36) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		int org.xmlpull.v1.XmlPullParser.nextTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "nextTag", "()I", ref global::android.content.res.XmlResourceParser_._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		int android.util.AttributeSet.getAttributeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeCount", "()I", ref global::android.content.res.XmlResourceParser_._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		global::java.lang.String android.util.AttributeSet.getPositionDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m42) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		int android.util.AttributeSet.getAttributeNameResource(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeNameResource", "(I)I", ref global::android.content.res.XmlResourceParser_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I", ref global::android.content.res.XmlResourceParser_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeListValue", "(I[Ljava/lang/String;I)I", ref global::android.content.res.XmlResourceParser_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z", ref global::android.content.res.XmlResourceParser_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeBooleanValue", "(IZ)Z", ref global::android.content.res.XmlResourceParser_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.content.res.XmlResourceParser_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeResourceValue", "(II)I", ref global::android.content.res.XmlResourceParser_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeIntValue", "(II)I", ref global::android.content.res.XmlResourceParser_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.content.res.XmlResourceParser_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", ref global::android.content.res.XmlResourceParser_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeUnsignedIntValue", "(II)I", ref global::android.content.res.XmlResourceParser_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F", ref global::android.content.res.XmlResourceParser_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getAttributeFloatValue", "(IF)F", ref global::android.content.res.XmlResourceParser_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		global::java.lang.String android.util.AttributeSet.getIdAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getIdAttribute", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m56) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m57;
		global::java.lang.String android.util.AttributeSet.getClassAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.XmlResourceParser_.staticClass, "getClassAttribute", "()Ljava/lang/String;", ref global::android.content.res.XmlResourceParser_._m57) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m58;
		int android.util.AttributeSet.getIdAttributeResourceValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getIdAttributeResourceValue", "(I)I", ref global::android.content.res.XmlResourceParser_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		int android.util.AttributeSet.getStyleAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.XmlResourceParser_.staticClass, "getStyleAttribute", "()I", ref global::android.content.res.XmlResourceParser_._m59);
		}
		static XmlResourceParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.XmlResourceParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/XmlResourceParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
