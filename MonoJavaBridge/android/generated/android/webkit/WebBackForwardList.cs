namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebBackForwardList : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebBackForwardList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone16123;
		protected virtual global::android.webkit.WebBackForwardList clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebBackForwardList._clone16123.native == global::System.IntPtr.Zero)
				global::android.webkit.WebBackForwardList._clone16123 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "clone", "()Landroid/webkit/WebBackForwardList;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._clone16123) as android.webkit.WebBackForwardList;
		}
		public new int Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize16124;
		public virtual int getSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebBackForwardList._getSize16124.native == global::System.IntPtr.Zero)
				global::android.webkit.WebBackForwardList._getSize16124 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getSize16124);
		}
		public new global::android.webkit.WebHistoryItem CurrentItem
		{
			get
			{
				return getCurrentItem();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentItem16125;
		public virtual global::android.webkit.WebHistoryItem getCurrentItem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebBackForwardList._getCurrentItem16125.native == global::System.IntPtr.Zero)
				global::android.webkit.WebBackForwardList._getCurrentItem16125 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getCurrentItem", "()Landroid/webkit/WebHistoryItem;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentItem16125) as android.webkit.WebHistoryItem;
		}
		public new int CurrentIndex
		{
			get
			{
				return getCurrentIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentIndex16126;
		public virtual int getCurrentIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebBackForwardList._getCurrentIndex16126.native == global::System.IntPtr.Zero)
				global::android.webkit.WebBackForwardList._getCurrentIndex16126 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getCurrentIndex", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentIndex16126);
		}
		internal static global::MonoJavaBridge.MethodId _getItemAtIndex16127;
		public virtual global::android.webkit.WebHistoryItem getItemAtIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebBackForwardList._getItemAtIndex16127.native == global::System.IntPtr.Zero)
				global::android.webkit.WebBackForwardList._getItemAtIndex16127 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getItemAtIndex16127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.webkit.WebHistoryItem;
		}
		static WebBackForwardList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebBackForwardList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebBackForwardList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
