namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnalogClock : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnalogClock()
		{
			InitJNI();
		}
		protected AnalogClock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow10909;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onAttachedToWindow10909);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onAttachedToWindow10909);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow10910;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onDetachedFromWindow10910);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onDetachedFromWindow10910);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged10911;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onSizeChanged10911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onSizeChanged10911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw10912;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onDraw10912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onDraw10912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure10913;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onMeasure10913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onMeasure10913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock10914;
		public AnalogClock(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock10914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock10915;
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock10915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock10916;
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock10916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AnalogClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AnalogClock"));
			global::android.widget.AnalogClock._onAttachedToWindow10909 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AnalogClock._onDetachedFromWindow10910 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AnalogClock._onSizeChanged10911 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AnalogClock._onDraw10912 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AnalogClock._onMeasure10913 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onMeasure", "(II)V");
			global::android.widget.AnalogClock._AnalogClock10914 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AnalogClock._AnalogClock10915 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AnalogClock._AnalogClock10916 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
