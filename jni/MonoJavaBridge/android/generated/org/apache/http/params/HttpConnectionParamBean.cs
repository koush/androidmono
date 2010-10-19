namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpConnectionParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnectionParamBean()
		{
			InitJNI();
		}
		protected HttpConnectionParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout27001;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout27001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout27001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay27002;
		public virtual void setTcpNoDelay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay27002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay27002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketBufferSize27003;
		public virtual void setSocketBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize27003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize27003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinger27004;
		public virtual void setLinger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setLinger27004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setLinger27004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionTimeout27005;
		public virtual void setConnectionTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout27005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout27005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStaleCheckingEnabled27006;
		public virtual void setStaleCheckingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled27006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled27006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpConnectionParamBean27007;
		public HttpConnectionParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._HttpConnectionParamBean27007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpConnectionParamBean"));
			global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout27001 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSoTimeout", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay27002 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setTcpNoDelay", "(Z)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize27003 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSocketBufferSize", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setLinger27004 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setLinger", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout27005 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setConnectionTimeout", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled27006 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setStaleCheckingEnabled", "(Z)V");
			global::org.apache.http.@params.HttpConnectionParamBean._HttpConnectionParamBean27007 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
