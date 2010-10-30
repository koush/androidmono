namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QuoteSpan : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected QuoteSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13533;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._writeToParcel13533.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._writeToParcel13533 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._writeToParcel13533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13534;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._describeContents13534.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._describeContents13534 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._describeContents13534);
		}
		public new int Color
		{
			get
			{
				return getColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColor13535;
		public virtual int getColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._getColor13535.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._getColor13535 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "getColor", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getColor13535);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13536;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._getSpanTypeId13536.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._getSpanTypeId13536 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "getSpanTypeId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getSpanTypeId13536);
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin13537;
		public virtual int getLeadingMargin(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._getLeadingMargin13537.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._getLeadingMargin13537 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "getLeadingMargin", "(Z)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._getLeadingMargin13537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin13538;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._drawLeadingMargin13538.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._drawLeadingMargin13538 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._drawLeadingMargin13538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _QuoteSpan13539;
		public QuoteSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._QuoteSpan13539.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._QuoteSpan13539 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan13539);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuoteSpan13540;
		public QuoteSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._QuoteSpan13540.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._QuoteSpan13540 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan13540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _QuoteSpan13541;
		public QuoteSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.QuoteSpan._QuoteSpan13541.native == global::System.IntPtr.Zero)
				global::android.text.style.QuoteSpan._QuoteSpan13541 = @__env.GetMethodIDNoThrow(global::android.text.style.QuoteSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.QuoteSpan.staticClass, global::android.text.style.QuoteSpan._QuoteSpan13541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static QuoteSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.QuoteSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/QuoteSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
