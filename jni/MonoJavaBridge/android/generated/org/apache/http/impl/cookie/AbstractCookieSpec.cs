namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.cookie.AbstractCookieSpec_))]
	public abstract partial class AbstractCookieSpec : java.lang.Object, org.apache.http.cookie.CookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCookieSpec()
		{
			InitJNI();
		}
		protected AbstractCookieSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse26457;
		public abstract global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1);
		internal static global::MonoJavaBridge.MethodId _match26458;
		public abstract bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		internal static global::MonoJavaBridge.MethodId _getVersion26459;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _validate26460;
		public abstract void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		internal static global::MonoJavaBridge.MethodId _formatCookies26461;
		public abstract global::java.util.List formatCookies(java.util.List arg0);
		internal static global::MonoJavaBridge.MethodId _getVersionHeader26462;
		public abstract global::org.apache.http.Header getVersionHeader();
		internal static global::MonoJavaBridge.MethodId _registerAttribHandler26463;
		public virtual void registerAttribHandler(java.lang.String arg0, org.apache.http.cookie.CookieAttributeHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec._registerAttribHandler26463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._registerAttribHandler26463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _findAttribHandler26464;
		protected virtual global::org.apache.http.cookie.CookieAttributeHandler findAttribHandler(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieAttributeHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec._findAttribHandler26464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieAttributeHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieAttributeHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._findAttribHandler26464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieAttributeHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribHandler26465;
		protected virtual global::org.apache.http.cookie.CookieAttributeHandler getAttribHandler(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieAttributeHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandler26465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieAttributeHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieAttributeHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandler26465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieAttributeHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribHandlers26466;
		protected virtual global::java.util.Collection getAttribHandlers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandlers26466)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandlers26466)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCookieSpec26467;
		public AbstractCookieSpec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._AbstractCookieSpec26467);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieSpec"));
			global::org.apache.http.impl.cookie.AbstractCookieSpec._parse26457 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._match26458 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._getVersion26459 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._validate26460 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._formatCookies26461 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._getVersionHeader26462 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._registerAttribHandler26463 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "registerAttribHandler", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieAttributeHandler;)V");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._findAttribHandler26464 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "findAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandler26465 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "getAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandlers26466 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "getAttribHandlers", "()Ljava/util/Collection;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec._AbstractCookieSpec26467 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.cookie.AbstractCookieSpec))]
	public sealed partial class AbstractCookieSpec_ : org.apache.http.impl.cookie.AbstractCookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCookieSpec_()
		{
			InitJNI();
		}
		internal AbstractCookieSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse26468;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._parse26468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec_._parse26468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match26469;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._match26469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec_._match26469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion26470;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersion26470);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersion26470);
		}
		internal static global::MonoJavaBridge.MethodId _validate26471;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._validate26471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec_._validate26471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies26472;
		public override global::java.util.List formatCookies(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._formatCookies26472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec_._formatCookies26472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader26473;
		public override global::org.apache.http.Header getVersionHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersionHeader26473)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersionHeader26473)) as org.apache.http.Header;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieSpec"));
			global::org.apache.http.impl.cookie.AbstractCookieSpec_._parse26468 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec_._match26469 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersion26470 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.AbstractCookieSpec_._validate26471 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.AbstractCookieSpec_._formatCookies26472 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersionHeader26473 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
		}
	}
}
