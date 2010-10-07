namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TextAppearanceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static TextAppearanceSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.TextAppearanceSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.TextAppearanceSpan(@__env);
			}
		}
		protected TextAppearanceSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8067;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.TextAppearanceSpan._writeToParcel8067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._writeToParcel8067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8068;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TextAppearanceSpan._describeContents8068);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._describeContents8068);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize8069;
		public virtual int getTextSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TextAppearanceSpan._getTextSize8069);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextSize8069);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextColor8070;
		public virtual global::android.content.res.ColorStateList getTextColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.TextAppearanceSpan._getTextColor8070));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextColor8070));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8071;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TextAppearanceSpan._getSpanTypeId8071);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getSpanTypeId8071);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8072;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.TextAppearanceSpan._updateDrawState8072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._updateDrawState8072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState8073;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.TextAppearanceSpan._updateMeasureState8073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._updateMeasureState8073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFamily8074;
		public virtual global::java.lang.String getFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.TextAppearanceSpan._getFamily8074));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getFamily8074));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLinkTextColor8075;
		public virtual global::android.content.res.ColorStateList getLinkTextColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.TextAppearanceSpan._getLinkTextColor8075));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getLinkTextColor8075));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextStyle8076;
		public virtual int getTextStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TextAppearanceSpan._getTextStyle8076);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._getTextStyle8076);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan8077;
		public TextAppearanceSpan(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8077, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan8078;
		public TextAppearanceSpan(java.lang.String arg0, int arg1, int arg2, android.content.res.ColorStateList arg3, android.content.res.ColorStateList arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8078, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan8079;
		public TextAppearanceSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8079, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan8080;
		public TextAppearanceSpan(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8080, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.TextAppearanceSpan.staticClass = @__class;
			global::android.text.style.TextAppearanceSpan._writeToParcel8067 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.TextAppearanceSpan._describeContents8068 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "describeContents", "()I");
			global::android.text.style.TextAppearanceSpan._getTextSize8069 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getTextSize", "()I");
			global::android.text.style.TextAppearanceSpan._getTextColor8070 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getTextColor", "()Landroid/content/res/ColorStateList;");
			global::android.text.style.TextAppearanceSpan._getSpanTypeId8071 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.TextAppearanceSpan._updateDrawState8072 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TextAppearanceSpan._updateMeasureState8073 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TextAppearanceSpan._getFamily8074 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getFamily", "()Ljava/lang/String;");
			global::android.text.style.TextAppearanceSpan._getLinkTextColor8075 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getLinkTextColor", "()Landroid/content/res/ColorStateList;");
			global::android.text.style.TextAppearanceSpan._getTextStyle8076 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getTextStyle", "()I");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8077 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8078 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8079 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan8080 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
