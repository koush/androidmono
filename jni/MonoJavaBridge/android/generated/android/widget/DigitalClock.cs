namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigitalClock : android.widget.TextView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DigitalClock()
		{
			InitJNI();
		}
		protected DigitalClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow11741;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DigitalClock._onAttachedToWindow11741);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._onAttachedToWindow11741);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow11742;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DigitalClock._onDetachedFromWindow11742);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._onDetachedFromWindow11742);
		}
		internal static global::MonoJavaBridge.MethodId _DigitalClock11743;
		public DigitalClock(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._DigitalClock11743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigitalClock11744;
		public DigitalClock(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._DigitalClock11744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DigitalClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DigitalClock"));
			global::android.widget.DigitalClock._onAttachedToWindow11741 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.DigitalClock._onDetachedFromWindow11742 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.DigitalClock._DigitalClock11743 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DigitalClock._DigitalClock11744 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
