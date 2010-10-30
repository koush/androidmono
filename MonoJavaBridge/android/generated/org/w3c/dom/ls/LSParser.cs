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
		internal static global::MonoJavaBridge.MethodId _parse34916;
		global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parse(org.w3c.dom.ls.LSInput arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", ref global::org.w3c.dom.ls.LSParser_._parse34916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _getFilter34917;
		global::org.w3c.dom.ls.LSParserFilter org.w3c.dom.ls.LSParser.getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSParserFilter>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;", ref global::org.w3c.dom.ls.LSParser_._getFilter34917) as org.w3c.dom.ls.LSParserFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter34918;
		void org.w3c.dom.ls.LSParser.setFilter(org.w3c.dom.ls.LSParserFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", ref global::org.w3c.dom.ls.LSParser_._setFilter34918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abort34919;
		void org.w3c.dom.ls.LSParser.abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "abort", "()V", ref global::org.w3c.dom.ls.LSParser_._abort34919);
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34920;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSParser.getDomConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.DOMConfiguration>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", ref global::org.w3c.dom.ls.LSParser_._getDomConfig34920) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _getAsync34921;
		bool org.w3c.dom.ls.LSParser.getAsync()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getAsync", "()Z", ref global::org.w3c.dom.ls.LSParser_._getAsync34921);
		}
		internal static global::MonoJavaBridge.MethodId _getBusy34922;
		bool org.w3c.dom.ls.LSParser.getBusy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSParser_.staticClass, "getBusy", "()Z", ref global::org.w3c.dom.ls.LSParser_._getBusy34922);
		}
		internal static global::MonoJavaBridge.MethodId _parseURI34923;
		global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parseURI(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Document>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", ref global::org.w3c.dom.ls.LSParser_._parseURI34923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parseWithContext34924;
		global::org.w3c.dom.Node org.w3c.dom.ls.LSParser.parseWithContext(org.w3c.dom.ls.LSInput arg0, org.w3c.dom.Node arg1, short arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::org.w3c.dom.ls.LSParser_.staticClass, "parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;", ref global::org.w3c.dom.ls.LSParser_._parseWithContext34924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.w3c.dom.Node;
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
