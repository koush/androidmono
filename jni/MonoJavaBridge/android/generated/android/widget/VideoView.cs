namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class VideoView : android.view.SurfaceView, android.widget.MediaController.MediaPlayerControl
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VideoView()
		{
			InitJNI();
		}
		protected VideoView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start12914;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._start12914);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._start12914);
		}
		internal static global::MonoJavaBridge.MethodId _suspend12915;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._suspend12915);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._suspend12915);
		}
		internal static global::MonoJavaBridge.MethodId _resume12916;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._resume12916);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resume12916);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown12917;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onKeyDown12917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onKeyDown12917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12918;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onTouchEvent12918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTouchEvent12918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent12919;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onTrackballEvent12919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTrackballEvent12919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12920;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._onMeasure12920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onMeasure12920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration12921;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getDuration12921);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getDuration12921);
		}
		internal static global::MonoJavaBridge.MethodId _pause12922;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._pause12922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._pause12922);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying12923;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._isPlaying12923);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._isPlaying12923);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo12924;
		public virtual void seekTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._seekTo12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._seekTo12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition12925;
		public virtual int getCurrentPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getCurrentPosition12925);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getCurrentPosition12925);
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener12926;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnPreparedListener12926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnPreparedListener12926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener12927;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnCompletionListener12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnCompletionListener12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener12928;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnErrorListener12928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnErrorListener12928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BufferPercentage
		{
			get
			{
				return getBufferPercentage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBufferPercentage12929;
		public virtual int getBufferPercentage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getBufferPercentage12929);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getBufferPercentage12929);
		}
		internal static global::MonoJavaBridge.MethodId _canPause12930;
		public virtual bool canPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canPause12930);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canPause12930);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekBackward12931;
		public virtual bool canSeekBackward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canSeekBackward12931);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekBackward12931);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekForward12932;
		public virtual bool canSeekForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canSeekForward12932);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekForward12932);
		}
		internal static global::MonoJavaBridge.MethodId _resolveAdjustedSize12933;
		public virtual int resolveAdjustedSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._resolveAdjustedSize12933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resolveAdjustedSize12933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoPath12934;
		public virtual void setVideoPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setVideoPath12934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoPath12934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoURI12935;
		public virtual void setVideoURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setVideoURI12935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoURI12935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopPlayback12936;
		public virtual void stopPlayback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._stopPlayback12936);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._stopPlayback12936);
		}
		internal static global::MonoJavaBridge.MethodId _setMediaController12937;
		public virtual void setMediaController(android.widget.MediaController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setMediaController12937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setMediaController12937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _VideoView12938;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView12939;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView12940;
		public VideoView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.VideoView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/VideoView"));
			global::android.widget.VideoView._start12914 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "start", "()V");
			global::android.widget.VideoView._suspend12915 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "suspend", "()V");
			global::android.widget.VideoView._resume12916 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resume", "()V");
			global::android.widget.VideoView._onKeyDown12917 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.VideoView._onTouchEvent12918 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onTrackballEvent12919 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onMeasure12920 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V");
			global::android.widget.VideoView._getDuration12921 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getDuration", "()I");
			global::android.widget.VideoView._pause12922 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "pause", "()V");
			global::android.widget.VideoView._isPlaying12923 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "isPlaying", "()Z");
			global::android.widget.VideoView._seekTo12924 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "seekTo", "(I)V");
			global::android.widget.VideoView._getCurrentPosition12925 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I");
			global::android.widget.VideoView._setOnPreparedListener12926 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.widget.VideoView._setOnCompletionListener12927 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.widget.VideoView._setOnErrorListener12928 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.widget.VideoView._getBufferPercentage12929 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I");
			global::android.widget.VideoView._canPause12930 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canPause", "()Z");
			global::android.widget.VideoView._canSeekBackward12931 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z");
			global::android.widget.VideoView._canSeekForward12932 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z");
			global::android.widget.VideoView._resolveAdjustedSize12933 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I");
			global::android.widget.VideoView._setVideoPath12934 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V");
			global::android.widget.VideoView._setVideoURI12935 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V");
			global::android.widget.VideoView._stopPlayback12936 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "stopPlayback", "()V");
			global::android.widget.VideoView._setMediaController12937 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V");
			global::android.widget.VideoView._VideoView12938 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.VideoView._VideoView12939 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.VideoView._VideoView12940 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
