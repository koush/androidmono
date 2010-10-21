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
		internal static global::MonoJavaBridge.MethodId _clone16066;
		protected virtual global::android.webkit.WebHistoryItem clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._clone16066)) as android.webkit.WebHistoryItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._clone16066)) as android.webkit.WebHistoryItem;
		}
		public new int Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId16067;
		public virtual int getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getId16067);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getId16067);
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle16068;
		public virtual global::java.lang.String getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getTitle16068)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getTitle16068)) as java.lang.String;
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl16069;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getUrl16069)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getUrl16069)) as java.lang.String;
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl16070;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getOriginalUrl16070)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getOriginalUrl16070)) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon16071;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem._getFavicon16071)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getFavicon16071)) as android.graphics.Bitmap;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebHistoryItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebHistoryItem"));
			global::android.webkit.WebHistoryItem._clone16066 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;");
			global::android.webkit.WebHistoryItem._getId16067 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getId", "()I");
			global::android.webkit.WebHistoryItem._getTitle16068 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getUrl16069 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getOriginalUrl16070 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getFavicon16071 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
		}
	}
}
