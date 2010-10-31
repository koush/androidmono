namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.Attributes_))]
	public partial interface Attributes  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::java.lang.String getValue(java.lang.String arg0);
		global::java.lang.String getValue(int arg0);
		global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getType(int arg0);
		global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getType(java.lang.String arg0);
		int getIndex(java.lang.String arg0);
		int getIndex(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getQName(int arg0);
		global::java.lang.String getLocalName(int arg0);
		global::java.lang.String getURI(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.Attributes))]
	internal sealed partial class Attributes_ : java.lang.Object, Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Attributes_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int org.xml.sax.Attributes.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.Attributes_.staticClass, "getLength", "()I", ref global::org.xml.sax.Attributes_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.xml.sax.Attributes.getValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getValue", "(I)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String org.xml.sax.Attributes.getType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getType", "(I)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.Attributes_.staticClass, "getIndex", "(Ljava/lang/String;)I", ref global::org.xml.sax.Attributes_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.Attributes_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::org.xml.sax.Attributes_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.String org.xml.sax.Attributes.getQName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getQName", "(I)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getLocalName", "(I)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.lang.String org.xml.sax.Attributes.getURI(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.Attributes_.staticClass, "getURI", "(I)Ljava/lang/String;", ref global::org.xml.sax.Attributes_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static Attributes_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Attributes_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Attributes"));
		}
	}
}
