namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.@params.HttpParams_))]
	public partial interface HttpParams  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.@params.HttpParams copy();
		global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getParameter(java.lang.String arg0);
		bool removeParameter(java.lang.String arg0);
		long getLongParameter(java.lang.String arg0, long arg1);
		global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1);
		int getIntParameter(java.lang.String arg0, int arg1);
		global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1);
		double getDoubleParameter(java.lang.String arg0, double arg1);
		global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1);
		bool getBooleanParameter(java.lang.String arg0, bool arg1);
		global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1);
		bool isParameterTrue(java.lang.String arg0);
		bool isParameterFalse(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.HttpParams))]
	internal sealed partial class HttpParams_ : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.HttpParams_.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.HttpParams_._m0) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.HttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.HttpParams_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object org.apache.http.@params.HttpParams.getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.@params.HttpParams_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool org.apache.http.@params.HttpParams.removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.HttpParams_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		long org.apache.http.@params.HttpParams.getLongParameter(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "getLongParameter", "(Ljava/lang/String;J)J", ref global::org.apache.http.@params.HttpParams_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setLongParameter(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.HttpParams_.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.HttpParams_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int org.apache.http.@params.HttpParams.getIntParameter(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "getIntParameter", "(Ljava/lang/String;I)I", ref global::org.apache.http.@params.HttpParams_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setIntParameter(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.HttpParams_.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.HttpParams_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		double org.apache.http.@params.HttpParams.getDoubleParameter(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D", ref global::org.apache.http.@params.HttpParams_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setDoubleParameter(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.HttpParams_.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.HttpParams_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool org.apache.http.@params.HttpParams.getBooleanParameter(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z", ref global::org.apache.http.@params.HttpParams_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setBooleanParameter(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.HttpParams_.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.HttpParams_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool org.apache.http.@params.HttpParams.isParameterTrue(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.HttpParams_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool org.apache.http.@params.HttpParams.isParameterFalse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.HttpParams_.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.HttpParams_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpParams_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpParams"));
		}
	}
}
