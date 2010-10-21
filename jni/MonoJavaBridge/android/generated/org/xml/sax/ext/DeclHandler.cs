namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.DeclHandler_))]
	public interface DeclHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void elementDecl(java.lang.String arg0, java.lang.String arg1);
		void attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4);
		void internalEntityDecl(java.lang.String arg0, java.lang.String arg1);
		void externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.DeclHandler))]
	public sealed partial class DeclHandler_ : java.lang.Object, DeclHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DeclHandler_()
		{
			InitJNI();
		}
		internal DeclHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _elementDecl34989;
		 void org.xml.sax.ext.DeclHandler.elementDecl(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_._elementDecl34989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_.staticClass, global::org.xml.sax.ext.DeclHandler_._elementDecl34989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attributeDecl34990;
		 void org.xml.sax.ext.DeclHandler.attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_._attributeDecl34990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_.staticClass, global::org.xml.sax.ext.DeclHandler_._attributeDecl34990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _internalEntityDecl34991;
		 void org.xml.sax.ext.DeclHandler.internalEntityDecl(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_._internalEntityDecl34991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_.staticClass, global::org.xml.sax.ext.DeclHandler_._internalEntityDecl34991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _externalEntityDecl34992;
		 void org.xml.sax.ext.DeclHandler.externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_._externalEntityDecl34992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DeclHandler_.staticClass, global::org.xml.sax.ext.DeclHandler_._externalEntityDecl34992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.DeclHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/DeclHandler"));
			global::org.xml.sax.ext.DeclHandler_._elementDecl34989 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DeclHandler_.staticClass, "elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DeclHandler_._attributeDecl34990 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DeclHandler_.staticClass, "attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DeclHandler_._internalEntityDecl34991 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DeclHandler_.staticClass, "internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DeclHandler_._externalEntityDecl34992 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DeclHandler_.staticClass, "externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
