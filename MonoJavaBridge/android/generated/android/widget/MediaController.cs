namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaController : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MediaController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.MediaController.MediaPlayerControl_))]
		public partial interface MediaPlayerControl  : global::MonoJavaBridge.IJavaObject 
		{
			void start();
			int getDuration();
			void pause();
			bool isPlaying();
			void seekTo(int arg0);
			int getCurrentPosition();
			int getBufferPercentage();
			bool canPause();
			bool canSeekBackward();
			bool canSeekForward();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.MediaController.MediaPlayerControl))]
		internal sealed partial class MediaPlayerControl_ : java.lang.Object, MediaPlayerControl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MediaPlayerControl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _start17398;
			void android.widget.MediaController.MediaPlayerControl.start()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "start", "()V", ref global::android.widget.MediaController.MediaPlayerControl_._start17398);
			}
			internal static global::MonoJavaBridge.MethodId _getDuration17399;
			int android.widget.MediaController.MediaPlayerControl.getDuration()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getDuration", "()I", ref global::android.widget.MediaController.MediaPlayerControl_._getDuration17399);
			}
			internal static global::MonoJavaBridge.MethodId _pause17400;
			void android.widget.MediaController.MediaPlayerControl.pause()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "pause", "()V", ref global::android.widget.MediaController.MediaPlayerControl_._pause17400);
			}
			internal static global::MonoJavaBridge.MethodId _isPlaying17401;
			bool android.widget.MediaController.MediaPlayerControl.isPlaying()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "isPlaying", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._isPlaying17401);
			}
			internal static global::MonoJavaBridge.MethodId _seekTo17402;
			void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "seekTo", "(I)V", ref global::android.widget.MediaController.MediaPlayerControl_._seekTo17402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentPosition17403;
			int android.widget.MediaController.MediaPlayerControl.getCurrentPosition()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getCurrentPosition", "()I", ref global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition17403);
			}
			internal static global::MonoJavaBridge.MethodId _getBufferPercentage17404;
			int android.widget.MediaController.MediaPlayerControl.getBufferPercentage()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getBufferPercentage", "()I", ref global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage17404);
			}
			internal static global::MonoJavaBridge.MethodId _canPause17405;
			bool android.widget.MediaController.MediaPlayerControl.canPause()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canPause", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._canPause17405);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekBackward17406;
			bool android.widget.MediaController.MediaPlayerControl.canSeekBackward()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekBackward", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward17406);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekForward17407;
			bool android.widget.MediaController.MediaPlayerControl.canSeekForward()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekForward", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._canSeekForward17407);
			}
			static MediaPlayerControl_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MediaController.MediaPlayerControl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController$MediaPlayerControl"));
			}
			internal static void InitJNI()
			{
			}
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled17408;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V", ref global::android.widget.MediaController._setEnabled17408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17409;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.MediaController._onTouchEvent17409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent17410;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.MediaController._onTrackballEvent17410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17411;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.MediaController._dispatchKeyEvent17411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17412;
		public virtual void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "onFinishInflate", "()V", ref global::android.widget.MediaController._onFinishInflate17412);
		}
		internal static global::MonoJavaBridge.MethodId _isShowing17413;
		public virtual bool isShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "isShowing", "()Z", ref global::android.widget.MediaController._isShowing17413);
		}
		internal static global::MonoJavaBridge.MethodId _show17414;
		public virtual void show(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "show", "(I)V", ref global::android.widget.MediaController._show17414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show17415;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "show", "()V", ref global::android.widget.MediaController._show17415);
		}
		internal static global::MonoJavaBridge.MethodId _hide17416;
		public virtual void hide()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "hide", "()V", ref global::android.widget.MediaController._hide17416);
		}
		public new global::android.widget.MediaController.MediaPlayerControl MediaPlayer
		{
			set
			{
				setMediaPlayer(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMediaPlayer17417;
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V", ref global::android.widget.MediaController._setMediaPlayer17417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View AnchorView
		{
			set
			{
				setAnchorView(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAnchorView17418;
		public virtual void setAnchorView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V", ref global::android.widget.MediaController._setAnchorView17418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrevNextListeners17419;
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V", ref global::android.widget.MediaController._setPrevNextListeners17419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setPrevNextListeners(global::android.view.View.OnClickListenerDelegate arg0, global::android.view.View.OnClickListenerDelegate arg1)
		{
			setPrevNextListeners((global::android.view.View.OnClickListenerDelegateWrapper)arg0, (global::android.view.View.OnClickListenerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController17420;
		public MediaController(android.content.Context arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MediaController._MediaController17420.native == global::System.IntPtr.Zero)
				global::android.widget.MediaController._MediaController17420 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController17420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController17421;
		public MediaController(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MediaController._MediaController17421.native == global::System.IntPtr.Zero)
				global::android.widget.MediaController._MediaController17421 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController17421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController17422;
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MediaController._MediaController17422.native == global::System.IntPtr.Zero)
				global::android.widget.MediaController._MediaController17422 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController17422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MediaController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MediaController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController"));
		}
		internal static void InitJNI()
		{
		}
	}
}
