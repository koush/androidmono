namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpHost : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpHost()
		{
			InitJNI();
		}
		internal HttpHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31456;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpHost._equals31456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._equals31456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31457;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._toString31457)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toString31457)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31458;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpHost._hashCode31458);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._hashCode31458);
		}
		internal static global::MonoJavaBridge.MethodId _clone31459;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._clone31459)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._clone31459)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toURI31460;
		public global::java.lang.String toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._toURI31460)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toURI31460)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort31461;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpHost._getPort31461);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getPort31461);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName31462;
		public global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._getHostName31462)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getHostName31462)) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName31463;
		public global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._getSchemeName31463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getSchemeName31463)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toHostString31464;
		public global::java.lang.String toHostString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._toHostString31464)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toHostString31464)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31465;
		public HttpHost(org.apache.http.HttpHost arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31466;
		public HttpHost(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31467;
		public HttpHost(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost31468;
		public HttpHost(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost31468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static global::java.lang.String DEFAULT_SCHEME_NAME
		{
			get
			{
				return "http";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpHost"));
			global::org.apache.http.HttpHost._equals31456 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.HttpHost._toString31457 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._hashCode31458 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "hashCode", "()I");
			global::org.apache.http.HttpHost._clone31459 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.HttpHost._toURI31460 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toURI", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._getPort31461 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getPort", "()I");
			global::org.apache.http.HttpHost._getHostName31462 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getHostName", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._getSchemeName31463 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._toHostString31464 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toHostString", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._HttpHost31465 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.HttpHost._HttpHost31466 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::org.apache.http.HttpHost._HttpHost31467 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpHost._HttpHost31468 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
		}
	}
}
