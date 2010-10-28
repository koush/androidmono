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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33919;
		void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor33920;
		global::org.apache.http.HttpResponseInterceptor org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor33920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor33920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount33921;
		int org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount33921);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount33921);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors33922;
		void org.apache.http.protocol.HttpResponseInterceptorList.clearResponseInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors33922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors33922);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass33923;
		void org.apache.http.protocol.HttpResponseInterceptorList.removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass33923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass33923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors33924;
		void org.apache.http.protocol.HttpResponseInterceptorList.setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors33924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors33924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpResponseInterceptorList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpResponseInterceptorList"));
			global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33918 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor33919 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor33920 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount33921 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptorCount", "()I");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors33922 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "clearResponseInterceptors", "()V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass33923 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors33924 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
