namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLSpan : android.text.style.ClickableSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLSpan()
		{
			InitJNI();
		}
		protected URLSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getURL8393;
		public virtual global::java.lang.String getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.URLSpan._getURL8393)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._getURL8393)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _onClick8394;
		public override void onClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.URLSpan._onClick8394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._onClick8394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8395;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.URLSpan._writeToParcel8395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._writeToParcel8395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8396;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.URLSpan._describeContents8396);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._describeContents8396);
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8397;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.URLSpan._getSpanTypeId8397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._getSpanTypeId8397);
		}
		internal static global::MonoJavaBridge.MethodId _URLSpan8398;
		public URLSpan(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._URLSpan8398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URLSpan8399;
		public URLSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.URLSpan.staticClass, global::android.text.style.URLSpan._URLSpan8399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.URLSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/URLSpan"));
			global::android.text.style.URLSpan._getURL8393 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "getURL", "()Ljava/lang/String;");
			global::android.text.style.URLSpan._onClick8394 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.text.style.URLSpan._writeToParcel8395 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.URLSpan._describeContents8396 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "describeContents", "()I");
			global::android.text.style.URLSpan._getSpanTypeId8397 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.URLSpan._URLSpan8398 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.style.URLSpan._URLSpan8399 = @__env.GetMethodIDNoThrow(global::android.text.style.URLSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
