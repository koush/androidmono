namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigitalClock : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigitalClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DigitalClock.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.DigitalClock._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DigitalClock.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.DigitalClock._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DigitalClock(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DigitalClock._m2.native == global::System.IntPtr.Zero)
				global::android.widget.DigitalClock._m2 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DigitalClock(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DigitalClock._m3.native == global::System.IntPtr.Zero)
				global::android.widget.DigitalClock._m3 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DigitalClock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DigitalClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DigitalClock"));
		}
	}
}
