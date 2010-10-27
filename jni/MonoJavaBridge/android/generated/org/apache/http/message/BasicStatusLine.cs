namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicStatusLine : java.lang.Object, StatusLine, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicStatusLine()
		{
			InitJNI();
		}
		protected BasicStatusLine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33644;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine._toString33644)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._toString33644)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33645;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine._clone33645)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._clone33645)) as java.lang.Object;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33646;
		public virtual global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine._getProtocolVersion33646)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._getProtocolVersion33646)) as org.apache.http.ProtocolVersion;
		}
		public new int StatusCode
		{
			get
			{
				return getStatusCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode33647;
		public virtual int getStatusCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine._getStatusCode33647);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._getStatusCode33647);
		}
		public new global::java.lang.String ReasonPhrase
		{
			get
			{
				return getReasonPhrase();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReasonPhrase33648;
		public virtual global::java.lang.String getReasonPhrase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine._getReasonPhrase33648)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._getReasonPhrase33648)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicStatusLine33649;
		public BasicStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._BasicStatusLine33649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicStatusLine.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicStatusLine"));
			global::org.apache.http.message.BasicStatusLine._toString33644 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicStatusLine._clone33645 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicStatusLine._getProtocolVersion33646 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicStatusLine._getStatusCode33647 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "getStatusCode", "()I");
			global::org.apache.http.message.BasicStatusLine._getReasonPhrase33648 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "getReasonPhrase", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicStatusLine._BasicStatusLine33649 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
		}
	}
}
