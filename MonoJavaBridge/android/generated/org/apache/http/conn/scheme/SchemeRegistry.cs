namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SchemeRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SchemeRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get32311;
		public global::org.apache.http.conn.scheme.Scheme get(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._get32311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._get32311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _register32312;
		public global::org.apache.http.conn.scheme.Scheme register(org.apache.http.conn.scheme.Scheme arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._register32312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._register32312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme32313;
		public global::org.apache.http.conn.scheme.Scheme getScheme(org.apache.http.HttpHost arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme32313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme32313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme32314;
		public global::org.apache.http.conn.scheme.Scheme getScheme(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme32314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme32314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		public new global::java.util.Map Items
		{
			set
			{
				setItems(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setItems32315;
		public void setItems(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._setItems32315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._setItems32315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregister32316;
		public global::org.apache.http.conn.scheme.Scheme unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._unregister32316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.Scheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._unregister32316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		public new global::java.util.List SchemeNames
		{
			get
			{
				return getSchemeNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeNames32317;
		public global::java.util.List getSchemeNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames32317)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames32317)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _SchemeRegistry32318;
		public SchemeRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._SchemeRegistry32318);
			Init(@__env, handle);
		}
		static SchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.SchemeRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/SchemeRegistry"));
			global::org.apache.http.conn.scheme.SchemeRegistry._get32311 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "get", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._register32312 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "register", "(Lorg/apache/http/conn/scheme/Scheme;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getScheme32313 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Lorg/apache/http/HttpHost;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getScheme32314 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._setItems32315 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V");
			global::org.apache.http.conn.scheme.SchemeRegistry._unregister32316 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames32317 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;");
			global::org.apache.http.conn.scheme.SchemeRegistry._SchemeRegistry32318 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}