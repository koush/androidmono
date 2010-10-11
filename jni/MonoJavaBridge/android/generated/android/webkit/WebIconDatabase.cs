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
			internal static global::MonoJavaBridge.MethodId _onReceivedIcon10426;
			 void android.webkit.WebIconDatabase.IconListener.onReceivedIcon(java.lang.String arg0, android.graphics.Bitmap arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon10426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.IconListener_.staticClass, global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon10426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebIconDatabase.IconListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase$IconListener"));
				global::android.webkit.WebIconDatabase.IconListener_._onReceivedIcon10426 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.IconListener_.staticClass, "onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance10427;
		public static global::android.webkit.WebIconDatabase getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._getInstance10427)) as android.webkit.WebIconDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _close10428;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._close10428);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._close10428);
		}
		internal static global::MonoJavaBridge.MethodId _open10429;
		public void open(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._open10429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._open10429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllIcons10430;
		public void removeAllIcons() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._removeAllIcons10430);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._removeAllIcons10430);
		}
		internal static global::MonoJavaBridge.MethodId _requestIconForPageUrl10431;
		public void requestIconForPageUrl(java.lang.String arg0, android.webkit.WebIconDatabase.IconListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._requestIconForPageUrl10431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._requestIconForPageUrl10431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _retainIconForPageUrl10432;
		public void retainIconForPageUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._retainIconForPageUrl10432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._retainIconForPageUrl10432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _releaseIconForPageUrl10433;
		public void releaseIconForPageUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase._releaseIconForPageUrl10433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebIconDatabase.staticClass, global::android.webkit.WebIconDatabase._releaseIconForPageUrl10433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebIconDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebIconDatabase"));
			global::android.webkit.WebIconDatabase._getInstance10427 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "getInstance", "()Landroid/webkit/WebIconDatabase;");
			global::android.webkit.WebIconDatabase._close10428 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "close", "()V");
			global::android.webkit.WebIconDatabase._open10429 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "open", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._removeAllIcons10430 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "removeAllIcons", "()V");
			global::android.webkit.WebIconDatabase._requestIconForPageUrl10431 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V");
			global::android.webkit.WebIconDatabase._retainIconForPageUrl10432 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "retainIconForPageUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebIconDatabase._releaseIconForPageUrl10433 = @__env.GetMethodIDNoThrow(global::android.webkit.WebIconDatabase.staticClass, "releaseIconForPageUrl", "(Ljava/lang/String;)V");
		}
	}
}
