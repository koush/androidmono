namespace android.content.res
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.res.XmlResourceParser_))]
	public interface XmlResourceParser : org.xmlpull.v1.XmlPullParser, android.util.AttributeSet
	{
		void close();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.res.XmlResourceParser))]
	public sealed partial class XmlResourceParser_ : java.lang.Object, XmlResourceParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlResourceParser_()
		{
			InitJNI();
		}
		internal XmlResourceParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close2369;
		 void android.content.res.XmlResourceParser.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._close2369);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._close2369);
		}
		internal static global::MonoJavaBridge.MethodId _setProperty2370;
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setProperty2370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setProperty2370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty2371;
		 global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getProperty2371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getProperty2371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName2372;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getName2372)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getName2372)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next2373;
		 int org.xmlpull.v1.XmlPullParser.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._next2373);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._next2373);
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber2374;
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getLineNumber2374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getLineNumber2374);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace2375;
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._isWhitespace2375);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._isWhitespace2375);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken2376;
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._nextToken2376);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._nextToken2376);
		}
		internal static global::MonoJavaBridge.MethodId _setInput2377;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setInput2377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setInput2377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInput2378;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setInput2378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setInput2378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix2379;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getPrefix2379)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getPrefix2379)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue2380;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue2380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue2380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue2381;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue2381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue2381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber2382;
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getColumnNumber2382);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getColumnNumber2382);
		}
		internal static global::MonoJavaBridge.MethodId _getText2383;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getText2383)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getText2383)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEventType2384;
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getEventType2384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getEventType2384);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount2385;
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeCount2385);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeCount2385);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName2386;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeName2386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeName2386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription2387;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getPositionDescription2387)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getPositionDescription2387)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature2388;
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._setFeature2388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._setFeature2388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature2389;
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getFeature2389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getFeature2389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding2390;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getInputEncoding2390)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getInputEncoding2390)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _defineEntityReplacementText2391;
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._defineEntityReplacementText2391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._defineEntityReplacementText2391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceCount2392;
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespaceCount2392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespaceCount2392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespacePrefix2393;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespacePrefix2393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespacePrefix2393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceUri2394;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespaceUri2394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespaceUri2394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace2395;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespace2395)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespace2395)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace2396;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getNamespace2396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getNamespace2396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth2397;
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getDepth2397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getDepth2397);
		}
		internal static global::MonoJavaBridge.MethodId _getTextCharacters2398;
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getTextCharacters2398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getTextCharacters2398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isEmptyElementTag2399;
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._isEmptyElementTag2399);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._isEmptyElementTag2399);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNamespace2400;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeNamespace2400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeNamespace2400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributePrefix2401;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributePrefix2401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributePrefix2401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeType2402;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeType2402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeType2402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAttributeDefault2403;
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._isAttributeDefault2403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._isAttributeDefault2403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _require2404;
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._require2404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._require2404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _nextText2405;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._nextText2405)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._nextText2405)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTag2406;
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._nextTag2406);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._nextTag2406);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue2407;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue2407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue2407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue2408;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeValue2408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeValue2408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount2409;
		 int android.util.AttributeSet.getAttributeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeCount2409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeCount2409);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName2410;
		 global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeName2410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeName2410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription2411;
		 global::java.lang.String android.util.AttributeSet.getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getPositionDescription2411)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getPositionDescription2411)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNameResource2412;
		 int android.util.AttributeSet.getAttributeNameResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeNameResource2412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeNameResource2412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue2413;
		 int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeListValue2413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeListValue2413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue2414;
		 int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeListValue2414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeListValue2414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue2415;
		 bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue2415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue2415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue2416;
		 bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue2416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeBooleanValue2416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue2417;
		 int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeResourceValue2417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeResourceValue2417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue2418;
		 int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeResourceValue2418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeResourceValue2418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue2419;
		 int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeIntValue2419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeIntValue2419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue2420;
		 int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeIntValue2420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeIntValue2420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue2421;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue2421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue2421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue2422;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue2422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue2422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue2423;
		 float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeFloatValue2423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeFloatValue2423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue2424;
		 float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getAttributeFloatValue2424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getAttributeFloatValue2424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttribute2425;
		 global::java.lang.String android.util.AttributeSet.getIdAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getIdAttribute2425)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getIdAttribute2425)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClassAttribute2426;
		 global::java.lang.String android.util.AttributeSet.getClassAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getClassAttribute2426)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getClassAttribute2426)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttributeResourceValue2427;
		 int android.util.AttributeSet.getIdAttributeResourceValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getIdAttributeResourceValue2427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getIdAttributeResourceValue2427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStyleAttribute2428;
		 int android.util.AttributeSet.getStyleAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_._getStyleAttribute2428);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.XmlResourceParser_.staticClass, global::android.content.res.XmlResourceParser_._getStyleAttribute2428);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.XmlResourceParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/XmlResourceParser"));
			global::android.content.res.XmlResourceParser_._close2369 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "close", "()V");
			global::android.content.res.XmlResourceParser_._setProperty2370 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.content.res.XmlResourceParser_._getProperty2371 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.res.XmlResourceParser_._getName2372 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getName", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._next2373 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "next", "()I");
			global::android.content.res.XmlResourceParser_._getLineNumber2374 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getLineNumber", "()I");
			global::android.content.res.XmlResourceParser_._isWhitespace2375 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "isWhitespace", "()Z");
			global::android.content.res.XmlResourceParser_._nextToken2376 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "nextToken", "()I");
			global::android.content.res.XmlResourceParser_._setInput2377 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::android.content.res.XmlResourceParser_._setInput2378 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setInput", "(Ljava/io/Reader;)V");
			global::android.content.res.XmlResourceParser_._getPrefix2379 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeValue2380 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeValue2381 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getColumnNumber2382 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getColumnNumber", "()I");
			global::android.content.res.XmlResourceParser_._getText2383 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getText", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getEventType2384 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getEventType", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeCount2385 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeCount", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeName2386 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getPositionDescription2387 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._setFeature2388 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::android.content.res.XmlResourceParser_._getFeature2389 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::android.content.res.XmlResourceParser_._getInputEncoding2390 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._defineEntityReplacementText2391 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.res.XmlResourceParser_._getNamespaceCount2392 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespaceCount", "(I)I");
			global::android.content.res.XmlResourceParser_._getNamespacePrefix2393 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getNamespaceUri2394 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getNamespace2395 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespace", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getNamespace2396 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getDepth2397 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getDepth", "()I");
			global::android.content.res.XmlResourceParser_._getTextCharacters2398 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getTextCharacters", "([I)[C");
			global::android.content.res.XmlResourceParser_._isEmptyElementTag2399 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "isEmptyElementTag", "()Z");
			global::android.content.res.XmlResourceParser_._getAttributeNamespace2400 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributePrefix2401 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeType2402 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._isAttributeDefault2403 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "isAttributeDefault", "(I)Z");
			global::android.content.res.XmlResourceParser_._require2404 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::android.content.res.XmlResourceParser_._nextText2405 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "nextText", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._nextTag2406 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "nextTag", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeValue2407 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeValue2408 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeCount2409 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeCount", "()I");
			global::android.content.res.XmlResourceParser_._getAttributeName2410 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getPositionDescription2411 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getAttributeNameResource2412 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeNameResource", "(I)I");
			global::android.content.res.XmlResourceParser_._getAttributeListValue2413 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeListValue2414 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeListValue", "(I[Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeBooleanValue2415 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			global::android.content.res.XmlResourceParser_._getAttributeBooleanValue2416 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeBooleanValue", "(IZ)Z");
			global::android.content.res.XmlResourceParser_._getAttributeResourceValue2417 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeResourceValue2418 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeResourceValue", "(II)I");
			global::android.content.res.XmlResourceParser_._getAttributeIntValue2419 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeIntValue", "(II)I");
			global::android.content.res.XmlResourceParser_._getAttributeIntValue2420 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue2421 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.XmlResourceParser_._getAttributeUnsignedIntValue2422 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeUnsignedIntValue", "(II)I");
			global::android.content.res.XmlResourceParser_._getAttributeFloatValue2423 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			global::android.content.res.XmlResourceParser_._getAttributeFloatValue2424 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getAttributeFloatValue", "(IF)F");
			global::android.content.res.XmlResourceParser_._getIdAttribute2425 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getIdAttribute", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getClassAttribute2426 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getClassAttribute", "()Ljava/lang/String;");
			global::android.content.res.XmlResourceParser_._getIdAttributeResourceValue2427 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getIdAttributeResourceValue", "(I)I");
			global::android.content.res.XmlResourceParser_._getStyleAttribute2428 = @__env.GetMethodIDNoThrow(global::android.content.res.XmlResourceParser_.staticClass, "getStyleAttribute", "()I");
		}
	}
}
