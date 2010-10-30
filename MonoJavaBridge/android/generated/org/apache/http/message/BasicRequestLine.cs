namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicRequestLine : java.lang.Object, RequestLine, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicRequestLine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicRequestLine.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicRequestLine._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicRequestLine._m1) as java.lang.Object;
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicRequestLine.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicRequestLine._m2) as java.lang.String;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicRequestLine._m3) as org.apache.http.ProtocolVersion;
		}
		public new global::java.lang.String Uri
		{
			get
			{
				return getUri();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getUri()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicRequestLine.staticClass, "getUri", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicRequestLine._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public BasicRequestLine(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicRequestLine._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicRequestLine._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicRequestLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicRequestLine.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicRequestLine"));
		}
		internal static void InitJNI()
		{
		}
	}
}
