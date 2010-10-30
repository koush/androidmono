namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicRequestLine : java.lang.Object, RequestLine, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicRequestLine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33639;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._toString33639)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33640;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._clone33640)) as java.lang.Object;
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod33641;
		public virtual global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._getMethod33641)) as java.lang.String;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33642;
		public virtual global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._getProtocolVersion33642)) as org.apache.http.ProtocolVersion;
		}
		public new global::java.lang.String Uri
		{
			get
			{
				return getUri();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUri33643;
		public virtual global::java.lang.String getUri()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._getUri33643)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicRequestLine33644;
		public BasicRequestLine(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._BasicRequestLine33644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicRequestLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicRequestLine.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicRequestLine"));
			global::org.apache.http.message.BasicRequestLine._toString33639 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicRequestLine._clone33640 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicRequestLine._getMethod33641 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicRequestLine._getProtocolVersion33642 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicRequestLine._getUri33643 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "getUri", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicRequestLine._BasicRequestLine33644 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
