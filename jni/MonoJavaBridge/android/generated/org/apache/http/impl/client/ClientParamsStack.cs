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
		internal static global::MonoJavaBridge.MethodId _copy26128;
		public override global::org.apache.http.@params.HttpParams copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._copy26128)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._copy26128)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter26129;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._setParameter26129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._setParameter26129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter26130;
		public override global::java.lang.Object getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getParameter26130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getParameter26130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter26131;
		public override bool removeParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._removeParameter26131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._removeParameter26131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.@params.HttpParams ApplicationParams
		{
			get
			{
				return getApplicationParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationParams26132;
		public virtual global::org.apache.http.@params.HttpParams getApplicationParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getApplicationParams26132)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getApplicationParams26132)) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams ClientParams
		{
			get
			{
				return getClientParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClientParams26133;
		public virtual global::org.apache.http.@params.HttpParams getClientParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getClientParams26133)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getClientParams26133)) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams RequestParams
		{
			get
			{
				return getRequestParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestParams26134;
		public virtual global::org.apache.http.@params.HttpParams getRequestParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getRequestParams26134)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getRequestParams26134)) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams OverrideParams
		{
			get
			{
				return getOverrideParams();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOverrideParams26135;
		public virtual global::org.apache.http.@params.HttpParams getOverrideParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack._getOverrideParams26135)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._getOverrideParams26135)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamsStack26136;
		public ClientParamsStack(org.apache.http.@params.HttpParams arg0, org.apache.http.@params.HttpParams arg1, org.apache.http.@params.HttpParams arg2, org.apache.http.@params.HttpParams arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack26136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamsStack26137;
		public ClientParamsStack(org.apache.http.impl.client.ClientParamsStack arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack26137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClientParamsStack26138;
		public ClientParamsStack(org.apache.http.impl.client.ClientParamsStack arg0, org.apache.http.@params.HttpParams arg1, org.apache.http.@params.HttpParams arg2, org.apache.http.@params.HttpParams arg3, org.apache.http.@params.HttpParams arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack26138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.ClientParamsStack.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/ClientParamsStack"));
			global::org.apache.http.impl.client.ClientParamsStack._copy26128 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "copy", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._setParameter26129 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getParameter26130 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.ClientParamsStack._removeParameter26131 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.impl.client.ClientParamsStack._getApplicationParams26132 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getApplicationParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getClientParams26133 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getClientParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getRequestParams26134 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getRequestParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._getOverrideParams26135 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getOverrideParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack26136 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/@params/HttpParams;Lorg/apache/http/@params/HttpParams;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack26137 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;)V");
			global::org.apache.http.impl.client.ClientParamsStack._ClientParamsStack26138 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;Lorg/apache/http/@params/HttpParams;Lorg/apache/http/@params/HttpParams;Lorg/apache/http/@params/HttpParams;Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
