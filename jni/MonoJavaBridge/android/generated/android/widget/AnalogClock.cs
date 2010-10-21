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
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16600;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onAttachedToWindow16600);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onAttachedToWindow16600);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16601;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onDetachedFromWindow16601);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onDetachedFromWindow16601);
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16602;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onSizeChanged16602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onSizeChanged16602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16603;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onDraw16603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onDraw16603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16604;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AnalogClock._onMeasure16604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._onMeasure16604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock16605;
		public AnalogClock(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock16605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock16606;
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock16606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnalogClock16607;
		public AnalogClock(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AnalogClock.staticClass, global::android.widget.AnalogClock._AnalogClock16607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AnalogClock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AnalogClock"));
			global::android.widget.AnalogClock._onAttachedToWindow16600 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AnalogClock._onDetachedFromWindow16601 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AnalogClock._onSizeChanged16602 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AnalogClock._onDraw16603 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AnalogClock._onMeasure16604 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "onMeasure", "(II)V");
			global::android.widget.AnalogClock._AnalogClock16605 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.AnalogClock._AnalogClock16606 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AnalogClock._AnalogClock16607 = @__env.GetMethodIDNoThrow(global::android.widget.AnalogClock.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
