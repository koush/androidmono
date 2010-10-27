namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSSerializer_))]
	public partial interface LSSerializer  : global::MonoJavaBridge.IJavaObject 
	{
		bool write(org.w3c.dom.Node arg0, org.w3c.dom.ls.LSOutput arg1);
		global::org.w3c.dom.DOMConfiguration getDomConfig();
		global::java.lang.String getNewLine();
		void setNewLine(java.lang.String arg0);
		bool writeToURI(org.w3c.dom.Node arg0, java.lang.String arg1);
		global::java.lang.String writeToString(org.w3c.dom.Node arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSSerializer))]
	internal sealed partial class LSSerializer_ : java.lang.Object, LSSerializer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSSerializer_()
		{
			InitJNI();
		}
		internal LSSerializer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write34937;
		bool org.w3c.dom.ls.LSSerializer.write(org.w3c.dom.Node arg0, org.w3c.dom.ls.LSOutput arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_._write34937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_.staticClass, global::org.w3c.dom.ls.LSSerializer_._write34937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDomConfig34938;
		global::org.w3c.dom.DOMConfiguration org.w3c.dom.ls.LSSerializer.getDomConfig()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_._getDomConfig34938)) as org.w3c.dom.DOMConfiguration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.DOMConfiguration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_.staticClass, global::org.w3c.dom.ls.LSSerializer_._getDomConfig34938)) as org.w3c.dom.DOMConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _getNewLine34939;
		global::java.lang.String org.w3c.dom.ls.LSSerializer.getNewLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_._getNewLine34939)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_.staticClass, global::org.w3c.dom.ls.LSSerializer_._getNewLine34939)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNewLine34940;
		void org.w3c.dom.ls.LSSerializer.setNewLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_._setNewLine34940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_.staticClass, global::org.w3c.dom.ls.LSSerializer_._setNewLine34940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToURI34941;
		bool org.w3c.dom.ls.LSSerializer.writeToURI(org.w3c.dom.Node arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_._writeToURI34941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_.staticClass, global::org.w3c.dom.ls.LSSerializer_._writeToURI34941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToString34942;
		global::java.lang.String org.w3c.dom.ls.LSSerializer.writeToString(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_._writeToString34942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSSerializer_.staticClass, global::org.w3c.dom.ls.LSSerializer_._writeToString34942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSSerializer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSSerializer"));
			global::org.w3c.dom.ls.LSSerializer_._write34937 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSSerializer_.staticClass, "write", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/ls/LSOutput;)Z");
			global::org.w3c.dom.ls.LSSerializer_._getDomConfig34938 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSSerializer_.staticClass, "getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;");
			global::org.w3c.dom.ls.LSSerializer_._getNewLine34939 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSSerializer_.staticClass, "getNewLine", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSSerializer_._setNewLine34940 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSSerializer_.staticClass, "setNewLine", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSSerializer_._writeToURI34941 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSSerializer_.staticClass, "writeToURI", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Z");
			global::org.w3c.dom.ls.LSSerializer_._writeToString34942 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSSerializer_.staticClass, "writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;");
		}
	}
}
