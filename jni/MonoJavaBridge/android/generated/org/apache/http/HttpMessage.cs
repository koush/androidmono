namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpMessage_))]
	public partial interface HttpMessage  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		global::org.apache.http.@params.HttpParams getParams();
		void setParams(org.apache.http.@params.HttpParams arg0);
		global::org.apache.http.Header[] getHeaders(java.lang.String arg0);
		bool containsHeader(java.lang.String arg0);
		global::org.apache.http.Header getFirstHeader(java.lang.String arg0);
		global::org.apache.http.Header getLastHeader(java.lang.String arg0);
		global::org.apache.http.Header[] getAllHeaders();
		void addHeader(org.apache.http.Header arg0);
		void addHeader(java.lang.String arg0, java.lang.String arg1);
		void setHeader(java.lang.String arg0, java.lang.String arg1);
		void setHeader(org.apache.http.Header arg0);
		void setHeaders(org.apache.http.Header[] arg0);
		void removeHeader(org.apache.http.Header arg0);
		void removeHeaders(java.lang.String arg0);
		global::org.apache.http.HeaderIterator headerIterator();
		global::org.apache.http.HeaderIterator headerIterator(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpMessage))]
	internal sealed partial class HttpMessage_ : java.lang.Object, HttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpMessage_()
		{
			InitJNI();
		}
		internal HttpMessage_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31600;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getProtocolVersion31600)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getProtocolVersion31600)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams31601;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getParams31601)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getParams31601)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams31602;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setParams31602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setParams31602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders31603;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getHeaders31603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getHeaders31603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader31604;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._containsHeader31604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._containsHeader31604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader31605;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getFirstHeader31605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getFirstHeader31605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader31606;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getLastHeader31606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getLastHeader31606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders31607;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getAllHeaders31607)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getAllHeaders31607)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31608;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._addHeader31608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._addHeader31608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31609;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._addHeader31609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._addHeader31609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31610;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setHeader31610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setHeader31610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31611;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setHeader31611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setHeader31611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders31612;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setHeaders31612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setHeaders31612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader31613;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._removeHeader31613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._removeHeader31613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders31614;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._removeHeaders31614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._removeHeaders31614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31615;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._headerIterator31615)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._headerIterator31615)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31616;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._headerIterator31616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._headerIterator31616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpMessage_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpMessage"));
			global::org.apache.http.HttpMessage_._getProtocolVersion31600 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.HttpMessage_._getParams31601 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.HttpMessage_._setParams31602 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.HttpMessage_._getHeaders31603 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._containsHeader31604 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.HttpMessage_._getFirstHeader31605 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._getLastHeader31606 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._getAllHeaders31607 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._addHeader31608 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._addHeader31609 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpMessage_._setHeader31610 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpMessage_._setHeader31611 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._setHeaders31612 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._removeHeader31613 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._removeHeaders31614 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpMessage_._headerIterator31615 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.HttpMessage_._headerIterator31616 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
