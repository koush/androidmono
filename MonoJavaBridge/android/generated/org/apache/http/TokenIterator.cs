namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.TokenIterator_))]
	public partial interface TokenIterator : java.util.Iterator
	{
		bool hasNext();
		global::java.lang.String nextToken();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.TokenIterator))]
	internal sealed partial class TokenIterator_ : java.lang.Object, TokenIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TokenIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool org.apache.http.TokenIterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.TokenIterator_.staticClass, "hasNext", "()Z", ref global::org.apache.http.TokenIterator_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.TokenIterator.nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.TokenIterator_.staticClass, "nextToken", "()Ljava/lang/String;", ref global::org.apache.http.TokenIterator_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.util.Iterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.TokenIterator_.staticClass, "hasNext", "()Z", ref global::org.apache.http.TokenIterator_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.Iterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.TokenIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.TokenIterator_._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.TokenIterator_.staticClass, "remove", "()V", ref global::org.apache.http.TokenIterator_._m4);
		}
		static TokenIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.TokenIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/TokenIterator"));
		}
	}
}
