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
		internal static global::MonoJavaBridge.MethodId _getURL13621;
		public virtual global::java.lang.String getURL()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._getURL13621)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onClick13622;
		public override void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._onClick13622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13623;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._writeToParcel13623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13624;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._describeContents13624);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13625;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._getSpanTypeId13625);
		}
		internal static global::MonoJavaBridge.MethodId _URLSpan13626;
		public URLSpan(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._URLSpan13626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URLSpan13627;
		public URLSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._URLSpan13627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static URLSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.URLSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/URLSpan"));
			global::android.text.style.URLSpan._getURL13621 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "getURL", "()Ljava/lang/String;");
			global::android.text.style.URLSpan._onClick13622 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.text.style.URLSpan._writeToParcel13623 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.URLSpan._describeContents13624 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "describeContents", "()I");
			global::android.text.style.URLSpan._getSpanTypeId13625 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.URLSpan._URLSpan13626 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.style.URLSpan._URLSpan13627 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
