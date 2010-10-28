namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientParamsStack : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientParamsStack()
		{
			InitJNI();
		}
		protected ClientParamsStack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy32870;
		public override global::org.apache.http.@params.HttpParams copy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._copy32870)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._copy32870)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter32871;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._setParameter32871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._setParameter32871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter32872;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getParameter32872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getParameter32872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter32873;
		public override bool removeParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._removeParameter32873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._removeParameter32873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.@params.HttpParams ApplicationParams
		{
			get
			{
				return getApplicationParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationParams32874;
		public virtual global::org.apache.http.@params.HttpParams getApplicationParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getApplicationParams32874)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getApplicationParams32874)) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams ClientParams
		{
			get
			{
				return getClientParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClientParams32875;
		public virtual global::org.apache.http.@params.HttpParams getClientParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getClientParams32875)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getClientParams32875)) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams RequestParams
		{
			get
			{
				return getRequestParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestParams32876;
		public virtual global::org.apache.http.@params.HttpParams getRequestParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getRequestParams32876)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getRequestParams32876)) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams OverrideParams
		{
			get
			{
				return getOverrideParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOverrideParams32877;
		public virtual global::org.apache.http.@params.HttpParams getOverrideParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getOverrideParams32877)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getOverrideParams32877)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamsStack32878;
		public ClientParamsStack(org.apache.http.@params.HttpParams arg0, org.apache.http.@params.HttpParams arg1, org.apache.http.@params.HttpParams arg2, org.apache.http.@params.HttpParams arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack32878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamsStack32879;
		public ClientParamsStack(org.apache.http.impl.client.ClientParamsStack arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack32879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamsStack32880;
		public ClientParamsStack(org.apache.http.impl.client.ClientParamsStack arg0, org.apache.http.@params.HttpParams arg1, org.apache.http.@params.HttpParams arg2, org.apache.http.@params.HttpParams arg3, org.apache.http.@params.HttpParams arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack32880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.ClientParamsStack.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/ClientParamsStack"));
			global::org.apache.http.impl.client.ClientParamsStack._copy32870 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._setParameter32871 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getParameter32872 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.ClientParamsStack._removeParameter32873 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.impl.client.ClientParamsStack._getApplicationParams32874 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getApplicationParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getClientParams32875 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getClientParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getRequestParams32876 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getRequestParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getOverrideParams32877 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getOverrideParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack32878 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack32879 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;)V");
			global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack32880 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
