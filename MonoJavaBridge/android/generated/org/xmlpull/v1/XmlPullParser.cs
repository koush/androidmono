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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._setProperty35311.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._setProperty35311 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setProperty35311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35312;
		global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getProperty35312.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getProperty35312 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getProperty35312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName35313;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getName35313.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getName35313 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getName35313)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next35314;
		int org.xmlpull.v1.XmlPullParser.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._next35314.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._next35314 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "next", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._next35314);
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35315;
		int org.xmlpull.v1.XmlPullParser.getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getLineNumber35315.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getLineNumber35315 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getLineNumber", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getLineNumber35315);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace35316;
		bool org.xmlpull.v1.XmlPullParser.isWhitespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._isWhitespace35316.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._isWhitespace35316 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isWhitespace", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isWhitespace35316);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken35317;
		int org.xmlpull.v1.XmlPullParser.nextToken()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._nextToken35317.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._nextToken35317 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextToken", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextToken35317);
		}
		internal static global::MonoJavaBridge.MethodId _setInput35318;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._setInput35318.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._setInput35318 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setInput35318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInput35319;
		void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._setInput35319.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._setInput35319 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/Reader;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setInput35319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix35320;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getPrefix35320.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getPrefix35320 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPrefix", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getPrefix35320)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue35321;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35321.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35321 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue35322;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35322.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35322 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue35322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35323;
		int org.xmlpull.v1.XmlPullParser.getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35323.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35323 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getColumnNumber", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getColumnNumber35323);
		}
		internal static global::MonoJavaBridge.MethodId _getText35324;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getText35324.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getText35324 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getText", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getText35324)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEventType35325;
		int org.xmlpull.v1.XmlPullParser.getEventType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getEventType35325.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getEventType35325 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getEventType", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getEventType35325);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount35326;
		int org.xmlpull.v1.XmlPullParser.getAttributeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35326.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35326 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeCount", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeCount35326);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName35327;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributeName35327.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributeName35327 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeName35327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription35328;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35328.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35328 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getPositionDescription35328)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35329;
		void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._setFeature35329.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._setFeature35329 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setFeature35329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35330;
		bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getFeature35330.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getFeature35330 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getFeature35330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding35331;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35331.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35331 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getInputEncoding35331)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _defineEntityReplacementText35332;
		void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35332.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35332 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText35332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceCount35333;
		int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35333.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35333 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceCount", "(I)I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount35333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespacePrefix35334;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35334.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35334 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix35334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceUri35335;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35335.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35335 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri35335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35336;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getNamespace35336.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getNamespace35336 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespace35336)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace35337;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getNamespace35337.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getNamespace35337 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespace35337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth35338;
		int org.xmlpull.v1.XmlPullParser.getDepth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getDepth35338.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getDepth35338 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getDepth", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getDepth35338);
		}
		internal static global::MonoJavaBridge.MethodId _getTextCharacters35339;
		char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35339.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35339 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getTextCharacters", "([I)[C");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getTextCharacters35339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isEmptyElementTag35340;
		bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35340.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35340 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isEmptyElementTag", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag35340);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNamespace35341;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35341.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35341 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace35341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributePrefix35342;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35342.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35342 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix35342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeType35343;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._getAttributeType35343.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._getAttributeType35343 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeType35343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAttributeDefault35344;
		bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35344.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35344 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isAttributeDefault", "(I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault35344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _require35345;
		void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._require35345.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._require35345 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._require35345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _nextText35346;
		global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._nextText35346.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._nextText35346 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextText", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextText35346)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTag35347;
		int org.xmlpull.v1.XmlPullParser.nextTag()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParser_._nextTag35347.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParser_._nextTag35347 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextTag", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextTag35347);
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
