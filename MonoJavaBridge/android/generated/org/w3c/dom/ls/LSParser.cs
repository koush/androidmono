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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._parse34916.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._parse34916 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._parse34916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _getFilter34917;
		global::org.w3c.dom.ls.LSParserFilter org.w3c.dom.ls.LSParser.getFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._getFilter34917.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._getFilter34917 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSParserFilter>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getFilter34917)) as org.w3c.dom.ls.LSParserFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter34918;
		void org.w3c.dom.ls.LSParser.setFilter(org.w3c.dom.ls.LSParserFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._setFilter34918.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._setFilter34918 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._setFilter34918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abort34919;
		void org.w3c.dom.ls.LSParser.abort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._abort34919.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._abort34919 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "abort", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._abort34919);
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34920;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSParser.getDomConfig()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._getDomConfig34920.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._getDomConfig34920 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getDomConfig34920)) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _getAsync34921;
		bool org.w3c.dom.ls.LSParser.getAsync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._getAsync34921.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._getAsync34921 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getAsync", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getAsync34921);
		}
		internal static global::MonoJavaBridge.MethodId _getBusy34922;
		bool org.w3c.dom.ls.LSParser.getBusy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._getBusy34922.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._getBusy34922 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getBusy", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getBusy34922);
		}
		internal static global::MonoJavaBridge.MethodId _parseURI34923;
		global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parseURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._parseURI34923.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._parseURI34923 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._parseURI34923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parseWithContext34924;
		global::org.w3c.dom.Node org.w3c.dom.ls.LSParser.parseWithContext(org.w3c.dom.ls.LSInput arg0, org.w3c.dom.Node arg1, short arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.w3c.dom.ls.LSParser_._parseWithContext34924.native == global::System.IntPtr.Zero)
				global::org.w3c.dom.ls.LSParser_._parseWithContext34924 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._parseWithContext34924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
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
