namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.CookieStore_))]
	public interface CookieStore  : global::MonoJavaBridge.IJavaObject 
	{
		void clear();
		void addCookie(org.apache.http.cookie.Cookie arg0);
		global::java.util.List getCookies();
		bool clearExpired(java.util.Date arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.CookieStore))]
	public sealed partial class CookieStore_ : java.lang.Object, CookieStore
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieStore_()
		{
			InitJNI();
		}
		internal CookieStore_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear31755;
		 void org.apache.http.client.CookieStore.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_._clear31755);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_.staticClass, global::org.apache.http.client.CookieStore_._clear31755);
		}
		internal static global::MonoJavaBridge.MethodId _addCookie31756;
		 void org.apache.http.client.CookieStore.addCookie(org.apache.http.cookie.Cookie arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_._addCookie31756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_.staticClass, global::org.apache.http.client.CookieStore_._addCookie31756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookies31757;
		 global::java.util.List org.apache.http.client.CookieStore.getCookies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_._getCookies31757)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_.staticClass, global::org.apache.http.client.CookieStore_._getCookies31757)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _clearExpired31758;
		 bool org.apache.http.client.CookieStore.clearExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_._clearExpired31758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.client.CookieStore_.staticClass, global::org.apache.http.client.CookieStore_._clearExpired31758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.CookieStore_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/CookieStore"));
			global::org.apache.http.client.CookieStore_._clear31755 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CookieStore_.staticClass, "clear", "()V");
			global::org.apache.http.client.CookieStore_._addCookie31756 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CookieStore_.staticClass, "addCookie", "(Lorg/apache/http/cookie/Cookie;)V");
			global::org.apache.http.client.CookieStore_._getCookies31757 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CookieStore_.staticClass, "getCookies", "()Ljava/util/List;");
			global::org.apache.http.client.CookieStore_._clearExpired31758 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CookieStore_.staticClass, "clearExpired", "(Ljava/util/Date;)Z");
		}
	}
}
