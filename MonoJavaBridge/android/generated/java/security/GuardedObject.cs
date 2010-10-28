namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GuardedObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GuardedObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Object Object
		{
			get
			{
				return getObject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getObject22958;
		public virtual global::java.lang.Object getObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.GuardedObject._getObject22958)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.GuardedObject.staticClass, global::java.security.GuardedObject._getObject22958)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _GuardedObject22959;
		public GuardedObject(java.lang.Object arg0, java.security.Guard arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GuardedObject.staticClass, global::java.security.GuardedObject._GuardedObject22959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static GuardedObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.GuardedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/GuardedObject"));
			global::java.security.GuardedObject._getObject22958 = @__env.GetMethodIDNoThrow(global::java.security.GuardedObject.staticClass, "getObject", "()Ljava/lang/Object;");
			global::java.security.GuardedObject._GuardedObject22959 = @__env.GetMethodIDNoThrow(global::java.security.GuardedObject.staticClass, "<init>", "(Ljava/lang/Object;Ljava/security/Guard;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
