namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpResponseInterceptorList_))]
	public partial interface HttpResponseInterceptorList  : global::MonoJavaBridge.IJavaObject 
	{
		void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0);
		void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1);
		global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0);
		int getResponseInterceptorCount();
		void clearResponseInterceptors();
		void removeResponseInterceptorByClass(java.lang.Class arg0);
		void setInterceptors(java.util.List arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpResponseInterceptorList))]
	internal sealed partial class HttpResponseInterceptorList_ : java.lang.Object, HttpResponseInterceptorList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpResponseInterceptorList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.HttpResponseInterceptor org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponseInterceptor>(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponseInterceptor;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptorCount", "()I", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.protocol.HttpResponseInterceptorList.clearResponseInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "clearResponseInterceptors", "()V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.protocol.HttpResponseInterceptorList.removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.apache.http.protocol.HttpResponseInterceptorList.setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpResponseInterceptorList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpResponseInterceptorList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
