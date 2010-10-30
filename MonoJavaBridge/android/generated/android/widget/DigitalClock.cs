namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigitalClock : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigitalClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16988;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DigitalClock.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.DigitalClock._onAttachedToWindow16988);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16989;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DigitalClock.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.DigitalClock._onDetachedFromWindow16989);
		}
		internal static global::MonoJavaBridge.MethodId _DigitalClock16990;
		public DigitalClock(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DigitalClock._DigitalClock16990.native == global::System.IntPtr.Zero)
				global::android.widget.DigitalClock._DigitalClock16990 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._DigitalClock16990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigitalClock16991;
		public DigitalClock(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DigitalClock._DigitalClock16991.native == global::System.IntPtr.Zero)
				global::android.widget.DigitalClock._DigitalClock16991 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._DigitalClock16991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DigitalClock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DigitalClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DigitalClock"));
		}
		internal static void InitJNI()
		{
		}
	}
}
