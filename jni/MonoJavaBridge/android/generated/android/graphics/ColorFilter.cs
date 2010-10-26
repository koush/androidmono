namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ColorFilter()
		{
			InitJNI();
		}
		protected ColorFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5239;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorFilter._finalize5239);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorFilter.staticClass, global::android.graphics.ColorFilter._finalize5239);
		}
		internal static global::MonoJavaBridge.MethodId _ColorFilter5240;
		public ColorFilter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorFilter.staticClass, global::android.graphics.ColorFilter._ColorFilter5240);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorFilter"));
			global::android.graphics.ColorFilter._finalize5239 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorFilter.staticClass, "finalize", "()V");
			global::android.graphics.ColorFilter._ColorFilter5240 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorFilter.staticClass, "<init>", "()V");
		}
	}
}
