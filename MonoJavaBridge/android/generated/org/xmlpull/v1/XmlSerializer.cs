namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xmlpull.v1.XmlSerializer_))]
	public partial interface XmlSerializer  : global::MonoJavaBridge.IJavaObject 
	{
		void setProperty(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getProperty(java.lang.String arg0);
		global::java.lang.String getName();
		void flush();
		void comment(java.lang.String arg0);
		global::java.lang.String getPrefix(java.lang.String arg0, bool arg1);
		global::org.xmlpull.v1.XmlSerializer text(char[] arg0, int arg1, int arg2);
		global::org.xmlpull.v1.XmlSerializer text(java.lang.String arg0);
		void startDocument(java.lang.String arg0, java.lang.Boolean arg1);
		void endDocument();
		void ignorableWhitespace(java.lang.String arg0);
		void processingInstruction(java.lang.String arg0);
		void setFeature(java.lang.String arg0, bool arg1);
		bool getFeature(java.lang.String arg0);
		global::java.lang.String getNamespace();
		int getDepth();
		void setOutput(java.io.OutputStream arg0, java.lang.String arg1);
		void setOutput(java.io.Writer arg0);
		void setPrefix(java.lang.String arg0, java.lang.String arg1);
		global::org.xmlpull.v1.XmlSerializer startTag(java.lang.String arg0, java.lang.String arg1);
		global::org.xmlpull.v1.XmlSerializer attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::org.xmlpull.v1.XmlSerializer endTag(java.lang.String arg0, java.lang.String arg1);
		void cdsect(java.lang.String arg0);
		void entityRef(java.lang.String arg0);
		void docdecl(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xmlpull.v1.XmlSerializer))]
	internal sealed partial class XmlSerializer_ : java.lang.Object, XmlSerializer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XmlSerializer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.xmlpull.v1.XmlSerializer.setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.xmlpull.v1.XmlSerializer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object org.xmlpull.v1.XmlSerializer.getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.xmlpull.v1.XmlSerializer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.xmlpull.v1.XmlSerializer.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlSerializer_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.xmlpull.v1.XmlSerializer.flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "flush", "()V", ref global::org.xmlpull.v1.XmlSerializer_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.xmlpull.v1.XmlSerializer.comment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "comment", "(Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String org.xmlpull.v1.XmlSerializer.getPrefix(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;", ref global::org.xmlpull.v1.XmlSerializer_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "text", "([CII)Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlSerializer_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.text(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlSerializer_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void org.xmlpull.v1.XmlSerializer.startDocument(java.lang.String arg0, java.lang.Boolean arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V", ref global::org.xmlpull.v1.XmlSerializer_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void org.xmlpull.v1.XmlSerializer.endDocument()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "endDocument", "()V", ref global::org.xmlpull.v1.XmlSerializer_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void org.xmlpull.v1.XmlSerializer.ignorableWhitespace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "ignorableWhitespace", "(Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void org.xmlpull.v1.XmlSerializer.processingInstruction(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "processingInstruction", "(Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void org.xmlpull.v1.XmlSerializer.setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "setFeature", "(Ljava/lang/String;Z)V", ref global::org.xmlpull.v1.XmlSerializer_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool org.xmlpull.v1.XmlSerializer.getFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "getFeature", "(Ljava/lang/String;)Z", ref global::org.xmlpull.v1.XmlSerializer_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.String org.xmlpull.v1.XmlSerializer.getNamespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "getNamespace", "()Ljava/lang/String;", ref global::org.xmlpull.v1.XmlSerializer_._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		int org.xmlpull.v1.XmlSerializer.getDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "getDepth", "()I", ref global::org.xmlpull.v1.XmlSerializer_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void org.xmlpull.v1.XmlSerializer.setOutput(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void org.xmlpull.v1.XmlSerializer.setOutput(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "setOutput", "(Ljava/io/Writer;)V", ref global::org.xmlpull.v1.XmlSerializer_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void org.xmlpull.v1.XmlSerializer.setPrefix(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.startTag(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlSerializer_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlSerializer_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::org.xmlpull.v1.XmlSerializer org.xmlpull.v1.XmlSerializer.endTag(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xmlpull.v1.XmlSerializer>(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", ref global::org.xmlpull.v1.XmlSerializer_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void org.xmlpull.v1.XmlSerializer.cdsect(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "cdsect", "(Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void org.xmlpull.v1.XmlSerializer.entityRef(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "entityRef", "(Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void org.xmlpull.v1.XmlSerializer.docdecl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlSerializer_.staticClass, "docdecl", "(Ljava/lang/String;)V", ref global::org.xmlpull.v1.XmlSerializer_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static XmlSerializer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlSerializer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlSerializer"));
		}
	}
}
