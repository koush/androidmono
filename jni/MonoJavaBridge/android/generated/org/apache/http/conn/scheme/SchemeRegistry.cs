namespace org.apache.http.conn.scheme
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class SchemeRegistry : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SchemeRegistry()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.scheme.SchemeRegistry), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.scheme.SchemeRegistry(@__env);
			}
		}
		internal SchemeRegistry(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get14494;
		public global::org.apache.http.conn.scheme.Scheme get(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry._get14494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._get14494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _register14495;
		public global::org.apache.http.conn.scheme.Scheme register(org.apache.http.conn.scheme.Scheme arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry._register14495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._register14495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScheme14496;
		public global::org.apache.http.conn.scheme.Scheme getScheme(org.apache.http.HttpHost arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme14496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme14496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScheme14497;
		public global::org.apache.http.conn.scheme.Scheme getScheme(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme14497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme14497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setItems14498;
		public void setItems(java.util.Map arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.scheme.SchemeRegistry._setItems14498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._setItems14498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregister14499;
		public global::org.apache.http.conn.scheme.Scheme unregister(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry._unregister14499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.Scheme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._unregister14499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeNames14500;
		public global::java.util.List getSchemeNames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames14500));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames14500));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SchemeRegistry14501;
		public SchemeRegistry()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._SchemeRegistry14501, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.scheme.SchemeRegistry.staticClass = @__class;
			global::org.apache.http.conn.scheme.SchemeRegistry._get14494 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "get", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._register14495 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "register", "(Lorg/apache/http/conn/scheme/Scheme;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getScheme14496 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Lorg/apache/http/HttpHost;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getScheme14497 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._setItems14498 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V");
			global::org.apache.http.conn.scheme.SchemeRegistry._unregister14499 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames14500 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;");
			global::org.apache.http.conn.scheme.SchemeRegistry._SchemeRegistry14501 = @__env.GetMethodID(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "<init>", "()V");
		}
	}
}
