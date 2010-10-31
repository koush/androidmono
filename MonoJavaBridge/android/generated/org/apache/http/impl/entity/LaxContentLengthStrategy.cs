namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LaxContentLengthStrategy : java.lang.Object, org.apache.http.entity.ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LaxContentLengthStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long determineLength(org.apache.http.HttpMessage arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J", ref global::org.apache.http.impl.entity.LaxContentLengthStrategy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public LaxContentLengthStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.LaxContentLengthStrategy._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.LaxContentLengthStrategy._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.LaxContentLengthStrategy._m1);
			Init(@__env, handle);
		}
		static LaxContentLengthStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/LaxContentLengthStrategy"));
		}
	}
}
