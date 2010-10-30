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
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.w3c.dom.ls.LSParser org.w3c.dom.ls.DOMImplementationLS.createLSParser(short arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSParser>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", ref global::org.w3c.dom.ls.DOMImplementationLS_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.w3c.dom.ls.LSParser;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.w3c.dom.ls.LSSerializer org.w3c.dom.ls.DOMImplementationLS.createLSSerializer()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSSerializer>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;", ref global::org.w3c.dom.ls.DOMImplementationLS_._m1) as org.w3c.dom.ls.LSSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.w3c.dom.ls.LSInput org.w3c.dom.ls.DOMImplementationLS.createLSInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSInput>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSInput", "()Lorg/w3c/dom/ls/LSInput;", ref global::org.w3c.dom.ls.DOMImplementationLS_._m2) as org.w3c.dom.ls.LSInput;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.w3c.dom.ls.LSOutput org.w3c.dom.ls.DOMImplementationLS.createLSOutput()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.ls.LSOutput>(this, global::org.w3c.dom.ls.DOMImplementationLS_.staticClass, "createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;", ref global::org.w3c.dom.ls.DOMImplementationLS_._m3) as org.w3c.dom.ls.LSOutput;
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
