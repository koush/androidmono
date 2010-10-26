namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieOrigin : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieOrigin()
		{
			InitJNI();
		}
		internal CookieOrigin(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32409;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._toString32409)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._toString32409)) as java.lang.String;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath32410;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._getPath32410)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._getPath32410)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort32411;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._getPort32411);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._getPort32411);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost32412;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._getHost32412)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._getHost32412)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32413;
		public bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._isSecure32413);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._isSecure32413);
		}
		internal static global::MonoJavaBridge.MethodId _CookieOrigin32414;
		public CookieOrigin(java.lang.String arg0, int arg1, java.lang.String arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._CookieOrigin32414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieOrigin.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieOrigin"));
			global::org.apache.http.cookie.CookieOrigin._toString32409 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.cookie.CookieOrigin._getPath32410 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.CookieOrigin._getPort32411 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "getPort", "()I");
			global::org.apache.http.cookie.CookieOrigin._getHost32412 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "getHost", "()Ljava/lang/String;");
			global::org.apache.http.cookie.CookieOrigin._isSecure32413 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.CookieOrigin._CookieOrigin32414 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V");
		}
	}
}
