namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.impl.auth.NTLMEngine_))]
	public partial interface NTLMEngine  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String generateType1Msg(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String generateType3Msg(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.NTLMEngine))]
	internal sealed partial class NTLMEngine_ : java.lang.Object, NTLMEngine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NTLMEngine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.impl.auth.NTLMEngine.generateType1Msg(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.NTLMEngine_.staticClass, "generateType1Msg", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.auth.NTLMEngine_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.impl.auth.NTLMEngine.generateType3Msg(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.NTLMEngine_.staticClass, "generateType3Msg", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.auth.NTLMEngine_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as java.lang.String;
		}
		static NTLMEngine_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.NTLMEngine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/NTLMEngine"));
		}
	}
}
