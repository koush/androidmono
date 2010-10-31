namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebHistoryItem : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebHistoryItem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::android.webkit.WebHistoryItem clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebHistoryItem.staticClass, "clone", "()Landroid/webkit/WebHistoryItem;", ref global::android.webkit.WebHistoryItem._m0) as android.webkit.WebHistoryItem;
		}
		public new int Id
		{
			get
			{
				return getId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebHistoryItem.staticClass, "getId", "()I", ref global::android.webkit.WebHistoryItem._m1);
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebHistoryItem.staticClass, "getTitle", "()Ljava/lang/String;", ref global::android.webkit.WebHistoryItem._m2) as java.lang.String;
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebHistoryItem.staticClass, "getUrl", "()Ljava/lang/String;", ref global::android.webkit.WebHistoryItem._m3) as java.lang.String;
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getOriginalUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebHistoryItem.staticClass, "getOriginalUrl", "()Ljava/lang/String;", ref global::android.webkit.WebHistoryItem._m4) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.graphics.Bitmap getFavicon()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.webkit.WebHistoryItem.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;", ref global::android.webkit.WebHistoryItem._m5) as android.graphics.Bitmap;
		}
		static WebHistoryItem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebHistoryItem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebHistoryItem"));
		}
	}
}
