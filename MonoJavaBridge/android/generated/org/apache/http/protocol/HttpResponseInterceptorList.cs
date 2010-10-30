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
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33918;
		void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33919;
		void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor33920;
		global::org.apache.http.HttpResponseInterceptor org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponseInterceptor>(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor33920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponseInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount33921;
		int org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptorCount", "()I", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount33921);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors33922;
		void org.apache.http.protocol.HttpResponseInterceptorList.clearResponseInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "clearResponseInterceptors", "()V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors33922);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass33923;
		void org.apache.http.protocol.HttpResponseInterceptorList.removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass33923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors33924;
		void org.apache.http.protocol.HttpResponseInterceptorList.setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V", ref global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors33924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
