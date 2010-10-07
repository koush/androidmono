namespace org.apache.http.protocol
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpContext 
	{
		global::java.lang.Object getAttribute(java.lang.String arg0);
		global::java.lang.Object removeAttribute(java.lang.String arg0);
		void setAttribute(java.lang.String arg0, java.lang.Object arg1);
	}

	public partial class HttpContext_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpContext.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpContext : java.lang.Object, HttpContext
	{
		internal static global::java.lang.Class staticClass;
		static __HttpContext()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.protocol.__HttpContext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.protocol.__HttpContext(@__env);
			}
		}
		internal __HttpContext(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttribute14553;
		 global::java.lang.Object org.apache.http.protocol.HttpContext.getAttribute(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.protocol.__HttpContext._getAttribute14553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.protocol.__HttpContext.staticClass, global::org.apache.http.protocol.__HttpContext._getAttribute14553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAttribute14554;
		 global::java.lang.Object org.apache.http.protocol.HttpContext.removeAttribute(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.protocol.__HttpContext._removeAttribute14554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.protocol.__HttpContext.staticClass, global::org.apache.http.protocol.__HttpContext._removeAttribute14554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAttribute14555;
		 void org.apache.http.protocol.HttpContext.setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.protocol.__HttpContext._setAttribute14555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.protocol.__HttpContext.staticClass, global::org.apache.http.protocol.__HttpContext._setAttribute14555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.protocol.__HttpContext.staticClass = @__class;
			global::org.apache.http.protocol.__HttpContext._getAttribute14553 = @__env.GetMethodID(global::org.apache.http.protocol.__HttpContext.staticClass, "org.apache.http.protocol.HttpContext.getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.__HttpContext._removeAttribute14554 = @__env.GetMethodID(global::org.apache.http.protocol.__HttpContext.staticClass, "org.apache.http.protocol.HttpContext.removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.__HttpContext._setAttribute14555 = @__env.GetMethodID(global::org.apache.http.protocol.__HttpContext.staticClass, "org.apache.http.protocol.HttpContext.setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
		}
	}
}
