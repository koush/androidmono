namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.TabStopSpan_))]
	public partial interface TabStopSpan : ParagraphStyle
	{
		int getTabStop();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.TabStopSpan))]
	internal sealed partial class TabStopSpan_ : java.lang.Object, TabStopSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TabStopSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		int android.text.style.TabStopSpan.getTabStop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TabStopSpan_.staticClass, "getTabStop", "()I", ref global::android.text.style.TabStopSpan_._m0);
		}
		static TabStopSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TabStopSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TabStopSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
