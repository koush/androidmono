namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone32570;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._clone32570)) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32571;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._getContent32571)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32572;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._writeTo32572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32573;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._getContentLength32573);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32574;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._isRepeatable32574);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32575;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._isStreaming32575);
		}
		internal static global::MonoJavaBridge.MethodId _StringEntity32576;
		public StringEntity(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._StringEntity32576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringEntity32577;
		public StringEntity(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._StringEntity32577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.StringEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/StringEntity"));
			global::org.apache.http.entity.StringEntity._clone32570 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.entity.StringEntity._getContent32571 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.StringEntity._writeTo32572 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.StringEntity._getContentLength32573 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.StringEntity._isRepeatable32574 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.StringEntity._isStreaming32575 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.StringEntity._StringEntity32576 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.entity.StringEntity._StringEntity32577 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.StringEntity.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
