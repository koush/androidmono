namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSParser_))]
	public partial interface LSParser  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.Document parse(org.w3c.dom.ls.LSInput arg0);
		global::org.w3c.dom.ls.LSParserFilter getFilter();
		void setFilter(org.w3c.dom.ls.LSParserFilter arg0);
		void abort();
		global::org.w3c.dom.DOMConfiguration getDomConfig();
		bool getAsync();
		bool getBusy();
		global::org.w3c.dom.Document parseURI(java.lang.String arg0);
		global::org.w3c.dom.Node parseWithContext(org.w3c.dom.ls.LSInput arg0, org.w3c.dom.Node arg1, short arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSParser))]
	internal sealed partial class LSParser_ : java.lang.Object, LSParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LSParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parse(org.w3c.dom.ls.LSInput arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", ref global::org.w3c.dom.ls.LSParser_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.ls.LSParserFilter org.w3c.dom.ls.LSParser.getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSParserFilter>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;", ref global::org.w3c.dom.ls.LSParser_._m1) as org.w3c.dom.ls.LSParserFilter;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.w3c.dom.ls.LSParser.setFilter(org.w3c.dom.ls.LSParserFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", ref global::org.w3c.dom.ls.LSParser_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.w3c.dom.ls.LSParser.abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "abort", "()V", ref global::org.w3c.dom.ls.LSParser_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSParser.getDomConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMConfiguration>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", ref global::org.w3c.dom.ls.LSParser_._m4) as org.w3c.dom.DOMConfiguration;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool org.w3c.dom.ls.LSParser.getAsync()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getAsync", "()Z", ref global::org.w3c.dom.ls.LSParser_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool org.w3c.dom.ls.LSParser.getBusy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getBusy", "()Z", ref global::org.w3c.dom.ls.LSParser_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parseURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", ref global::org.w3c.dom.ls.LSParser_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::org.w3c.dom.Node org.w3c.dom.ls.LSParser.parseWithContext(org.w3c.dom.ls.LSInput arg0, org.w3c.dom.Node arg1, short arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ls.LSParser_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.w3c.dom.Node;
		}
		static LSParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
