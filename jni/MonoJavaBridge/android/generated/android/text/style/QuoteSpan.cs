namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QuoteSpan : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static QuoteSpan()
		{
			InitJNI();
		}
		protected QuoteSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8851;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.QuoteSpan._writeToParcel8851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._writeToParcel8851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8852;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan._describeContents8852);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._describeContents8852);
		}
		public new int Color
		{
			get
			{
				return getColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColor8853;
		public virtual int getColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan._getColor8853);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getColor8853);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8854;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan._getSpanTypeId8854);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getSpanTypeId8854);
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin8855;
		public virtual int getLeadingMargin(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan._getLeadingMargin8855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getLeadingMargin8855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin8856;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.QuoteSpan._drawLeadingMargin8856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._drawLeadingMargin8856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _QuoteSpan8857;
		public QuoteSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan8857);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuoteSpan8858;
		public QuoteSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan8858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuoteSpan8859;
		public QuoteSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan8859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.QuoteSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/QuoteSpan"));
			global::android.text.style.QuoteSpan._writeToParcel8851 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.QuoteSpan._describeContents8852 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "describeContents", "()I");
			global::android.text.style.QuoteSpan._getColor8853 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "getColor", "()I");
			global::android.text.style.QuoteSpan._getSpanTypeId8854 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.QuoteSpan._getLeadingMargin8855 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.QuoteSpan._drawLeadingMargin8856 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::android.text.style.QuoteSpan._QuoteSpan8857 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "<init>", "()V");
			global::android.text.style.QuoteSpan._QuoteSpan8858 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.QuoteSpan._QuoteSpan8859 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
