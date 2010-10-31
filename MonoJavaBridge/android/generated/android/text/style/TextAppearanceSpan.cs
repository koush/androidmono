namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextAppearanceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextAppearanceSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.TextAppearanceSpan._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "describeContents", "()I", ref global::android.text.style.TextAppearanceSpan._m1);
		}
		public new int TextSize
		{
			get
			{
				return getTextSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getTextSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "getTextSize", "()I", ref global::android.text.style.TextAppearanceSpan._m2);
		}
		public new global::android.content.res.ColorStateList TextColor
		{
			get
			{
				return getTextColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.content.res.ColorStateList getTextColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "getTextColor", "()Landroid/content/res/ColorStateList;", ref global::android.text.style.TextAppearanceSpan._m3) as android.content.res.ColorStateList;
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.TextAppearanceSpan._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.TextAppearanceSpan._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.TextAppearanceSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Family
		{
			get
			{
				return getFamily();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.style.TextAppearanceSpan.staticClass, "getFamily", "()Ljava/lang/String;", ref global::android.text.style.TextAppearanceSpan._m7) as java.lang.String;
		}
		public new global::android.content.res.ColorStateList LinkTextColor
		{
			get
			{
				return getLinkTextColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.content.res.ColorStateList getLinkTextColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "getLinkTextColor", "()Landroid/content/res/ColorStateList;", ref global::android.text.style.TextAppearanceSpan._m8) as android.content.res.ColorStateList;
		}
		public new int TextStyle
		{
			get
			{
				return getTextStyle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getTextStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, "getTextStyle", "()I", ref global::android.text.style.TextAppearanceSpan._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public TextAppearanceSpan(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TextAppearanceSpan._m10.native == global::System.IntPtr.Zero)
				global::android.text.style.TextAppearanceSpan._m10 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public TextAppearanceSpan(java.lang.String arg0, int arg1, int arg2, android.content.res.ColorStateList arg3, android.content.res.ColorStateList arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TextAppearanceSpan._m11.native == global::System.IntPtr.Zero)
				global::android.text.style.TextAppearanceSpan._m11 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public TextAppearanceSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TextAppearanceSpan._m12.native == global::System.IntPtr.Zero)
				global::android.text.style.TextAppearanceSpan._m12 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public TextAppearanceSpan(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TextAppearanceSpan._m13.native == global::System.IntPtr.Zero)
				global::android.text.style.TextAppearanceSpan._m13 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TextAppearanceSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TextAppearanceSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TextAppearanceSpan"));
		}
	}
}
