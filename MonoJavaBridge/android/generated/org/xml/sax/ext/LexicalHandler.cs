namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.LexicalHandler_))]
	public partial interface LexicalHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void comment(char[] arg0, int arg1, int arg2);
		void startCDATA();
		void endCDATA();
		void startEntity(java.lang.String arg0);
		void endEntity(java.lang.String arg0);
		void startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void endDTD();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.LexicalHandler))]
	internal sealed partial class LexicalHandler_ : java.lang.Object, LexicalHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LexicalHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "comment", "([CII)V", ref global::org.xml.sax.ext.LexicalHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.xml.sax.ext.LexicalHandler.startCDATA()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "startCDATA", "()V", ref global::org.xml.sax.ext.LexicalHandler_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.xml.sax.ext.LexicalHandler.endCDATA()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "endCDATA", "()V", ref global::org.xml.sax.ext.LexicalHandler_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.LexicalHandler_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.LexicalHandler_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.LexicalHandler_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.xml.sax.ext.LexicalHandler.endDTD()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.LexicalHandler_.staticClass, "endDTD", "()V", ref global::org.xml.sax.ext.LexicalHandler_._m6);
		}
		static LexicalHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.LexicalHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/LexicalHandler"));
		}
	}
}
