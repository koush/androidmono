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
		internal static global::MonoJavaBridge.MethodId _equals24967;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpHost._equals24967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._equals24967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString24968;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._toString24968)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toString24968)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode24969;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpHost._hashCode24969);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._hashCode24969);
		}
		internal static global::MonoJavaBridge.MethodId _clone24970;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._clone24970)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._clone24970)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toURI24971;
		public global::java.lang.String toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._toURI24971)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toURI24971)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort24972;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpHost._getPort24972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getPort24972);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostName24973;
		public global::java.lang.String getHostName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._getHostName24973)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getHostName24973)) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName24974;
		public global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._getSchemeName24974)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._getSchemeName24974)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toHostString24975;
		public global::java.lang.String toHostString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost._toHostString24975)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._toHostString24975)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost24976;
		public HttpHost(org.apache.http.HttpHost arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost24976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost24977;
		public HttpHost(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost24977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost24978;
		public HttpHost(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost24978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHost24979;
		public HttpHost(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._HttpHost24979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::org.apache.http.HttpHost._equals24967 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.HttpHost._toString24968 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._hashCode24969 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "hashCode", "()I");
			global::org.apache.http.HttpHost._clone24970 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.HttpHost._toURI24971 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toURI", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._getPort24972 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getPort", "()I");
			global::org.apache.http.HttpHost._getHostName24973 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getHostName", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._getSchemeName24974 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._toHostString24975 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "toHostString", "()Ljava/lang/String;");
			global::org.apache.http.HttpHost._HttpHost24976 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::org.apache.http.HttpHost._HttpHost24977 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::org.apache.http.HttpHost._HttpHost24978 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.HttpHost._HttpHost24979 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
		}
	}
}
