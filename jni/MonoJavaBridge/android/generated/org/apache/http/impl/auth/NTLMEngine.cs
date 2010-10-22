namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.impl.auth.NTLMEngine_))]
	public partial interface NTLMEngine  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String generateType1Msg(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String generateType3Msg(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.NTLMEngine))]
	public sealed partial class NTLMEngine_ : java.lang.Object, NTLMEngine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NTLMEngine_()
		{
			InitJNI();
		}
		internal NTLMEngine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _generateType1Msg32618;
		 global::java.lang.String org.apache.http.impl.auth.NTLMEngine.generateType1Msg(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMEngine_._generateType1Msg32618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMEngine_.staticClass, global::org.apache.http.impl.auth.NTLMEngine_._generateType1Msg32618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _generateType3Msg32619;
		 global::java.lang.String org.apache.http.impl.auth.NTLMEngine.generateType3Msg(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMEngine_._generateType3Msg32619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMEngine_.staticClass, global::org.apache.http.impl.auth.NTLMEngine_._generateType3Msg32619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.NTLMEngine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/NTLMEngine"));
			global::org.apache.http.impl.auth.NTLMEngine_._generateType1Msg32618 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMEngine_.staticClass, "generateType1Msg", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMEngine_._generateType3Msg32619 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMEngine_.staticClass, "generateType3Msg", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
		}
	}
}
