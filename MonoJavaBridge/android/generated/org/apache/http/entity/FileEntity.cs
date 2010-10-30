namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.FileEntity.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.entity.FileEntity._m0) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.FileEntity.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.FileEntity._m1) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.FileEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.FileEntity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.FileEntity.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.FileEntity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.FileEntity.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.FileEntity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.FileEntity.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.FileEntity._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public FileEntity(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FileEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.FileEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/FileEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
