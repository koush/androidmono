namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReferenceQueue : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReferenceQueue()
		{
			InitJNI();
		}
		protected ReferenceQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _remove20990;
		public virtual global::java.lang.@ref.Reference remove(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.@ref.ReferenceQueue._remove20990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.@ref.Reference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.@ref.ReferenceQueue.staticClass, global::java.lang.@ref.ReferenceQueue._remove20990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.@ref.Reference;
		}
		internal static global::MonoJavaBridge.MethodId _remove20991;
		public virtual global::java.lang.@ref.Reference remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.@ref.ReferenceQueue._remove20991)) as java.lang.@ref.Reference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.@ref.ReferenceQueue.staticClass, global::java.lang.@ref.ReferenceQueue._remove20991)) as java.lang.@ref.Reference;
		}
		internal static global::MonoJavaBridge.MethodId _poll20992;
		public virtual global::java.lang.@ref.Reference poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.@ref.ReferenceQueue._poll20992)) as java.lang.@ref.Reference;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.@ref.ReferenceQueue.staticClass, global::java.lang.@ref.ReferenceQueue._poll20992)) as java.lang.@ref.Reference;
		}
		internal static global::MonoJavaBridge.MethodId _ReferenceQueue20993;
		public ReferenceQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.ReferenceQueue.staticClass, global::java.lang.@ref.ReferenceQueue._ReferenceQueue20993);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.ReferenceQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ref/ReferenceQueue"));
			global::java.lang.@ref.ReferenceQueue._remove20990 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.ReferenceQueue.staticClass, "remove", "(J)Ljava/lang/ref/Reference;");
			global::java.lang.@ref.ReferenceQueue._remove20991 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.ReferenceQueue.staticClass, "remove", "()Ljava/lang/ref/Reference;");
			global::java.lang.@ref.ReferenceQueue._poll20992 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.ReferenceQueue.staticClass, "poll", "()Ljava/lang/ref/Reference;");
			global::java.lang.@ref.ReferenceQueue._ReferenceQueue20993 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.ReferenceQueue.staticClass, "<init>", "()V");
		}
	}
}
