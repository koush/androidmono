namespace org.apache.http.conn.ssl
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface X509HostnameVerifier : javax.net.ssl.HostnameVerifier
	{
		new bool verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1);
		void verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1);
		void verify(java.lang.String arg0, java.security.cert.X509Certificate arg1);
		void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2);
	}

	public partial class X509HostnameVerifier_
	{
		public static global::java.lang.Class _class
		{
			get { return __X509HostnameVerifier.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __X509HostnameVerifier : java.lang.Object, X509HostnameVerifier
	{
		internal static global::java.lang.Class staticClass;
		static __X509HostnameVerifier()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.ssl.__X509HostnameVerifier), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.ssl.__X509HostnameVerifier(@__env);
			}
		}
		internal __X509HostnameVerifier(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _verify14519;
		 bool org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verify14520;
		 void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verify14521;
		 void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, java.security.cert.X509Certificate arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verify14522;
		 void org.apache.http.conn.ssl.X509HostnameVerifier.verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verify14523;
		 bool javax.net.ssl.HostnameVerifier.verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14523, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14523, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass = @__class;
			global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14519 = @__env.GetMethodID(global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, "org.apache.http.conn.ssl.X509HostnameVerifier.verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14520 = @__env.GetMethodID(global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, "org.apache.http.conn.ssl.X509HostnameVerifier.verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V");
			global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14521 = @__env.GetMethodID(global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, "org.apache.http.conn.ssl.X509HostnameVerifier.verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V");
			global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14522 = @__env.GetMethodID(global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, "org.apache.http.conn.ssl.X509HostnameVerifier.verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.__X509HostnameVerifier._verify14523 = @__env.GetMethodID(global::org.apache.http.conn.ssl.__X509HostnameVerifier.staticClass, "javax.net.ssl.HostnameVerifier.verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
		}
	}
}
