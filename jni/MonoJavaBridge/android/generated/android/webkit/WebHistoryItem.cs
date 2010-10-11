namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebHistoryItem : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebHistoryItem()
		{
			InitJNI();
		}
		protected WebHistoryItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone10420;
		protected virtual new global::android.webkit.WebHistoryItem clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._clone10420)) as android.webkit.WebHistoryItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._clone10420)) as android.webkit.WebHistoryItem;
		}
		internal static global::MonoJavaBridge.MethodId _getId10421;
		public virtual int getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getId10421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getId10421);
		}
		internal static global::MonoJavaBridge.MethodId _getTitle10422;
		public virtual global::java.lang.String getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getTitle10422)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getTitle10422)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUrl10423;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getUrl10423)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getUrl10423)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl10424;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getOriginalUrl10424)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getOriginalUrl10424)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon10425;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getFavicon10425)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getFavicon10425)) as android.graphics.Bitmap;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebHistoryItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebHistoryItem"));
			global::android.webkit.WebHistoryItem._clone10420 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;");
			global::android.webkit.WebHistoryItem._getId10421 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getId", "()I");
			global::android.webkit.WebHistoryItem._getTitle10422 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getUrl10423 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getOriginalUrl10424 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getFavicon10425 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
		}
	}
}
