namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLSpan : android.text.style.ClickableSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String URL
		{
			get
			{
				return getURL();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.style.URLSpan.staticClass, "getURL", "()Ljava/lang/String;", ref global::android.text.style.URLSpan._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.URLSpan.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.text.style.URLSpan._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.URLSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.URLSpan._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.URLSpan.staticClass, "describeContents", "()I", ref global::android.text.style.URLSpan._m3);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.URLSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.URLSpan._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public URLSpan(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.URLSpan._m5.native == global::System.IntPtr.Zero)
				global::android.text.style.URLSpan._m5 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public URLSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.URLSpan._m6.native == global::System.IntPtr.Zero)
				global::android.text.style.URLSpan._m6 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static URLSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.URLSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/URLSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
