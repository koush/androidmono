namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabStopSpan_Standard : java.lang.Object, TabStopSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TabStopSpan_Standard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int TabStop
		{
			get
			{
				return getTabStop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabStop13596;
		public virtual int getTabStop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TabStopSpan_Standard.staticClass, "getTabStop", "()I", ref global::android.text.style.TabStopSpan_Standard._getTabStop13596);
		}
		internal static global::MonoJavaBridge.MethodId _TabStopSpan_Standard13597;
		public TabStopSpan_Standard(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard13597.native == global::System.IntPtr.Zero)
				global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard13597 = @__env.GetMethodIDNoThrow(global::android.text.style.TabStopSpan_Standard.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TabStopSpan_Standard.staticClass, global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard13597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TabStopSpan_Standard()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TabStopSpan_Standard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TabStopSpan$Standard"));
		}
		internal static void InitJNI()
		{
		}
	}
}
