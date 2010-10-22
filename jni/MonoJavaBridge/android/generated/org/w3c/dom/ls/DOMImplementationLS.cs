namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.DOMImplementationLS_))]
	public partial interface DOMImplementationLS  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.w3c.dom.ls.LSParser createLSParser(short arg0, java.lang.String arg1);
		global::org.w3c.dom.ls.LSSerializer createLSSerializer();
		global::org.w3c.dom.ls.LSInput createLSInput();
		global::org.w3c.dom.ls.LSOutput createLSOutput();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.DOMImplementationLS))]
	public sealed partial class DOMImplementationLS_ : java.lang.Object, DOMImplementationLS
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMImplementationLS_()
		{
			InitJNI();
		}
		internal DOMImplementationLS_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createLSParser34763;
		 global::org.w3c.dom.ls.LSParser org.w3c.dom.ls.DOMImplementationLS.createLSParser(short arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_._createLSParser34763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.ls.LSParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, global::org.w3c.dom.ls.DOMImplementationLS_._createLSParser34763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.w3c.dom.ls.LSParser;
		}
		internal static global::MonoJavaBridge.MethodId _createLSSerializer34764;
		 global::org.w3c.dom.ls.LSSerializer org.w3c.dom.ls.DOMImplementationLS.createLSSerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_._createLSSerializer34764)) as org.w3c.dom.ls.LSSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, global::org.w3c.dom.ls.DOMImplementationLS_._createLSSerializer34764)) as org.w3c.dom.ls.LSSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _createLSInput34765;
		 global::org.w3c.dom.ls.LSInput org.w3c.dom.ls.DOMImplementationLS.createLSInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSInput>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_._createLSInput34765)) as org.w3c.dom.ls.LSInput;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSInput>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, global::org.w3c.dom.ls.DOMImplementationLS_._createLSInput34765)) as org.w3c.dom.ls.LSInput;
		}
		internal static global::MonoJavaBridge.MethodId _createLSOutput34766;
		 global::org.w3c.dom.ls.LSOutput org.w3c.dom.ls.DOMImplementationLS.createLSOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSOutput>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_._createLSOutput34766)) as org.w3c.dom.ls.LSOutput;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.ls.LSOutput>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, global::org.w3c.dom.ls.DOMImplementationLS_._createLSOutput34766)) as org.w3c.dom.ls.LSOutput;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.DOMImplementationLS_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/DOMImplementationLS"));
			global::org.w3c.dom.ls.DOMImplementationLS_._createLSParser34763 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;");
			global::org.w3c.dom.ls.DOMImplementationLS_._createLSSerializer34764 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;");
			global::org.w3c.dom.ls.DOMImplementationLS_._createLSInput34765 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSInput", "()Lorg/w3c/dom/ls/LSInput;");
			global::org.w3c.dom.ls.DOMImplementationLS_._createLSOutput34766 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;");
		}
	}
}
