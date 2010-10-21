namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileEntity()
		{
			InitJNI();
		}
		protected FileEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone32421;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity._clone32421)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._clone32421)) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32422;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity._getContent32422)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._getContent32422)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32423;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity._writeTo32423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._writeTo32423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32424;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity._getContentLength32424);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._getContentLength32424);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32425;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity._isRepeatable32425);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._isRepeatable32425);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32426;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity._isStreaming32426);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._isStreaming32426);
		}
		internal static global::MonoJavaBridge.MethodId _FileEntity32427;
		public FileEntity(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._FileEntity32427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.FileEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/FileEntity"));
			global::org.apache.http.entity.FileEntity._clone32421 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.entity.FileEntity._getContent32422 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.FileEntity._writeTo32423 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.FileEntity._getContentLength32424 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.FileEntity._isRepeatable32425 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.FileEntity._isStreaming32426 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.FileEntity._FileEntity32427 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
	}
}
