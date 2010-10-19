namespace org.apache.http.impl.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LaxContentLengthStrategy : java.lang.Object, org.apache.http.entity.ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LaxContentLengthStrategy()
		{
			InitJNI();
		}
		protected LaxContentLengthStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _determineLength26630;
		public virtual long determineLength(org.apache.http.HttpMessage arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.entity.LaxContentLengthStrategy._determineLength26630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.LaxContentLengthStrategy._determineLength26630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LaxContentLengthStrategy26631;
		public LaxContentLengthStrategy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, global::org.apache.http.impl.entity.LaxContentLengthStrategy._LaxContentLengthStrategy26631);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/entity/LaxContentLengthStrategy"));
			global::org.apache.http.impl.entity.LaxContentLengthStrategy._determineLength26630 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J");
			global::org.apache.http.impl.entity.LaxContentLengthStrategy._LaxContentLengthStrategy26631 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.entity.LaxContentLengthStrategy.staticClass, "<init>", "()V");
		}
	}
}
