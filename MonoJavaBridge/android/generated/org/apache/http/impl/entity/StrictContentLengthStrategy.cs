namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StrictContentLengthStrategy : java.lang.Object, org.apache.http.entity.ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StrictContentLengthStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long determineLength(org.apache.http.HttpMessage arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J", ref global::org.apache.http.impl.entity.StrictContentLengthStrategy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StrictContentLengthStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.entity.StrictContentLengthStrategy._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.entity.StrictContentLengthStrategy._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.StrictContentLengthStrategy._m1);
			Init(@__env, handle);
		}
		static StrictContentLengthStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/StrictContentLengthStrategy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
