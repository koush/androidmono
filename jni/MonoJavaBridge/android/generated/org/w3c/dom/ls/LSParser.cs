namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSParser_))]
	public interface LSParser  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class LSParser_ : java.lang.Object, LSParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSParser_()
		{
			InitJNI();
		}
		internal LSParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse34797;
		 global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parse(org.w3c.dom.ls.LSInput arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._parse34797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._parse34797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _getFilter34798;
		 global::org.w3c.dom.ls.LSParserFilter org.w3c.dom.ls.LSParser.getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSParserFilter>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getFilter34798)) as org.w3c.dom.ls.LSParserFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSParserFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._getFilter34798)) as org.w3c.dom.ls.LSParserFilter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter34799;
		 void org.w3c.dom.ls.LSParser.setFilter(org.w3c.dom.ls.LSParserFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._setFilter34799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._setFilter34799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abort34800;
		 void org.w3c.dom.ls.LSParser.abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._abort34800);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._abort34800);
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34801;
		 global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSParser.getDomConfig() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getDomConfig34801)) as org.w3c.dom.DOMConfiguration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._getDomConfig34801)) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _getAsync34802;
		 bool org.w3c.dom.ls.LSParser.getAsync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getAsync34802);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._getAsync34802);
		}
		internal static global::MonoJavaBridge.MethodId _getBusy34803;
		 bool org.w3c.dom.ls.LSParser.getBusy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._getBusy34803);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._getBusy34803);
		}
		internal static global::MonoJavaBridge.MethodId _parseURI34804;
		 global::org.w3c.dom.Document org.w3c.dom.ls.LSParser.parseURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._parseURI34804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Document>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._parseURI34804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.w3c.dom.Document;
		}
		internal static global::MonoJavaBridge.MethodId _parseWithContext34805;
		 global::org.w3c.dom.Node org.w3c.dom.ls.LSParser.parseWithContext(org.w3c.dom.ls.LSInput arg0, org.w3c.dom.Node arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_._parseWithContext34805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParser_.staticClass, global::org.w3c.dom.ls.LSParser_._parseWithContext34805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.w3c.dom.Node;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSParser"));
			global::org.w3c.dom.ls.LSParser_._parse34797 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;");
			global::org.w3c.dom.ls.LSParser_._getFilter34798 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;");
			global::org.w3c.dom.ls.LSParser_._setFilter34799 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V");
			global::org.w3c.dom.ls.LSParser_._abort34800 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "abort", "()V");
			global::org.w3c.dom.ls.LSParser_._getDomConfig34801 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;");
			global::org.w3c.dom.ls.LSParser_._getAsync34802 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getAsync", "()Z");
			global::org.w3c.dom.ls.LSParser_._getBusy34803 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "getBusy", "()Z");
			global::org.w3c.dom.ls.LSParser_._parseURI34804 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;");
			global::org.w3c.dom.ls.LSParser_._parseWithContext34805 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParser_.staticClass, "parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;");
		}
	}
}
