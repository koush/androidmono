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
		public interface IconListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebIconDatabase.IconListener))]
		public sealed partial class IconListener_ : java.lang.Object, IconListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IconListener_()
			{
				InitJNI();
			}
			internal IconListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onReceivedIcon16072;
			 void android.webkit.WebIconDatabase.IconListener.onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon16072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.IconListener_.staticClass, global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon16072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebIconDatabase.IconListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase$IconListener"));
				global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon16072 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.IconListener_.staticClass, "onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			}
		}
		public static global::android.webkit.WebIconDatabase Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16073;
		public static global::android.webkit.WebIconDatabase getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._getInstance16073)) as android.webkit.WebIconDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _close16074;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._close16074);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._close16074);
		}
		internal static global::MonoJavaBridge.MethodId _open16075;
		public void open(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._open16075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._open16075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllIcons16076;
		public void removeAllIcons() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._removeAllIcons16076);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._removeAllIcons16076);
		}
		internal static global::MonoJavaBridge.MethodId _requestIconForPageUrl16077;
		public void requestIconForPageUrl(java.lang.String arg0, android.webkit.WebIconDatabase.IconListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._requestIconForPageUrl16077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._requestIconForPageUrl16077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _retainIconForPageUrl16078;
		public void retainIconForPageUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._retainIconForPageUrl16078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._retainIconForPageUrl16078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _releaseIconForPageUrl16079;
		public void releaseIconForPageUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._releaseIconForPageUrl16079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._releaseIconForPageUrl16079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebIconDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase"));
			global::android.webkit.WebIconDatabase._getInstance16073 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "getInstance", "()Landroid/webkit/WebIconDatabase;");
			global::android.webkit.WebIconDatabase._close16074 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "close", "()V");
			global::android.webkit.WebIconDatabase._open16075 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "open", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._removeAllIcons16076 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "removeAllIcons", "()V");
			global::android.webkit.WebIconDatabase._requestIconForPageUrl16077 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			global::android.webkit.WebIconDatabase._retainIconForPageUrl16078 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "retainIconForPageUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._releaseIconForPageUrl16079 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "releaseIconForPageUrl", "(Ljava/lang/String;)V");
		}
	}
}
