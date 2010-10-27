namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultConnectionReuseStrategy : java.lang.Object, ConnectionReuseStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultConnectionReuseStrategy()
		{
			InitJNI();
		}
		protected DefaultConnectionReuseStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _keepAlive32632;
		public virtual bool keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.DefaultConnectionReuseStrategy._keepAlive32632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, global::org.apache.http.impl.DefaultConnectionReuseStrategy._keepAlive32632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createTokenIterator32633;
		protected virtual global::org.apache.http.TokenIterator createTokenIterator(org.apache.http.HeaderIterator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.TokenIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultConnectionReuseStrategy._createTokenIterator32633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.TokenIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.TokenIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, global::org.apache.http.impl.DefaultConnectionReuseStrategy._createTokenIterator32633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.TokenIterator;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultConnectionReuseStrategy32634;
		public DefaultConnectionReuseStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, global::org.apache.http.impl.DefaultConnectionReuseStrategy._DefaultConnectionReuseStrategy32634);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultConnectionReuseStrategy"));
			global::org.apache.http.impl.DefaultConnectionReuseStrategy._keepAlive32632 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, "keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.DefaultConnectionReuseStrategy._createTokenIterator32633 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, "createTokenIterator", "(Lorg/apache/http/HeaderIterator;)Lorg/apache/http/TokenIterator;");
			global::org.apache.http.impl.DefaultConnectionReuseStrategy._DefaultConnectionReuseStrategy32634 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultConnectionReuseStrategy.staticClass, "<init>", "()V");
		}
	}
}
