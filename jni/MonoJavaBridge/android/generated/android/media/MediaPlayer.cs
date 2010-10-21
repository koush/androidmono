namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MediaPlayer()
		{
			InitJNI();
		}
		protected MediaPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnBufferingUpdateListener_))]
		public interface OnBufferingUpdateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onBufferingUpdate(android.media.MediaPlayer arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnBufferingUpdateListener))]
		public sealed partial class OnBufferingUpdateListener_ : java.lang.Object, OnBufferingUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnBufferingUpdateListener_()
			{
				InitJNI();
			}
			internal OnBufferingUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onBufferingUpdate7288;
			 void android.media.MediaPlayer.OnBufferingUpdateListener.onBufferingUpdate(android.media.MediaPlayer arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate7288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass, global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate7288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnBufferingUpdateListener"));
				global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate7288 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnCompletionListener_))]
		public interface OnCompletionListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCompletion(android.media.MediaPlayer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnCompletionListener))]
		public sealed partial class OnCompletionListener_ : java.lang.Object, OnCompletionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnCompletionListener_()
			{
				InitJNI();
			}
			internal OnCompletionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCompletion7289;
			 void android.media.MediaPlayer.OnCompletionListener.onCompletion(android.media.MediaPlayer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnCompletionListener_._onCompletion7289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnCompletionListener_.staticClass, global::android.media.MediaPlayer.OnCompletionListener_._onCompletion7289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnCompletionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnCompletionListener"));
				global::android.media.MediaPlayer.OnCompletionListener_._onCompletion7289 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnCompletionListener_.staticClass, "onCompletion", "(Landroid/media/MediaPlayer;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnErrorListener_))]
		public interface OnErrorListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onError(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnErrorListener))]
		public sealed partial class OnErrorListener_ : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnErrorListener_()
			{
				InitJNI();
			}
			internal OnErrorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onError7290;
			 bool android.media.MediaPlayer.OnErrorListener.onError(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnErrorListener_._onError7290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnErrorListener_.staticClass, global::android.media.MediaPlayer.OnErrorListener_._onError7290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnErrorListener"));
				global::android.media.MediaPlayer.OnErrorListener_._onError7290 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaPlayer;II)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnInfoListener_))]
		public interface OnInfoListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onInfo(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnInfoListener))]
		public sealed partial class OnInfoListener_ : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnInfoListener_()
			{
				InitJNI();
			}
			internal OnInfoListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onInfo7291;
			 bool android.media.MediaPlayer.OnInfoListener.onInfo(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnInfoListener_._onInfo7291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnInfoListener_.staticClass, global::android.media.MediaPlayer.OnInfoListener_._onInfo7291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnInfoListener"));
				global::android.media.MediaPlayer.OnInfoListener_._onInfo7291 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaPlayer;II)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnPreparedListener_))]
		public interface OnPreparedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onPrepared(android.media.MediaPlayer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnPreparedListener))]
		public sealed partial class OnPreparedListener_ : java.lang.Object, OnPreparedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreparedListener_()
			{
				InitJNI();
			}
			internal OnPreparedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPrepared7292;
			 void android.media.MediaPlayer.OnPreparedListener.onPrepared(android.media.MediaPlayer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnPreparedListener_._onPrepared7292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnPreparedListener_.staticClass, global::android.media.MediaPlayer.OnPreparedListener_._onPrepared7292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnPreparedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnPreparedListener"));
				global::android.media.MediaPlayer.OnPreparedListener_._onPrepared7292 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnPreparedListener_.staticClass, "onPrepared", "(Landroid/media/MediaPlayer;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnSeekCompleteListener_))]
		public interface OnSeekCompleteListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onSeekComplete(android.media.MediaPlayer arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnSeekCompleteListener))]
		public sealed partial class OnSeekCompleteListener_ : java.lang.Object, OnSeekCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnSeekCompleteListener_()
			{
				InitJNI();
			}
			internal OnSeekCompleteListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSeekComplete7293;
			 void android.media.MediaPlayer.OnSeekCompleteListener.onSeekComplete(android.media.MediaPlayer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete7293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass, global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete7293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnSeekCompleteListener"));
				global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete7293 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass, "onSeekComplete", "(Landroid/media/MediaPlayer;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaPlayer.OnVideoSizeChangedListener_))]
		public interface OnVideoSizeChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaPlayer.OnVideoSizeChangedListener))]
		public sealed partial class OnVideoSizeChangedListener_ : java.lang.Object, OnVideoSizeChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnVideoSizeChangedListener_()
			{
				InitJNI();
			}
			internal OnVideoSizeChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onVideoSizeChanged7294;
			 void android.media.MediaPlayer.OnVideoSizeChangedListener.onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged7294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass, global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged7294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnVideoSizeChangedListener"));
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged7294 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7295;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._finalize7295);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._finalize7295);
		}
		internal static global::MonoJavaBridge.MethodId _start7296;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._start7296);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._start7296);
		}
		internal static global::MonoJavaBridge.MethodId _stop7297;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._stop7297);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._stop7297);
		}
		internal static global::MonoJavaBridge.MethodId _reset7298;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._reset7298);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._reset7298);
		}
		internal static global::MonoJavaBridge.MethodId _release7299;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._release7299);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._release7299);
		}
		internal static global::MonoJavaBridge.MethodId _create7300;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1, android.view.SurfaceHolder arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create7300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _create7301;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create7301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _create7302;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create7302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _prepare7303;
		public virtual void prepare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._prepare7303);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepare7303);
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration7304;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getDuration7304);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getDuration7304);
		}
		internal static global::MonoJavaBridge.MethodId _pause7305;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._pause7305);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._pause7305);
		}
		internal static global::MonoJavaBridge.MethodId _setDisplay7306;
		public virtual void setDisplay(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDisplay7306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDisplay7306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7307;
		public virtual void setDataSource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource7307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7308;
		public virtual void setDataSource(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource7308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7309;
		public virtual void setDataSource(java.io.FileDescriptor arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource7309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource7310;
		public virtual void setDataSource(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource7310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource7310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _prepareAsync7311;
		public virtual void prepareAsync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._prepareAsync7311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepareAsync7311);
		}
		internal static global::MonoJavaBridge.MethodId _setWakeMode7312;
		public virtual void setWakeMode(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setWakeMode7312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setWakeMode7312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setScreenOnWhilePlaying7313;
		public virtual void setScreenOnWhilePlaying(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setScreenOnWhilePlaying7313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setScreenOnWhilePlaying7313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VideoWidth
		{
			get
			{
				return getVideoWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoWidth7314;
		public virtual int getVideoWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getVideoWidth7314);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoWidth7314);
		}
		public new int VideoHeight
		{
			get
			{
				return getVideoHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoHeight7315;
		public virtual int getVideoHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getVideoHeight7315);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoHeight7315);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying7316;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer._isPlaying7316);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isPlaying7316);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo7317;
		public virtual void seekTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._seekTo7317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._seekTo7317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition7318;
		public virtual int getCurrentPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getCurrentPosition7318);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getCurrentPosition7318);
		}
		internal static global::MonoJavaBridge.MethodId _setAudioStreamType7319;
		public virtual void setAudioStreamType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setAudioStreamType7319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setAudioStreamType7319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLooping7320;
		public virtual void setLooping(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setLooping7320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setLooping7320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLooping7321;
		public virtual bool isLooping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer._isLooping7321);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isLooping7321);
		}
		internal static global::MonoJavaBridge.MethodId _setVolume7322;
		public virtual void setVolume(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setVolume7322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setVolume7322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener7323;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnPreparedListener7323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnPreparedListener7323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener7324;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnCompletionListener7324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnCompletionListener7324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnBufferingUpdateListener7325;
		public virtual void setOnBufferingUpdateListener(android.media.MediaPlayer.OnBufferingUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnBufferingUpdateListener7325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnBufferingUpdateListener7325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnSeekCompleteListener7326;
		public virtual void setOnSeekCompleteListener(android.media.MediaPlayer.OnSeekCompleteListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnSeekCompleteListener7326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnSeekCompleteListener7326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnVideoSizeChangedListener7327;
		public virtual void setOnVideoSizeChangedListener(android.media.MediaPlayer.OnVideoSizeChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnVideoSizeChangedListener7327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnVideoSizeChangedListener7327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener7328;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnErrorListener7328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnErrorListener7328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnInfoListener7329;
		public virtual void setOnInfoListener(android.media.MediaPlayer.OnInfoListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnInfoListener7329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnInfoListener7329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MediaPlayer7330;
		public MediaPlayer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._MediaPlayer7330);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer"));
			global::android.media.MediaPlayer._finalize7295 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "finalize", "()V");
			global::android.media.MediaPlayer._start7296 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "start", "()V");
			global::android.media.MediaPlayer._stop7297 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "stop", "()V");
			global::android.media.MediaPlayer._reset7298 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "reset", "()V");
			global::android.media.MediaPlayer._release7299 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "release", "()V");
			global::android.media.MediaPlayer._create7300 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create7301 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create7302 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._prepare7303 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "prepare", "()V");
			global::android.media.MediaPlayer._getDuration7304 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getDuration", "()I");
			global::android.media.MediaPlayer._pause7305 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "pause", "()V");
			global::android.media.MediaPlayer._setDisplay7306 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.media.MediaPlayer._setDataSource7307 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/lang/String;)V");
			global::android.media.MediaPlayer._setDataSource7308 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaPlayer._setDataSource7309 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;JJ)V");
			global::android.media.MediaPlayer._setDataSource7310 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.media.MediaPlayer._prepareAsync7311 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "prepareAsync", "()V");
			global::android.media.MediaPlayer._setWakeMode7312 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setWakeMode", "(Landroid/content/Context;I)V");
			global::android.media.MediaPlayer._setScreenOnWhilePlaying7313 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setScreenOnWhilePlaying", "(Z)V");
			global::android.media.MediaPlayer._getVideoWidth7314 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getVideoWidth", "()I");
			global::android.media.MediaPlayer._getVideoHeight7315 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getVideoHeight", "()I");
			global::android.media.MediaPlayer._isPlaying7316 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "isPlaying", "()Z");
			global::android.media.MediaPlayer._seekTo7317 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "seekTo", "(I)V");
			global::android.media.MediaPlayer._getCurrentPosition7318 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getCurrentPosition", "()I");
			global::android.media.MediaPlayer._setAudioStreamType7319 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setAudioStreamType", "(I)V");
			global::android.media.MediaPlayer._setLooping7320 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setLooping", "(Z)V");
			global::android.media.MediaPlayer._isLooping7321 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "isLooping", "()Z");
			global::android.media.MediaPlayer._setVolume7322 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setVolume", "(FF)V");
			global::android.media.MediaPlayer._setOnPreparedListener7323 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.media.MediaPlayer._setOnCompletionListener7324 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.media.MediaPlayer._setOnBufferingUpdateListener7325 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V");
			global::android.media.MediaPlayer._setOnSeekCompleteListener7326 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V");
			global::android.media.MediaPlayer._setOnVideoSizeChangedListener7327 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V");
			global::android.media.MediaPlayer._setOnErrorListener7328 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.media.MediaPlayer._setOnInfoListener7329 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V");
			global::android.media.MediaPlayer._MediaPlayer7330 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "<init>", "()V");
		}
	}
}
