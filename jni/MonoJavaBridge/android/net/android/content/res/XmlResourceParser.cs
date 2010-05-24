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
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.__XmlResourceParser), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _close2034; 
		 void android.content.res.XmlResourceParser.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _close2034); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _close2034); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProperty2035; 
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _setProperty2035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _setProperty2035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProperty2036; 
		 java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getProperty2036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getProperty2036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName2037; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName2037)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getName2037)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next2038; 
		 int org.xmlpull.v1.XmlPullParser.next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _next2038); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _next2038); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber2039; 
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getLineNumber2039); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getLineNumber2039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWhitespace2040; 
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallBooleanMethod(this, _isWhitespace2040); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.__XmlResourceParser.staticClass, _isWhitespace2040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextToken2041; 
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _nextToken2041); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _nextToken2041); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInput2042; 
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _setInput2042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _setInput2042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInput2043; 
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _setInput2043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _setInput2043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrefix2044; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPrefix2044)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getPrefix2044)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2045; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeValue2045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeValue2045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2046; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeValue2046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeValue2046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber2047; 
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getColumnNumber2047); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getColumnNumber2047); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText2048; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getText2048)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getText2048)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventType2049; 
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getEventType2049); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getEventType2049); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount2050; 
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeCount2050); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeCount2050); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName2051; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeName2051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeName2051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription2052; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPositionDescription2052)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getPositionDescription2052)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeature2053; 
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _setFeature2053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _setFeature2053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFeature2054; 
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallBooleanMethod(this, _getFeature2054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.__XmlResourceParser.staticClass, _getFeature2054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputEncoding2055; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getInputEncoding2055)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getInputEncoding2055)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _defineEntityReplacementText2056; 
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _defineEntityReplacementText2056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _defineEntityReplacementText2056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceCount2057; 
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getNamespaceCount2057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getNamespaceCount2057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespacePrefix2058; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespacePrefix2058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getNamespacePrefix2058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceUri2059; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespaceUri2059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getNamespaceUri2059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace2060; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespace2060)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getNamespace2060)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace2061; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespace2061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getNamespace2061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDepth2062; 
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getDepth2062); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getDepth2062); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextCharacters2063; 
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{ 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getTextCharacters2063, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getTextCharacters2063, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmptyElementTag2064; 
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallBooleanMethod(this, _isEmptyElementTag2064); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.__XmlResourceParser.staticClass, _isEmptyElementTag2064); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNamespace2065; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeNamespace2065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeNamespace2065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributePrefix2066; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributePrefix2066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributePrefix2066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeType2067; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeType2067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeType2067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAttributeDefault2068; 
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallBooleanMethod(this, _isAttributeDefault2068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.__XmlResourceParser.staticClass, _isAttributeDefault2068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _require2069; 
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				@__env.CallVoidMethod(this, _require2069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.__XmlResourceParser.staticClass, _require2069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextText2070; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _nextText2070)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _nextText2070)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextTag2071; 
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _nextTag2071); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _nextTag2071); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2072; 
		 java.lang.String android.util.AttributeSet.getAttributeValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeValue2072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeValue2072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue2073; 
		 java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeValue2073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeValue2073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount2074; 
		 int android.util.AttributeSet.getAttributeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeCount2074); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeCount2074); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName2075; 
		 java.lang.String android.util.AttributeSet.getAttributeName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeName2075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeName2075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription2076; 
		 java.lang.String android.util.AttributeSet.getPositionDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPositionDescription2076)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getPositionDescription2076)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNameResource2077; 
		 int android.util.AttributeSet.getAttributeNameResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeNameResource2077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeNameResource2077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeListValue2078; 
		 int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeListValue2078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeListValue2078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeListValue2079; 
		 int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeListValue2079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeListValue2079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeBooleanValue2080; 
		 bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallBooleanMethod(this, _getAttributeBooleanValue2080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeBooleanValue2080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeBooleanValue2081; 
		 bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallBooleanMethod(this, _getAttributeBooleanValue2081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeBooleanValue2081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeResourceValue2082; 
		 int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeResourceValue2082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeResourceValue2082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeResourceValue2083; 
		 int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeResourceValue2083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeResourceValue2083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeIntValue2084; 
		 int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeIntValue2084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeIntValue2084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeIntValue2085; 
		 int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeIntValue2085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeIntValue2085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeUnsignedIntValue2086; 
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeUnsignedIntValue2086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeUnsignedIntValue2086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeUnsignedIntValue2087; 
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getAttributeUnsignedIntValue2087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeUnsignedIntValue2087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeFloatValue2088; 
		 float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallFloatMethod(this, _getAttributeFloatValue2088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeFloatValue2088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeFloatValue2089; 
		 float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallFloatMethod(this, _getAttributeFloatValue2089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.res.__XmlResourceParser.staticClass, _getAttributeFloatValue2089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIdAttribute2090; 
		 java.lang.String android.util.AttributeSet.getIdAttribute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getIdAttribute2090)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getIdAttribute2090)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassAttribute2091; 
		 java.lang.String android.util.AttributeSet.getClassAttribute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getClassAttribute2091)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.__XmlResourceParser.staticClass, _getClassAttribute2091)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIdAttributeResourceValue2092; 
		 int android.util.AttributeSet.getIdAttributeResourceValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getIdAttributeResourceValue2092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getIdAttributeResourceValue2092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStyleAttribute2093; 
		 int android.util.AttributeSet.getStyleAttribute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.__XmlResourceParser)) 
				return @__env.CallIntMethod(this, _getStyleAttribute2093); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.__XmlResourceParser.staticClass, _getStyleAttribute2093); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.res.__XmlResourceParser.staticClass = @__class; 
			global::android.content.res.__XmlResourceParser._close2034 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.content.res.XmlResourceParser.close", "()V"); 
			global::android.content.res.__XmlResourceParser._setProperty2035 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"); 
			global::android.content.res.__XmlResourceParser._getProperty2036 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.content.res.__XmlResourceParser._getName2037 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getName", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._next2038 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.next", "()I"); 
			global::android.content.res.__XmlResourceParser._getLineNumber2039 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getLineNumber", "()I"); 
			global::android.content.res.__XmlResourceParser._isWhitespace2040 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.isWhitespace", "()Z"); 
			global::android.content.res.__XmlResourceParser._nextToken2041 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextToken", "()I"); 
			global::android.content.res.__XmlResourceParser._setInput2042 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V"); 
			global::android.content.res.__XmlResourceParser._setInput2043 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/Reader;)V"); 
			global::android.content.res.__XmlResourceParser._getPrefix2044 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPrefix", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributeValue2045 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributeValue2046 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getColumnNumber2047 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getColumnNumber", "()I"); 
			global::android.content.res.__XmlResourceParser._getText2048 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getText", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getEventType2049 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getEventType", "()I"); 
			global::android.content.res.__XmlResourceParser._getAttributeCount2050 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeCount", "()I"); 
			global::android.content.res.__XmlResourceParser._getAttributeName2051 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeName", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getPositionDescription2052 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPositionDescription", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._setFeature2053 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.setFeature", "(Ljava/lang/String;Z)V"); 
			global::android.content.res.__XmlResourceParser._getFeature2054 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getFeature", "(Ljava/lang/String;)Z"); 
			global::android.content.res.__XmlResourceParser._getInputEncoding2055 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getInputEncoding", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._defineEntityReplacementText2056 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.res.__XmlResourceParser._getNamespaceCount2057 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceCount", "(I)I"); 
			global::android.content.res.__XmlResourceParser._getNamespacePrefix2058 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespacePrefix", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getNamespaceUri2059 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceUri", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getNamespace2060 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getNamespace2061 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getDepth2062 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getDepth", "()I"); 
			global::android.content.res.__XmlResourceParser._getTextCharacters2063 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getTextCharacters", "([I)[C"); 
			global::android.content.res.__XmlResourceParser._isEmptyElementTag2064 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.isEmptyElementTag", "()Z"); 
			global::android.content.res.__XmlResourceParser._getAttributeNamespace2065 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeNamespace", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributePrefix2066 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributePrefix", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributeType2067 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeType", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._isAttributeDefault2068 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.isAttributeDefault", "(I)Z"); 
			global::android.content.res.__XmlResourceParser._require2069 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.require", "(ILjava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.res.__XmlResourceParser._nextText2070 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextText", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._nextTag2071 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextTag", "()I"); 
			global::android.content.res.__XmlResourceParser._getAttributeValue2072 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeValue", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributeValue2073 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributeCount2074 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeCount", "()I"); 
			global::android.content.res.__XmlResourceParser._getAttributeName2075 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeName", "(I)Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getPositionDescription2076 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getPositionDescription", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getAttributeNameResource2077 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeNameResource", "(I)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeListValue2078 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeListValue2079 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeListValue", "(I[Ljava/lang/String;I)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2080 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z"); 
			global::android.content.res.__XmlResourceParser._getAttributeBooleanValue2081 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeBooleanValue", "(IZ)Z"); 
			global::android.content.res.__XmlResourceParser._getAttributeResourceValue2082 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeResourceValue2083 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeResourceValue", "(II)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeIntValue2084 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeIntValue", "(II)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeIntValue2085 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2086 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeUnsignedIntValue2087 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeUnsignedIntValue", "(II)I"); 
			global::android.content.res.__XmlResourceParser._getAttributeFloatValue2088 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F"); 
			global::android.content.res.__XmlResourceParser._getAttributeFloatValue2089 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getAttributeFloatValue", "(IF)F"); 
			global::android.content.res.__XmlResourceParser._getIdAttribute2090 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getIdAttribute", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getClassAttribute2091 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getClassAttribute", "()Ljava/lang/String;"); 
			global::android.content.res.__XmlResourceParser._getIdAttributeResourceValue2092 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getIdAttributeResourceValue", "(I)I"); 
			global::android.content.res.__XmlResourceParser._getStyleAttribute2093 = @__env.GetMethodID(global::android.content.res.__XmlResourceParser.staticClass, "android.util.AttributeSet.getStyleAttribute", "()I"); 
		} 
	} 
} 
