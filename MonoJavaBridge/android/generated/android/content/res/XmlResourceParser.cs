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
		internal static global::MonoJavaBridge.MethodId _close4284;
		void android.content.res.XmlResourceParser.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._close4284);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._close4284);
		}
		internal static global::MonoJavaBridge.MethodId _setProperty4285;
		void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setProperty4285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setProperty4285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty4286;
		global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getProperty4286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getProperty4286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName4287;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getName4287)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getName4287)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next4288;
		int org.xmlpull.v1.XmlPullParser.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._next4288);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._next4288);
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber4289;
		int org.xmlpull.v1.XmlPullParser.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getLineNumber4289);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getLineNumber4289);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace4290;
		bool org.xmlpull.v1.XmlPullParser.isWhitespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._isWhitespace4290);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._isWhitespace4290);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken4291;
		int org.xmlpull.v1.XmlPullParser.nextToken()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._nextToken4291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._nextToken4291);
		}
		internal static global::MonoJavaBridge.MethodId _setInput4292;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setInput4292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setInput4292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInput4293;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setInput4293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setInput4293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix4294;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getPrefix4294)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getPrefix4294)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue4295;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue4295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue4295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue4296;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue4296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue4296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber4297;
		int org.xmlpull.v1.XmlPullParser.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getColumnNumber4297);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getColumnNumber4297);
		}
		internal static global::MonoJavaBridge.MethodId _getText4298;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getText4298)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getText4298)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEventType4299;
		int org.xmlpull.v1.XmlPullParser.getEventType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getEventType4299);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getEventType4299);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount4300;
		int org.xmlpull.v1.XmlPullParser.getAttributeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeCount4300);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeCount4300);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName4301;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeName4301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeName4301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription4302;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getPositionDescription4302)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getPositionDescription4302)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature4303;
		void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setFeature4303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setFeature4303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature4304;
		bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getFeature4304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getFeature4304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding4305;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getInputEncoding4305)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getInputEncoding4305)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _defineEntityReplacementText4306;
		void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._defineEntityReplacementText4306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._defineEntityReplacementText4306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceCount4307;
		int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespaceCount4307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespaceCount4307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespacePrefix4308;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespacePrefix4308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespacePrefix4308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceUri4309;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespaceUri4309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespaceUri4309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace4310;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespace4310)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespace4310)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace4311;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespace4311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespace4311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth4312;
		int org.xmlpull.v1.XmlPullParser.getDepth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getDepth4312);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getDepth4312);
		}
		internal static global::MonoJavaBridge.MethodId _getTextCharacters4313;
		char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getTextCharacters4313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getTextCharacters4313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isEmptyElementTag4314;
		bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._isEmptyElementTag4314);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._isEmptyElementTag4314);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNamespace4315;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeNamespace4315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeNamespace4315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributePrefix4316;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributePrefix4316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributePrefix4316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeType4317;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeType4317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeType4317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAttributeDefault4318;
		bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._isAttributeDefault4318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._isAttributeDefault4318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _require4319;
		void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._require4319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._require4319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _nextText4320;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._nextText4320)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._nextText4320)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTag4321;
		int org.xmlpull.v1.XmlPullParser.nextTag()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._nextTag4321);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._nextTag4321);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue4322;
		global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue4322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue4322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue4323;
		global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue4323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue4323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount4324;
		int android.util.AttributeSet.getAttributeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeCount4324);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeCount4324);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName4325;
		global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeName4325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeName4325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription4326;
		global::java.lang.String android.util.AttributeSet.getPositionDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getPositionDescription4326)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getPositionDescription4326)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNameResource4327;
		int android.util.AttributeSet.getAttributeNameResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeNameResource4327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeNameResource4327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue4328;
		int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeListValue4328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeListValue4328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue4329;
		int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeListValue4329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeListValue4329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue4330;
		bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue4330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue4330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue4331;
		bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue4331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue4331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue4332;
		int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeResourceValue4332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeResourceValue4332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue4333;
		int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeResourceValue4333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeResourceValue4333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue4334;
		int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeIntValue4334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeIntValue4334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue4335;
		int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeIntValue4335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeIntValue4335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue4336;
		int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue4336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue4336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue4337;
		int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue4337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue4337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue4338;
		float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeFloatValue4338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeFloatValue4338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue4339;
		float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeFloatValue4339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeFloatValue4339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttribute4340;
		global::java.lang.String android.util.AttributeSet.getIdAttribute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getIdAttribute4340)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getIdAttribute4340)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClassAttribute4341;
		global::java.lang.String android.util.AttributeSet.getClassAttribute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getClassAttribute4341)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getClassAttribute4341)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttributeResourceValue4342;
		int android.util.AttributeSet.getIdAttributeResourceValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getIdAttributeResourceValue4342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getIdAttributeResourceValue4342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStyleAttribute4343;
		int android.util.AttributeSet.getStyleAttribute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getStyleAttribute4343);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getStyleAttribute4343);
		}
		static XmlResourceParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.XmlResourceParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/XmlResourceParser"));
			global::android.content.res.XmlResourceParser_._close4284 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "close", "()V");
			global::android.content.res.XmlResourceParser_._setProperty4285 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.content.res.XmlResourceParser_._getProperty4286 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.res.XmlResourceParser_._getName4287 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getName", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._next4288 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "next", "()I");
			global::android.content.res.XmlResourceParser_._getLineNumber4289 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getLineNumber", "()I");
			global::android.content.res.XmlResourceParser_._isWhitespace4290 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "isWhitespace", "()Z");
			global::android.content.res.XmlResourceParser_._nextToken4291 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "nextToken", "()I");
			global::android.content.res.XmlResourceParser_._setInput4292 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::android.content.res.XmlResourceParser_._setInput4293 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setInput", "(Ljava/io/Reader;)V");
			global::android.content.res.XmlResourceParser_._getPrefix4294 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeValue4295 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeValue4296 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getColumnNumber4297 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getColumnNumber", "()I");
			global::android.content.res.XmlResourceParser_._getText4298 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getText", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getEventType4299 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getEventType", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeCount4300 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeCount", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeName4301 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getPositionDescription4302 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._setFeature4303 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::android.content.res.XmlResourceParser_._getFeature4304 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::android.content.res.XmlResourceParser_._getInputEncoding4305 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._defineEntityReplacementText4306 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.res.XmlResourceParser_._getNamespaceCount4307 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespaceCount", "(I)I");
			global::android.content.res.XmlResourceParser_._getNamespacePrefix4308 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getNamespaceUri4309 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getNamespace4310 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespace", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getNamespace4311 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getDepth4312 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getDepth", "()I");
			global::android.content.res.XmlResourceParser_._getTextCharacters4313 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getTextCharacters", "([I)[C");
			global::android.content.res.XmlResourceParser_._isEmptyElementTag4314 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "isEmptyElementTag", "()Z");
			global::android.content.res.XmlResourceParser_._getAttributeNamespace4315 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributePrefix4316 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeType4317 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._isAttributeDefault4318 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "isAttributeDefault", "(I)Z");
			global::android.content.res.XmlResourceParser_._require4319 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::android.content.res.XmlResourceParser_._nextText4320 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "nextText", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._nextTag4321 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "nextTag", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeValue4322 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeValue4323 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeCount4324 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeCount", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeName4325 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getPositionDescription4326 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeNameResource4327 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeNameResource", "(I)I");
			global::android.content.res.XmlResourceParser_._getAttributeListValue4328 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeListValue4329 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeListValue", "(I[Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeBooleanValue4330 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			global::android.content.res.XmlResourceParser_._getAttributeBooleanValue4331 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeBooleanValue", "(IZ)Z");
			global::android.content.res.XmlResourceParser_._getAttributeResourceValue4332 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeResourceValue4333 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeResourceValue", "(II)I");
			global::android.content.res.XmlResourceParser_._getAttributeIntValue4334 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeIntValue", "(II)I");
			global::android.content.res.XmlResourceParser_._getAttributeIntValue4335 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue4336 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue4337 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeUnsignedIntValue", "(II)I");
			global::android.content.res.XmlResourceParser_._getAttributeFloatValue4338 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			global::android.content.res.XmlResourceParser_._getAttributeFloatValue4339 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeFloatValue", "(IF)F");
			global::android.content.res.XmlResourceParser_._getIdAttribute4340 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getIdAttribute", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getClassAttribute4341 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getClassAttribute", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getIdAttributeResourceValue4342 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getIdAttributeResourceValue", "(I)I");
			global::android.content.res.XmlResourceParser_._getStyleAttribute4343 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getStyleAttribute", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
