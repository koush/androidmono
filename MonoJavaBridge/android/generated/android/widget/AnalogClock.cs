namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnalogClock : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnalogClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16694;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AnalogClock.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.AnalogClock._onAttachedToWindow16694);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16695;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AnalogClock.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.AnalogClock._onDetachedFromWindow16695);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16696;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AnalogClock.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.AnalogClock._onSizeChanged16696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16697;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AnalogClock.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.AnalogClock._onDraw16697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16698;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AnalogClock.staticClass, "onMeasure", "(II)V", ref global::android.widget.AnalogClock._onMeasure16698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock16699;
		public AnalogClock(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AnalogClock._AnalogClock16699.native == global::System.IntPtr.Zero)
				global::android.widget.AnalogClock._AnalogClock16699 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock16699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock16700;
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AnalogClock._AnalogClock16700.native == global::System.IntPtr.Zero)
				global::android.widget.AnalogClock._AnalogClock16700 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock16700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock16701;
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AnalogClock._AnalogClock16701.native == global::System.IntPtr.Zero)
				global::android.widget.AnalogClock._AnalogClock16701 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock16701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AnalogClock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AnalogClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AnalogClock"));
		}
		internal static void InitJNI()
		{
		}
	}
}
