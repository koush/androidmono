namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CookieHandler_))]
	public abstract partial class CookieHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieHandler()
		{
			InitJNI();
		}
		protected CookieHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21366;
		public abstract global::java.util.Map get(java.net.URI arg0, java.util.Map arg1);
		internal static global::MonoJavaBridge.MethodId _put21367;
		public abstract void put(java.net.URI arg0, java.util.Map arg1);
		internal static global::MonoJavaBridge.MethodId _getDefault21368;
		public static global::java.net.CookieHandler getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.CookieHandler.staticClass, global::java.net.CookieHandler._getDefault21368)) as java.net.CookieHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault21369;
		public static void setDefault(java.net.CookieHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.CookieHandler.staticClass, global::java.net.CookieHandler._setDefault21369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CookieHandler21370;
		public CookieHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CookieHandler.staticClass, global::java.net.CookieHandler._CookieHandler21370);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CookieHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CookieHandler"));
			global::java.net.CookieHandler._get21366 = @__env.GetMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;");
			global::java.net.CookieHandler._put21367 = @__env.GetMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "put", "(Ljava/net/URI;Ljava/util/Map;)V");
			global::java.net.CookieHandler._getDefault21368 = @__env.GetStaticMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "getDefault", "()Ljava/net/CookieHandler;");
			global::java.net.CookieHandler._setDefault21369 = @__env.GetStaticMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "setDefault", "(Ljava/net/CookieHandler;)V");
			global::java.net.CookieHandler._CookieHandler21370 = @__env.GetMethodIDNoThrow(global::java.net.CookieHandler.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CookieHandler))]
	internal sealed partial class CookieHandler_ : java.net.CookieHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieHandler_()
		{
			InitJNI();
		}
		internal CookieHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21371;
		public override global::java.util.Map get(java.net.URI arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.CookieHandler_._get21371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.CookieHandler_.staticClass, global::java.net.CookieHandler_._get21371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _put21372;
		public override void put(java.net.URI arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.CookieHandler_._put21372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.CookieHandler_.staticClass, global::java.net.CookieHandler_._put21372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CookieHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CookieHandler"));
			global::java.net.CookieHandler_._get21371 = @__env.GetMethodIDNoThrow(global::java.net.CookieHandler_.staticClass, "get", "(Ljava/net/URI;Ljava/util/Map;)Ljava/util/Map;");
			global::java.net.CookieHandler_._put21372 = @__env.GetMethodIDNoThrow(global::java.net.CookieHandler_.staticClass, "put", "(Ljava/net/URI;Ljava/util/Map;)V");
		}
	}
}
