namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HeaderElement 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.NameValuePair[] getParameters();
		global::org.apache.http.NameValuePair getParameter(int arg0);
		int getParameterCount();
		global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0);
	}

	public partial class HeaderElement_
	{
		public static global::java.lang.Class _class
		{
			get { return __HeaderElement.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HeaderElement : java.lang.Object, HeaderElement
	{
		internal static global::java.lang.Class staticClass;
		static __HeaderElement()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HeaderElement), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HeaderElement(@__env);
			}
		}
		internal __HeaderElement(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName14194;
		 global::java.lang.String org.apache.http.HeaderElement.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderElement._getName14194));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderElement.staticClass, global::org.apache.http.__HeaderElement._getName14194));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue14195;
		 global::java.lang.String org.apache.http.HeaderElement.getValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderElement._getValue14195));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderElement.staticClass, global::org.apache.http.__HeaderElement._getValue14195));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameters14196;
		 global::org.apache.http.NameValuePair[] org.apache.http.HeaderElement.getParameters() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderElement._getParameters14196));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderElement.staticClass, global::org.apache.http.__HeaderElement._getParameters14196));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameter14197;
		 global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameter(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.NameValuePair>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderElement._getParameter14197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.NameValuePair>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderElement.staticClass, global::org.apache.http.__HeaderElement._getParameter14197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameterCount14198;
		 int org.apache.http.HeaderElement.getParameterCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__HeaderElement._getParameterCount14198);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__HeaderElement.staticClass, global::org.apache.http.__HeaderElement._getParameterCount14198);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameterByName14199;
		 global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameterByName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.NameValuePair>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HeaderElement._getParameterByName14199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.NameValuePair>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HeaderElement.staticClass, global::org.apache.http.__HeaderElement._getParameterByName14199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HeaderElement.staticClass = @__class;
			global::org.apache.http.__HeaderElement._getName14194 = @__env.GetMethodID(global::org.apache.http.__HeaderElement.staticClass, "org.apache.http.HeaderElement.getName", "()Ljava/lang/String;");
			global::org.apache.http.__HeaderElement._getValue14195 = @__env.GetMethodID(global::org.apache.http.__HeaderElement.staticClass, "org.apache.http.HeaderElement.getValue", "()Ljava/lang/String;");
			global::org.apache.http.__HeaderElement._getParameters14196 = @__env.GetMethodID(global::org.apache.http.__HeaderElement.staticClass, "org.apache.http.HeaderElement.getParameters", "()[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.__HeaderElement._getParameter14197 = @__env.GetMethodID(global::org.apache.http.__HeaderElement.staticClass, "org.apache.http.HeaderElement.getParameter", "(I)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.__HeaderElement._getParameterCount14198 = @__env.GetMethodID(global::org.apache.http.__HeaderElement.staticClass, "org.apache.http.HeaderElement.getParameterCount", "()I");
			global::org.apache.http.__HeaderElement._getParameterByName14199 = @__env.GetMethodID(global::org.apache.http.__HeaderElement.staticClass, "org.apache.http.HeaderElement.getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
		}
	}
}
