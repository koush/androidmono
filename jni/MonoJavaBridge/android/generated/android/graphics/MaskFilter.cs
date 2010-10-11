namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MaskFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MaskFilter()
		{
			InitJNI();
		}
		protected MaskFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3336;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.MaskFilter._finalize3336);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.MaskFilter.staticClass, global::android.graphics.MaskFilter._finalize3336);
		}
		internal static global::MonoJavaBridge.MethodId _MaskFilter3337;
		public MaskFilter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.MaskFilter.staticClass, global::android.graphics.MaskFilter._MaskFilter3337);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.MaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/MaskFilter"));
			global::android.graphics.MaskFilter._finalize3336 = @__env.GetMethodIDNoThrow(global::android.graphics.MaskFilter.staticClass, "finalize", "()V");
			global::android.graphics.MaskFilter._MaskFilter3337 = @__env.GetMethodIDNoThrow(global::android.graphics.MaskFilter.staticClass, "<init>", "()V");
		}
	}
}
