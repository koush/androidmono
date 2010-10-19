namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpRequestInterceptorList_))]
	public interface HttpRequestInterceptorList  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class HttpRequestInterceptorList_ : java.lang.Object, HttpRequestInterceptorList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestInterceptorList_()
		{
			InitJNI();
		}
		internal HttpRequestInterceptorList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor27108;
		 void org.apache.http.protocol.HttpRequestInterceptorList.addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor27108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor27108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor27109;
		 void org.apache.http.protocol.HttpRequestInterceptorList.addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor27109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor27109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor27110;
		 global::org.apache.http.HttpRequestInterceptor org.apache.http.protocol.HttpRequestInterceptorList.getRequestInterceptor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptor27110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptor27110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount27111;
		 int org.apache.http.protocol.HttpRequestInterceptorList.getRequestInterceptorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptorCount27111);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptorCount27111);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors27112;
		 void org.apache.http.protocol.HttpRequestInterceptorList.clearRequestInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._clearRequestInterceptors27112);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._clearRequestInterceptors27112);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass27113;
		 void org.apache.http.protocol.HttpRequestInterceptorList.removeRequestInterceptorByClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._removeRequestInterceptorByClass27113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._removeRequestInterceptorByClass27113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors27114;
		 void org.apache.http.protocol.HttpRequestInterceptorList.setInterceptors(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_._setInterceptors27114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, global::org.apache.http.protocol.HttpRequestInterceptorList_._setInterceptors27114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestInterceptorList"));
			global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor27108 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._addRequestInterceptor27109 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptor27110 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._getRequestInterceptorCount27111 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "getRequestInterceptorCount", "()I");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._clearRequestInterceptors27112 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "clearRequestInterceptors", "()V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._removeRequestInterceptorByClass27113 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.HttpRequestInterceptorList_._setInterceptors27114 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V");
		}
	}
}
