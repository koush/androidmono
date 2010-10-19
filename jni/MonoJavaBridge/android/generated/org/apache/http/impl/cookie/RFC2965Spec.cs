namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965Spec : org.apache.http.impl.cookie.RFC2109Spec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RFC2965Spec()
		{
			InitJNI();
		}
		protected RFC2965Spec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse26610;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec._parse26610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._parse26610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match26611;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec._match26611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._match26611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion26612;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec._getVersion26612);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._getVersion26612);
		}
		internal static global::MonoJavaBridge.MethodId _validate26613;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec._validate26613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._validate26613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader26614;
		public override global::org.apache.http.Header getVersionHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec._getVersionHeader26614)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._getVersionHeader26614)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _formatCookieAsVer26615;
		protected override void formatCookieAsVer(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.cookie.Cookie arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec._formatCookieAsVer26615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._formatCookieAsVer26615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965Spec26616;
		public RFC2965Spec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec26616);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965Spec26617;
		public RFC2965Spec(java.lang.String[] arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec26617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965Spec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965Spec"));
			global::org.apache.http.impl.cookie.RFC2965Spec._parse26610 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.RFC2965Spec._match26611 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.RFC2965Spec._getVersion26612 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.RFC2965Spec._validate26613 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.RFC2965Spec._getVersionHeader26614 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.RFC2965Spec._formatCookieAsVer26615 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V");
			global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec26616 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "<init>", "()V");
			global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec26617 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "<init>", "([Ljava/lang/String;Z)V");
		}
	}
}
