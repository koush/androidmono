namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.DynamicDrawableSpan_))]
	public abstract partial class DynamicDrawableSpan : android.text.style.ReplacementSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DynamicDrawableSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.DynamicDrawableSpan.staticClass, "getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMetricsInt;)I", ref global::android.text.style.DynamicDrawableSpan._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public int getSize(android.graphics.Paint arg0, string arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4)
		{
			return getSize(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::android.graphics.drawable.Drawable getDrawable();
		private static global::MonoJavaBridge.MethodId _m2;
		public override void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.DynamicDrawableSpan.staticClass, "draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)V", ref global::android.text.style.DynamicDrawableSpan._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		public void draw(android.graphics.Canvas arg0, string arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8)
		{
			draw(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getVerticalAlignment()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.DynamicDrawableSpan.staticClass, "getVerticalAlignment", "()I", ref global::android.text.style.DynamicDrawableSpan._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DynamicDrawableSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DynamicDrawableSpan._m4.native == global::System.IntPtr.Zero)
				global::android.text.style.DynamicDrawableSpan._m4 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected DynamicDrawableSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DynamicDrawableSpan._m5.native == global::System.IntPtr.Zero)
				global::android.text.style.DynamicDrawableSpan._m5 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int ALIGN_BOTTOM
		{
			get
			{
				return 0;
			}
		}
		public static int ALIGN_BASELINE
		{
			get
			{
				return 1;
			}
		}
		static DynamicDrawableSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.DynamicDrawableSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/DynamicDrawableSpan"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.DynamicDrawableSpan))]
	internal sealed partial class DynamicDrawableSpan_ : android.text.style.DynamicDrawableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DynamicDrawableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::android.graphics.drawable.Drawable getDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.DynamicDrawableSpan_.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.text.style.DynamicDrawableSpan_._m0) as android.graphics.drawable.Drawable;
		}
		static DynamicDrawableSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.DynamicDrawableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/DynamicDrawableSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
