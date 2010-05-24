namespace org.xmlpull.v1 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface XmlPullParser 
	{ 
		void setProperty(java.lang.String arg0, java.lang.Object arg1); 
		java.lang.Object getProperty(java.lang.String arg0); 
		java.lang.String getName(); 
		int next(); 
		int getLineNumber(); 
		bool isWhitespace(); 
		int nextToken(); 
		void setInput(java.io.InputStream arg0, java.lang.String arg1); 
		void setInput(java.io.Reader arg0); 
		java.lang.String getPrefix(); 
		java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1); 
		java.lang.String getAttributeValue(int arg0); 
		int getColumnNumber(); 
		java.lang.String getText(); 
		int getEventType(); 
		int getAttributeCount(); 
		java.lang.String getAttributeName(int arg0); 
		java.lang.String getPositionDescription(); 
		void setFeature(java.lang.String arg0, bool arg1); 
		bool getFeature(java.lang.String arg0); 
		java.lang.String getInputEncoding(); 
		void defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1); 
		int getNamespaceCount(int arg0); 
		java.lang.String getNamespacePrefix(int arg0); 
		java.lang.String getNamespaceUri(int arg0); 
		java.lang.String getNamespace(); 
		java.lang.String getNamespace(java.lang.String arg0); 
		int getDepth(); 
		char[] getTextCharacters(int[] arg0); 
		bool isEmptyElementTag(); 
		java.lang.String getAttributeNamespace(int arg0); 
		java.lang.String getAttributePrefix(int arg0); 
		java.lang.String getAttributeType(int arg0); 
		bool isAttributeDefault(int arg0); 
		void require(int arg0, java.lang.String arg1, java.lang.String arg2); 
		java.lang.String nextText(); 
		int nextTag(); 
	} 

	public partial class XmlPullParser_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __XmlPullParser.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __XmlPullParser : java.lang.Object, XmlPullParser
	{ 
		internal static global::java.lang.Class staticClass; 
		static __XmlPullParser() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(org.xmlpull.v1.__XmlPullParser), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xmlpull.v1.__XmlPullParser(@__env); 
			} 
		} 
		internal __XmlPullParser(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProperty13354; 
		 void org.xmlpull.v1.XmlPullParser.setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				@__env.CallVoidMethod(this, _setProperty13354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _setProperty13354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProperty13355; 
		 java.lang.Object org.xmlpull.v1.XmlPullParser.getProperty(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getProperty13355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getProperty13355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName13356; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName13356)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getName13356)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next13357; 
		 int org.xmlpull.v1.XmlPullParser.next() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _next13357); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _next13357); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber13358; 
		 int org.xmlpull.v1.XmlPullParser.getLineNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _getLineNumber13358); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getLineNumber13358); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWhitespace13359; 
		 bool org.xmlpull.v1.XmlPullParser.isWhitespace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallBooleanMethod(this, _isWhitespace13359); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _isWhitespace13359); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextToken13360; 
		 int org.xmlpull.v1.XmlPullParser.nextToken() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _nextToken13360); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _nextToken13360); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInput13361; 
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.InputStream arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				@__env.CallVoidMethod(this, _setInput13361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _setInput13361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInput13362; 
		 void org.xmlpull.v1.XmlPullParser.setInput(java.io.Reader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				@__env.CallVoidMethod(this, _setInput13362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _setInput13362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrefix13363; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getPrefix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPrefix13363)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getPrefix13363)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue13364; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeValue13364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributeValue13364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeValue13365; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeValue13365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributeValue13365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber13366; 
		 int org.xmlpull.v1.XmlPullParser.getColumnNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _getColumnNumber13366); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getColumnNumber13366); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText13367; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getText13367)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getText13367)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEventType13368; 
		 int org.xmlpull.v1.XmlPullParser.getEventType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _getEventType13368); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getEventType13368); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeCount13369; 
		 int org.xmlpull.v1.XmlPullParser.getAttributeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _getAttributeCount13369); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributeCount13369); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeName13370; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeName13370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributeName13370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionDescription13371; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getPositionDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPositionDescription13371)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getPositionDescription13371)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeature13372; 
		 void org.xmlpull.v1.XmlPullParser.setFeature(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				@__env.CallVoidMethod(this, _setFeature13372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _setFeature13372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFeature13373; 
		 bool org.xmlpull.v1.XmlPullParser.getFeature(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallBooleanMethod(this, _getFeature13373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getFeature13373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputEncoding13374; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getInputEncoding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getInputEncoding13374)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getInputEncoding13374)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _defineEntityReplacementText13375; 
		 void org.xmlpull.v1.XmlPullParser.defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				@__env.CallVoidMethod(this, _defineEntityReplacementText13375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _defineEntityReplacementText13375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceCount13376; 
		 int org.xmlpull.v1.XmlPullParser.getNamespaceCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _getNamespaceCount13376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getNamespaceCount13376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespacePrefix13377; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespacePrefix(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespacePrefix13377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getNamespacePrefix13377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespaceUri13378; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespaceUri(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespaceUri13378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getNamespaceUri13378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace13379; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespace13379)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getNamespace13379)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace13380; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getNamespace(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNamespace13380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getNamespace13380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDepth13381; 
		 int org.xmlpull.v1.XmlPullParser.getDepth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _getDepth13381); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getDepth13381); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextCharacters13382; 
		 char[] org.xmlpull.v1.XmlPullParser.getTextCharacters(int[] arg0) 
		{ 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getTextCharacters13382, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getTextCharacters13382, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmptyElementTag13383; 
		 bool org.xmlpull.v1.XmlPullParser.isEmptyElementTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallBooleanMethod(this, _isEmptyElementTag13383); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _isEmptyElementTag13383); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeNamespace13384; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeNamespace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeNamespace13384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributeNamespace13384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributePrefix13385; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributePrefix(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributePrefix13385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributePrefix13385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeType13386; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.getAttributeType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttributeType13386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _getAttributeType13386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAttributeDefault13387; 
		 bool org.xmlpull.v1.XmlPullParser.isAttributeDefault(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallBooleanMethod(this, _isAttributeDefault13387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _isAttributeDefault13387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _require13388; 
		 void org.xmlpull.v1.XmlPullParser.require(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				@__env.CallVoidMethod(this, _require13388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _require13388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextText13389; 
		 java.lang.String org.xmlpull.v1.XmlPullParser.nextText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _nextText13389)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, org.xmlpull.v1.__XmlPullParser.staticClass, _nextText13389)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextTag13390; 
		 int org.xmlpull.v1.XmlPullParser.nextTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xmlpull.v1.__XmlPullParser)) 
				return @__env.CallIntMethod(this, _nextTag13390); 
			else 
				return @__env.CallNonVirtualIntMethod(this, org.xmlpull.v1.__XmlPullParser.staticClass, _nextTag13390); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xmlpull.v1.__XmlPullParser.staticClass = @__class; 
			global::org.xmlpull.v1.__XmlPullParser._setProperty13354 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"); 
			global::org.xmlpull.v1.__XmlPullParser._getProperty13355 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::org.xmlpull.v1.__XmlPullParser._getName13356 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getName", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._next13357 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.next", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._getLineNumber13358 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getLineNumber", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._isWhitespace13359 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.isWhitespace", "()Z"); 
			global::org.xmlpull.v1.__XmlPullParser._nextToken13360 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextToken", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._setInput13361 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V"); 
			global::org.xmlpull.v1.__XmlPullParser._setInput13362 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setInput", "(Ljava/io/Reader;)V"); 
			global::org.xmlpull.v1.__XmlPullParser._getPrefix13363 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPrefix", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributeValue13364 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributeValue13365 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeValue", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getColumnNumber13366 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getColumnNumber", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._getText13367 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getText", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getEventType13368 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getEventType", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributeCount13369 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeCount", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributeName13370 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeName", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getPositionDescription13371 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getPositionDescription", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._setFeature13372 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.setFeature", "(Ljava/lang/String;Z)V"); 
			global::org.xmlpull.v1.__XmlPullParser._getFeature13373 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getFeature", "(Ljava/lang/String;)Z"); 
			global::org.xmlpull.v1.__XmlPullParser._getInputEncoding13374 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getInputEncoding", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._defineEntityReplacementText13375 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::org.xmlpull.v1.__XmlPullParser._getNamespaceCount13376 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceCount", "(I)I"); 
			global::org.xmlpull.v1.__XmlPullParser._getNamespacePrefix13377 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespacePrefix", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getNamespaceUri13378 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespaceUri", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getNamespace13379 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getNamespace13380 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getNamespace", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getDepth13381 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getDepth", "()I"); 
			global::org.xmlpull.v1.__XmlPullParser._getTextCharacters13382 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getTextCharacters", "([I)[C"); 
			global::org.xmlpull.v1.__XmlPullParser._isEmptyElementTag13383 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.isEmptyElementTag", "()Z"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributeNamespace13384 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeNamespace", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributePrefix13385 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributePrefix", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._getAttributeType13386 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.getAttributeType", "(I)Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._isAttributeDefault13387 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.isAttributeDefault", "(I)Z"); 
			global::org.xmlpull.v1.__XmlPullParser._require13388 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.require", "(ILjava/lang/String;Ljava/lang/String;)V"); 
			global::org.xmlpull.v1.__XmlPullParser._nextText13389 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextText", "()Ljava/lang/String;"); 
			global::org.xmlpull.v1.__XmlPullParser._nextTag13390 = @__env.GetMethodID(global::org.xmlpull.v1.__XmlPullParser.staticClass, "org.xmlpull.v1.XmlPullParser.nextTag", "()I"); 
		} 
	} 
} 
