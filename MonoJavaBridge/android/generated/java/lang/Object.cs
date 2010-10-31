namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Object 
	{
		internal static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Object(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, "finalize", "()V", ref global::java.lang.Object._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void wait()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, "wait", "()V", ref global::java.lang.Object._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void wait(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, "wait", "(J)V", ref global::java.lang.Object._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void wait(long arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, "wait", "(JI)V", ref global::java.lang.Object._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Object.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Object._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Object.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Object._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Object.staticClass, "hashCode", "()I", ref global::java.lang.Object._m6);
		}
		public new global::java.lang.Class Class
		{
			get
			{
				return getClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Class getClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Object.staticClass, "getClass", "()Ljava/lang/Class;", ref global::java.lang.Object._m7) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Object.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.lang.Object._m8) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void notify()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, "notify", "()V", ref global::java.lang.Object._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void notifyAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, "notifyAll", "()V", ref global::java.lang.Object._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Object() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Object._m11 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Object.staticClass, global::java.lang.Object._m11);
			Init(@__env, handle);
		}
		static Object()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Object.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Object"));
		}
	}
}
