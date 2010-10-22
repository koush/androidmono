namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.Source_))]
	public partial interface Source  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getSystemId();
		void setSystemId(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Source))]
	public sealed partial class Source_ : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Source_()
		{
			InitJNI();
		}
		internal Source_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId30832;
		 global::java.lang.String javax.xml.transform.Source.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.Source_._getSystemId30832)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.Source_.staticClass, global::javax.xml.transform.Source_._getSystemId30832)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId30833;
		 void javax.xml.transform.Source.setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.Source_._setSystemId30833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.Source_.staticClass, global::javax.xml.transform.Source_._setSystemId30833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Source_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Source"));
			global::javax.xml.transform.Source_._getSystemId30832 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Source_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.Source_._setSystemId30833 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.Source_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
		}
	}
}
