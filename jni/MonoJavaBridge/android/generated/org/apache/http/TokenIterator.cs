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
		static TokenIterator_()
		{
			InitJNI();
		}
		internal TokenIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext31766;
		bool org.apache.http.TokenIterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.TokenIterator_._hasNext31766);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.TokenIterator_.staticClass, global::org.apache.http.TokenIterator_._hasNext31766);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken31767;
		global::java.lang.String org.apache.http.TokenIterator.nextToken()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.TokenIterator_._nextToken31767)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.TokenIterator_.staticClass, global::org.apache.http.TokenIterator_._nextToken31767)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext31768;
		bool java.util.Iterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.TokenIterator_._hasNext31768);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.TokenIterator_.staticClass, global::org.apache.http.TokenIterator_._hasNext31768);
		}
		internal static global::MonoJavaBridge.MethodId _next31769;
		global::java.lang.Object java.util.Iterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.TokenIterator_._next31769)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.TokenIterator_.staticClass, global::org.apache.http.TokenIterator_._next31769)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove31770;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.TokenIterator_._remove31770);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.TokenIterator_.staticClass, global::org.apache.http.TokenIterator_._remove31770);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.TokenIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/TokenIterator"));
			global::org.apache.http.TokenIterator_._hasNext31766 = @__env.GetMethodIDNoThrow(global::org.apache.http.TokenIterator_.staticClass, "hasNext", "()Z");
			global::org.apache.http.TokenIterator_._nextToken31767 = @__env.GetMethodIDNoThrow(global::org.apache.http.TokenIterator_.staticClass, "nextToken", "()Ljava/lang/String;");
			global::org.apache.http.TokenIterator_._hasNext31768 = @__env.GetMethodIDNoThrow(global::org.apache.http.TokenIterator_.staticClass, "hasNext", "()Z");
			global::org.apache.http.TokenIterator_._next31769 = @__env.GetMethodIDNoThrow(global::org.apache.http.TokenIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.TokenIterator_._remove31770 = @__env.GetMethodIDNoThrow(global::org.apache.http.TokenIterator_.staticClass, "remove", "()V");
		}
	}
}
