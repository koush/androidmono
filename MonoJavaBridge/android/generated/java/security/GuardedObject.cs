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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object getObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.GuardedObject.staticClass, "getObject", "()Ljava/lang/Object;", ref global::java.security.GuardedObject._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public GuardedObject(java.lang.Object arg0, java.security.Guard arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.GuardedObject._m1.native == global::System.IntPtr.Zero)
				global::java.security.GuardedObject._m1 = @__env.GetMethodIDNoThrow(global::java.security.GuardedObject.staticClass, "<init>", "(Ljava/lang/Object;Ljava/security/Guard;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GuardedObject.staticClass, global::java.security.GuardedObject._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static GuardedObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.GuardedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/GuardedObject"));
		}
	}
}
