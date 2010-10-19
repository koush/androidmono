namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpResponseInterceptorList_))]
	public interface HttpResponseInterceptorList  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class HttpResponseInterceptorList_ : java.lang.Object, HttpResponseInterceptorList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpResponseInterceptorList_()
		{
			InitJNI();
		}
		internal HttpResponseInterceptorList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor27115;
		 void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor27115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor27115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor27116;
		 void org.apache.http.protocol.HttpResponseInterceptorList.addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor27116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor27116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor27117;
		 global::org.apache.http.HttpResponseInterceptor org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor27117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor27117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount27118;
		 int org.apache.http.protocol.HttpResponseInterceptorList.getResponseInterceptorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount27118);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount27118);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors27119;
		 void org.apache.http.protocol.HttpResponseInterceptorList.clearResponseInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors27119);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors27119);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass27120;
		 void org.apache.http.protocol.HttpResponseInterceptorList.removeResponseInterceptorByClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass27120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass27120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors27121;
		 void org.apache.http.protocol.HttpResponseInterceptorList.setInterceptors(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors27121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors27121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpResponseInterceptorList"));
			global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor27115 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._addResponseInterceptor27116 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptor27117 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._getResponseInterceptorCount27118 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "getResponseInterceptorCount", "()I");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._clearResponseInterceptors27119 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "clearResponseInterceptors", "()V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._removeResponseInterceptorByClass27120 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.HttpResponseInterceptorList_._setInterceptors27121 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpResponseInterceptorList_.staticClass, "setInterceptors", "(Ljava/util/List;)V");
		}
	}
}
