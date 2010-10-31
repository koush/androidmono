namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpRequestInterceptorList_))]
	public partial interface HttpRequestInterceptorList  : global::MonoJavaBridge.IJavaObject 
	{
		void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0);
		void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1);
		global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0);
		int getRequestInterceptorCount();
		void clearRequestInterceptors();
		void removeRequestInterceptorByClass(java.lang.Class arg0);
		void setInterceptors(java.util.List arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpRequestInterceptorList))]
	internal sealed partial class HttpRequestInterceptorList_ : java.lang.Object, HttpRequestInterceptorList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequestInterceptorList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.protocol.HttpRequestInterceptorList.addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.protocol.HttpRequestInterceptorList.addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.HttpRequestInterceptor org.apache.http.protocol.HttpRequestInterceptorList.getRequestInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequestInterceptor>(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpRequestInterceptor;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.apache.http.protocol.HttpRequestInterceptorList.getRequestInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "getRequestInterceptorCount", "()I", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.protocol.HttpRequestInterceptorList.clearRequestInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "clearRequestInterceptors", "()V", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.protocol.HttpRequestInterceptorList.removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.protocol.HttpRequestInterceptorList.setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V", ref global::org.apache.http.protocol.HttpRequestInterceptorList_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpRequestInterceptorList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestInterceptorList"));
		}
	}
}
