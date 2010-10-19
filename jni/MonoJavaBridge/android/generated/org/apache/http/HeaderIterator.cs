namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderIterator_))]
	public interface HeaderIterator : java.util.Iterator
	{
		bool hasNext();
		global::org.apache.http.Header nextHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderIterator))]
	public sealed partial class HeaderIterator_ : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeaderIterator_()
		{
			InitJNI();
		}
		internal HeaderIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext24903;
		 bool org.apache.http.HeaderIterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_._hasNext24903);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_.staticClass, global::org.apache.http.HeaderIterator_._hasNext24903);
		}
		internal static global::MonoJavaBridge.MethodId _nextHeader24904;
		 global::org.apache.http.Header org.apache.http.HeaderIterator.nextHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_._nextHeader24904)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_.staticClass, global::org.apache.http.HeaderIterator_._nextHeader24904)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext24905;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_._hasNext24905);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_.staticClass, global::org.apache.http.HeaderIterator_._hasNext24905);
		}
		internal static global::MonoJavaBridge.MethodId _next24906;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_._next24906)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_.staticClass, global::org.apache.http.HeaderIterator_._next24906)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove24907;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_._remove24907);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HeaderIterator_.staticClass, global::org.apache.http.HeaderIterator_._remove24907);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderIterator"));
			global::org.apache.http.HeaderIterator_._hasNext24903 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderIterator_.staticClass, "hasNext", "()Z");
			global::org.apache.http.HeaderIterator_._nextHeader24904 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderIterator_.staticClass, "nextHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.HeaderIterator_._hasNext24905 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderIterator_.staticClass, "hasNext", "()Z");
			global::org.apache.http.HeaderIterator_._next24906 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.HeaderIterator_._remove24907 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderIterator_.staticClass, "remove", "()V");
		}
	}
}
