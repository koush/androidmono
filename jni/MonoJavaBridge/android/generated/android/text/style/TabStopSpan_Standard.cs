namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabStopSpan_Standard : java.lang.Object, TabStopSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TabStopSpan_Standard()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getTabStop13534;
		public virtual int getTabStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TabStopSpan_Standard._getTabStop13534);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TabStopSpan_Standard.staticClass, global::android.text.style.TabStopSpan_Standard._getTabStop13534);
		}
		internal static global::MonoJavaBridge.MethodId _TabStopSpan_Standard13535;
		public TabStopSpan_Standard(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TabStopSpan_Standard.staticClass, global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard13535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TabStopSpan_Standard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TabStopSpan_Standard"));
			global::android.text.style.TabStopSpan_Standard._getTabStop13534 = @__env.GetMethodIDNoThrow(global::android.text.style.TabStopSpan_Standard.staticClass, "getTabStop", "()I");
			global::android.text.style.TabStopSpan_Standard._TabStopSpan_Standard13535 = @__env.GetMethodIDNoThrow(global::android.text.style.TabStopSpan_Standard.staticClass, "<init>", "(I)V");
		}
	}
}
