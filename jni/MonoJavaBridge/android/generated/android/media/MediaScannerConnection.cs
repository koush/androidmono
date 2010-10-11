namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaScannerConnection : java.lang.Object, android.content.ServiceConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MediaScannerConnection()
		{
			InitJNI();
		}
		protected MediaScannerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_))]
		public interface MediaScannerConnectionClient : OnScanCompletedListener
		{
			void onMediaScannerConnected();
			new void onScanCompleted(java.lang.String arg0, android.net.Uri arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaScannerConnection.MediaScannerConnectionClient))]
		public sealed partial class MediaScannerConnectionClient_ : java.lang.Object, MediaScannerConnectionClient
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MediaScannerConnectionClient_()
			{
				InitJNI();
			}
			internal MediaScannerConnectionClient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMediaScannerConnected5055;
			 void android.media.MediaScannerConnection.MediaScannerConnectionClient.onMediaScannerConnected() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onMediaScannerConnected5055);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onMediaScannerConnected5055);
			}
			internal static global::MonoJavaBridge.MethodId _onScanCompleted5056;
			 void android.media.MediaScannerConnection.MediaScannerConnectionClient.onScanCompleted(java.lang.String arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted5056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted5056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onScanCompleted5057;
			 void android.media.MediaScannerConnection.OnScanCompletedListener.onScanCompleted(java.lang.String arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted5057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted5057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection$MediaScannerConnectionClient"));
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onMediaScannerConnected5055 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onMediaScannerConnected", "()V");
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted5056 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
				global::android.media.MediaScannerConnection.MediaScannerConnectionClient_._onScanCompleted5057 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.MediaScannerConnectionClient_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaScannerConnection.OnScanCompletedListener_))]
		public interface OnScanCompletedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScanCompleted(java.lang.String arg0, android.net.Uri arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaScannerConnection.OnScanCompletedListener))]
		public sealed partial class OnScanCompletedListener_ : java.lang.Object, OnScanCompletedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnScanCompletedListener_()
			{
				InitJNI();
			}
			internal OnScanCompletedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScanCompleted5058;
			 void android.media.MediaScannerConnection.OnScanCompletedListener.onScanCompleted(java.lang.String arg0, android.net.Uri arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.OnScanCompletedListener_._onScanCompleted5058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass, global::android.media.MediaScannerConnection.OnScanCompletedListener_._onScanCompleted5058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection$OnScanCompletedListener"));
				global::android.media.MediaScannerConnection.OnScanCompletedListener_._onScanCompleted5058 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.OnScanCompletedListener_.staticClass, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _connect5059;
		public virtual void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection._connect5059);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._connect5059);
		}
		internal static global::MonoJavaBridge.MethodId _onServiceConnected5060;
		public virtual void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection._onServiceConnected5060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._onServiceConnected5060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onServiceDisconnected5061;
		public virtual void onServiceDisconnected(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection._onServiceDisconnected5061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._onServiceDisconnected5061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect5062;
		public virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection._disconnect5062);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._disconnect5062);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected5063;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaScannerConnection._isConnected5063);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._isConnected5063);
		}
		internal static global::MonoJavaBridge.MethodId _scanFile5064;
		public virtual void scanFile(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection._scanFile5064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._scanFile5064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scanFile5065;
		public static void scanFile(android.content.Context arg0, java.lang.String[] arg1, java.lang.String[] arg2, android.media.MediaScannerConnection.OnScanCompletedListener arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._scanFile5065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _MediaScannerConnection5066;
		public MediaScannerConnection(android.content.Context arg0, android.media.MediaScannerConnection.MediaScannerConnectionClient arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._MediaScannerConnection5066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaScannerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaScannerConnection"));
			global::android.media.MediaScannerConnection._connect5059 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "connect", "()V");
			global::android.media.MediaScannerConnection._onServiceConnected5060 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");
			global::android.media.MediaScannerConnection._onServiceDisconnected5061 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");
			global::android.media.MediaScannerConnection._disconnect5062 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "disconnect", "()V");
			global::android.media.MediaScannerConnection._isConnected5063 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "isConnected", "()Z");
			global::android.media.MediaScannerConnection._scanFile5064 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.media.MediaScannerConnection._scanFile5065 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Landroid/media/MediaScannerConnection$OnScanCompletedListener;)V");
			global::android.media.MediaScannerConnection._MediaScannerConnection5066 = @__env.GetMethodIDNoThrow(global::android.media.MediaScannerConnection.staticClass, "<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConnectionClient;)V");
		}
	}
}
