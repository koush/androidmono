namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpMessage_))]
	public interface HttpMessage  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class HttpMessage_ : java.lang.Object, HttpMessage
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpMessage_()
		{
			InitJNI();
		}
		internal HttpMessage_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion24991;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getProtocolVersion24991)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getProtocolVersion24991)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams24992;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getParams24992)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getParams24992)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams24993;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setParams24993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setParams24993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders24994;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getHeaders24994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getHeaders24994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader24995;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._containsHeader24995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._containsHeader24995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader24996;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getFirstHeader24996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getFirstHeader24996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader24997;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getLastHeader24997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getLastHeader24997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders24998;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._getAllHeaders24998)) as org.apache.http.Header[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._getAllHeaders24998)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader24999;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._addHeader24999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._addHeader24999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader25000;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._addHeader25000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._addHeader25000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader25001;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setHeader25001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setHeader25001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader25002;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setHeader25002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setHeader25002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders25003;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._setHeaders25003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._setHeaders25003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader25004;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._removeHeader25004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._removeHeader25004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders25005;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._removeHeaders25005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._removeHeaders25005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator25006;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._headerIterator25006)) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._headerIterator25006)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator25007;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_._headerIterator25007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpMessage_.staticClass, global::org.apache.http.HttpMessage_._headerIterator25007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpMessage_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpMessage"));
			global::org.apache.http.HttpMessage_._getProtocolVersion24991 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.HttpMessage_._getParams24992 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.HttpMessage_._setParams24993 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.HttpMessage_._getHeaders24994 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._containsHeader24995 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.HttpMessage_._getFirstHeader24996 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._getLastHeader24997 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._getAllHeaders24998 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.HttpMessage_._addHeader24999 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._addHeader25000 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpMessage_._setHeader25001 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.HttpMessage_._setHeader25002 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._setHeaders25003 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._removeHeader25004 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.HttpMessage_._removeHeaders25005 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpMessage_._headerIterator25006 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.HttpMessage_._headerIterator25007 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpMessage_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
