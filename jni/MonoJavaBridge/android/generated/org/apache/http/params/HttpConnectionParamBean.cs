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
		internal static global::MonoJavaBridge.MethodId _setSoTimeout33647;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout33647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout33647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay33648;
		public virtual void setTcpNoDelay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay33648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay33648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketBufferSize33649;
		public virtual void setSocketBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize33649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize33649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinger33650;
		public virtual void setLinger(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setLinger33650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setLinger33650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionTimeout33651;
		public virtual void setConnectionTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout33651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout33651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStaleCheckingEnabled33652;
		public virtual void setStaleCheckingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled33652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled33652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpConnectionParamBean33653;
		public HttpConnectionParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._HttpConnectionParamBean33653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/HttpConnectionParamBean"));
			global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout33647 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSoTimeout", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay33648 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setTcpNoDelay", "(Z)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize33649 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSocketBufferSize", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setLinger33650 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setLinger", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout33651 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setConnectionTimeout", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled33652 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setStaleCheckingEnabled", "(Z)V");
			global::org.apache.http.@params.HttpConnectionParamBean._HttpConnectionParamBean33653 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
