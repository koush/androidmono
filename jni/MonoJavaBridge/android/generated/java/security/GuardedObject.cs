namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GuardedObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GuardedObject()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getObject17241;
		public virtual global::java.lang.Object getObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.GuardedObject._getObject17241)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.GuardedObject.staticClass, global::java.security.GuardedObject._getObject17241)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _GuardedObject17242;
		public GuardedObject(java.lang.Object arg0, java.security.Guard arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GuardedObject.staticClass, global::java.security.GuardedObject._GuardedObject17242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.GuardedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/GuardedObject"));
			global::java.security.GuardedObject._getObject17241 = @__env.GetMethodIDNoThrow(global::java.security.GuardedObject.staticClass, "getObject", "()Ljava/lang/Object;");
			global::java.security.GuardedObject._GuardedObject17242 = @__env.GetMethodIDNoThrow(global::java.security.GuardedObject.staticClass, "<init>", "(Ljava/lang/Object;Ljava/security/Guard;)V");
		}
	}
}
