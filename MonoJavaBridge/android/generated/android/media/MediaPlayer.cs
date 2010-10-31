namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MediaPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnBufferingUpdateListener_))]
		public partial interface OnBufferingUpdateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onBufferingUpdate(android.media.MediaPlayer arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnBufferingUpdateListener))]
		internal sealed partial class OnBufferingUpdateListener_ : java.lang.Object, OnBufferingUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnBufferingUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaPlayer.OnBufferingUpdateListener.onBufferingUpdate(android.media.MediaPlayer arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", ref global::android.media.MediaPlayer.OnBufferingUpdateListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnBufferingUpdateListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnBufferingUpdateListener"));
			}
		}

		public delegate void OnBufferingUpdateListenerDelegate(android.media.MediaPlayer arg0, int arg1);

		internal partial class OnBufferingUpdateListenerDelegateWrapper : java.lang.Object, OnBufferingUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnBufferingUpdateListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnBufferingUpdateListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnBufferingUpdateListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnBufferingUpdateListenerDelegateWrapper"));
			}
		}
		internal partial class OnBufferingUpdateListenerDelegateWrapper
		{
			private OnBufferingUpdateListenerDelegate myDelegate;
			public void onBufferingUpdate(android.media.MediaPlayer arg0, int arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnBufferingUpdateListenerDelegateWrapper(OnBufferingUpdateListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnCompletionListener_))]
		public partial interface OnCompletionListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCompletion(android.media.MediaPlayer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnCompletionListener))]
		internal sealed partial class OnCompletionListener_ : java.lang.Object, OnCompletionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnCompletionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaPlayer.OnCompletionListener.onCompletion(android.media.MediaPlayer arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.OnCompletionListener_.staticClass, "onCompletion", "(Landroid/media/MediaPlayer;)V", ref global::android.media.MediaPlayer.OnCompletionListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnCompletionListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnCompletionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnCompletionListener"));
			}
		}

		public delegate void OnCompletionListenerDelegate(android.media.MediaPlayer arg0);

		internal partial class OnCompletionListenerDelegateWrapper : java.lang.Object, OnCompletionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCompletionListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnCompletionListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnCompletionListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnCompletionListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnCompletionListenerDelegateWrapper"));
			}
		}
		internal partial class OnCompletionListenerDelegateWrapper
		{
			private OnCompletionListenerDelegate myDelegate;
			public void onCompletion(android.media.MediaPlayer arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnCompletionListenerDelegateWrapper(OnCompletionListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnErrorListener_))]
		public partial interface OnErrorListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onError(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnErrorListener))]
		internal sealed partial class OnErrorListener_ : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnErrorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.media.MediaPlayer.OnErrorListener.onError(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaPlayer.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaPlayer;II)Z", ref global::android.media.MediaPlayer.OnErrorListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnErrorListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnErrorListener"));
			}
		}

		public delegate bool OnErrorListenerDelegate(android.media.MediaPlayer arg0, int arg1, int arg2);

		internal partial class OnErrorListenerDelegateWrapper : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnErrorListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnErrorListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnErrorListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnErrorListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnErrorListenerDelegateWrapper"));
			}
		}
		internal partial class OnErrorListenerDelegateWrapper
		{
			private OnErrorListenerDelegate myDelegate;
			public bool onError(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnErrorListenerDelegateWrapper(OnErrorListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnInfoListener_))]
		public partial interface OnInfoListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onInfo(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnInfoListener))]
		internal sealed partial class OnInfoListener_ : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnInfoListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.media.MediaPlayer.OnInfoListener.onInfo(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaPlayer.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaPlayer;II)Z", ref global::android.media.MediaPlayer.OnInfoListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnInfoListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnInfoListener"));
			}
		}

		public delegate bool OnInfoListenerDelegate(android.media.MediaPlayer arg0, int arg1, int arg2);

		internal partial class OnInfoListenerDelegateWrapper : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnInfoListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnInfoListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnInfoListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnInfoListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnInfoListenerDelegateWrapper"));
			}
		}
		internal partial class OnInfoListenerDelegateWrapper
		{
			private OnInfoListenerDelegate myDelegate;
			public bool onInfo(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnInfoListenerDelegateWrapper(OnInfoListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnPreparedListener_))]
		public partial interface OnPreparedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onPrepared(android.media.MediaPlayer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnPreparedListener))]
		internal sealed partial class OnPreparedListener_ : java.lang.Object, OnPreparedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnPreparedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaPlayer.OnPreparedListener.onPrepared(android.media.MediaPlayer arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.OnPreparedListener_.staticClass, "onPrepared", "(Landroid/media/MediaPlayer;)V", ref global::android.media.MediaPlayer.OnPreparedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnPreparedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnPreparedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnPreparedListener"));
			}
		}

		public delegate void OnPreparedListenerDelegate(android.media.MediaPlayer arg0);

		internal partial class OnPreparedListenerDelegateWrapper : java.lang.Object, OnPreparedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnPreparedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnPreparedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnPreparedListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnPreparedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnPreparedListenerDelegateWrapper"));
			}
		}
		internal partial class OnPreparedListenerDelegateWrapper
		{
			private OnPreparedListenerDelegate myDelegate;
			public void onPrepared(android.media.MediaPlayer arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnPreparedListenerDelegateWrapper(OnPreparedListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnSeekCompleteListener_))]
		public partial interface OnSeekCompleteListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onSeekComplete(android.media.MediaPlayer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnSeekCompleteListener))]
		internal sealed partial class OnSeekCompleteListener_ : java.lang.Object, OnSeekCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnSeekCompleteListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaPlayer.OnSeekCompleteListener.onSeekComplete(android.media.MediaPlayer arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass, "onSeekComplete", "(Landroid/media/MediaPlayer;)V", ref global::android.media.MediaPlayer.OnSeekCompleteListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnSeekCompleteListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnSeekCompleteListener"));
			}
		}

		public delegate void OnSeekCompleteListenerDelegate(android.media.MediaPlayer arg0);

		internal partial class OnSeekCompleteListenerDelegateWrapper : java.lang.Object, OnSeekCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnSeekCompleteListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnSeekCompleteListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnSeekCompleteListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnSeekCompleteListenerDelegateWrapper"));
			}
		}
		internal partial class OnSeekCompleteListenerDelegateWrapper
		{
			private OnSeekCompleteListenerDelegate myDelegate;
			public void onSeekComplete(android.media.MediaPlayer arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnSeekCompleteListenerDelegateWrapper(OnSeekCompleteListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnVideoSizeChangedListener_))]
		public partial interface OnVideoSizeChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnVideoSizeChangedListener))]
		internal sealed partial class OnVideoSizeChangedListener_ : java.lang.Object, OnVideoSizeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnVideoSizeChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaPlayer.OnVideoSizeChangedListener.onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", ref global::android.media.MediaPlayer.OnVideoSizeChangedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnVideoSizeChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnVideoSizeChangedListener"));
			}
		}

		public delegate void OnVideoSizeChangedListenerDelegate(android.media.MediaPlayer arg0, int arg1, int arg2);

		internal partial class OnVideoSizeChangedListenerDelegateWrapper : java.lang.Object, OnVideoSizeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnVideoSizeChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnVideoSizeChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnVideoSizeChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnVideoSizeChangedListenerDelegateWrapper"));
			}
		}
		internal partial class OnVideoSizeChangedListenerDelegateWrapper
		{
			private OnVideoSizeChangedListenerDelegate myDelegate;
			public void onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnVideoSizeChangedListenerDelegateWrapper(OnVideoSizeChangedListenerDelegate d)
			{
				global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper ret = new global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "finalize", "()V", ref global::android.media.MediaPlayer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "start", "()V", ref global::android.media.MediaPlayer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "stop", "()V", ref global::android.media.MediaPlayer._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "reset", "()V", ref global::android.media.MediaPlayer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "release", "()V", ref global::android.media.MediaPlayer._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1, android.view.SurfaceHolder arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaPlayer._m5.native == global::System.IntPtr.Zero)
				global::android.media.MediaPlayer._m5 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/media/MediaPlayer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.media.MediaPlayer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaPlayer._m6.native == global::System.IntPtr.Zero)
				global::android.media.MediaPlayer._m6 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaPlayer._m7.native == global::System.IntPtr.Zero)
				global::android.media.MediaPlayer._m7 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void prepare()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "prepare", "()V", ref global::android.media.MediaPlayer._m8);
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, "getDuration", "()I", ref global::android.media.MediaPlayer._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void pause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "pause", "()V", ref global::android.media.MediaPlayer._m10);
		}
		public new global::android.view.SurfaceHolder Display
		{
			set
			{
				setDisplay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setDisplay(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V", ref global::android.media.MediaPlayer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setDataSource(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/lang/String;)V", ref global::android.media.MediaPlayer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setDataSource(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;)V", ref global::android.media.MediaPlayer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setDataSource(java.io.FileDescriptor arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;JJ)V", ref global::android.media.MediaPlayer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setDataSource(android.content.Context arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", ref global::android.media.MediaPlayer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void prepareAsync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "prepareAsync", "()V", ref global::android.media.MediaPlayer._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setWakeMode(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setWakeMode", "(Landroid/content/Context;I)V", ref global::android.media.MediaPlayer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool ScreenOnWhilePlaying
		{
			set
			{
				setScreenOnWhilePlaying(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setScreenOnWhilePlaying(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setScreenOnWhilePlaying", "(Z)V", ref global::android.media.MediaPlayer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VideoWidth
		{
			get
			{
				return getVideoWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getVideoWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, "getVideoWidth", "()I", ref global::android.media.MediaPlayer._m19);
		}
		public new int VideoHeight
		{
			get
			{
				return getVideoHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getVideoHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, "getVideoHeight", "()I", ref global::android.media.MediaPlayer._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isPlaying()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaPlayer.staticClass, "isPlaying", "()Z", ref global::android.media.MediaPlayer._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void seekTo(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "seekTo", "(I)V", ref global::android.media.MediaPlayer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getCurrentPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, "getCurrentPosition", "()I", ref global::android.media.MediaPlayer._m23);
		}
		public new int AudioStreamType
		{
			set
			{
				setAudioStreamType(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setAudioStreamType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setAudioStreamType", "(I)V", ref global::android.media.MediaPlayer._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Looping
		{
			set
			{
				setLooping(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setLooping(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setLooping", "(Z)V", ref global::android.media.MediaPlayer._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool isLooping()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaPlayer.staticClass, "isLooping", "()Z", ref global::android.media.MediaPlayer._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setVolume(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setVolume", "(FF)V", ref global::android.media.MediaPlayer._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", ref global::android.media.MediaPlayer._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreparedListener(global::android.media.MediaPlayer.OnPreparedListenerDelegate arg0)
		{
			setOnPreparedListener((global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", ref global::android.media.MediaPlayer._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCompletionListener(global::android.media.MediaPlayer.OnCompletionListenerDelegate arg0)
		{
			setOnCompletionListener((global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setOnBufferingUpdateListener(android.media.MediaPlayer.OnBufferingUpdateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V", ref global::android.media.MediaPlayer._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnBufferingUpdateListener(global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegate arg0)
		{
			setOnBufferingUpdateListener((global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setOnSeekCompleteListener(android.media.MediaPlayer.OnSeekCompleteListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V", ref global::android.media.MediaPlayer._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnSeekCompleteListener(global::android.media.MediaPlayer.OnSeekCompleteListenerDelegate arg0)
		{
			setOnSeekCompleteListener((global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setOnVideoSizeChangedListener(android.media.MediaPlayer.OnVideoSizeChangedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V", ref global::android.media.MediaPlayer._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnVideoSizeChangedListener(global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegate arg0)
		{
			setOnVideoSizeChangedListener((global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", ref global::android.media.MediaPlayer._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnErrorListener(global::android.media.MediaPlayer.OnErrorListenerDelegate arg0)
		{
			setOnErrorListener((global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setOnInfoListener(android.media.MediaPlayer.OnInfoListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V", ref global::android.media.MediaPlayer._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnInfoListener(global::android.media.MediaPlayer.OnInfoListenerDelegate arg0)
		{
			setOnInfoListener((global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public MediaPlayer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaPlayer._m35.native == global::System.IntPtr.Zero)
				global::android.media.MediaPlayer._m35 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._m35);
			Init(@__env, handle);
		}
		public static int MEDIA_ERROR_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int MEDIA_ERROR_SERVER_DIED
		{
			get
			{
				return 100;
			}
		}
		public static int MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK
		{
			get
			{
				return 200;
			}
		}
		public static int MEDIA_INFO_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int MEDIA_INFO_VIDEO_TRACK_LAGGING
		{
			get
			{
				return 700;
			}
		}
		public static int MEDIA_INFO_BAD_INTERLEAVING
		{
			get
			{
				return 800;
			}
		}
		public static int MEDIA_INFO_NOT_SEEKABLE
		{
			get
			{
				return 801;
			}
		}
		public static int MEDIA_INFO_METADATA_UPDATE
		{
			get
			{
				return 802;
			}
		}
		static MediaPlayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer"));
		}
	}
}
