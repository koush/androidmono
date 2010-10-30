namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.message.AbstractHttpMessage_))]
	public abstract partial class AbstractHttpMessage : java.lang.Object, HttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::org.apache.http.ProtocolVersion getProtocolVersion();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.@params.HttpParams getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.message.AbstractHttpMessage._m1) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.message.AbstractHttpMessage._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.Header[] getHeaders(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", ref global::org.apache.http.message.AbstractHttpMessage._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool containsHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "containsHeader", "(Ljava/lang/String;)Z", ref global::org.apache.http.message.AbstractHttpMessage._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.Header getFirstHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.AbstractHttpMessage._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.Header getLastHeader(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", ref global::org.apache.http.message.AbstractHttpMessage._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.Header[] getAllHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;", ref global::org.apache.http.message.AbstractHttpMessage._m7) as org.apache.http.Header[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "addHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.AbstractHttpMessage._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.message.AbstractHttpMessage._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.message.AbstractHttpMessage._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.AbstractHttpMessage._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V", ref global::org.apache.http.message.AbstractHttpMessage._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.message.AbstractHttpMessage._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "removeHeaders", "(Ljava/lang/String;)V", ref global::org.apache.http.message.AbstractHttpMessage._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::org.apache.http.HeaderIterator headerIterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.message.AbstractHttpMessage._m15) as org.apache.http.HeaderIterator;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::org.apache.http.HeaderIterator headerIterator(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderIterator>(this, global::org.apache.http.message.AbstractHttpMessage.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", ref global::org.apache.http.message.AbstractHttpMessage._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HeaderIterator;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected AbstractHttpMessage() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.AbstractHttpMessage._m17.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.AbstractHttpMessage._m17 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._m17);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected AbstractHttpMessage(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.AbstractHttpMessage._m18.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.AbstractHttpMessage._m18 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.AbstractHttpMessage.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.AbstractHttpMessage.staticClass, global::org.apache.http.message.AbstractHttpMessage._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbstractHttpMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.AbstractHttpMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/AbstractHttpMessage"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.AbstractHttpMessage))]
	internal sealed partial class AbstractHttpMessage_ : org.apache.http.message.AbstractHttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpMessage_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.AbstractHttpMessage_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.AbstractHttpMessage_._m0) as org.apache.http.ProtocolVersion;
		}
		static AbstractHttpMessage_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.AbstractHttpMessage_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/AbstractHttpMessage"));
		}
		internal static void InitJNI()
		{
		}
	}
}
