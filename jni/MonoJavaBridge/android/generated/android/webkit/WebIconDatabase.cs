namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class WebIconDatabase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebIconDatabase()
		{
			InitJNI();
		}
		internal WebIconDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.WebIconDatabase.IconListener_))]
		public partial interface IconListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebIconDatabase.IconListener))]
		internal sealed partial class IconListener_ : java.lang.Object, IconListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IconListener_()
			{
				InitJNI();
			}
			internal IconListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onReceivedIcon16160;
			void android.webkit.WebIconDatabase.IconListener.onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon16160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.IconListener_.staticClass, global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon16160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebIconDatabase.IconListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase$IconListener"));
				global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon16160 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.IconListener_.staticClass, "onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			}
		}

		public delegate void IconListenerDelegate(java.lang.String arg0, android.graphics.Bitmap arg1);

		internal partial class IconListenerDelegateWrapper : java.lang.Object, IconListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IconListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected IconListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _IconListenerDelegateWrapper16161;
			public IconListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebIconDatabase.IconListenerDelegateWrapper.staticClass, global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper._IconListenerDelegateWrapper16161);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase_IconListenerDelegateWrapper"));
				global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper._IconListenerDelegateWrapper16161 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class IconListenerDelegateWrapper
		{
			private IconListenerDelegate myDelegate;
			public void onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator IconListenerDelegateWrapper(IconListenerDelegate d)
			{
				global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper ret = new global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public static global::android.webkit.WebIconDatabase Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16162;
		public static global::android.webkit.WebIconDatabase getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebIconDatabase>(@__env.CallStaticObjectMethod(android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._getInstance16162)) as android.webkit.WebIconDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _close16163;
		public void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._close16163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._close16163);
		}
		internal static global::MonoJavaBridge.MethodId _open16164;
		public void open(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._open16164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._open16164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllIcons16165;
		public void removeAllIcons()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._removeAllIcons16165);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._removeAllIcons16165);
		}
		internal static global::MonoJavaBridge.MethodId _requestIconForPageUrl16166;
		public void requestIconForPageUrl(java.lang.String arg0, android.webkit.WebIconDatabase.IconListener arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._requestIconForPageUrl16166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._requestIconForPageUrl16166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void requestIconForPageUrl(java.lang.String arg0, global::android.webkit.WebIconDatabase.IconListenerDelegate arg1)
		{
			requestIconForPageUrl(arg0, (global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _retainIconForPageUrl16167;
		public void retainIconForPageUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._retainIconForPageUrl16167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._retainIconForPageUrl16167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _releaseIconForPageUrl16168;
		public void releaseIconForPageUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._releaseIconForPageUrl16168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._releaseIconForPageUrl16168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebIconDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase"));
			global::android.webkit.WebIconDatabase._getInstance16162 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "getInstance", "()Landroid/webkit/WebIconDatabase;");
			global::android.webkit.WebIconDatabase._close16163 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "close", "()V");
			global::android.webkit.WebIconDatabase._open16164 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "open", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._removeAllIcons16165 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "removeAllIcons", "()V");
			global::android.webkit.WebIconDatabase._requestIconForPageUrl16166 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			global::android.webkit.WebIconDatabase._retainIconForPageUrl16167 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "retainIconForPageUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._releaseIconForPageUrl16168 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "releaseIconForPageUrl", "(Ljava/lang/String;)V");
		}
	}
}
