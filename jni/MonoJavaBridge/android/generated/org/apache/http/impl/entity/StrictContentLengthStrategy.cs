namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StrictContentLengthStrategy : java.lang.Object, org.apache.http.entity.ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StrictContentLengthStrategy()
		{
			InitJNI();
		}
		protected StrictContentLengthStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _determineLength26632;
		public virtual long determineLength(org.apache.http.HttpMessage arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.entity.StrictContentLengthStrategy._determineLength26632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.StrictContentLengthStrategy._determineLength26632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StrictContentLengthStrategy26633;
		public StrictContentLengthStrategy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.StrictContentLengthStrategy._StrictContentLengthStrategy26633);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/StrictContentLengthStrategy"));
			global::org.apache.http.impl.entity.StrictContentLengthStrategy._determineLength26632 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J");
			global::org.apache.http.impl.entity.StrictContentLengthStrategy._StrictContentLengthStrategy26633 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.StrictContentLengthStrategy.staticClass, "<init>", "()V");
		}
	}
}
