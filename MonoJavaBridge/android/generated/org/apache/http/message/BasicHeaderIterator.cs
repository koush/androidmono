namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderIterator : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33529;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "hasNext", "()Z", ref global::org.apache.http.message.BasicHeaderIterator._hasNext33529);
		}
		internal static global::MonoJavaBridge.MethodId _next33530;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicHeaderIterator._next33530) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33531;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "remove", "()V", ref global::org.apache.http.message.BasicHeaderIterator._remove33531);
		}
		internal static global::MonoJavaBridge.MethodId _findNext33532;
		protected virtual int findNext(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "findNext", "(I)I", ref global::org.apache.http.message.BasicHeaderIterator._findNext33532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextHeader33533;
		public virtual global::org.apache.http.Header nextHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "nextHeader", "()Lorg/apache/http/Header;", ref global::org.apache.http.message.BasicHeaderIterator._nextHeader33533) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _filterHeader33534;
		protected virtual bool filterHeader(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderIterator.staticClass, "filterHeader", "(I)Z", ref global::org.apache.http.message.BasicHeaderIterator._filterHeader33534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderIterator33535;
		public BasicHeaderIterator(org.apache.http.Header[] arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderIterator._BasicHeaderIterator33535.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderIterator._BasicHeaderIterator33535 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "<init>", "([Lorg/apache/http/Header;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._BasicHeaderIterator33535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
