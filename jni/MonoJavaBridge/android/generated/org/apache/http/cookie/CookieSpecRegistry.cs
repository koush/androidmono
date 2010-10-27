namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieSpecRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieSpecRegistry()
		{
			InitJNI();
		}
		internal CookieSpecRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register32425;
		public void register(java.lang.String arg0, org.apache.http.cookie.CookieSpecFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry._register32425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._register32425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.util.Map Items
		{
			set
			{
				setItems(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setItems32426;
		public void setItems(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry._setItems32426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._setItems32426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregister32427;
		public void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry._unregister32427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._unregister32427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookieSpec32428;
		public global::org.apache.http.cookie.CookieSpec getCookieSpec(java.lang.String arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry._getCookieSpec32428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.cookie.CookieSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._getCookieSpec32428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.cookie.CookieSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getCookieSpec32429;
		public global::org.apache.http.cookie.CookieSpec getCookieSpec(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry._getCookieSpec32429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._getCookieSpec32429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
		}
		public new global::java.util.List SpecNames
		{
			get
			{
				return getSpecNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpecNames32430;
		public global::java.util.List getSpecNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry._getSpecNames32430)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._getSpecNames32430)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _CookieSpecRegistry32431;
		public CookieSpecRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookieSpecRegistry.staticClass, global::org.apache.http.cookie.CookieSpecRegistry._CookieSpecRegistry32431);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpecRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpecRegistry"));
			global::org.apache.http.cookie.CookieSpecRegistry._register32425 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieSpecFactory;)V");
			global::org.apache.http.cookie.CookieSpecRegistry._setItems32426 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "setItems", "(Ljava/util/Map;)V");
			global::org.apache.http.cookie.CookieSpecRegistry._unregister32427 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "unregister", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.CookieSpecRegistry._getCookieSpec32428 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "getCookieSpec", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;");
			global::org.apache.http.cookie.CookieSpecRegistry._getCookieSpec32429 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "getCookieSpec", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieSpec;");
			global::org.apache.http.cookie.CookieSpecRegistry._getSpecNames32430 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "getSpecNames", "()Ljava/util/List;");
			global::org.apache.http.cookie.CookieSpecRegistry._CookieSpecRegistry32431 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecRegistry.staticClass, "<init>", "()V");
		}
	}
}
