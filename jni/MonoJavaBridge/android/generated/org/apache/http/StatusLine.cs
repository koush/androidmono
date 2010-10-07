namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface StatusLine 
	{
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		int getStatusCode();
		global::java.lang.String getReasonPhrase();
	}

	public partial class StatusLine_
	{
		public static global::java.lang.Class _class
		{
			get { return __StatusLine.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __StatusLine : java.lang.Object, StatusLine
	{
		internal static global::java.lang.Class staticClass;
		static __StatusLine()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__StatusLine), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__StatusLine(@__env);
			}
		}
		internal __StatusLine(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolVersion14365;
		 global::org.apache.http.ProtocolVersion org.apache.http.StatusLine.getProtocolVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__StatusLine._getProtocolVersion14365));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__StatusLine.staticClass, global::org.apache.http.__StatusLine._getProtocolVersion14365));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatusCode14366;
		 int org.apache.http.StatusLine.getStatusCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__StatusLine._getStatusCode14366);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__StatusLine.staticClass, global::org.apache.http.__StatusLine._getStatusCode14366);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getReasonPhrase14367;
		 global::java.lang.String org.apache.http.StatusLine.getReasonPhrase() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__StatusLine._getReasonPhrase14367));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__StatusLine.staticClass, global::org.apache.http.__StatusLine._getReasonPhrase14367));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__StatusLine.staticClass = @__class;
			global::org.apache.http.__StatusLine._getProtocolVersion14365 = @__env.GetMethodID(global::org.apache.http.__StatusLine.staticClass, "org.apache.http.StatusLine.getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.__StatusLine._getStatusCode14366 = @__env.GetMethodID(global::org.apache.http.__StatusLine.staticClass, "org.apache.http.StatusLine.getStatusCode", "()I");
			global::org.apache.http.__StatusLine._getReasonPhrase14367 = @__env.GetMethodID(global::org.apache.http.__StatusLine.staticClass, "org.apache.http.StatusLine.getReasonPhrase", "()Ljava/lang/String;");
		}
	}
}
