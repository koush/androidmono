namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.TypeInfo_))]
	public partial interface TypeInfo  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getTypeName();
		global::java.lang.String getTypeNamespace();
		bool isDerivedFrom(java.lang.String arg0, java.lang.String arg1, int arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.TypeInfo))]
	internal sealed partial class TypeInfo_ : java.lang.Object, TypeInfo
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TypeInfo_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.w3c.dom.TypeInfo.getTypeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.TypeInfo_.staticClass, "getTypeName", "()Ljava/lang/String;", ref global::org.w3c.dom.TypeInfo_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.w3c.dom.TypeInfo.getTypeNamespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.TypeInfo_.staticClass, "getTypeNamespace", "()Ljava/lang/String;", ref global::org.w3c.dom.TypeInfo_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool org.w3c.dom.TypeInfo.isDerivedFrom(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.w3c.dom.TypeInfo_.staticClass, "isDerivedFrom", "(Ljava/lang/String;Ljava/lang/String;I)Z", ref global::org.w3c.dom.TypeInfo_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static TypeInfo_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.TypeInfo_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/TypeInfo"));
		}
		internal static void InitJNI()
		{
		}
	}
}
