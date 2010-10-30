namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaScannerConnection : java.lang.Object, android.content.ServiceConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MediaScannerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_))]
		public partial interface MediaScannerConnectionClient : OnScanCompletedListener
		{
			void onMediaScannerConnected();
			void onScanCompleted(java.lang.String arg0, android.net.Uri arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaScannerConnection.MediaScannerConnectionClient))]
		internal sealed partial class MediaScannerConnectionClient_ : java.lang.Object, MediaScannerConnectionClient
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MediaScannerConnectionClient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaScannerConnection.MediaScannerConnectionClient.onMediaScannerConnected()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onMediaScannerConnected", "()V", ref global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.media.MediaScannerConnection.MediaScannerConnectionClient.onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", ref global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.media.MediaScannerConnection.OnScanCompletedListener.onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", ref global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static MediaScannerConnectionClient_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection$MediaScannerConnectionClient"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaScannerConnection.OnScanCompletedListener_))]
		public partial interface OnScanCompletedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScanCompleted(java.lang.String arg0, android.net.Uri arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaScannerConnection.OnScanCompletedListener))]
		internal sealed partial class OnScanCompletedListener_ : java.lang.Object, OnScanCompletedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnScanCompletedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaScannerConnection.OnScanCompletedListener.onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", ref global::android.media.MediaScannerConnection.OnScanCompletedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnScanCompletedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection$OnScanCompletedListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnScanCompletedListenerDelegate(java.lang.String arg0, android.net.Uri arg1);

		internal partial class OnScanCompletedListenerDelegateWrapper : java.lang.Object, OnScanCompletedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnScanCompletedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnScanCompletedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper.staticClass, global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnScanCompletedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection_OnScanCompletedListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnScanCompletedListenerDelegateWrapper
		{
			private OnScanCompletedListenerDelegate myDelegate;
			public void onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnScanCompletedListenerDelegateWrapper(OnScanCompletedListenerDelegate d)
			{
				global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper ret = new global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, "connect", "()V", ref global::android.media.MediaScannerConnection._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", ref global::android.media.MediaScannerConnection._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onServiceDisconnected(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V", ref global::android.media.MediaScannerConnection._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, "disconnect", "()V", ref global::android.media.MediaScannerConnection._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaScannerConnection.staticClass, "isConnected", "()Z", ref global::android.media.MediaScannerConnection._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void scanFile(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.media.MediaScannerConnection._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void scanFile(android.content.Context arg0, java.lang.String[] arg1, java.lang.String[] arg2, android.media.MediaScannerConnection.OnScanCompletedListener arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaScannerConnection._m6.native == global::System.IntPtr.Zero)
				global::android.media.MediaScannerConnection._m6 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Landroid/media/MediaScannerConnection$OnScanCompletedListener;)V");
			@__env.CallStaticVoidMethod(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static void scanFile(android.content.Context arg0, java.lang.String[] arg1, java.lang.String[] arg2, global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegate arg3)
		{
			scanFile(arg0, arg1, arg2, (global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper)arg3);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public MediaScannerConnection(android.content.Context arg0, android.media.MediaScannerConnection.MediaScannerConnectionClient arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaScannerConnection._m7.native == global::System.IntPtr.Zero)
				global::android.media.MediaScannerConnection._m7 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConnectionClient;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MediaScannerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaScannerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
