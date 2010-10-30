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
		internal static global::MonoJavaBridge.MethodId _hasNext31766;
		bool org.apache.http.TokenIterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.TokenIterator_.staticClass, "hasNext", "()Z", ref global::org.apache.http.TokenIterator_._hasNext31766);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken31767;
		global::java.lang.String org.apache.http.TokenIterator.nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.TokenIterator_.staticClass, "nextToken", "()Ljava/lang/String;", ref global::org.apache.http.TokenIterator_._nextToken31767) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext31768;
		bool java.util.Iterator.hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.TokenIterator_.staticClass, "hasNext", "()Z", ref global::org.apache.http.TokenIterator_._hasNext31768);
		}
		internal static global::MonoJavaBridge.MethodId _next31769;
		global::java.lang.Object java.util.Iterator.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.TokenIterator_.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.TokenIterator_._next31769) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove31770;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.TokenIterator_.staticClass, "remove", "()V", ref global::org.apache.http.TokenIterator_._remove31770);
		}
		static TokenIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.TokenIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/TokenIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
