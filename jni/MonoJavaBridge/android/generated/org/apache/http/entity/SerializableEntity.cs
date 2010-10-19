namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SerializableEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SerializableEntity()
		{
			InitJNI();
		}
		protected SerializableEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent25826;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity._getContent25826)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._getContent25826)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25827;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity._writeTo25827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._writeTo25827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength25828;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity._getContentLength25828);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._getContentLength25828);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25829;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity._isRepeatable25829);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._isRepeatable25829);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25830;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity._isStreaming25830);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._isStreaming25830);
		}
		internal static global::MonoJavaBridge.MethodId _SerializableEntity25831;
		public SerializableEntity(java.io.Serializable arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._SerializableEntity25831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.SerializableEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/SerializableEntity"));
			global::org.apache.http.entity.SerializableEntity._getContent25826 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.SerializableEntity._writeTo25827 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.SerializableEntity._getContentLength25828 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.SerializableEntity._isRepeatable25829 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.SerializableEntity._isStreaming25830 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.SerializableEntity._SerializableEntity25831 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "<init>", "(Ljava/io/Serializable;Z)V");
		}
	}
}
