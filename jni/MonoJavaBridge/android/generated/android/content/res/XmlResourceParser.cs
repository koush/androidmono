namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface XmlResourceParser : org.xmlpull.v1.XmlPullParser, android.util.AttributeSet
	{
		void close();
	}

	public partial class XmlResourceParser_
	{
		public static global::java.lang.Class _class
		{
			get { return __XmlResourceParser.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __XmlResourceParser : java.lang.Object, XmlResourceParser
	{
		internal static global::java.lang.Class staticClass;
		static __XmlResourceParser()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.__XmlResourceParser), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.res.__XmlResourceParser(@__env);
			}
		}
		internal __XmlResourceParser(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2215;
		 void android.content.res.XmlResourceParser.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._close2215);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._close2215);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProperty2216;
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._setProperty2216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._setProperty2216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProperty2217;
		 global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getProperty2217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getProperty2217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName2218;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getName2218));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getName2218));
		}
		internal static global::net.sf.jni4net.jni.MethodId _next2219;
		 int org.xmlpull.v1.XmlPullParser.next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._next2219);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._next2219);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber2220;
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getLineNumber2220);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getLineNumber2220);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWhitespace2221;
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.__XmlResourceParser._isWhitespace2221);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._isWhitespace2221);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextToken2222;
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._nextToken2222);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._nextToken2222);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInput2223;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._setInput2223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._setInput2223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInput2224;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._setInput2224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._setInput2224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrefix2225;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getPrefix2225));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getPrefix2225));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2226;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeValue2226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeValue2226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2227;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeValue2227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeValue2227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber2228;
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getColumnNumber2228);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getColumnNumber2228);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText2229;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getText2229));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getText2229));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEventType2230;
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getEventType2230);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getEventType2230);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount2231;
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeCount2231);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeCount2231);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName2232;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeName2232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeName2232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription2233;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getPositionDescription2233));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getPositionDescription2233));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeature2234;
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._setFeature2234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._setFeature2234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFeature2235;
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.__XmlResourceParser._getFeature2235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getFeature2235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputEncoding2236;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getInputEncoding2236));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getInputEncoding2236));
		}
		internal static global::net.sf.jni4net.jni.MethodId _defineEntityReplacementText2237;
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._defineEntityReplacementText2237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._defineEntityReplacementText2237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceCount2238;
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getNamespaceCount2238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getNamespaceCount2238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespacePrefix2239;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getNamespacePrefix2239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getNamespacePrefix2239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceUri2240;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getNamespaceUri2240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getNamespaceUri2240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace2241;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getNamespace2241));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getNamespace2241));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace2242;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getNamespace2242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getNamespace2242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDepth2243;
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getDepth2243);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getDepth2243);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextCharacters2244;
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getTextCharacters2244, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getTextCharacters2244, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmptyElementTag2245;
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.__XmlResourceParser._isEmptyElementTag2245);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._isEmptyElementTag2245);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNamespace2246;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeNamespace2246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeNamespace2246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributePrefix2247;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributePrefix2247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributePrefix2247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeType2248;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeType2248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeType2248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAttributeDefault2249;
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.__XmlResourceParser._isAttributeDefault2249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._isAttributeDefault2249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _require2250;
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.__XmlResourceParser._require2250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._require2250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextText2251;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._nextText2251));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._nextText2251));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextTag2252;
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._nextTag2252);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._nextTag2252);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2253;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeValue2253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeValue2253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2254;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeValue2254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeValue2254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount2255;
		 int android.util.AttributeSet.getAttributeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeCount2255);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeCount2255);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName2256;
		 global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getAttributeName2256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeName2256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription2257;
		 global::java.lang.String android.util.AttributeSet.getPositionDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getPositionDescription2257));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getPositionDescription2257));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNameResource2258;
		 int android.util.AttributeSet.getAttributeNameResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeNameResource2258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeNameResource2258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeListValue2259;
		 int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeListValue2259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeListValue2259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeListValue2260;
		 int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeListValue2260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeListValue2260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeBooleanValue2261;
		 bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeBooleanValue2262;
		 bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeResourceValue2263;
		 int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeResourceValue2263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeResourceValue2263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeResourceValue2264;
		 int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeResourceValue2264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeResourceValue2264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeIntValue2265;
		 int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeIntValue2265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeIntValue2265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeIntValue2266;
		 int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeIntValue2266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeIntValue2266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeUnsignedIntValue2267;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeUnsignedIntValue2268;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeFloatValue2269;
		 float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.__XmlResourceParser._getAttributeFloatValue2269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeFloatValue2269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeFloatValue2270;
		 float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.res.__XmlResourceParser._getAttributeFloatValue2270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getAttributeFloatValue2270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIdAttribute2271;
		 global::java.lang.String android.util.AttributeSet.getIdAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getIdAttribute2271));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getIdAttribute2271));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassAttribute2272;
		 global::java.lang.String android.util.AttributeSet.getClassAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.__XmlResourceParser._getClassAttribute2272));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getClassAttribute2272));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIdAttributeResourceValue2273;
		 int android.util.AttributeSet.getIdAttributeResourceValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getIdAttributeResourceValue2273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getIdAttributeResourceValue2273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStyleAttribute2274;
		 int android.util.AttributeSet.getStyleAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.__XmlResourceParser._getStyleAttribute2274);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.__XmlResourceParser.staticClass, global::android.content.res.__XmlResourceParser._getStyleAttribute2274);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.__XmlResourceParser.staticClass = @__class;
			global::android.content.res.__XmlResourceParser._close2215 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.content.res.XmlResourceParser.close", "()V");
			global::android.content.res.__XmlResourceParser._setProperty2216 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.content.res.__XmlResourceParser._getProperty2217 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.res.__XmlResourceParser._getName2218 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getName", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._next2219 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.next", "()I");
			global::android.content.res.__XmlResourceParser._getLineNumber2220 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getLineNumber", "()I");
			global::android.content.res.__XmlResourceParser._isWhitespace2221 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.isWhitespace", "()Z");
			global::android.content.res.__XmlResourceParser._nextToken2222 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextToken", "()I");
			global::android.content.res.__XmlResourceParser._setInput2223 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::android.content.res.__XmlResourceParser._setInput2224 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/Reader;)V");
			global::android.content.res.__XmlResourceParser._getPrefix2225 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPrefix", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributeValue2226 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributeValue2227 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getColumnNumber2228 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getColumnNumber", "()I");
			global::android.content.res.__XmlResourceParser._getText2229 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getText", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getEventType2230 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getEventType", "()I");
			global::android.content.res.__XmlResourceParser._getAttributeCount2231 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeCount", "()I");
			global::android.content.res.__XmlResourceParser._getAttributeName2232 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeName", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getPositionDescription2233 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._setFeature2234 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setFeature", "(Ljava/lang/String;Z)V");
			global::android.content.res.__XmlResourceParser._getFeature2235 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getFeature", "(Ljava/lang/String;)Z");
			global::android.content.res.__XmlResourceParser._getInputEncoding2236 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getInputEncoding", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._defineEntityReplacementText2237 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.res.__XmlResourceParser._getNamespaceCount2238 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceCount", "(I)I");
			global::android.content.res.__XmlResourceParser._getNamespacePrefix2239 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespacePrefix", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getNamespaceUri2240 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceUri", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getNamespace2241 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getNamespace2242 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getDepth2243 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getDepth", "()I");
			global::android.content.res.__XmlResourceParser._getTextCharacters2244 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getTextCharacters", "([I)[C");
			global::android.content.res.__XmlResourceParser._isEmptyElementTag2245 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.isEmptyElementTag", "()Z");
			global::android.content.res.__XmlResourceParser._getAttributeNamespace2246 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeNamespace", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributePrefix2247 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributePrefix", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributeType2248 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeType", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._isAttributeDefault2249 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.isAttributeDefault", "(I)Z");
			global::android.content.res.__XmlResourceParser._require2250 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.require", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::android.content.res.__XmlResourceParser._nextText2251 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextText", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._nextTag2252 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextTag", "()I");
			global::android.content.res.__XmlResourceParser._getAttributeValue2253 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeValue", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributeValue2254 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributeCount2255 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeCount", "()I");
			global::android.content.res.__XmlResourceParser._getAttributeName2256 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeName", "(I)Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getPositionDescription2257 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getAttributeNameResource2258 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeNameResource", "(I)I");
			global::android.content.res.__XmlResourceParser._getAttributeListValue2259 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.content.res.__XmlResourceParser._getAttributeListValue2260 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeListValue", "(I[Ljava/lang/String;I)I");
			global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2261 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2262 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeBooleanValue", "(IZ)Z");
			global::android.content.res.__XmlResourceParser._getAttributeResourceValue2263 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.__XmlResourceParser._getAttributeResourceValue2264 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeResourceValue", "(II)I");
			global::android.content.res.__XmlResourceParser._getAttributeIntValue2265 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeIntValue", "(II)I");
			global::android.content.res.__XmlResourceParser._getAttributeIntValue2266 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2267 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2268 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeUnsignedIntValue", "(II)I");
			global::android.content.res.__XmlResourceParser._getAttributeFloatValue2269 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			global::android.content.res.__XmlResourceParser._getAttributeFloatValue2270 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeFloatValue", "(IF)F");
			global::android.content.res.__XmlResourceParser._getIdAttribute2271 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getIdAttribute", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getClassAttribute2272 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getClassAttribute", "()Ljava/lang/String;");
			global::android.content.res.__XmlResourceParser._getIdAttributeResourceValue2273 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getIdAttributeResourceValue", "(I)I");
			global::android.content.res.__XmlResourceParser._getStyleAttribute2274 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getStyleAttribute", "()I");
		}
	}
}
