namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class HttpHost : java.lang.Object, java.lang.Cloneable
	{
		internal static global::java.lang.Class staticClass;
		static HttpHost()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.HttpHost), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.HttpHost(@__env);
			}
		}
		internal HttpHost(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals14261;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.HttpHost._equals14261, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._equals14261, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString14262;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.HttpHost._toString14262));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toString14262));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode14263;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.HttpHost._hashCode14263);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._hashCode14263);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone14264;
		public global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.HttpHost._clone14264));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._clone14264));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toURI14265;
		public global::java.lang.String toURI() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.HttpHost._toURI14265));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toURI14265));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPort14266;
		public int getPort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.HttpHost._getPort14266);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getPort14266);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHostName14267;
		public global::java.lang.String getHostName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.HttpHost._getHostName14267));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getHostName14267));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeName14268;
		public global::java.lang.String getSchemeName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.HttpHost._getSchemeName14268));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getSchemeName14268));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toHostString14269;
		public global::java.lang.String toHostString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.HttpHost._toHostString14269));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toHostString14269));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpHost14270;
		public HttpHost(org.apache.http.HttpHost arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost14270, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpHost14271;
		public HttpHost(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost14271, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpHost14272;
		public HttpHost(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost14272, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HttpHost14273;
		public HttpHost(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost14273, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		public static global::java.lang.String DEFAULT_SCHEME_NAME
		{
			get
			{
				return "http";
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.HttpHost.staticClass = @__class;
			global::org.apache.http.HttpHost._equals14261 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.HttpHost._toString14262 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._hashCode14263 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "hashCode", "()I");
			global::org.apache.http.HttpHost._clone14264 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.HttpHost._toURI14265 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "toURI", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._getPort14266 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "getPort", "()I");
			global::org.apache.http.HttpHost._getHostName14267 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "getHostName", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._getSchemeName14268 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._toHostString14269 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "toHostString", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._HttpHost14270 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.HttpHost._HttpHost14271 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::org.apache.http.HttpHost._HttpHost14272 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpHost._HttpHost14273 = @__env.GetMethodID(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
		}
	}
}
