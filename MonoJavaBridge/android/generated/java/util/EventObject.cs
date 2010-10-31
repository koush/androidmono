namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EventObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EventObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.EventObject.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.EventObject._m0) as java.lang.String;
		}
		public new global::java.lang.Object Source
		{
			get
			{
				return getSource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object getSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EventObject.staticClass, "getSource", "()Ljava/lang/Object;", ref global::java.util.EventObject._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public EventObject(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EventObject._m2.native == global::System.IntPtr.Zero)
				global::java.util.EventObject._m2 = @__env.GetMethodIDNoThrow(global::java.util.EventObject.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EventObject.staticClass, global::java.util.EventObject._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EventObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventObject"));
		}
	}
}
