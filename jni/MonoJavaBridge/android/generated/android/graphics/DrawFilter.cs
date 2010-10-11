namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DrawFilter()
		{
			InitJNI();
		}
		protected DrawFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3308;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.DrawFilter._finalize3308);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.DrawFilter.staticClass, global::android.graphics.DrawFilter._finalize3308);
		}
		internal static global::MonoJavaBridge.MethodId _DrawFilter3309;
		public DrawFilter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.DrawFilter.staticClass, global::android.graphics.DrawFilter._DrawFilter3309);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.DrawFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/DrawFilter"));
			global::android.graphics.DrawFilter._finalize3308 = @__env.GetMethodIDNoThrow(global::android.graphics.DrawFilter.staticClass, "finalize", "()V");
			global::android.graphics.DrawFilter._DrawFilter3309 = @__env.GetMethodIDNoThrow(global::android.graphics.DrawFilter.staticClass, "<init>", "()V");
		}
	}
}
