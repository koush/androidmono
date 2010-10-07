namespace org.apache.http.client
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ResponseHandler 
	{
		global::java.lang.Object handleResponse(org.apache.http.HttpResponse arg0);
	}

	public partial class ResponseHandler_
	{
		public static global::java.lang.Class _class
		{
			get { return __ResponseHandler.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ResponseHandler : java.lang.Object, ResponseHandler
	{
		internal static global::java.lang.Class staticClass;
		static __ResponseHandler()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.client.__ResponseHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.client.__ResponseHandler(@__env);
			}
		}
		internal __ResponseHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleResponse14378;
		 global::java.lang.Object org.apache.http.client.ResponseHandler.handleResponse(org.apache.http.HttpResponse arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__ResponseHandler._handleResponse14378, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__ResponseHandler.staticClass, global::org.apache.http.client.__ResponseHandler._handleResponse14378, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.client.__ResponseHandler.staticClass = @__class;
			global::org.apache.http.client.__ResponseHandler._handleResponse14378 = @__env.GetMethodID(global::org.apache.http.client.__ResponseHandler.staticClass, "org.apache.http.client.ResponseHandler.handleResponse", "(Lorg/apache/http/HttpResponse;)Ljava/lang/Object;");
		}
	}
}
