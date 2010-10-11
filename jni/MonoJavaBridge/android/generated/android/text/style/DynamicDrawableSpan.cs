namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.DynamicDrawableSpan_))]
	public abstract partial class DynamicDrawableSpan : android.text.style.ReplacementSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DynamicDrawableSpan()
		{
			InitJNI();
		}
		protected DynamicDrawableSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSize8247;
		public override int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan._getSize8247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._getSize8247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public int getSize(android.graphics.Paint arg0, string arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4)
		{
			return getSize(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable8248;
		public abstract global::android.graphics.drawable.Drawable getDrawable();
		internal static global::MonoJavaBridge.MethodId _draw8249;
		public override void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan._draw8249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._draw8249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		public void draw(android.graphics.Canvas arg0, string arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8)
		{
			draw(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalAlignment8250;
		public virtual int getVerticalAlignment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan._getVerticalAlignment8250);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._getVerticalAlignment8250);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicDrawableSpan8251;
		public DynamicDrawableSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan8251);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicDrawableSpan8252;
		protected DynamicDrawableSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DynamicDrawableSpan.staticClass, global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan8252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.DynamicDrawableSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/DynamicDrawableSpan"));
			global::android.text.style.DynamicDrawableSpan._getSize8247 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMetricsInt;)I");
			global::android.text.style.DynamicDrawableSpan._getDrawable8248 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.text.style.DynamicDrawableSpan._draw8249 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)V");
			global::android.text.style.DynamicDrawableSpan._getVerticalAlignment8250 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "getVerticalAlignment", "()I");
			global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan8251 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "()V");
			global::android.text.style.DynamicDrawableSpan._DynamicDrawableSpan8252 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan.staticClass, "<init>", "(I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.DynamicDrawableSpan))]
	public sealed partial class DynamicDrawableSpan_ : android.text.style.DynamicDrawableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DynamicDrawableSpan_()
		{
			InitJNI();
		}
		internal DynamicDrawableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable8253;
		public override global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan_._getDrawable8253)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.DynamicDrawableSpan_.staticClass, global::android.text.style.DynamicDrawableSpan_._getDrawable8253)) as android.graphics.drawable.Drawable;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.DynamicDrawableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/DynamicDrawableSpan"));
			global::android.text.style.DynamicDrawableSpan_._getDrawable8253 = @__env.GetMethodIDNoThrow(global::android.text.style.DynamicDrawableSpan_.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
		}
	}
}
