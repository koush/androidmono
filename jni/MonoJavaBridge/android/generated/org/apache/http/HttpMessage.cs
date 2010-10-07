namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpMessage 
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

	public partial class HttpMessage_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpMessage.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpMessage : java.lang.Object, HttpMessage
	{
		internal static global::java.lang.Class staticClass;
		static __HttpMessage()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpMessage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpMessage(@__env);
			}
		}
		internal __HttpMessage(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14285;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._getProtocolVersion14285));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._getProtocolVersion14285));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParams14286;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._getParams14286));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._getParams14286));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParams14287;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._setParams14287, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._setParams14287, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders14288;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._getHeaders14288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._getHeaders14288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsHeader14289;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpMessage._containsHeader14289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._containsHeader14289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstHeader14290;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._getFirstHeader14290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._getFirstHeader14290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastHeader14291;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._getLastHeader14291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._getLastHeader14291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllHeaders14292;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._getAllHeaders14292));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._getAllHeaders14292));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14293;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._addHeader14293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._addHeader14293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14294;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._addHeader14294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._addHeader14294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14295;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._setHeader14295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._setHeader14295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14296;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._setHeader14296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._setHeader14296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaders14297;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._setHeaders14297, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._setHeaders14297, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader14298;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._removeHeader14298, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._removeHeader14298, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaders14299;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpMessage._removeHeaders14299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._removeHeaders14299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14300;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._headerIterator14300));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._headerIterator14300));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14301;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpMessage._headerIterator14301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpMessage.staticClass, global::org.apache.http.__HttpMessage._headerIterator14301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpMessage.staticClass = @__class;
			global::org.apache.http.__HttpMessage._getProtocolVersion14285 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.__HttpMessage._getParams14286 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.__HttpMessage._setParams14287 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.__HttpMessage._getHeaders14288 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpMessage._containsHeader14289 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.__HttpMessage._getFirstHeader14290 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpMessage._getLastHeader14291 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpMessage._getAllHeaders14292 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpMessage._addHeader14293 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpMessage._addHeader14294 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpMessage._setHeader14295 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpMessage._setHeader14296 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpMessage._setHeaders14297 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpMessage._removeHeader14298 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpMessage._removeHeaders14299 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.__HttpMessage._headerIterator14300 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.__HttpMessage._headerIterator14301 = @__env.GetMethodID(global::org.apache.http.__HttpMessage.staticClass, "org.apache.http.HttpMessage.headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
