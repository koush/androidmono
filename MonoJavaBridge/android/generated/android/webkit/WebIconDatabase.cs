namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class WebIconDatabase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal IconListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.webkit.WebIconDatabase.IconListener.onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.IconListener_.staticClass, "onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", ref global::android.webkit.WebIconDatabase.IconListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static IconListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebIconDatabase.IconListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase$IconListener"));
			}
		}

		public delegate void IconListenerDelegate(java.lang.String arg0, android.graphics.Bitmap arg1);

		internal partial class IconListenerDelegateWrapper : java.lang.Object, IconListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected IconListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public IconListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebIconDatabase.IconListenerDelegateWrapper.staticClass, global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static IconListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase_IconListenerDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.webkit.WebIconDatabase getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebIconDatabase._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.WebIconDatabase._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "getInstance", "()Landroid/webkit/WebIconDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.WebIconDatabase>(@__env.CallStaticObjectMethod(android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._m0)) as android.webkit.WebIconDatabase;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, "close", "()V", ref global::android.webkit.WebIconDatabase._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void open(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, "open", "(Ljava/lang/String;)V", ref global::android.webkit.WebIconDatabase._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void removeAllIcons()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, "removeAllIcons", "()V", ref global::android.webkit.WebIconDatabase._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void requestIconForPageUrl(java.lang.String arg0, android.webkit.WebIconDatabase.IconListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, "requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V", ref global::android.webkit.WebIconDatabase._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void requestIconForPageUrl(java.lang.String arg0, global::android.webkit.WebIconDatabase.IconListenerDelegate arg1)
		{
			requestIconForPageUrl(arg0, (global::android.webkit.WebIconDatabase.IconListenerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void retainIconForPageUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, "retainIconForPageUrl", "(Ljava/lang/String;)V", ref global::android.webkit.WebIconDatabase._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void releaseIconForPageUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebIconDatabase.staticClass, "releaseIconForPageUrl", "(Ljava/lang/String;)V", ref global::android.webkit.WebIconDatabase._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static WebIconDatabase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebIconDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase"));
		}
	}
}
