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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity._clone32570)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._clone32570)) as java.lang.Object;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity._getContent32571)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._getContent32571)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32572;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity._writeTo32572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._writeTo32572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity._getContentLength32573);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._getContentLength32573);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32574;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity._isRepeatable32574);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._isRepeatable32574);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32575;
		public override bool isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity._isStreaming32575);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.StringEntity.staticClass, global::org.apache.http.entity.StringEntity._isStreaming32575);
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
