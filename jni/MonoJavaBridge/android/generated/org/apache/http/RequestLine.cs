namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface RequestLine 
	{
		global::java.lang.String getMethod();
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		global::java.lang.String getUri();
	}

	public partial class RequestLine_
	{
		public static global::java.lang.Class _class
		{
			get { return __RequestLine.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __RequestLine : java.lang.Object, RequestLine
	{
		internal static global::java.lang.Class staticClass;
		static __RequestLine()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__RequestLine), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__RequestLine(@__env);
			}
		}
		internal __RequestLine(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMethod14362;
		 global::java.lang.String org.apache.http.RequestLine.getMethod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__RequestLine._getMethod14362));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__RequestLine.staticClass, global::org.apache.http.__RequestLine._getMethod14362));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14363;
		 global::org.apache.http.ProtocolVersion org.apache.http.RequestLine.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__RequestLine._getProtocolVersion14363));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__RequestLine.staticClass, global::org.apache.http.__RequestLine._getProtocolVersion14363));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUri14364;
		 global::java.lang.String org.apache.http.RequestLine.getUri() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__RequestLine._getUri14364));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__RequestLine.staticClass, global::org.apache.http.__RequestLine._getUri14364));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__RequestLine.staticClass = @__class;
			global::org.apache.http.__RequestLine._getMethod14362 = @__env.GetMethodID(global::org.apache.http.__RequestLine.staticClass, "org.apache.http.RequestLine.getMethod", "()Ljava/lang/String;");
			global::org.apache.http.__RequestLine._getProtocolVersion14363 = @__env.GetMethodID(global::org.apache.http.__RequestLine.staticClass, "org.apache.http.RequestLine.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.__RequestLine._getUri14364 = @__env.GetMethodID(global::org.apache.http.__RequestLine.staticClass, "org.apache.http.RequestLine.getUri", "()Ljava/lang/String;");
		}
	}
}
