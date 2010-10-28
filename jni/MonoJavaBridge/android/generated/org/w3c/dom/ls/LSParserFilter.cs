namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSParserFilter_))]
	public partial interface LSParserFilter  : global::MonoJavaBridge.IJavaObject 
	{
		short startElement(org.w3c.dom.Element arg0);
		int getWhatToShow();
		short acceptNode(org.w3c.dom.Node arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSParserFilter))]
	internal sealed partial class LSParserFilter_ : java.lang.Object, LSParserFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSParserFilter_()
		{
			InitJNI();
		}
		internal LSParserFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement34930;
		short org.w3c.dom.ls.LSParserFilter.startElement(org.w3c.dom.Element arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParserFilter_._startElement34930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParserFilter_.staticClass, global::org.w3c.dom.ls.LSParserFilter_._startElement34930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWhatToShow34931;
		int org.w3c.dom.ls.LSParserFilter.getWhatToShow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParserFilter_._getWhatToShow34931);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParserFilter_.staticClass, global::org.w3c.dom.ls.LSParserFilter_._getWhatToShow34931);
		}
		internal static global::MonoJavaBridge.MethodId _acceptNode34932;
		short org.w3c.dom.ls.LSParserFilter.acceptNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParserFilter_._acceptNode34932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::org.w3c.dom.ls.LSParserFilter_.staticClass, global::org.w3c.dom.ls.LSParserFilter_._acceptNode34932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSParserFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSParserFilter"));
			global::org.w3c.dom.ls.LSParserFilter_._startElement34930 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParserFilter_.staticClass, "startElement", "(Lorg/w3c/dom/Element;)S");
			global::org.w3c.dom.ls.LSParserFilter_._getWhatToShow34931 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParserFilter_.staticClass, "getWhatToShow", "()I");
			global::org.w3c.dom.ls.LSParserFilter_._acceptNode34932 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSParserFilter_.staticClass, "acceptNode", "(Lorg/w3c/dom/Node;)S");
		}
	}
}
