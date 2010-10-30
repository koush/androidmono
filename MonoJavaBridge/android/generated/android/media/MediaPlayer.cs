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
			internal static global::MonoJavaBridge.MethodId _onBufferingUpdate7316;
			void android.media.MediaPlayer.OnBufferingUpdateListener.onBufferingUpdate(android.media.MediaPlayer arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate7316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnBufferingUpdateListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnBufferingUpdateListener"));
				global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate7316 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnBufferingUpdateListenerDelegate(android.media.MediaPlayer arg0, int arg1);

		internal partial class OnBufferingUpdateListenerDelegateWrapper : java.lang.Object, OnBufferingUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnBufferingUpdateListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnBufferingUpdateListenerDelegateWrapper7317;
			public OnBufferingUpdateListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper._OnBufferingUpdateListenerDelegateWrapper7317);
				Init(@__env, handle);
			}
			static OnBufferingUpdateListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnBufferingUpdateListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper._OnBufferingUpdateListenerDelegateWrapper7317 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onCompletion7318;
			void android.media.MediaPlayer.OnCompletionListener.onCompletion(android.media.MediaPlayer arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnCompletionListener_._onCompletion7318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnCompletionListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnCompletionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnCompletionListener"));
				global::android.media.MediaPlayer.OnCompletionListener_._onCompletion7318 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnCompletionListener_.staticClass, "onCompletion", "(Landroid/media/MediaPlayer;)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnCompletionListenerDelegate(android.media.MediaPlayer arg0);

		internal partial class OnCompletionListenerDelegateWrapper : java.lang.Object, OnCompletionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCompletionListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnCompletionListenerDelegateWrapper7319;
			public OnCompletionListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnCompletionListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper._OnCompletionListenerDelegateWrapper7319);
				Init(@__env, handle);
			}
			static OnCompletionListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnCompletionListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper._OnCompletionListenerDelegateWrapper7319 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onError7320;
			bool android.media.MediaPlayer.OnErrorListener.onError(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnErrorListener_._onError7320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnErrorListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnErrorListener"));
				global::android.media.MediaPlayer.OnErrorListener_._onError7320 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaPlayer;II)Z");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnErrorListenerDelegate(android.media.MediaPlayer arg0, int arg1, int arg2);

		internal partial class OnErrorListenerDelegateWrapper : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnErrorListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnErrorListenerDelegateWrapper7321;
			public OnErrorListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnErrorListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper._OnErrorListenerDelegateWrapper7321);
				Init(@__env, handle);
			}
			static OnErrorListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnErrorListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper._OnErrorListenerDelegateWrapper7321 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onInfo7322;
			bool android.media.MediaPlayer.OnInfoListener.onInfo(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnInfoListener_._onInfo7322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnInfoListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnInfoListener"));
				global::android.media.MediaPlayer.OnInfoListener_._onInfo7322 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaPlayer;II)Z");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnInfoListenerDelegate(android.media.MediaPlayer arg0, int arg1, int arg2);

		internal partial class OnInfoListenerDelegateWrapper : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnInfoListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnInfoListenerDelegateWrapper7323;
			public OnInfoListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnInfoListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper._OnInfoListenerDelegateWrapper7323);
				Init(@__env, handle);
			}
			static OnInfoListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnInfoListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper._OnInfoListenerDelegateWrapper7323 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onPrepared7324;
			void android.media.MediaPlayer.OnPreparedListener.onPrepared(android.media.MediaPlayer arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnPreparedListener_._onPrepared7324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnPreparedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnPreparedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnPreparedListener"));
				global::android.media.MediaPlayer.OnPreparedListener_._onPrepared7324 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnPreparedListener_.staticClass, "onPrepared", "(Landroid/media/MediaPlayer;)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnPreparedListenerDelegate(android.media.MediaPlayer arg0);

		internal partial class OnPreparedListenerDelegateWrapper : java.lang.Object, OnPreparedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnPreparedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnPreparedListenerDelegateWrapper7325;
			public OnPreparedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnPreparedListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper._OnPreparedListenerDelegateWrapper7325);
				Init(@__env, handle);
			}
			static OnPreparedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnPreparedListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper._OnPreparedListenerDelegateWrapper7325 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onSeekComplete7326;
			void android.media.MediaPlayer.OnSeekCompleteListener.onSeekComplete(android.media.MediaPlayer arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete7326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnSeekCompleteListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnSeekCompleteListener"));
				global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete7326 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass, "onSeekComplete", "(Landroid/media/MediaPlayer;)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnSeekCompleteListenerDelegate(android.media.MediaPlayer arg0);

		internal partial class OnSeekCompleteListenerDelegateWrapper : java.lang.Object, OnSeekCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnSeekCompleteListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnSeekCompleteListenerDelegateWrapper7327;
			public OnSeekCompleteListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper._OnSeekCompleteListenerDelegateWrapper7327);
				Init(@__env, handle);
			}
			static OnSeekCompleteListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnSeekCompleteListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper._OnSeekCompleteListenerDelegateWrapper7327 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onVideoSizeChanged7328;
			void android.media.MediaPlayer.OnVideoSizeChangedListener.onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged7328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnVideoSizeChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnVideoSizeChangedListener"));
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged7328 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnVideoSizeChangedListenerDelegate(android.media.MediaPlayer arg0, int arg1, int arg2);

		internal partial class OnVideoSizeChangedListenerDelegateWrapper : java.lang.Object, OnVideoSizeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnVideoSizeChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnVideoSizeChangedListenerDelegateWrapper7329;
			public OnVideoSizeChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper.staticClass, global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper._OnVideoSizeChangedListenerDelegateWrapper7329);
				Init(@__env, handle);
			}
			static OnVideoSizeChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer_OnVideoSizeChangedListenerDelegateWrapper"));
				global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper._OnVideoSizeChangedListenerDelegateWrapper7329 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _finalize7330;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._finalize7330);
		}
		internal static global::MonoJavaBridge.MethodId _start7331;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._start7331);
		}
		internal static global::MonoJavaBridge.MethodId _stop7332;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._stop7332);
		}
		internal static global::MonoJavaBridge.MethodId _reset7333;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._reset7333);
		}
		internal static global::MonoJavaBridge.MethodId _release7334;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._release7334);
		}
		internal static global::MonoJavaBridge.MethodId _create7335;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1, android.view.SurfaceHolder arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create7335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _create7336;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create7336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _create7337;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create7337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _prepare7338;
		public virtual void prepare()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepare7338);
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration7339;
		public virtual int getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getDuration7339);
		}
		internal static global::MonoJavaBridge.MethodId _pause7340;
		public virtual void pause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._pause7340);
		}
		public new global::android.view.SurfaceHolder Display
		{
			set
			{
				setDisplay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDisplay7341;
		public virtual void setDisplay(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDisplay7341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7342;
		public virtual void setDataSource(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7343;
		public virtual void setDataSource(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7344;
		public virtual void setDataSource(java.io.FileDescriptor arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7345;
		public virtual void setDataSource(android.content.Context arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _prepareAsync7346;
		public virtual void prepareAsync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepareAsync7346);
		}
		internal static global::MonoJavaBridge.MethodId _setWakeMode7347;
		public virtual void setWakeMode(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setWakeMode7347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool ScreenOnWhilePlaying
		{
			set
			{
				setScreenOnWhilePlaying(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setScreenOnWhilePlaying7348;
		public virtual void setScreenOnWhilePlaying(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setScreenOnWhilePlaying7348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VideoWidth
		{
			get
			{
				return getVideoWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoWidth7349;
		public virtual int getVideoWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoWidth7349);
		}
		public new int VideoHeight
		{
			get
			{
				return getVideoHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoHeight7350;
		public virtual int getVideoHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoHeight7350);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying7351;
		public virtual bool isPlaying()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isPlaying7351);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo7352;
		public virtual void seekTo(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._seekTo7352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition7353;
		public virtual int getCurrentPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getCurrentPosition7353);
		}
		public new int AudioStreamType
		{
			set
			{
				setAudioStreamType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAudioStreamType7354;
		public virtual void setAudioStreamType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setAudioStreamType7354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Looping
		{
			set
			{
				setLooping(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLooping7355;
		public virtual void setLooping(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setLooping7355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLooping7356;
		public virtual bool isLooping()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isLooping7356);
		}
		internal static global::MonoJavaBridge.MethodId _setVolume7357;
		public virtual void setVolume(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setVolume7357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener7358;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnPreparedListener7358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreparedListener(global::android.media.MediaPlayer.OnPreparedListenerDelegate arg0)
		{
			setOnPreparedListener((global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener7359;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnCompletionListener7359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCompletionListener(global::android.media.MediaPlayer.OnCompletionListenerDelegate arg0)
		{
			setOnCompletionListener((global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnBufferingUpdateListener7360;
		public virtual void setOnBufferingUpdateListener(android.media.MediaPlayer.OnBufferingUpdateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnBufferingUpdateListener7360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnBufferingUpdateListener(global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegate arg0)
		{
			setOnBufferingUpdateListener((global::android.media.MediaPlayer.OnBufferingUpdateListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnSeekCompleteListener7361;
		public virtual void setOnSeekCompleteListener(android.media.MediaPlayer.OnSeekCompleteListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnSeekCompleteListener7361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnSeekCompleteListener(global::android.media.MediaPlayer.OnSeekCompleteListenerDelegate arg0)
		{
			setOnSeekCompleteListener((global::android.media.MediaPlayer.OnSeekCompleteListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnVideoSizeChangedListener7362;
		public virtual void setOnVideoSizeChangedListener(android.media.MediaPlayer.OnVideoSizeChangedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnVideoSizeChangedListener7362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnVideoSizeChangedListener(global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegate arg0)
		{
			setOnVideoSizeChangedListener((global::android.media.MediaPlayer.OnVideoSizeChangedListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener7363;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnErrorListener7363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnErrorListener(global::android.media.MediaPlayer.OnErrorListenerDelegate arg0)
		{
			setOnErrorListener((global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnInfoListener7364;
		public virtual void setOnInfoListener(android.media.MediaPlayer.OnInfoListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnInfoListener7364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnInfoListener(global::android.media.MediaPlayer.OnInfoListenerDelegate arg0)
		{
			setOnInfoListener((global::android.media.MediaPlayer.OnInfoListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _MediaPlayer7365;
		public MediaPlayer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._MediaPlayer7365);
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
			global::android.media.MediaPlayer._finalize7330 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "finalize", "()V");
			global::android.media.MediaPlayer._start7331 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "start", "()V");
			global::android.media.MediaPlayer._stop7332 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "stop", "()V");
			global::android.media.MediaPlayer._reset7333 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "reset", "()V");
			global::android.media.MediaPlayer._release7334 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "release", "()V");
			global::android.media.MediaPlayer._create7335 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create7336 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create7337 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._prepare7338 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "prepare", "()V");
			global::android.media.MediaPlayer._getDuration7339 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getDuration", "()I");
			global::android.media.MediaPlayer._pause7340 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "pause", "()V");
			global::android.media.MediaPlayer._setDisplay7341 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.media.MediaPlayer._setDataSource7342 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/lang/String;)V");
			global::android.media.MediaPlayer._setDataSource7343 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaPlayer._setDataSource7344 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;JJ)V");
			global::android.media.MediaPlayer._setDataSource7345 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.media.MediaPlayer._prepareAsync7346 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "prepareAsync", "()V");
			global::android.media.MediaPlayer._setWakeMode7347 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setWakeMode", "(Landroid/content/Context;I)V");
			global::android.media.MediaPlayer._setScreenOnWhilePlaying7348 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setScreenOnWhilePlaying", "(Z)V");
			global::android.media.MediaPlayer._getVideoWidth7349 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getVideoWidth", "()I");
			global::android.media.MediaPlayer._getVideoHeight7350 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getVideoHeight", "()I");
			global::android.media.MediaPlayer._isPlaying7351 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "isPlaying", "()Z");
			global::android.media.MediaPlayer._seekTo7352 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "seekTo", "(I)V");
			global::android.media.MediaPlayer._getCurrentPosition7353 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getCurrentPosition", "()I");
			global::android.media.MediaPlayer._setAudioStreamType7354 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setAudioStreamType", "(I)V");
			global::android.media.MediaPlayer._setLooping7355 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setLooping", "(Z)V");
			global::android.media.MediaPlayer._isLooping7356 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "isLooping", "()Z");
			global::android.media.MediaPlayer._setVolume7357 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setVolume", "(FF)V");
			global::android.media.MediaPlayer._setOnPreparedListener7358 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.media.MediaPlayer._setOnCompletionListener7359 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.media.MediaPlayer._setOnBufferingUpdateListener7360 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V");
			global::android.media.MediaPlayer._setOnSeekCompleteListener7361 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V");
			global::android.media.MediaPlayer._setOnVideoSizeChangedListener7362 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V");
			global::android.media.MediaPlayer._setOnErrorListener7363 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.media.MediaPlayer._setOnInfoListener7364 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V");
			global::android.media.MediaPlayer._MediaPlayer7365 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
