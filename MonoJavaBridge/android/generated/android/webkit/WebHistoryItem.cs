namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebHistoryItem : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebHistoryItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone16154;
		protected virtual global::android.webkit.WebHistoryItem clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._clone16154)) as android.webkit.WebHistoryItem;
		}
		public new int Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId16155;
		public virtual int getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getId16155);
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle16156;
		public virtual global::java.lang.String getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getTitle16156)) as java.lang.String;
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl16157;
		public virtual global::java.lang.String getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getUrl16157)) as java.lang.String;
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl16158;
		public virtual global::java.lang.String getOriginalUrl()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getOriginalUrl16158)) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon16159;
		public virtual global::android.graphics.Bitmap getFavicon()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebHistoryItem.staticClass, global::android.webkit.WebHistoryItem._getFavicon16159)) as android.graphics.Bitmap;
		}
		static WebHistoryItem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebHistoryItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebHistoryItem"));
			global::android.webkit.WebHistoryItem._clone16154 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;");
			global::android.webkit.WebHistoryItem._getId16155 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getId", "()I");
			global::android.webkit.WebHistoryItem._getTitle16156 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getUrl16157 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getOriginalUrl16158 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebHistoryItem._getFavicon16159 = @__env.GetMethodIDNoThrow(global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
		}
		internal static void InitJNI()
		{
		}
	}
}
