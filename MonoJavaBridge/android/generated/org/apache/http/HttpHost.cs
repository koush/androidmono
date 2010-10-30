namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpHost : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31575;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._equals31575.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._equals31575 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._equals31575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31576;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._toString31576.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._toString31576 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toString31576)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31577;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._hashCode31577.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._hashCode31577 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "hashCode", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._hashCode31577);
		}
		internal static global::MonoJavaBridge.MethodId _clone31578;
		public global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._clone31578.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._clone31578 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._clone31578)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toURI31579;
		public global::java.lang.String toURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._toURI31579.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._toURI31579 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toURI", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toURI31579)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort31580;
		public int getPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._getPort31580.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._getPort31580 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getPort", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getPort31580);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName31581;
		public global::java.lang.String getHostName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._getHostName31581.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._getHostName31581 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getHostName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getHostName31581)) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName31582;
		public global::java.lang.String getSchemeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._getSchemeName31582.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._getSchemeName31582 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getSchemeName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getSchemeName31582)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toHostString31583;
		public global::java.lang.String toHostString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._toHostString31583.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._toHostString31583 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toHostString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toHostString31583)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31584;
		public HttpHost(org.apache.http.HttpHost arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._HttpHost31584.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._HttpHost31584 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31585;
		public HttpHost(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._HttpHost31585.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._HttpHost31585 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31586;
		public HttpHost(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._HttpHost31586.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._HttpHost31586 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31587;
		public HttpHost(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._HttpHost31587.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._HttpHost31587 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static global::java.lang.String DEFAULT_SCHEME_NAME
		{
			get
			{
				return "http";
			}
		}
		static HttpHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpHost"));
		}
		internal static void InitJNI()
		{
		}
	}
}
