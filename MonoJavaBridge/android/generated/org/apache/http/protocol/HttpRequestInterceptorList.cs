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
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor33911;
		void org.apache.http.protocol.HttpRequestInterceptorList.addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor33911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor33912;
		void org.apache.http.protocol.HttpRequestInterceptorList.addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor33912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor33913;
		global::org.apache.http.HttpRequestInterceptor org.apache.http.protocol.HttpRequestInterceptorList.getRequestInterceptor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptor33913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount33914;
		int org.apache.http.protocol.HttpRequestInterceptorList.getRequestInterceptorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptorCount33914);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors33915;
		void org.apache.http.protocol.HttpRequestInterceptorList.clearRequestInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._clearRequestInterceptors33915);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass33916;
		void org.apache.http.protocol.HttpRequestInterceptorList.removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._removeRequestInterceptorByClass33916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors33917;
		void org.apache.http.protocol.HttpRequestInterceptorList.setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._setInterceptors33917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpRequestInterceptorList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestInterceptorList"));
			global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor33911 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor33912 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptor33913 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptorCount33914 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "getRequestInterceptorCount", "()I");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._clearRequestInterceptors33915 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "clearRequestInterceptors", "()V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._removeRequestInterceptorByClass33916 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._setInterceptors33917 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
