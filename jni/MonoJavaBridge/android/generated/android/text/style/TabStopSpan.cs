namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.TabStopSpan_))]
	public partial interface TabStopSpan : ParagraphStyle
	{
		int getTabStop();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.TabStopSpan))]
	public sealed partial class TabStopSpan_ : java.lang.Object, TabStopSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TabStopSpan_()
		{
			InitJNI();
		}
		internal TabStopSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getTabStop13536;
		 int android.text.style.TabStopSpan.getTabStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TabStopSpan_._getTabStop13536);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TabStopSpan_.staticClass, global::android.text.style.TabStopSpan_._getTabStop13536);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TabStopSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TabStopSpan"));
			global::android.text.style.TabStopSpan_._getTabStop13536 = @__env.GetMethodIDNoThrow(global::android.text.style.TabStopSpan_.staticClass, "getTabStop", "()I");
		}
	}
}
