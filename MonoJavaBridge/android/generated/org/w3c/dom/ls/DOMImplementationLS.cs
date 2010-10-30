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
	internal sealed partial class DOMImplementationLS_ : java.lang.Object, DOMImplementationLS
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DOMImplementationLS_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createLSParser34882;
		global::org.w3c.dom.ls.LSParser org.w3c.dom.ls.DOMImplementationLS.createLSParser(short arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSParser>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", ref global::org.w3c.dom.ls.DOMImplementationLS_._createLSParser34882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.ls.LSParser;
		}
		internal static global::MonoJavaBridge.MethodId _createLSSerializer34883;
		global::org.w3c.dom.ls.LSSerializer org.w3c.dom.ls.DOMImplementationLS.createLSSerializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSSerializer>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;", ref global::org.w3c.dom.ls.DOMImplementationLS_._createLSSerializer34883) as org.w3c.dom.ls.LSSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _createLSInput34884;
		global::org.w3c.dom.ls.LSInput org.w3c.dom.ls.DOMImplementationLS.createLSInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSInput>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSInput", "()Lorg/w3c/dom/ls/LSInput;", ref global::org.w3c.dom.ls.DOMImplementationLS_._createLSInput34884) as org.w3c.dom.ls.LSInput;
		}
		internal static global::MonoJavaBridge.MethodId _createLSOutput34885;
		global::org.w3c.dom.ls.LSOutput org.w3c.dom.ls.DOMImplementationLS.createLSOutput()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSOutput>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;", ref global::org.w3c.dom.ls.DOMImplementationLS_._createLSOutput34885) as org.w3c.dom.ls.LSOutput;
		}
		static DOMImplementationLS_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.DOMImplementationLS_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/DOMImplementationLS"));
		}
		internal static void InitJNI()
		{
		}
	}
}
