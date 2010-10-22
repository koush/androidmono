namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCookieStore : java.lang.Object, org.apache.http.client.CookieStore
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicCookieStore()
		{
			InitJNI();
		}
		protected BasicCookieStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32737;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore._toString32737)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._toString32737)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear32738;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore._clear32738);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._clear32738);
		}
		internal static global::MonoJavaBridge.MethodId _addCookie32739;
		public virtual void addCookie(org.apache.http.cookie.Cookie arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore._addCookie32739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._addCookie32739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Cookies
		{
			get
			{
				return getCookies();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCookies32740;
		public virtual global::java.util.List getCookies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore._getCookies32740)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._getCookies32740)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _clearExpired32741;
		public virtual bool clearExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore._clearExpired32741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._clearExpired32741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCookies32742;
		public virtual void addCookies(org.apache.http.cookie.Cookie[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore._addCookies32742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._addCookies32742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicCookieStore32743;
		public BasicCookieStore()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._BasicCookieStore32743);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicCookieStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicCookieStore"));
			global::org.apache.http.impl.client.BasicCookieStore._toString32737 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.client.BasicCookieStore._clear32738 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "clear", "()V");
			global::org.apache.http.impl.client.BasicCookieStore._addCookie32739 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "addCookie", "(Lorg/apache/http/cookie/Cookie;)V");
			global::org.apache.http.impl.client.BasicCookieStore._getCookies32740 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "getCookies", "()Ljava/util/List;");
			global::org.apache.http.impl.client.BasicCookieStore._clearExpired32741 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "clearExpired", "(Ljava/util/Date;)Z");
			global::org.apache.http.impl.client.BasicCookieStore._addCookies32742 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "addCookies", "([Lorg/apache/http/cookie/Cookie;)V");
			global::org.apache.http.impl.client.BasicCookieStore._BasicCookieStore32743 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "<init>", "()V");
		}
	}
}
