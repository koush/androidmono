namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AbsoluteSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsoluteSizeSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Size
		{
			get
			{
				return getSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I", ref global::android.text.style.AbsoluteSizeSpan._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.AbsoluteSizeSpan._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I", ref global::android.text.style.AbsoluteSizeSpan._m2);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.AbsoluteSizeSpan._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.AbsoluteSizeSpan._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Dip
		{
			get
			{
				return getDip();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool getDip()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z", ref global::android.text.style.AbsoluteSizeSpan._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.AbsoluteSizeSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AbsoluteSizeSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AbsoluteSizeSpan._m7.native == global::System.IntPtr.Zero)
				global::android.text.style.AbsoluteSizeSpan._m7 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AbsoluteSizeSpan(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AbsoluteSizeSpan._m8.native == global::System.IntPtr.Zero)
				global::android.text.style.AbsoluteSizeSpan._m8 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AbsoluteSizeSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AbsoluteSizeSpan._m9.native == global::System.IntPtr.Zero)
				global::android.text.style.AbsoluteSizeSpan._m9 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbsoluteSizeSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AbsoluteSizeSpan"));
		}
	}
}
