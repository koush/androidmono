namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Object 
	{
		internal static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Object(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize20367;
		protected virtual void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._finalize20367.native == global::System.IntPtr.Zero)
				global::java.lang.Object._finalize20367 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._finalize20367);
		}
		internal static global::MonoJavaBridge.MethodId _wait20368;
		public virtual void wait()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._wait20368.native == global::System.IntPtr.Zero)
				global::java.lang.Object._wait20368 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "wait", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._wait20368);
		}
		internal static global::MonoJavaBridge.MethodId _wait20369;
		public virtual void wait(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._wait20369.native == global::System.IntPtr.Zero)
				global::java.lang.Object._wait20369 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "wait", "(J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._wait20369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _wait20370;
		public virtual void wait(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._wait20370.native == global::System.IntPtr.Zero)
				global::java.lang.Object._wait20370 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "wait", "(JI)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._wait20370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals20371;
		public virtual bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._equals20371.native == global::System.IntPtr.Zero)
				global::java.lang.Object._equals20371 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._equals20371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20372;
		public virtual global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._toString20372.native == global::System.IntPtr.Zero)
				global::java.lang.Object._toString20372 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Object.staticClass, global::java.lang.Object._toString20372) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20373;
		public virtual int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._hashCode20373.native == global::System.IntPtr.Zero)
				global::java.lang.Object._hashCode20373 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._hashCode20373);
		}
		public new global::java.lang.Class Class
		{
			get
			{
				return getClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClass20374;
		public virtual global::java.lang.Class getClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._getClass20374.native == global::System.IntPtr.Zero)
				global::java.lang.Object._getClass20374 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "getClass", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Object.staticClass, global::java.lang.Object._getClass20374) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _clone20375;
		protected virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._clone20375.native == global::System.IntPtr.Zero)
				global::java.lang.Object._clone20375 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._clone20375) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _notify20376;
		public virtual void notify()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._notify20376.native == global::System.IntPtr.Zero)
				global::java.lang.Object._notify20376 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "notify", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._notify20376);
		}
		internal static global::MonoJavaBridge.MethodId _notifyAll20377;
		public virtual void notifyAll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._notifyAll20377.native == global::System.IntPtr.Zero)
				global::java.lang.Object._notifyAll20377 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "notifyAll", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Object.staticClass, global::java.lang.Object._notifyAll20377);
		}
		internal static global::MonoJavaBridge.MethodId _Object20378;
		public Object() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Object._Object20378.native == global::System.IntPtr.Zero)
				global::java.lang.Object._Object20378 = @__env.GetMethodIDNoThrow(global::java.lang.Object.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Object.staticClass, global::java.lang.Object._Object20378);
			Init(@__env, handle);
		}
		static Object()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Object.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Object"));
		}
		internal static void InitJNI()
		{
		}
	}
}
