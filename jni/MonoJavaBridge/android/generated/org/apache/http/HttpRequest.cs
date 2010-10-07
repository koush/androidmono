namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpRequest : HttpMessage
	{
		global::org.apache.http.RequestLine getRequestLine();
	}

	public partial class HttpRequest_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpRequest.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpRequest : java.lang.Object, HttpRequest
	{
		internal static global::java.lang.Class staticClass;
		static __HttpRequest()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpRequest), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpRequest(@__env);
			}
		}
		internal __HttpRequest(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRequestLine14302;
		 global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.RequestLine>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getRequestLine14302));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.RequestLine>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getRequestLine14302));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14303;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getProtocolVersion14303));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getProtocolVersion14303));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParams14304;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getParams14304));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getParams14304));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParams14305;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._setParams14305, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._setParams14305, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders14306;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getHeaders14306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getHeaders14306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsHeader14307;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpRequest._containsHeader14307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._containsHeader14307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstHeader14308;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getFirstHeader14308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getFirstHeader14308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastHeader14309;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getLastHeader14309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getLastHeader14309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllHeaders14310;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._getAllHeaders14310));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._getAllHeaders14310));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14311;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._addHeader14311, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._addHeader14311, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14312;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._addHeader14312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._addHeader14312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14313;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._setHeader14313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._setHeader14313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14314;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._setHeader14314, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._setHeader14314, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaders14315;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._setHeaders14315, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._setHeaders14315, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader14316;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._removeHeader14316, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._removeHeader14316, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaders14317;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpRequest._removeHeaders14317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._removeHeaders14317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14318;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._headerIterator14318));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._headerIterator14318));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14319;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpRequest._headerIterator14319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpRequest.staticClass, global::org.apache.http.__HttpRequest._headerIterator14319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpRequest.staticClass = @__class;
			global::org.apache.http.__HttpRequest._getRequestLine14302 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpRequest.getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.__HttpRequest._getProtocolVersion14303 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.__HttpRequest._getParams14304 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.__HttpRequest._setParams14305 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.__HttpRequest._getHeaders14306 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpRequest._containsHeader14307 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.__HttpRequest._getFirstHeader14308 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpRequest._getLastHeader14309 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpRequest._getAllHeaders14310 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpRequest._addHeader14311 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpRequest._addHeader14312 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpRequest._setHeader14313 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpRequest._setHeader14314 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpRequest._setHeaders14315 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpRequest._removeHeader14316 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpRequest._removeHeaders14317 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.__HttpRequest._headerIterator14318 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.__HttpRequest._headerIterator14319 = @__env.GetMethodID(global::org.apache.http.__HttpRequest.staticClass, "org.apache.http.HttpMessage.headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
