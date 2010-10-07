namespace org.apache.http.client.methods
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpUriRequest : HttpRequest
	{
		global::java.lang.String getMethod();
		global::java.net.URI getURI();
		void abort();
		bool isAborted();
	}

	public partial class HttpUriRequest_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpUriRequest.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpUriRequest : java.lang.Object, HttpUriRequest
	{
		internal static global::java.lang.Class staticClass;
		static __HttpUriRequest()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.client.methods.__HttpUriRequest), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.client.methods.__HttpUriRequest(@__env);
			}
		}
		internal __HttpUriRequest(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMethod14379;
		 global::java.lang.String org.apache.http.client.methods.HttpUriRequest.getMethod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getMethod14379));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getMethod14379));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getURI14380;
		 global::java.net.URI org.apache.http.client.methods.HttpUriRequest.getURI() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getURI14380));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URI>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getURI14380));
		}
		internal static global::net.sf.jni4net.jni.MethodId _abort14381;
		 void org.apache.http.client.methods.HttpUriRequest.abort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._abort14381);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._abort14381);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAborted14382;
		 bool org.apache.http.client.methods.HttpUriRequest.isAborted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._isAborted14382);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._isAborted14382);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRequestLine14383;
		 global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.RequestLine>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getRequestLine14383));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.RequestLine>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getRequestLine14383));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14384;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getProtocolVersion14384));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getProtocolVersion14384));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParams14385;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getParams14385));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getParams14385));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParams14386;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._setParams14386, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._setParams14386, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders14387;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getHeaders14387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getHeaders14387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsHeader14388;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._containsHeader14388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._containsHeader14388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstHeader14389;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getFirstHeader14389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getFirstHeader14389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastHeader14390;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getLastHeader14390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getLastHeader14390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllHeaders14391;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._getAllHeaders14391));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._getAllHeaders14391));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14392;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._addHeader14392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._addHeader14392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14393;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._addHeader14393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._addHeader14393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14394;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._setHeader14394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._setHeader14394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14395;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._setHeader14395, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._setHeader14395, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaders14396;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._setHeaders14396, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._setHeaders14396, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader14397;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._removeHeader14397, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._removeHeader14397, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaders14398;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest._removeHeaders14398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._removeHeaders14398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14399;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._headerIterator14399));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._headerIterator14399));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14400;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest._headerIterator14400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.methods.__HttpUriRequest.staticClass, global::org.apache.http.client.methods.__HttpUriRequest._headerIterator14400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.client.methods.__HttpUriRequest.staticClass = @__class;
			global::org.apache.http.client.methods.__HttpUriRequest._getMethod14379 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.client.methods.HttpUriRequest.getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.__HttpUriRequest._getURI14380 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.client.methods.HttpUriRequest.getURI", "()Ljava/net/URI;");
			global::org.apache.http.client.methods.__HttpUriRequest._abort14381 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.client.methods.HttpUriRequest.abort", "()V");
			global::org.apache.http.client.methods.__HttpUriRequest._isAborted14382 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.client.methods.HttpUriRequest.isAborted", "()Z");
			global::org.apache.http.client.methods.__HttpUriRequest._getRequestLine14383 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpRequest.getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.client.methods.__HttpUriRequest._getProtocolVersion14384 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.client.methods.__HttpUriRequest._getParams14385 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.client.methods.__HttpUriRequest._setParams14386 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._getHeaders14387 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.__HttpUriRequest._containsHeader14388 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.client.methods.__HttpUriRequest._getFirstHeader14389 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.__HttpUriRequest._getLastHeader14390 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.__HttpUriRequest._getAllHeaders14391 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.client.methods.__HttpUriRequest._addHeader14392 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._addHeader14393 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._setHeader14394 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._setHeader14395 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._setHeaders14396 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._removeHeader14397 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._removeHeaders14398 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.client.methods.__HttpUriRequest._headerIterator14399 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.client.methods.__HttpUriRequest._headerIterator14400 = @__env.GetMethodID(global::org.apache.http.client.methods.__HttpUriRequest.staticClass, "org.apache.http.HttpMessage.headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
