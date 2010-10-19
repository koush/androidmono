namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntityTemplate : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntityTemplate()
		{
			InitJNI();
		}
		protected EntityTemplate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent25795;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate._getContent25795)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._getContent25795)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25796;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate._writeTo25796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._writeTo25796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength25797;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate._getContentLength25797);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._getContentLength25797);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25798;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate._isRepeatable25798);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._isRepeatable25798);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25799;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate._isStreaming25799);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._isStreaming25799);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent25800;
		public override void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate._consumeContent25800);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._consumeContent25800);
		}
		internal static global::MonoJavaBridge.MethodId _EntityTemplate25801;
		public EntityTemplate(org.apache.http.entity.ContentProducer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.EntityTemplate.staticClass, global::org.apache.http.entity.EntityTemplate._EntityTemplate25801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.EntityTemplate.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/EntityTemplate"));
			global::org.apache.http.entity.EntityTemplate._getContent25795 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.EntityTemplate._writeTo25796 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.EntityTemplate._getContentLength25797 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.EntityTemplate._isRepeatable25798 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.EntityTemplate._isStreaming25799 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.EntityTemplate._consumeContent25800 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.EntityTemplate._EntityTemplate25801 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.EntityTemplate.staticClass, "<init>", "(Lorg/apache/http/entity/ContentProducer;)V");
		}
	}
}
