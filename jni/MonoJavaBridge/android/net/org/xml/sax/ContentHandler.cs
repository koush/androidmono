namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ContentHandler 
	{ 
		void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3); 
		void characters(char[] arg0, int arg1, int arg2); 
		void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2); 
		void startDocument(); 
		void endDocument(); 
		void startPrefixMapping(java.lang.String arg0, java.lang.String arg1); 
		void ignorableWhitespace(char[] arg0, int arg1, int arg2); 
		void processingInstruction(java.lang.String arg0, java.lang.String arg1); 
		void setDocumentLocator(org.xml.sax.Locator arg0); 
		void skippedEntity(java.lang.String arg0); 
		void endPrefixMapping(java.lang.String arg0); 
	} 

	public partial class ContentHandler_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ContentHandler.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ContentHandler : java.lang.Object, ContentHandler
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ContentHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(org.xml.sax.__ContentHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::org.xml.sax.__ContentHandler(@__env); 
			} 
		} 
		internal __ContentHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startElement13289; 
		 void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _startElement13289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _startElement13289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _characters13290; 
		 void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _characters13290, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _characters13290, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endElement13291; 
		 void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _endElement13291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _endElement13291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startDocument13292; 
		 void org.xml.sax.ContentHandler.startDocument() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _startDocument13292); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _startDocument13292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endDocument13293; 
		 void org.xml.sax.ContentHandler.endDocument() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _endDocument13293); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _endDocument13293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startPrefixMapping13294; 
		 void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _startPrefixMapping13294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _startPrefixMapping13294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ignorableWhitespace13295; 
		 void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _ignorableWhitespace13295, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _ignorableWhitespace13295, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _processingInstruction13296; 
		 void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _processingInstruction13296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _processingInstruction13296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDocumentLocator13297; 
		 void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _setDocumentLocator13297, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _setDocumentLocator13297, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _skippedEntity13298; 
		 void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _skippedEntity13298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _skippedEntity13298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endPrefixMapping13299; 
		 void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(org.xml.sax.__ContentHandler)) 
				@__env.CallVoidMethod(this, _endPrefixMapping13299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, org.xml.sax.__ContentHandler.staticClass, _endPrefixMapping13299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::org.xml.sax.__ContentHandler.staticClass = @__class; 
			global::org.xml.sax.__ContentHandler._startElement13289 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V"); 
			global::org.xml.sax.__ContentHandler._characters13290 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.characters", "([CII)V"); 
			global::org.xml.sax.__ContentHandler._endElement13291 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::org.xml.sax.__ContentHandler._startDocument13292 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.startDocument", "()V"); 
			global::org.xml.sax.__ContentHandler._endDocument13293 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.endDocument", "()V"); 
			global::org.xml.sax.__ContentHandler._startPrefixMapping13294 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::org.xml.sax.__ContentHandler._ignorableWhitespace13295 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.ignorableWhitespace", "([CII)V"); 
			global::org.xml.sax.__ContentHandler._processingInstruction13296 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::org.xml.sax.__ContentHandler._setDocumentLocator13297 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.setDocumentLocator", "(Lorg/xml/sax/Locator;)V"); 
			global::org.xml.sax.__ContentHandler._skippedEntity13298 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.skippedEntity", "(Ljava/lang/String;)V"); 
			global::org.xml.sax.__ContentHandler._endPrefixMapping13299 = @__env.GetMethodID(global::org.xml.sax.__ContentHandler.staticClass, "org.xml.sax.ContentHandler.endPrefixMapping", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
