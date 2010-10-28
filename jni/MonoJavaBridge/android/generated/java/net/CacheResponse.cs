namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CacheResponse_))]
	public abstract partial class CacheResponse : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CacheResponse()
		{
			InitJNI();
		}
		protected CacheResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders21354;
		public abstract global::java.util.Map getHeaders();
		internal static global::MonoJavaBridge.MethodId _getBody21355;
		public abstract global::java.io.InputStream getBody();
		internal static global::MonoJavaBridge.MethodId _CacheResponse21356;
		public CacheResponse() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CacheResponse.staticClass, global::java.net.CacheResponse._CacheResponse21356);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheResponse"));
			global::java.net.CacheResponse._getHeaders21354 = @__env.GetMethodIDNoThrow(global::java.net.CacheResponse.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::java.net.CacheResponse._getBody21355 = @__env.GetMethodIDNoThrow(global::java.net.CacheResponse.staticClass, "getBody", "()Ljava/io/InputStream;");
			global::java.net.CacheResponse._CacheResponse21356 = @__env.GetMethodIDNoThrow(global::java.net.CacheResponse.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CacheResponse))]
	internal sealed partial class CacheResponse_ : java.net.CacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CacheResponse_()
		{
			InitJNI();
		}
		internal CacheResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders21357;
		public override global::java.util.Map getHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.CacheResponse_._getHeaders21357)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.CacheResponse_.staticClass, global::java.net.CacheResponse_._getHeaders21357)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getBody21358;
		public override global::java.io.InputStream getBody()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.CacheResponse_._getBody21358)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.CacheResponse_.staticClass, global::java.net.CacheResponse_._getBody21358)) as java.io.InputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheResponse"));
			global::java.net.CacheResponse_._getHeaders21357 = @__env.GetMethodIDNoThrow(global::java.net.CacheResponse_.staticClass, "getHeaders", "()Ljava/util/Map;");
			global::java.net.CacheResponse_._getBody21358 = @__env.GetMethodIDNoThrow(global::java.net.CacheResponse_.staticClass, "getBody", "()Ljava/io/InputStream;");
		}
	}
}
