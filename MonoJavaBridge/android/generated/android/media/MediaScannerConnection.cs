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
			internal static global::MonoJavaBridge.MethodId _onMediaScannerConnected7430;
			void android.media.MediaScannerConnection.MediaScannerConnectionClient.onMediaScannerConnected()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onMediaScannerConnected7430);
			}
			internal static global::MonoJavaBridge.MethodId _onScanCompleted7431;
			void android.media.MediaScannerConnection.MediaScannerConnectionClient.onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted7431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onScanCompleted7432;
			void android.media.MediaScannerConnection.OnScanCompletedListener.onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted7432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static MediaScannerConnectionClient_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection$MediaScannerConnectionClient"));
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onMediaScannerConnected7430 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onMediaScannerConnected", "()V");
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted7431 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted7432 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
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
			internal static global::MonoJavaBridge.MethodId _onScanCompleted7433;
			void android.media.MediaScannerConnection.OnScanCompletedListener.onScanCompleted(java.lang.String arg0, android.net.Uri arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.OnScanCompletedListener_._onScanCompleted7433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnScanCompletedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection$OnScanCompletedListener"));
				global::android.media.MediaScannerConnection.OnScanCompletedListener_._onScanCompleted7433 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
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
			internal static global::MonoJavaBridge.MethodId _OnScanCompletedListenerDelegateWrapper7434;
			public OnScanCompletedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper.staticClass, global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper._OnScanCompletedListenerDelegateWrapper7434);
				Init(@__env, handle);
			}
			static OnScanCompletedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection_OnScanCompletedListenerDelegateWrapper"));
				global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper._OnScanCompletedListenerDelegateWrapper7434 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _connect7435;
		public virtual void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._connect7435);
		}
		internal static global::MonoJavaBridge.MethodId _onServiceConnected7436;
		public virtual void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._onServiceConnected7436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onServiceDisconnected7437;
		public virtual void onServiceDisconnected(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._onServiceDisconnected7437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect7438;
		public virtual void disconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._disconnect7438);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected7439;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._isConnected7439);
		}
		internal static global::MonoJavaBridge.MethodId _scanFile7440;
		public virtual void scanFile(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._scanFile7440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scanFile7441;
		public static void scanFile(android.content.Context arg0, java.lang.String[] arg1, java.lang.String[] arg2, android.media.MediaScannerConnection.OnScanCompletedListener arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._scanFile7441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static void scanFile(android.content.Context arg0, java.lang.String[] arg1, java.lang.String[] arg2, global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegate arg3)
		{
			scanFile(arg0, arg1, arg2, (global::android.media.MediaScannerConnection.OnScanCompletedListenerDelegateWrapper)arg3);
		}
		internal static global::MonoJavaBridge.MethodId _MediaScannerConnection7442;
		public MediaScannerConnection(android.content.Context arg0, android.media.MediaScannerConnection.MediaScannerConnectionClient arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._MediaScannerConnection7442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MediaScannerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaScannerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection"));
			global::android.media.MediaScannerConnection._connect7435 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "connect", "()V");
			global::android.media.MediaScannerConnection._onServiceConnected7436 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");
			global::android.media.MediaScannerConnection._onServiceDisconnected7437 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");
			global::android.media.MediaScannerConnection._disconnect7438 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "disconnect", "()V");
			global::android.media.MediaScannerConnection._isConnected7439 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "isConnected", "()Z");
			global::android.media.MediaScannerConnection._scanFile7440 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.media.MediaScannerConnection._scanFile7441 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Landroid/media/MediaScannerConnection$OnScanCompletedListener;)V");
			global::android.media.MediaScannerConnection._MediaScannerConnection7442 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConnectionClient;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
