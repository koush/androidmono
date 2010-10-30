namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSInput_))]
	public partial interface LSInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getEncoding();
		void setEncoding(java.lang.String arg0);
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		global::java.io.Reader getCharacterStream();
		void setCharacterStream(java.io.Reader arg0);
		void setSystemId(java.lang.String arg0);
		global::java.lang.String getBaseURI();
		void setPublicId(java.lang.String arg0);
		void setByteStream(java.io.InputStream arg0);
		global::java.io.InputStream getByteStream();
		global::java.lang.String getStringData();
		void setStringData(java.lang.String arg0);
		void setBaseURI(java.lang.String arg0);
		bool getCertifiedText();
		void setCertifiedText(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSInput))]
	internal sealed partial class LSInput_ : java.lang.Object, LSInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LSInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.w3c.dom.ls.LSInput.getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSInput_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.w3c.dom.ls.LSInput.setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSInput_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.w3c.dom.ls.LSInput.getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSInput_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.w3c.dom.ls.LSInput.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSInput_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.io.Reader org.w3c.dom.ls.LSInput.getCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getCharacterStream", "()Ljava/io/Reader;", ref global::org.w3c.dom.ls.LSInput_._m4) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.w3c.dom.ls.LSInput.setCharacterStream(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V", ref global::org.w3c.dom.ls.LSInput_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.w3c.dom.ls.LSInput.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSInput_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String org.w3c.dom.ls.LSInput.getBaseURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getBaseURI", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSInput_._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.w3c.dom.ls.LSInput.setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setPublicId", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSInput_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.w3c.dom.ls.LSInput.setByteStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setByteStream", "(Ljava/io/InputStream;)V", ref global::org.w3c.dom.ls.LSInput_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.io.InputStream org.w3c.dom.ls.LSInput.getByteStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getByteStream", "()Ljava/io/InputStream;", ref global::org.w3c.dom.ls.LSInput_._m10) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String org.w3c.dom.ls.LSInput.getStringData()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getStringData", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSInput_._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void org.w3c.dom.ls.LSInput.setStringData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setStringData", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSInput_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void org.w3c.dom.ls.LSInput.setBaseURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setBaseURI", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSInput_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool org.w3c.dom.ls.LSInput.getCertifiedText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "getCertifiedText", "()Z", ref global::org.w3c.dom.ls.LSInput_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void org.w3c.dom.ls.LSInput.setCertifiedText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSInput_.staticClass, "setCertifiedText", "(Z)V", ref global::org.w3c.dom.ls.LSInput_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static LSInput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSInput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
