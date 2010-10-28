namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LaxContentLengthStrategy : java.lang.Object, org.apache.http.entity.ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LaxContentLengthStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _determineLength33376;
		public virtual long determineLength(org.apache.http.HttpMessage arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.entity.LaxContentLengthStrategy._determineLength33376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.LaxContentLengthStrategy._determineLength33376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LaxContentLengthStrategy33377;
		public LaxContentLengthStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.LaxContentLengthStrategy._LaxContentLengthStrategy33377);
			Init(@__env, handle);
		}
		static LaxContentLengthStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/LaxContentLengthStrategy"));
			global::org.apache.http.impl.entity.LaxContentLengthStrategy._determineLength33376 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J");
			global::org.apache.http.impl.entity.LaxContentLengthStrategy._LaxContentLengthStrategy33377 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
