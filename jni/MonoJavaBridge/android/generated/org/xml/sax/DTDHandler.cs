namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.DTDHandler_))]
	public interface DTDHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.DTDHandler))]
	public sealed partial class DTDHandler_ : java.lang.Object, DTDHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DTDHandler_()
		{
			InitJNI();
		}
		internal DTDHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl28103;
		 void org.xml.sax.DTDHandler.unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DTDHandler_._unparsedEntityDecl28103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DTDHandler_.staticClass, global::org.xml.sax.DTDHandler_._unparsedEntityDecl28103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl28104;
		 void org.xml.sax.DTDHandler.notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.DTDHandler_._notationDecl28104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.DTDHandler_.staticClass, global::org.xml.sax.DTDHandler_._notationDecl28104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.DTDHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/DTDHandler"));
			global::org.xml.sax.DTDHandler_._unparsedEntityDecl28103 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DTDHandler_.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.DTDHandler_._notationDecl28104 = @__env.GetMethodIDNoThrow(global::org.xml.sax.DTDHandler_.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
