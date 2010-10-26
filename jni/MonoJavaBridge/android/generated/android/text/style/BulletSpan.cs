namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BulletSpan : java.lang.Object, LeadingMarginSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BulletSpan()
		{
			InitJNI();
		}
		protected BulletSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13449;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.BulletSpan._writeToParcel13449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._writeToParcel13449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13450;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BulletSpan._describeContents13450);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._describeContents13450);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13451;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BulletSpan._getSpanTypeId13451);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._getSpanTypeId13451);
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin13452;
		public virtual int getLeadingMargin(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BulletSpan._getLeadingMargin13452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._getLeadingMargin13452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin13453;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.BulletSpan._drawLeadingMargin13453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._drawLeadingMargin13453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _BulletSpan13454;
		public BulletSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._BulletSpan13454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BulletSpan13455;
		public BulletSpan(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._BulletSpan13455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BulletSpan13456;
		public BulletSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._BulletSpan13456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BulletSpan13457;
		public BulletSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BulletSpan.staticClass, global::android.text.style.BulletSpan._BulletSpan13457);
			Init(@__env, handle);
		}
		public static int STANDARD_GAP_WIDTH
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.BulletSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/BulletSpan"));
			global::android.text.style.BulletSpan._writeToParcel13449 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.BulletSpan._describeContents13450 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "describeContents", "()I");
			global::android.text.style.BulletSpan._getSpanTypeId13451 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.BulletSpan._getLeadingMargin13452 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.BulletSpan._drawLeadingMargin13453 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::android.text.style.BulletSpan._BulletSpan13454 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.BulletSpan._BulletSpan13455 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "<init>", "(II)V");
			global::android.text.style.BulletSpan._BulletSpan13456 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.text.style.BulletSpan._BulletSpan13457 = @__env.GetMethodIDNoThrow(global::android.text.style.BulletSpan.staticClass, "<init>", "()V");
		}
	}
}
