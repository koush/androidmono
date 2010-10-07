namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpEntityEnclosingRequest : HttpRequest
	{
		global::org.apache.http.HttpEntity getEntity();
		void setEntity(org.apache.http.HttpEntity arg0);
		bool expectContinue();
	}

	public partial class HttpEntityEnclosingRequest_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpEntityEnclosingRequest.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpEntityEnclosingRequest : java.lang.Object, HttpEntityEnclosingRequest
	{
		internal static global::java.lang.Class staticClass;
		static __HttpEntityEnclosingRequest()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpEntityEnclosingRequest), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpEntityEnclosingRequest(@__env);
			}
		}
		internal __HttpEntityEnclosingRequest(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntity14240;
		 global::org.apache.http.HttpEntity org.apache.http.HttpEntityEnclosingRequest.getEntity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpEntity>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getEntity14240));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpEntity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getEntity14240));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntity14241;
		 void org.apache.http.HttpEntityEnclosingRequest.setEntity(org.apache.http.HttpEntity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._setEntity14241, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._setEntity14241, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _expectContinue14242;
		 bool org.apache.http.HttpEntityEnclosingRequest.expectContinue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._expectContinue14242);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._expectContinue14242);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRequestLine14243;
		 global::org.apache.http.RequestLine org.apache.http.HttpRequest.getRequestLine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.RequestLine>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getRequestLine14243));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.RequestLine>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getRequestLine14243));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14244;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getProtocolVersion14244));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getProtocolVersion14244));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParams14245;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getParams14245));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getParams14245));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParams14246;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._setParams14246, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._setParams14246, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders14247;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getHeaders14247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getHeaders14247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsHeader14248;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._containsHeader14248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._containsHeader14248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstHeader14249;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getFirstHeader14249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getFirstHeader14249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastHeader14250;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getLastHeader14250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getLastHeader14250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllHeaders14251;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._getAllHeaders14251));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._getAllHeaders14251));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14252;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._addHeader14252, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._addHeader14252, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14253;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._addHeader14253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._addHeader14253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14254;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._setHeader14254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._setHeader14254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14255;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._setHeader14255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._setHeader14255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaders14256;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._setHeaders14256, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._setHeaders14256, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader14257;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._removeHeader14257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._removeHeader14257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaders14258;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest._removeHeaders14258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._removeHeaders14258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14259;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._headerIterator14259));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._headerIterator14259));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14260;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest._headerIterator14260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, global::org.apache.http.__HttpEntityEnclosingRequest._headerIterator14260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpEntityEnclosingRequest.staticClass = @__class;
			global::org.apache.http.__HttpEntityEnclosingRequest._getEntity14240 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpEntityEnclosingRequest.getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.__HttpEntityEnclosingRequest._setEntity14241 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpEntityEnclosingRequest.setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._expectContinue14242 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpEntityEnclosingRequest.expectContinue", "()Z");
			global::org.apache.http.__HttpEntityEnclosingRequest._getRequestLine14243 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpRequest.getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.__HttpEntityEnclosingRequest._getProtocolVersion14244 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.__HttpEntityEnclosingRequest._getParams14245 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.__HttpEntityEnclosingRequest._setParams14246 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._getHeaders14247 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpEntityEnclosingRequest._containsHeader14248 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.__HttpEntityEnclosingRequest._getFirstHeader14249 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpEntityEnclosingRequest._getLastHeader14250 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpEntityEnclosingRequest._getAllHeaders14251 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpEntityEnclosingRequest._addHeader14252 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._addHeader14253 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._setHeader14254 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._setHeader14255 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._setHeaders14256 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._removeHeader14257 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._removeHeaders14258 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.__HttpEntityEnclosingRequest._headerIterator14259 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.__HttpEntityEnclosingRequest._headerIterator14260 = @__env.GetMethodID(global::org.apache.http.__HttpEntityEnclosingRequest.staticClass, "org.apache.http.HttpMessage.headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
