namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.Attributes2_))]
	public partial interface Attributes2 : Attributes
	{
		bool isSpecified(int arg0);
		bool isSpecified(java.lang.String arg0, java.lang.String arg1);
		bool isSpecified(java.lang.String arg0);
		bool isDeclared(int arg0);
		bool isDeclared(java.lang.String arg0);
		bool isDeclared(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.Attributes2))]
	internal sealed partial class Attributes2_ : java.lang.Object, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Attributes2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool org.xml.sax.ext.Attributes2.isSpecified(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(I)Z", ref global::org.xml.sax.ext.Attributes2_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool org.xml.sax.ext.Attributes2.isDeclared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(I)Z", ref global::org.xml.sax.ext.Attributes2_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int org.xml.sax.Attributes.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getLength", "()I", ref global::org.xml.sax.ext.Attributes2_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.String org.xml.sax.Attributes.getValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(I)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.xml.sax.Attributes.getType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(I)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;)I", ref global::org.xml.sax.ext.Attributes2_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::org.xml.sax.ext.Attributes2_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.String org.xml.sax.Attributes.getQName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getQName", "(I)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getLocalName", "(I)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.lang.String org.xml.sax.Attributes.getURI(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Attributes2_.staticClass, "getURI", "(I)Ljava/lang/String;", ref global::org.xml.sax.ext.Attributes2_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static Attributes2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2"));
		}
	}
}
