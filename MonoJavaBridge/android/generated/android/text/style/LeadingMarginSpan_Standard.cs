namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LeadingMarginSpan_Standard : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LeadingMarginSpan_Standard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.LeadingMarginSpan_Standard._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, "describeContents", "()I", ref global::android.text.style.LeadingMarginSpan_Standard._m1);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.LeadingMarginSpan_Standard._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getLeadingMargin(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, "getLeadingMargin", "(Z)I", ref global::android.text.style.LeadingMarginSpan_Standard._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.LeadingMarginSpan_Standard.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V", ref global::android.text.style.LeadingMarginSpan_Standard._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public LeadingMarginSpan_Standard(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.LeadingMarginSpan_Standard._m5.native == global::System.IntPtr.Zero)
				global::android.text.style.LeadingMarginSpan_Standard._m5 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public LeadingMarginSpan_Standard(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.LeadingMarginSpan_Standard._m6.native == global::System.IntPtr.Zero)
				global::android.text.style.LeadingMarginSpan_Standard._m6 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public LeadingMarginSpan_Standard(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.LeadingMarginSpan_Standard._m7.native == global::System.IntPtr.Zero)
				global::android.text.style.LeadingMarginSpan_Standard._m7 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.LeadingMarginSpan_Standard.staticClass, global::android.text.style.LeadingMarginSpan_Standard._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LeadingMarginSpan_Standard()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LeadingMarginSpan_Standard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LeadingMarginSpan$Standard"));
		}
		internal static void InitJNI()
		{
		}
	}
}
