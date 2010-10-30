namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class VideoView : android.view.SurfaceView, android.widget.MediaController.MediaPlayerControl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected VideoView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start18220;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._start18220);
		}
		internal static global::MonoJavaBridge.MethodId _suspend18221;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._suspend18221);
		}
		internal static global::MonoJavaBridge.MethodId _resume18222;
		public virtual void resume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resume18222);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown18223;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onKeyDown18223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent18224;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTouchEvent18224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent18225;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTrackballEvent18225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure18226;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onMeasure18226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration18227;
		public virtual int getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getDuration18227);
		}
		internal static global::MonoJavaBridge.MethodId _pause18228;
		public virtual void pause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._pause18228);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying18229;
		public virtual bool isPlaying()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._isPlaying18229);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo18230;
		public virtual void seekTo(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._seekTo18230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition18231;
		public virtual int getCurrentPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getCurrentPosition18231);
		}
		public new global::android.media.MediaPlayer.OnPreparedListener OnPreparedListener
		{
			set
			{
				setOnPreparedListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener18232;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnPreparedListener18232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnPreparedListener(global::android.media.MediaPlayer.OnPreparedListenerDelegate arg0)
		{
			setOnPreparedListener((global::android.media.MediaPlayer.OnPreparedListenerDelegateWrapper)arg0);
		}
		public new global::android.media.MediaPlayer.OnCompletionListener OnCompletionListener
		{
			set
			{
				setOnCompletionListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener18233;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnCompletionListener18233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCompletionListener(global::android.media.MediaPlayer.OnCompletionListenerDelegate arg0)
		{
			setOnCompletionListener((global::android.media.MediaPlayer.OnCompletionListenerDelegateWrapper)arg0);
		}
		public new global::android.media.MediaPlayer.OnErrorListener OnErrorListener
		{
			set
			{
				setOnErrorListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener18234;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnErrorListener18234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnErrorListener(global::android.media.MediaPlayer.OnErrorListenerDelegate arg0)
		{
			setOnErrorListener((global::android.media.MediaPlayer.OnErrorListenerDelegateWrapper)arg0);
		}
		public new int BufferPercentage
		{
			get
			{
				return getBufferPercentage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBufferPercentage18235;
		public virtual int getBufferPercentage()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getBufferPercentage18235);
		}
		internal static global::MonoJavaBridge.MethodId _canPause18236;
		public virtual bool canPause()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canPause18236);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekBackward18237;
		public virtual bool canSeekBackward()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekBackward18237);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekForward18238;
		public virtual bool canSeekForward()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekForward18238);
		}
		internal static global::MonoJavaBridge.MethodId _resolveAdjustedSize18239;
		public virtual int resolveAdjustedSize(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resolveAdjustedSize18239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String VideoPath
		{
			set
			{
				setVideoPath(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVideoPath18240;
		public virtual void setVideoPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoPath18240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.Uri VideoURI
		{
			set
			{
				setVideoURI(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVideoURI18241;
		public virtual void setVideoURI(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoURI18241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopPlayback18242;
		public virtual void stopPlayback()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._stopPlayback18242);
		}
		public new global::android.widget.MediaController MediaController
		{
			set
			{
				setMediaController(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMediaController18243;
		public virtual void setMediaController(android.widget.MediaController arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setMediaController18243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _VideoView18244;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView18244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView18245;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView18245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView18246;
		public VideoView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView18246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static VideoView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.VideoView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/VideoView"));
			global::android.widget.VideoView._start18220 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "start", "()V");
			global::android.widget.VideoView._suspend18221 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "suspend", "()V");
			global::android.widget.VideoView._resume18222 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resume", "()V");
			global::android.widget.VideoView._onKeyDown18223 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.VideoView._onTouchEvent18224 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onTrackballEvent18225 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onMeasure18226 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V");
			global::android.widget.VideoView._getDuration18227 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getDuration", "()I");
			global::android.widget.VideoView._pause18228 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "pause", "()V");
			global::android.widget.VideoView._isPlaying18229 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "isPlaying", "()Z");
			global::android.widget.VideoView._seekTo18230 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "seekTo", "(I)V");
			global::android.widget.VideoView._getCurrentPosition18231 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I");
			global::android.widget.VideoView._setOnPreparedListener18232 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.widget.VideoView._setOnCompletionListener18233 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.widget.VideoView._setOnErrorListener18234 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.widget.VideoView._getBufferPercentage18235 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I");
			global::android.widget.VideoView._canPause18236 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canPause", "()Z");
			global::android.widget.VideoView._canSeekBackward18237 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z");
			global::android.widget.VideoView._canSeekForward18238 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z");
			global::android.widget.VideoView._resolveAdjustedSize18239 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I");
			global::android.widget.VideoView._setVideoPath18240 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V");
			global::android.widget.VideoView._setVideoURI18241 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V");
			global::android.widget.VideoView._stopPlayback18242 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "stopPlayback", "()V");
			global::android.widget.VideoView._setMediaController18243 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V");
			global::android.widget.VideoView._VideoView18244 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.VideoView._VideoView18245 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.VideoView._VideoView18246 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
