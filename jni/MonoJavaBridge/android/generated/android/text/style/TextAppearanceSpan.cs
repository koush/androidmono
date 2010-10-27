namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextAppearanceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextAppearanceSpan()
		{
			InitJNI();
		}
		protected TextAppearanceSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13599;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._writeToParcel13599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._writeToParcel13599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13600;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._describeContents13600);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._describeContents13600);
		}
		public new int TextSize
		{
			get
			{
				return getTextSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize13601;
		public virtual int getTextSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getTextSize13601);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextSize13601);
		}
		public new global::android.content.res.ColorStateList TextColor
		{
			get
			{
				return getTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor13602;
		public virtual global::android.content.res.ColorStateList getTextColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getTextColor13602)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextColor13602)) as android.content.res.ColorStateList;
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13603;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getSpanTypeId13603);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getSpanTypeId13603);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13604;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._updateDrawState13604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._updateDrawState13604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13605;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._updateMeasureState13605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._updateMeasureState13605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Family
		{
			get
			{
				return getFamily();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFamily13606;
		public virtual global::java.lang.String getFamily()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getFamily13606)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getFamily13606)) as java.lang.String;
		}
		public new global::android.content.res.ColorStateList LinkTextColor
		{
			get
			{
				return getLinkTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColor13607;
		public virtual global::android.content.res.ColorStateList getLinkTextColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getLinkTextColor13607)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getLinkTextColor13607)) as android.content.res.ColorStateList;
		}
		public new int TextStyle
		{
			get
			{
				return getTextStyle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextStyle13608;
		public virtual int getTextStyle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getTextStyle13608);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextStyle13608);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan13609;
		public TextAppearanceSpan(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan13610;
		public TextAppearanceSpan(java.lang.String arg0, int arg1, int arg2, android.content.res.ColorStateList arg3, android.content.res.ColorStateList arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan13611;
		public TextAppearanceSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan13612;
		public TextAppearanceSpan(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TextAppearanceSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TextAppearanceSpan"));
			global::android.text.style.TextAppearanceSpan._writeToParcel13599 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.TextAppearanceSpan._describeContents13600 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "describeContents", "()I");
			global::android.text.style.TextAppearanceSpan._getTextSize13601 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getTextSize", "()I");
			global::android.text.style.TextAppearanceSpan._getTextColor13602 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getTextColor", "()Landroid/content/res/ColorStateList;");
			global::android.text.style.TextAppearanceSpan._getSpanTypeId13603 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.TextAppearanceSpan._updateDrawState13604 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TextAppearanceSpan._updateMeasureState13605 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TextAppearanceSpan._getFamily13606 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getFamily", "()Ljava/lang/String;");
			global::android.text.style.TextAppearanceSpan._getLinkTextColor13607 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getLinkTextColor", "()Landroid/content/res/ColorStateList;");
			global::android.text.style.TextAppearanceSpan._getTextStyle13608 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getTextStyle", "()I");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13609 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13610 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13611 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan13612 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
