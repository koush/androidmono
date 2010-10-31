namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderElementIterator : java.lang.Object, HeaderElementIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderElementIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "hasNext", "()Z", ref global::org.apache.http.message.BasicHeaderElementIterator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicHeaderElementIterator._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "remove", "()V", ref global::org.apache.http.message.BasicHeaderElementIterator._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.HeaderElement nextElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "nextElement", "()Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderElementIterator._m3) as org.apache.http.HeaderElement;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BasicHeaderElementIterator(org.apache.http.HeaderIterator arg0, org.apache.http.message.HeaderValueParser arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderElementIterator._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderElementIterator._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;Lorg/apache/http/message/HeaderValueParser;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public BasicHeaderElementIterator(org.apache.http.HeaderIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderElementIterator._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderElementIterator._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicHeaderElementIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderElementIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderElementIterator"));
		}
	}
}
