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
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16891;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DigitalClock._onAttachedToWindow16891);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._onAttachedToWindow16891);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16892;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DigitalClock._onDetachedFromWindow16892);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._onDetachedFromWindow16892);
		}
		internal static global::MonoJavaBridge.MethodId _DigitalClock16893;
		public DigitalClock(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._DigitalClock16893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DigitalClock16894;
		public DigitalClock(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DigitalClock.staticClass, global::android.widget.DigitalClock._DigitalClock16894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DigitalClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DigitalClock"));
			global::android.widget.DigitalClock._onAttachedToWindow16891 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.DigitalClock._onDetachedFromWindow16892 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.DigitalClock._DigitalClock16893 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DigitalClock._DigitalClock16894 = @__env.GetMethodIDNoThrow(global::android.widget.DigitalClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
