namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderIterator : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "hasNext", "()Z", ref global::org.apache.http.message.BasicHeaderIterator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicHeaderIterator._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "remove", "()V", ref global::org.apache.http.message.BasicHeaderIterator._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual int findNext(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "findNext", "(I)I", ref global::org.apache.http.message.BasicHeaderIterator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.Header nextHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "nextHeader", "()Lorg/apache/http/Header;", ref global::org.apache.http.message.BasicHeaderIterator._m4) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual bool filterHeader(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "filterHeader", "(I)Z", ref global::org.apache.http.message.BasicHeaderIterator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BasicHeaderIterator(org.apache.http.Header[] arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderIterator._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderIterator._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "<init>", "([Lorg/apache/http/Header;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicHeaderIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
