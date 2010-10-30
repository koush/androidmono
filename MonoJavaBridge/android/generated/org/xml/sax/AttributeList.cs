namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.AttributeList_))]
	public partial interface AttributeList  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::java.lang.String getName(int arg0);
		global::java.lang.String getValue(int arg0);
		global::java.lang.String getValue(java.lang.String arg0);
		global::java.lang.String getType(int arg0);
		global::java.lang.String getType(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.AttributeList))]
	internal sealed partial class AttributeList_ : java.lang.Object, AttributeList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AttributeList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34944;
		int org.xml.sax.AttributeList.getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.AttributeList_.staticClass, "getLength", "()I", ref global::org.xml.sax.AttributeList_._getLength34944);
		}
		internal static global::MonoJavaBridge.MethodId _getName34945;
		global::java.lang.String org.xml.sax.AttributeList.getName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.AttributeList_.staticClass, "getName", "(I)Ljava/lang/String;", ref global::org.xml.sax.AttributeList_._getName34945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34946;
		global::java.lang.String org.xml.sax.AttributeList.getValue(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.AttributeList_.staticClass, "getValue", "(I)Ljava/lang/String;", ref global::org.xml.sax.AttributeList_._getValue34946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34947;
		global::java.lang.String org.xml.sax.AttributeList.getValue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.AttributeList_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.AttributeList_._getValue34947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34948;
		global::java.lang.String org.xml.sax.AttributeList.getType(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.AttributeList_.staticClass, "getType", "(I)Ljava/lang/String;", ref global::org.xml.sax.AttributeList_._getType34948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34949;
		global::java.lang.String org.xml.sax.AttributeList.getType(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.AttributeList_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.xml.sax.AttributeList_._getType34949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static AttributeList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.AttributeList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/AttributeList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
