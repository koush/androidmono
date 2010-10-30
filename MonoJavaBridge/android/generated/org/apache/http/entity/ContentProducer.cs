namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.entity.ContentProducer_))]
	public partial interface ContentProducer  : global::MonoJavaBridge.IJavaObject 
	{
		void writeTo(java.io.OutputStream arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.ContentProducer))]
	internal sealed partial class ContentProducer_ : java.lang.Object, ContentProducer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentProducer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.entity.ContentProducer.writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.ContentProducer_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.ContentProducer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ContentProducer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ContentProducer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ContentProducer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
