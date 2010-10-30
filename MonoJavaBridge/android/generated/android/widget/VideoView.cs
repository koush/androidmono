namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class VideoView : android.view.SurfaceView, android.widget.MediaController.MediaPlayerControl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected VideoView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "start", "()V", ref global::android.widget.VideoView._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "suspend", "()V", ref global::android.widget.VideoView._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void resume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "resume", "()V", ref global::android.widget.VideoView._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.VideoView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.VideoView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.VideoView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "onMeasure", "(II)V", ref global::android.widget.VideoView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, "getDuration", "()I", ref global::android.widget.VideoView._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void pause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "pause", "()V", ref global::android.widget.VideoView._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isPlaying()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "isPlaying", "()Z", ref global::android.widget.VideoView._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void seekTo(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "seekTo", "(I)V", ref global::android.widget.VideoView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getCurrentPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I", ref global::android.widget.VideoView._m11);
		}
		public new global::android.media.MediaPlayer.OnPreparedListener OnPreparedListener
		{
			set
			{
				setOnPreparedListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", ref global::android.widget.VideoView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", ref global::android.widget.VideoView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", ref global::android.widget.VideoView._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getBufferPercentage()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I", ref global::android.widget.VideoView._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool canPause()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "canPause", "()Z", ref global::android.widget.VideoView._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool canSeekBackward()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z", ref global::android.widget.VideoView._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool canSeekForward()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.VideoView.staticClass, "canSeekForward", "()Z", ref global::android.widget.VideoView._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int resolveAdjustedSize(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I", ref global::android.widget.VideoView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String VideoPath
		{
			set
			{
				setVideoPath(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setVideoPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V", ref global::android.widget.VideoView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.Uri VideoURI
		{
			set
			{
				setVideoURI(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setVideoURI(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V", ref global::android.widget.VideoView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void stopPlayback()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "stopPlayback", "()V", ref global::android.widget.VideoView._m22);
		}
		public new global::android.widget.MediaController MediaController
		{
			set
			{
				setMediaController(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setMediaController(android.widget.MediaController arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V", ref global::android.widget.VideoView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.VideoView._m24.native == global::System.IntPtr.Zero)
				global::android.widget.VideoView._m24 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.VideoView._m25.native == global::System.IntPtr.Zero)
				global::android.widget.VideoView._m25 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public VideoView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.VideoView._m26.native == global::System.IntPtr.Zero)
				global::android.widget.VideoView._m26 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static VideoView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.VideoView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/VideoView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
