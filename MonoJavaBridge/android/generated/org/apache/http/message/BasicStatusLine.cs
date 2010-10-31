namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicStatusLine : java.lang.Object, StatusLine, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicStatusLine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicStatusLine.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicStatusLine._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicStatusLine.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicStatusLine._m1) as java.lang.Object;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicStatusLine.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicStatusLine._m2) as org.apache.http.ProtocolVersion;
		}
		public new int StatusCode
		{
			get
			{
				return getStatusCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getStatusCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicStatusLine.staticClass, "getStatusCode", "()I", ref global::org.apache.http.message.BasicStatusLine._m3);
		}
		public new global::java.lang.String ReasonPhrase
		{
			get
			{
				return getReasonPhrase();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getReasonPhrase()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicStatusLine.staticClass, "getReasonPhrase", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicStatusLine._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public BasicStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicStatusLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicStatusLine.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicStatusLine"));
		}
	}
}
