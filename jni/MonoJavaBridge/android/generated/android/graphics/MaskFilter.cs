namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MaskFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MaskFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5298;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.MaskFilter._finalize5298);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.MaskFilter.staticClass, global::android.graphics.MaskFilter._finalize5298);
		}
		internal static global::MonoJavaBridge.MethodId _MaskFilter5299;
		public MaskFilter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.MaskFilter.staticClass, global::android.graphics.MaskFilter._MaskFilter5299);
			Init(@__env, handle);
		}
		static MaskFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.MaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/MaskFilter"));
			global::android.graphics.MaskFilter._finalize5298 = @__env.GetMethodIDNoThrow(global::android.graphics.MaskFilter.staticClass, "finalize", "()V");
			global::android.graphics.MaskFilter._MaskFilter5299 = @__env.GetMethodIDNoThrow(global::android.graphics.MaskFilter.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
