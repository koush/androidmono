namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderElementIterator : java.lang.Object, HeaderElementIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderElementIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33523;
		public virtual bool hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator._hasNext33523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._hasNext33523);
		}
		internal static global::MonoJavaBridge.MethodId _next33524;
		public virtual global::java.lang.Object next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator._next33524)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._next33524)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33525;
		public virtual void remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator._remove33525);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._remove33525);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement33526;
		public virtual global::org.apache.http.HeaderElement nextElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator._nextElement33526)) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._nextElement33526)) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElementIterator33527;
		public BasicHeaderElementIterator(org.apache.http.HeaderIterator arg0, org.apache.http.message.HeaderValueParser arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderElementIterator33528;
		public BasicHeaderElementIterator(org.apache.http.HeaderIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderElementIterator.staticClass, global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicHeaderElementIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderElementIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderElementIterator"));
			global::org.apache.http.message.BasicHeaderElementIterator._hasNext33523 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicHeaderElementIterator._next33524 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicHeaderElementIterator._remove33525 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicHeaderElementIterator._nextElement33526 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "nextElement", "()Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33527 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;Lorg/apache/http/message/HeaderValueParser;)V");
			global::org.apache.http.message.BasicHeaderElementIterator._BasicHeaderElementIterator33528 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderElementIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
