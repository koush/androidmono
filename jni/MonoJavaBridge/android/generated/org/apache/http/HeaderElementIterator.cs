namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderElementIterator_))]
	public interface HeaderElementIterator : java.util.Iterator
	{
		bool hasNext();
		global::org.apache.http.HeaderElement nextElement();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderElementIterator))]
	public sealed partial class HeaderElementIterator_ : java.lang.Object, HeaderElementIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeaderElementIterator_()
		{
			InitJNI();
		}
		internal HeaderElementIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext24898;
		 bool org.apache.http.HeaderElementIterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._hasNext24898);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_.staticClass, global::org.apache.http.HeaderElementIterator_._hasNext24898);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement24899;
		 global::org.apache.http.HeaderElement org.apache.http.HeaderElementIterator.nextElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._nextElement24899)) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_.staticClass, global::org.apache.http.HeaderElementIterator_._nextElement24899)) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext24900;
		 bool java.util.Iterator.hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._hasNext24900);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_.staticClass, global::org.apache.http.HeaderElementIterator_._hasNext24900);
		}
		internal static global::MonoJavaBridge.MethodId _next24901;
		 global::java.lang.Object java.util.Iterator.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._next24901)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_.staticClass, global::org.apache.http.HeaderElementIterator_._next24901)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove24902;
		 void java.util.Iterator.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._remove24902);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_.staticClass, global::org.apache.http.HeaderElementIterator_._remove24902);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderElementIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderElementIterator"));
			global::org.apache.http.HeaderElementIterator_._hasNext24898 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "hasNext", "()Z");
			global::org.apache.http.HeaderElementIterator_._nextElement24899 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "nextElement", "()Lorg/apache/http/HeaderElement;");
			global::org.apache.http.HeaderElementIterator_._hasNext24900 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "hasNext", "()Z");
			global::org.apache.http.HeaderElementIterator_._next24901 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.HeaderElementIterator_._remove24902 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "remove", "()V");
		}
	}
}
