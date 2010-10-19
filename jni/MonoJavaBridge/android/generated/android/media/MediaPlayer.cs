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
			internal static global::MonoJavaBridge.MethodId _onBufferingUpdate4981;
			 void android.media.MediaPlayer.OnBufferingUpdateListener.onBufferingUpdate(android.media.MediaPlayer arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate4981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass, global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate4981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnBufferingUpdateListener"));
				global::android.media.MediaPlayer.OnBufferingUpdateListener_._onBufferingUpdate4981 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnBufferingUpdateListener_.staticClass, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V");
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
			internal static global::MonoJavaBridge.MethodId _onCompletion4982;
			 void android.media.MediaPlayer.OnCompletionListener.onCompletion(android.media.MediaPlayer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnCompletionListener_._onCompletion4982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnCompletionListener_.staticClass, global::android.media.MediaPlayer.OnCompletionListener_._onCompletion4982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnCompletionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnCompletionListener"));
				global::android.media.MediaPlayer.OnCompletionListener_._onCompletion4982 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnCompletionListener_.staticClass, "onCompletion", "(Landroid/media/MediaPlayer;)V");
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
			internal static global::MonoJavaBridge.MethodId _onError4983;
			 bool android.media.MediaPlayer.OnErrorListener.onError(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnErrorListener_._onError4983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnErrorListener_.staticClass, global::android.media.MediaPlayer.OnErrorListener_._onError4983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnErrorListener"));
				global::android.media.MediaPlayer.OnErrorListener_._onError4983 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaPlayer;II)Z");
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
			internal static global::MonoJavaBridge.MethodId _onInfo4984;
			 bool android.media.MediaPlayer.OnInfoListener.onInfo(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnInfoListener_._onInfo4984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.OnInfoListener_.staticClass, global::android.media.MediaPlayer.OnInfoListener_._onInfo4984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnInfoListener"));
				global::android.media.MediaPlayer.OnInfoListener_._onInfo4984 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaPlayer;II)Z");
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
			internal static global::MonoJavaBridge.MethodId _onPrepared4985;
			 void android.media.MediaPlayer.OnPreparedListener.onPrepared(android.media.MediaPlayer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnPreparedListener_._onPrepared4985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnPreparedListener_.staticClass, global::android.media.MediaPlayer.OnPreparedListener_._onPrepared4985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnPreparedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnPreparedListener"));
				global::android.media.MediaPlayer.OnPreparedListener_._onPrepared4985 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnPreparedListener_.staticClass, "onPrepared", "(Landroid/media/MediaPlayer;)V");
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
			internal static global::MonoJavaBridge.MethodId _onSeekComplete4986;
			 void android.media.MediaPlayer.OnSeekCompleteListener.onSeekComplete(android.media.MediaPlayer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete4986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass, global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete4986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnSeekCompleteListener"));
				global::android.media.MediaPlayer.OnSeekCompleteListener_._onSeekComplete4986 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnSeekCompleteListener_.staticClass, "onSeekComplete", "(Landroid/media/MediaPlayer;)V");
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
			internal static global::MonoJavaBridge.MethodId _onVideoSizeChanged4987;
			 void android.media.MediaPlayer.OnVideoSizeChangedListener.onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged4987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass, global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged4987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaPlayer$OnVideoSizeChangedListener"));
				global::android.media.MediaPlayer.OnVideoSizeChangedListener_._onVideoSizeChanged4987 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.OnVideoSizeChangedListener_.staticClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4988;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._finalize4988);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._finalize4988);
		}
		internal static global::MonoJavaBridge.MethodId _start4989;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._start4989);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._start4989);
		}
		internal static global::MonoJavaBridge.MethodId _stop4990;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._stop4990);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._stop4990);
		}
		internal static global::MonoJavaBridge.MethodId _reset4991;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._reset4991);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._reset4991);
		}
		internal static global::MonoJavaBridge.MethodId _release4992;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._release4992);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._release4992);
		}
		internal static global::MonoJavaBridge.MethodId _create4993;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1, android.view.SurfaceHolder arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create4993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _create4994;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create4994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _create4995;
		public static global::android.media.MediaPlayer create(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._create4995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.MediaPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _prepare4996;
		public virtual void prepare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._prepare4996);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepare4996);
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration4997;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getDuration4997);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getDuration4997);
		}
		internal static global::MonoJavaBridge.MethodId _pause4998;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._pause4998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._pause4998);
		}
		internal static global::MonoJavaBridge.MethodId _setDisplay4999;
		public virtual void setDisplay(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDisplay4999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDisplay4999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource5000;
		public virtual void setDataSource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource5000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource5000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource5001;
		public virtual void setDataSource(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource5001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource5001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource5002;
		public virtual void setDataSource(java.io.FileDescriptor arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource5002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource5002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDataSource5003;
		public virtual void setDataSource(android.content.Context arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setDataSource5003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setDataSource5003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _prepareAsync5004;
		public virtual void prepareAsync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._prepareAsync5004);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._prepareAsync5004);
		}
		internal static global::MonoJavaBridge.MethodId _setWakeMode5005;
		public virtual void setWakeMode(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setWakeMode5005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setWakeMode5005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setScreenOnWhilePlaying5006;
		public virtual void setScreenOnWhilePlaying(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setScreenOnWhilePlaying5006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setScreenOnWhilePlaying5006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VideoWidth
		{
			get
			{
				return getVideoWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoWidth5007;
		public virtual int getVideoWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getVideoWidth5007);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoWidth5007);
		}
		public new int VideoHeight
		{
			get
			{
				return getVideoHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoHeight5008;
		public virtual int getVideoHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getVideoHeight5008);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getVideoHeight5008);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying5009;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer._isPlaying5009);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isPlaying5009);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo5010;
		public virtual void seekTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._seekTo5010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._seekTo5010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition5011;
		public virtual int getCurrentPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaPlayer._getCurrentPosition5011);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._getCurrentPosition5011);
		}
		internal static global::MonoJavaBridge.MethodId _setAudioStreamType5012;
		public virtual void setAudioStreamType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setAudioStreamType5012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setAudioStreamType5012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLooping5013;
		public virtual void setLooping(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setLooping5013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setLooping5013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLooping5014;
		public virtual bool isLooping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer._isLooping5014);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._isLooping5014);
		}
		internal static global::MonoJavaBridge.MethodId _setVolume5015;
		public virtual void setVolume(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setVolume5015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setVolume5015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener5016;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnPreparedListener5016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnPreparedListener5016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener5017;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnCompletionListener5017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnCompletionListener5017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnBufferingUpdateListener5018;
		public virtual void setOnBufferingUpdateListener(android.media.MediaPlayer.OnBufferingUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnBufferingUpdateListener5018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnBufferingUpdateListener5018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnSeekCompleteListener5019;
		public virtual void setOnSeekCompleteListener(android.media.MediaPlayer.OnSeekCompleteListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnSeekCompleteListener5019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnSeekCompleteListener5019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnVideoSizeChangedListener5020;
		public virtual void setOnVideoSizeChangedListener(android.media.MediaPlayer.OnVideoSizeChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnVideoSizeChangedListener5020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnVideoSizeChangedListener5020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener5021;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnErrorListener5021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnErrorListener5021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnInfoListener5022;
		public virtual void setOnInfoListener(android.media.MediaPlayer.OnInfoListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaPlayer._setOnInfoListener5022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._setOnInfoListener5022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MediaPlayer5023;
		public MediaPlayer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaPlayer.staticClass, global::android.media.MediaPlayer._MediaPlayer5023);
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
			global::android.media.MediaPlayer._finalize4988 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "finalize", "()V");
			global::android.media.MediaPlayer._start4989 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "start", "()V");
			global::android.media.MediaPlayer._stop4990 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "stop", "()V");
			global::android.media.MediaPlayer._reset4991 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "reset", "()V");
			global::android.media.MediaPlayer._release4992 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "release", "()V");
			global::android.media.MediaPlayer._create4993 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create4994 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._create4995 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;");
			global::android.media.MediaPlayer._prepare4996 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "prepare", "()V");
			global::android.media.MediaPlayer._getDuration4997 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getDuration", "()I");
			global::android.media.MediaPlayer._pause4998 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "pause", "()V");
			global::android.media.MediaPlayer._setDisplay4999 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.media.MediaPlayer._setDataSource5000 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/lang/String;)V");
			global::android.media.MediaPlayer._setDataSource5001 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaPlayer._setDataSource5002 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;JJ)V");
			global::android.media.MediaPlayer._setDataSource5003 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			global::android.media.MediaPlayer._prepareAsync5004 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "prepareAsync", "()V");
			global::android.media.MediaPlayer._setWakeMode5005 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setWakeMode", "(Landroid/content/Context;I)V");
			global::android.media.MediaPlayer._setScreenOnWhilePlaying5006 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setScreenOnWhilePlaying", "(Z)V");
			global::android.media.MediaPlayer._getVideoWidth5007 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getVideoWidth", "()I");
			global::android.media.MediaPlayer._getVideoHeight5008 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getVideoHeight", "()I");
			global::android.media.MediaPlayer._isPlaying5009 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "isPlaying", "()Z");
			global::android.media.MediaPlayer._seekTo5010 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "seekTo", "(I)V");
			global::android.media.MediaPlayer._getCurrentPosition5011 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "getCurrentPosition", "()I");
			global::android.media.MediaPlayer._setAudioStreamType5012 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setAudioStreamType", "(I)V");
			global::android.media.MediaPlayer._setLooping5013 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setLooping", "(Z)V");
			global::android.media.MediaPlayer._isLooping5014 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "isLooping", "()Z");
			global::android.media.MediaPlayer._setVolume5015 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setVolume", "(FF)V");
			global::android.media.MediaPlayer._setOnPreparedListener5016 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.media.MediaPlayer._setOnCompletionListener5017 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.media.MediaPlayer._setOnBufferingUpdateListener5018 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V");
			global::android.media.MediaPlayer._setOnSeekCompleteListener5019 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V");
			global::android.media.MediaPlayer._setOnVideoSizeChangedListener5020 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V");
			global::android.media.MediaPlayer._setOnErrorListener5021 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.media.MediaPlayer._setOnInfoListener5022 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V");
			global::android.media.MediaPlayer._MediaPlayer5023 = @__env.GetMethodIDNoThrow(global::android.media.MediaPlayer.staticClass, "<init>", "()V");
		}
	}
}
