namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpResponse : org.apache.http.message.AbstractHttpMessage, HttpResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicHttpResponse._m0) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setLocale", "(Ljava/util/Locale;)V", ref global::org.apache.http.message.BasicHttpResponse._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual global::java.lang.String getReason(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "getReason", "(I)Ljava/lang/String;", ref global::org.apache.http.message.BasicHttpResponse._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.Locale getLocale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "getLocale", "()Ljava/util/Locale;", ref global::org.apache.http.message.BasicHttpResponse._m3) as java.util.Locale;
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.StatusLine getStatusLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.StatusLine>(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "getStatusLine", "()Lorg/apache/http/StatusLine;", ref global::org.apache.http.message.BasicHttpResponse._m4) as org.apache.http.StatusLine;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setStatusLine(org.apache.http.StatusLine arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusLine", "(Lorg/apache/http/StatusLine;)V", ref global::org.apache.http.message.BasicHttpResponse._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", ref global::org.apache.http.message.BasicHttpResponse._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V", ref global::org.apache.http.message.BasicHttpResponse._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int StatusCode
		{
			set
			{
				setStatusCode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setStatusCode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setStatusCode", "(I)V", ref global::org.apache.http.message.BasicHttpResponse._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String ReasonPhrase
		{
			set
			{
				setReasonPhrase(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setReasonPhrase(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setReasonPhrase", "(Ljava/lang/String;)V", ref global::org.apache.http.message.BasicHttpResponse._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::org.apache.http.HttpEntity getEntity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpEntity>(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;", ref global::org.apache.http.message.BasicHttpResponse._m10) as org.apache.http.HttpEntity;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHttpResponse.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V", ref global::org.apache.http.message.BasicHttpResponse._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public BasicHttpResponse(org.apache.http.StatusLine arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpResponse._m12.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpResponse._m12 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "<init>", "(Lorg/apache/http/StatusLine;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public BasicHttpResponse(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpResponse._m13.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpResponse._m13 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public BasicHttpResponse(org.apache.http.StatusLine arg0, org.apache.http.ReasonPhraseCatalog arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHttpResponse._m14.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHttpResponse._m14 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpResponse.staticClass, "<init>", "(Lorg/apache/http/StatusLine;Lorg/apache/http/ReasonPhraseCatalog;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpResponse.staticClass, global::org.apache.http.message.BasicHttpResponse._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicHttpResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHttpResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHttpResponse"));
		}
		internal static void InitJNI()
		{
		}
	}
}
