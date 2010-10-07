namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpResponse : HttpMessage
	{
		void setLocale(java.util.Locale arg0);
		global::java.util.Locale getLocale();
		global::org.apache.http.StatusLine getStatusLine();
		void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1);
		void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2);
		void setStatusLine(org.apache.http.StatusLine arg0);
		void setStatusCode(int arg0);
		void setReasonPhrase(java.lang.String arg0);
		global::org.apache.http.HttpEntity getEntity();
		void setEntity(org.apache.http.HttpEntity arg0);
	}

	public partial class HttpResponse_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpResponse.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpResponse : java.lang.Object, HttpResponse
	{
		internal static global::java.lang.Class staticClass;
		static __HttpResponse()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpResponse), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpResponse(@__env);
			}
		}
		internal __HttpResponse(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLocale14320;
		 void org.apache.http.HttpResponse.setLocale(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setLocale14320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setLocale14320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocale14321;
		 global::java.util.Locale org.apache.http.HttpResponse.getLocale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getLocale14321));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getLocale14321));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatusLine14322;
		 global::org.apache.http.StatusLine org.apache.http.HttpResponse.getStatusLine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.StatusLine>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getStatusLine14322));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.StatusLine>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getStatusLine14322));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStatusLine14323;
		 void org.apache.http.HttpResponse.setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setStatusLine14323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setStatusLine14323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStatusLine14324;
		 void org.apache.http.HttpResponse.setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setStatusLine14324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setStatusLine14324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStatusLine14325;
		 void org.apache.http.HttpResponse.setStatusLine(org.apache.http.StatusLine arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setStatusLine14325, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setStatusLine14325, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStatusCode14326;
		 void org.apache.http.HttpResponse.setStatusCode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setStatusCode14326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setStatusCode14326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setReasonPhrase14327;
		 void org.apache.http.HttpResponse.setReasonPhrase(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setReasonPhrase14327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setReasonPhrase14327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEntity14328;
		 global::org.apache.http.HttpEntity org.apache.http.HttpResponse.getEntity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpEntity>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getEntity14328));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpEntity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getEntity14328));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEntity14329;
		 void org.apache.http.HttpResponse.setEntity(org.apache.http.HttpEntity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setEntity14329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setEntity14329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14330;
		 global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getProtocolVersion14330));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getProtocolVersion14330));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParams14331;
		 global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getParams14331));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getParams14331));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParams14332;
		 void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setParams14332, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setParams14332, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders14333;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getHeaders14333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getHeaders14333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsHeader14334;
		 bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpResponse._containsHeader14334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._containsHeader14334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstHeader14335;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getFirstHeader14335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getFirstHeader14335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastHeader14336;
		 global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getLastHeader14336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.Header>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getLastHeader14336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllHeaders14337;
		 global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._getAllHeaders14337));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._getAllHeaders14337));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14338;
		 void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._addHeader14338, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._addHeader14338, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHeader14339;
		 void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._addHeader14339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._addHeader14339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14340;
		 void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setHeader14340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setHeader14340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeader14341;
		 void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setHeader14341, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setHeader14341, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeaders14342;
		 void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._setHeaders14342, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._setHeaders14342, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<org.apache.http.Header[], org.apache.http.Header>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeader14343;
		 void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._removeHeader14343, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._removeHeader14343, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeHeaders14344;
		 void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpResponse._removeHeaders14344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._removeHeaders14344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14345;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._headerIterator14345));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._headerIterator14345));
		}
		internal static global::net.sf.jni4net.jni.MethodId _headerIterator14346;
		 global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpResponse._headerIterator14346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HeaderIterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpResponse.staticClass, global::org.apache.http.__HttpResponse._headerIterator14346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpResponse.staticClass = @__class;
			global::org.apache.http.__HttpResponse._setLocale14320 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setLocale", "(Ljava/util/Locale;)V");
			global::org.apache.http.__HttpResponse._getLocale14321 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.getLocale", "()Ljava/util/Locale;");
			global::org.apache.http.__HttpResponse._getStatusLine14322 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.getStatusLine", "()Lorg/apache/http/StatusLine;");
			global::org.apache.http.__HttpResponse._setStatusLine14323 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V");
			global::org.apache.http.__HttpResponse._setStatusLine14324 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::org.apache.http.__HttpResponse._setStatusLine14325 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setStatusLine", "(Lorg/apache/http/StatusLine;)V");
			global::org.apache.http.__HttpResponse._setStatusCode14326 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setStatusCode", "(I)V");
			global::org.apache.http.__HttpResponse._setReasonPhrase14327 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setReasonPhrase", "(Ljava/lang/String;)V");
			global::org.apache.http.__HttpResponse._getEntity14328 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.__HttpResponse._setEntity14329 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpResponse.setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.__HttpResponse._getProtocolVersion14330 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.__HttpResponse._getParams14331 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.__HttpResponse._setParams14332 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.setParams", "(Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.__HttpResponse._getHeaders14333 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpResponse._containsHeader14334 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.containsHeader", "(Ljava/lang/String;)Z");
			global::org.apache.http.__HttpResponse._getFirstHeader14335 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpResponse._getLastHeader14336 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			global::org.apache.http.__HttpResponse._getAllHeaders14337 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.getAllHeaders", "()[Lorg/apache/http/Header;");
			global::org.apache.http.__HttpResponse._addHeader14338 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.addHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpResponse._addHeader14339 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpResponse._setHeader14340 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.__HttpResponse._setHeader14341 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.setHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpResponse._setHeaders14342 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.setHeaders", "([Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpResponse._removeHeader14343 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.removeHeader", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.__HttpResponse._removeHeaders14344 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.removeHeaders", "(Ljava/lang/String;)V");
			global::org.apache.http.__HttpResponse._headerIterator14345 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.headerIterator", "()Lorg/apache/http/HeaderIterator;");
			global::org.apache.http.__HttpResponse._headerIterator14346 = @__env.GetMethodID(global::org.apache.http.__HttpResponse.staticClass, "org.apache.http.HttpMessage.headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
		}
	}
}
