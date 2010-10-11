namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rasterizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Rasterizer()
		{
			InitJNI();
		}
		protected Rasterizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3666;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Rasterizer._finalize3666);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Rasterizer.staticClass, global::android.graphics.Rasterizer._finalize3666);
		}
		internal static global::MonoJavaBridge.MethodId _Rasterizer3667;
		public Rasterizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rasterizer.staticClass, global::android.graphics.Rasterizer._Rasterizer3667);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rasterizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rasterizer"));
			global::android.graphics.Rasterizer._finalize3666 = @__env.GetMethodIDNoThrow(global::android.graphics.Rasterizer.staticClass, "finalize", "()V");
			global::android.graphics.Rasterizer._Rasterizer3667 = @__env.GetMethodIDNoThrow(global::android.graphics.Rasterizer.staticClass, "<init>", "()V");
		}
	}
}
