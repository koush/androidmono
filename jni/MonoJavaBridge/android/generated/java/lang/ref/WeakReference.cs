namespace java.lang.@ref
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WeakReference : java.lang.@ref.Reference
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WeakReference()
		{
			InitJNI();
		}
		protected WeakReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _WeakReference15356;
		public WeakReference(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.WeakReference.staticClass, global::java.lang.@ref.WeakReference._WeakReference15356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WeakReference15357;
		public WeakReference(java.lang.Object arg0, java.lang.@ref.ReferenceQueue arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.@ref.WeakReference.staticClass, global::java.lang.@ref.WeakReference._WeakReference15357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.@ref.WeakReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/@ref/WeakReference"));
			global::java.lang.@ref.WeakReference._WeakReference15356 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.WeakReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.lang.@ref.WeakReference._WeakReference15357 = @__env.GetMethodIDNoThrow(global::java.lang.@ref.WeakReference.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/@ref/ReferenceQueue;)V");
		}
	}
}
