namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebBackForwardList : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebBackForwardList()
		{
			InitJNI();
		}
		protected WebBackForwardList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone10936;
		protected virtual global::android.webkit.WebBackForwardList clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebBackForwardList._clone10936)) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._clone10936)) as android.webkit.WebBackForwardList;
		}
		public new int Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize10937;
		public virtual int getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebBackForwardList._getSize10937);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getSize10937);
		}
		public new global::android.webkit.WebHistoryItem CurrentItem
		{
			get
			{
				return getCurrentItem();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentItem10938;
		public virtual global::android.webkit.WebHistoryItem getCurrentItem() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebBackForwardList._getCurrentItem10938)) as android.webkit.WebHistoryItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentItem10938)) as android.webkit.WebHistoryItem;
		}
		public new int CurrentIndex
		{
			get
			{
				return getCurrentIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentIndex10939;
		public virtual int getCurrentIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebBackForwardList._getCurrentIndex10939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getCurrentIndex10939);
		}
		internal static global::MonoJavaBridge.MethodId _getItemAtIndex10940;
		public virtual global::android.webkit.WebHistoryItem getItemAtIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebBackForwardList._getItemAtIndex10940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebHistoryItem;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebBackForwardList.staticClass, global::android.webkit.WebBackForwardList._getItemAtIndex10940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebHistoryItem;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebBackForwardList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebBackForwardList"));
			global::android.webkit.WebBackForwardList._clone10936 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "clone", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebBackForwardList._getSize10937 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getSize", "()I");
			global::android.webkit.WebBackForwardList._getCurrentItem10938 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getCurrentItem", "()Landroid/webkit/WebHistoryItem;");
			global::android.webkit.WebBackForwardList._getCurrentIndex10939 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getCurrentIndex", "()I");
			global::android.webkit.WebBackForwardList._getItemAtIndex10940 = @__env.GetMethodIDNoThrow(global::android.webkit.WebBackForwardList.staticClass, "getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;");
		}
	}
}
