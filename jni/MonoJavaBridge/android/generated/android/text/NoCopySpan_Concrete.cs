namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoCopySpan_Concrete : java.lang.Object, NoCopySpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoCopySpan_Concrete()
		{
			InitJNI();
		}
		protected NoCopySpan_Concrete(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoCopySpan_Concrete12841;
		public NoCopySpan_Concrete()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.NoCopySpan_Concrete.staticClass, global::android.text.NoCopySpan_Concrete._NoCopySpan_Concrete12841);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.NoCopySpan_Concrete.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/NoCopySpan_Concrete"));
			global::android.text.NoCopySpan_Concrete._NoCopySpan_Concrete12841 = @__env.GetMethodIDNoThrow(global::android.text.NoCopySpan_Concrete.staticClass, "<init>", "()V");
		}
	}
}
