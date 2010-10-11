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
		internal static global::MonoJavaBridge.MethodId _writeToParcel8371;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._writeToParcel8371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._writeToParcel8371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8372;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._describeContents8372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._describeContents8372);
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize8373;
		public virtual int getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getTextSize8373);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextSize8373);
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor8374;
		public virtual global::android.content.res.ColorStateList getTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getTextColor8374)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextColor8374)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8375;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getSpanTypeId8375);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getSpanTypeId8375);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8376;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._updateDrawState8376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._updateDrawState8376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8377;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._updateMeasureState8377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._updateMeasureState8377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFamily8378;
		public virtual global::java.lang.String getFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getFamily8378)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getFamily8378)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColor8379;
		public virtual global::android.content.res.ColorStateList getLinkTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getLinkTextColor8379)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getLinkTextColor8379)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getTextStyle8380;
		public virtual int getTextStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan._getTextStyle8380);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextStyle8380);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan8381;
		public TextAppearanceSpan(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan8382;
		public TextAppearanceSpan(java.lang.String arg0, int arg1, int arg2, android.content.res.ColorStateList arg3, android.content.res.ColorStateList arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan8383;
		public TextAppearanceSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextAppearanceSpan8384;
		public TextAppearanceSpan(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TextAppearanceSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TextAppearanceSpan"));
			global::android.text.style.TextAppearanceSpan._writeToParcel8371 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.TextAppearanceSpan._describeContents8372 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "describeContents", "()I");
			global::android.text.style.TextAppearanceSpan._getTextSize8373 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getTextSize", "()I");
			global::android.text.style.TextAppearanceSpan._getTextColor8374 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getTextColor", "()Landroid/content/res/ColorStateList;");
			global::android.text.style.TextAppearanceSpan._getSpanTypeId8375 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.TextAppearanceSpan._updateDrawState8376 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TextAppearanceSpan._updateMeasureState8377 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TextAppearanceSpan._getFamily8378 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getFamily", "()Ljava/lang/String;");
			global::android.text.style.TextAppearanceSpan._getLinkTextColor8379 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getLinkTextColor", "()Landroid/content/res/ColorStateList;");
			global::android.text.style.TextAppearanceSpan._getTextStyle8380 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "getTextStyle", "()I");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8381 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8382 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8383 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8384 = @__env.GetMethodIDNoThrow(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
