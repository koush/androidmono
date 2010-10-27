namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpResponseFactory : java.lang.Object, HttpResponseFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultHttpResponseFactory()
		{
			InitJNI();
		}
		protected DefaultHttpResponseFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newHttpResponse32641;
		public virtual global::org.apache.http.HttpResponse newHttpResponse(org.apache.http.ProtocolVersion arg0, int arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpResponseFactory._newHttpResponse32641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._newHttpResponse32641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _newHttpResponse32642;
		public virtual global::org.apache.http.HttpResponse newHttpResponse(org.apache.http.StatusLine arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpResponseFactory._newHttpResponse32642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._newHttpResponse32642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _determineLocale32643;
		protected virtual global::java.util.Locale determineLocale(org.apache.http.protocol.HttpContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpResponseFactory._determineLocale32643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._determineLocale32643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpResponseFactory32644;
		public DefaultHttpResponseFactory(org.apache.http.ReasonPhraseCatalog arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._DefaultHttpResponseFactory32644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpResponseFactory32645;
		public DefaultHttpResponseFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._DefaultHttpResponseFactory32645);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpResponseFactory"));
			global::org.apache.http.impl.DefaultHttpResponseFactory._newHttpResponse32641 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.DefaultHttpResponseFactory._newHttpResponse32642 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.DefaultHttpResponseFactory._determineLocale32643 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "determineLocale", "(Lorg/apache/http/protocol/HttpContext;)Ljava/util/Locale;");
			global::org.apache.http.impl.DefaultHttpResponseFactory._DefaultHttpResponseFactory32644 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "<init>", "(Lorg/apache/http/ReasonPhraseCatalog;)V");
			global::org.apache.http.impl.DefaultHttpResponseFactory._DefaultHttpResponseFactory32645 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "<init>", "()V");
		}
	}
}
