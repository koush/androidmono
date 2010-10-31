namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebBackForwardList : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebBackForwardList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::android.webkit.WebBackForwardList clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebBackForwardList.staticClass, "clone", "()Landroid/webkit/WebBackForwardList;", ref global::android.webkit.WebBackForwardList._m0) as android.webkit.WebBackForwardList;
		}
		public new int Size
		{
			get
			{
				return getSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, "getSize", "()I", ref global::android.webkit.WebBackForwardList._m1);
		}
		public new global::android.webkit.WebHistoryItem CurrentItem
		{
			get
			{
				return getCurrentItem();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.webkit.WebHistoryItem getCurrentItem()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebBackForwardList.staticClass, "getCurrentItem", "()Landroid/webkit/WebHistoryItem;", ref global::android.webkit.WebBackForwardList._m2) as android.webkit.WebHistoryItem;
		}
		public new int CurrentIndex
		{
			get
			{
				return getCurrentIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getCurrentIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, "getCurrentIndex", "()I", ref global::android.webkit.WebBackForwardList._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.webkit.WebHistoryItem getItemAtIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebBackForwardList.staticClass, "getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;", ref global::android.webkit.WebBackForwardList._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.webkit.WebHistoryItem;
		}
		static WebBackForwardList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebBackForwardList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebBackForwardList"));
		}
	}
}
