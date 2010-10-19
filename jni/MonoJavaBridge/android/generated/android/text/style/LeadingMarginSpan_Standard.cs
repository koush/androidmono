namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LeadingMarginSpan_Standard : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LeadingMarginSpan_Standard()
		{
			InitJNI();
		}
		protected LeadingMarginSpan_Standard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8829;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard._writeToParcel8829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._writeToParcel8829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8830;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard._describeContents8830);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._describeContents8830);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8831;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId8831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId8831);
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin8832;
		public virtual int getLeadingMargin(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin8832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin8832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin8833;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin8833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin8833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _LeadingMarginSpan_Standard8834;
		public LeadingMarginSpan_Standard(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard8834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LeadingMarginSpan_Standard8835;
		public LeadingMarginSpan_Standard(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard8835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LeadingMarginSpan_Standard8836;
		public LeadingMarginSpan_Standard(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard8836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LeadingMarginSpan_Standard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LeadingMarginSpan_Standard"));
			global::android.text.style.LeadingMarginSpan_Standard._writeToParcel8829 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.LeadingMarginSpan_Standard._describeContents8830 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "describeContents", "()I");
			global::android.text.style.LeadingMarginSpan_Standard._getSpanTypeId8831 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.LeadingMarginSpan_Standard._getLeadingMargin8832 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.LeadingMarginSpan_Standard._drawLeadingMargin8833 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard8834 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(II)V");
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard8835 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(I)V");
			global::android.text.style.LeadingMarginSpan_Standard._LeadingMarginSpan_Standard8836 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
