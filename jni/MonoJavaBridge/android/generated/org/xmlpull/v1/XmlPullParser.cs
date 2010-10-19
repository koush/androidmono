namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xmlpull.v1.XmlPullParser_))]
	public interface XmlPullParser  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _setProperty28439;
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setProperty28439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setProperty28439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty28440;
		 global::java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getProperty28440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getProperty28440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getName28441;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getName28441)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getName28441)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next28442;
		 int org.xmlpull.v1.XmlPullParser.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._next28442);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._next28442);
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber28443;
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getLineNumber28443);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getLineNumber28443);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace28444;
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isWhitespace28444);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._isWhitespace28444);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken28445;
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextToken28445);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._nextToken28445);
		}
		internal static global::MonoJavaBridge.MethodId _setInput28446;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setInput28446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setInput28446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInput28447;
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setInput28447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setInput28447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix28448;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getPrefix28448)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getPrefix28448)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue28449;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue28449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue28449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue28450;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue28450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeValue28450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber28451;
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getColumnNumber28451);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getColumnNumber28451);
		}
		internal static global::MonoJavaBridge.MethodId _getText28452;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getText28452)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getText28452)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEventType28453;
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getEventType28453);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getEventType28453);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount28454;
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeCount28454);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeCount28454);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName28455;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeName28455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeName28455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription28456;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getPositionDescription28456)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getPositionDescription28456)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature28457;
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._setFeature28457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._setFeature28457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature28458;
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getFeature28458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getFeature28458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputEncoding28459;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getInputEncoding28459)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getInputEncoding28459)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _defineEntityReplacementText28460;
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText28460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText28460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceCount28461;
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount28461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount28461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNamespacePrefix28462;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix28462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix28462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceUri28463;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri28463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri28463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace28464;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespace28464)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespace28464)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace28465;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getNamespace28465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getNamespace28465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDepth28466;
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getDepth28466);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getDepth28466);
		}
		internal static global::MonoJavaBridge.MethodId _getTextCharacters28467;
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getTextCharacters28467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getTextCharacters28467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _isEmptyElementTag28468;
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag28468);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag28468);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNamespace28469;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace28469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace28469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributePrefix28470;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix28470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix28470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeType28471;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._getAttributeType28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._getAttributeType28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAttributeDefault28472;
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault28472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault28472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _require28473;
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._require28473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._require28473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _nextText28474;
		 global::java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextText28474)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._nextText28474)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTag28475;
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_._nextTag28475);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParser_.staticClass, global::org.xmlpull.v1.XmlPullParser_._nextTag28475);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParser"));
			global::org.xmlpull.v1.XmlPullParser_._setProperty28439 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.XmlPullParser_._getProperty28440 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.XmlPullParser_._getName28441 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._next28442 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "next", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getLineNumber28443 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getLineNumber", "()I");
			global::org.xmlpull.v1.XmlPullParser_._isWhitespace28444 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isWhitespace", "()Z");
			global::org.xmlpull.v1.XmlPullParser_._nextToken28445 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextToken", "()I");
			global::org.xmlpull.v1.XmlPullParser_._setInput28446 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParser_._setInput28447 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setInput", "(Ljava/io/Reader;)V");
			global::org.xmlpull.v1.XmlPullParser_._getPrefix28448 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPrefix", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeValue28449 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeValue28450 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getColumnNumber28451 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getColumnNumber", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getText28452 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getText", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getEventType28453 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getEventType", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeCount28454 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeCount", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeName28455 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getPositionDescription28456 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._setFeature28457 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.XmlPullParser_._getFeature28458 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.XmlPullParser_._getInputEncoding28459 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getInputEncoding", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._defineEntityReplacementText28460 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParser_._getNamespaceCount28461 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceCount", "(I)I");
			global::org.xmlpull.v1.XmlPullParser_._getNamespacePrefix28462 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespacePrefix", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getNamespaceUri28463 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespaceUri", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getNamespace28464 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getNamespace28465 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getNamespace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getDepth28466 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getDepth", "()I");
			global::org.xmlpull.v1.XmlPullParser_._getTextCharacters28467 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getTextCharacters", "([I)[C");
			global::org.xmlpull.v1.XmlPullParser_._isEmptyElementTag28468 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isEmptyElementTag", "()Z");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeNamespace28469 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeNamespace", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributePrefix28470 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributePrefix", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._getAttributeType28471 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "getAttributeType", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._isAttributeDefault28472 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "isAttributeDefault", "(I)Z");
			global::org.xmlpull.v1.XmlPullParser_._require28473 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "require", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParser_._nextText28474 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextText", "()Ljava/lang/String;");
			global::org.xmlpull.v1.XmlPullParser_._nextTag28475 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParser_.staticClass, "nextTag", "()I");
		}
	}
}
