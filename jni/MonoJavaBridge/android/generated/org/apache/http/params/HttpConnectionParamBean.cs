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
		public new int SoTimeout
		{
			set
			{
				setSoTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout33766;
		public virtual void setSoTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout33766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout33766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool TcpNoDelay
		{
			set
			{
				setTcpNoDelay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTcpNoDelay33767;
		public virtual void setTcpNoDelay(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay33767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay33767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SocketBufferSize
		{
			set
			{
				setSocketBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSocketBufferSize33768;
		public virtual void setSocketBufferSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize33768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize33768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Linger
		{
			set
			{
				setLinger(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLinger33769;
		public virtual void setLinger(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setLinger33769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setLinger33769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ConnectionTimeout
		{
			set
			{
				setConnectionTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionTimeout33770;
		public virtual void setConnectionTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout33770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout33770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool StaleCheckingEnabled
		{
			set
			{
				setStaleCheckingEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStaleCheckingEnabled33771;
		public virtual void setStaleCheckingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled33771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled33771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpConnectionParamBean33772;
		public HttpConnectionParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpConnectionParamBean.staticClass, global::org.apache.http.@params.HttpConnectionParamBean._HttpConnectionParamBean33772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpConnectionParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpConnectionParamBean"));
			global::org.apache.http.@params.HttpConnectionParamBean._setSoTimeout33766 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSoTimeout", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setTcpNoDelay33767 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setTcpNoDelay", "(Z)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setSocketBufferSize33768 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setSocketBufferSize", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setLinger33769 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setLinger", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setConnectionTimeout33770 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setConnectionTimeout", "(I)V");
			global::org.apache.http.@params.HttpConnectionParamBean._setStaleCheckingEnabled33771 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "setStaleCheckingEnabled", "(Z)V");
			global::org.apache.http.@params.HttpConnectionParamBean._HttpConnectionParamBean33772 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpConnectionParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
