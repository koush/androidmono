namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderIterator_))]
	public partial interface HeaderIterator : java.util.Iterator
	{
		bool hasNext();
		global::org.apache.http.Header nextHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderIterator))]
	internal sealed partial class HeaderIterator_ : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HeaderIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool org.apache.http.HeaderIterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HeaderIterator_.staticClass, "hasNext", "()Z", ref global::org.apache.http.HeaderIterator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.Header org.apache.http.HeaderIterator.nextHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.HeaderIterator_.staticClass, "nextHeader", "()Lorg/apache/http/Header;", ref global::org.apache.http.HeaderIterator_._m1) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.util.Iterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HeaderIterator_.staticClass, "hasNext", "()Z", ref global::org.apache.http.HeaderIterator_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.Iterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HeaderIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.HeaderIterator_._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.HeaderIterator_.staticClass, "remove", "()V", ref global::org.apache.http.HeaderIterator_._m4);
		}
		static HeaderIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderIterator"));
		}
	}
}
