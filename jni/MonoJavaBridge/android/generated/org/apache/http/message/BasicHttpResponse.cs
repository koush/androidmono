namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpResponse : org.apache.http.message.AbstractHttpMessage, HttpResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpResponse()
		{
			InitJNI();
		}
		protected BasicHttpResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion26831;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._getProtocolVersion26831)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._getProtocolVersion26831)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _setLocale26832;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setLocale26832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setLocale26832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReason26833;
		protected virtual global::java.lang.String getReason(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._getReason26833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._getReason26833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.util.Locale Locale
		{
			get
			{
				return getLocale();
			}
			set
			{
				setLocale(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocale26834;
		public virtual global::java.util.Locale getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._getLocale26834)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._getLocale26834)) as java.util.Locale;
		}
		public new global::org.apache.http.StatusLine StatusLine
		{
			get
			{
				return getStatusLine();
			}
			set
			{
				setStatusLine(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusLine26835;
		public virtual global::org.apache.http.StatusLine getStatusLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._getStatusLine26835)) as org.apache.http.StatusLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._getStatusLine26835)) as org.apache.http.StatusLine;
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine26836;
		public virtual void setStatusLine(org.apache.http.StatusLine arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setStatusLine26836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setStatusLine26836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine26837;
		public virtual void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setStatusLine26837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setStatusLine26837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine26838;
		public virtual void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setStatusLine26838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setStatusLine26838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusCode26839;
		public virtual void setStatusCode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setStatusCode26839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setStatusCode26839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReasonPhrase26840;
		public virtual void setReasonPhrase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setReasonPhrase26840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setReasonPhrase26840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.HttpEntity Entity
		{
			get
			{
				return getEntity();
			}
			set
			{
				setEntity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntity26841;
		public virtual global::org.apache.http.HttpEntity getEntity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._getEntity26841)) as org.apache.http.HttpEntity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._getEntity26841)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity26842;
		public virtual void setEntity(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse._setEntity26842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._setEntity26842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpResponse26843;
		public BasicHttpResponse(org.apache.http.StatusLine arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._BasicHttpResponse26843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpResponse26844;
		public BasicHttpResponse(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._BasicHttpResponse26844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpResponse26845;
		public BasicHttpResponse(org.apache.http.StatusLine arg0, org.apache.http.ReasonPhraseCatalog arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._BasicHttpResponse26845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHttpResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHttpResponse"));
			global::org.apache.http.message.BasicHttpResponse._getProtocolVersion26831 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicHttpResponse._setLocale26832 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::org.apache.http.message.BasicHttpResponse._getReason26833 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "getReason", "(I)Ljava/lang/String;");
			global::org.apache.http.message.BasicHttpResponse._getLocale26834 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::org.apache.http.message.BasicHttpResponse._getStatusLine26835 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "getStatusLine", "()Lorg/apache/http/StatusLine;");
			global::org.apache.http.message.BasicHttpResponse._setStatusLine26836 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusLine", "(Lorg/apache/http/StatusLine;)V");
			global::org.apache.http.message.BasicHttpResponse._setStatusLine26837 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::org.apache.http.message.BasicHttpResponse._setStatusLine26838 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V");
			global::org.apache.http.message.BasicHttpResponse._setStatusCode26839 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusCode", "(I)V");
			global::org.apache.http.message.BasicHttpResponse._setReasonPhrase26840 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setReasonPhrase", "(Ljava/lang/String;)V");
			global::org.apache.http.message.BasicHttpResponse._getEntity26841 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.message.BasicHttpResponse._setEntity26842 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.message.BasicHttpResponse._BasicHttpResponse26843 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "<init>", "(Lorg/apache/http/StatusLine;)V");
			global::org.apache.http.message.BasicHttpResponse._BasicHttpResponse26844 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::org.apache.http.message.BasicHttpResponse._BasicHttpResponse26845 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "<init>", "(Lorg/apache/http/StatusLine;Lorg/apache/http/ReasonPhraseCatalog;Ljava/util/Locale;)V");
		}
	}
}
