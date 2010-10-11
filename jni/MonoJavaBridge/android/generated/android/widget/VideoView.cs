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
		internal static global::MonoJavaBridge.MethodId _start12368;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._start12368);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._start12368);
		}
		internal static global::MonoJavaBridge.MethodId _suspend12369;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._suspend12369);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._suspend12369);
		}
		internal static global::MonoJavaBridge.MethodId _resume12370;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._resume12370);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resume12370);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown12371;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onKeyDown12371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onKeyDown12371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12372;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onTouchEvent12372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTouchEvent12372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent12373;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onTrackballEvent12373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTrackballEvent12373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12374;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._onMeasure12374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onMeasure12374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDuration12375;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getDuration12375);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getDuration12375);
		}
		internal static global::MonoJavaBridge.MethodId _pause12376;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._pause12376);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._pause12376);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying12377;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._isPlaying12377);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._isPlaying12377);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo12378;
		public virtual void seekTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._seekTo12378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._seekTo12378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition12379;
		public virtual int getCurrentPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getCurrentPosition12379);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getCurrentPosition12379);
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener12380;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnPreparedListener12380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnPreparedListener12380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener12381;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnCompletionListener12381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnCompletionListener12381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener12382;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnErrorListener12382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnErrorListener12382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBufferPercentage12383;
		public virtual int getBufferPercentage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getBufferPercentage12383);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getBufferPercentage12383);
		}
		internal static global::MonoJavaBridge.MethodId _canPause12384;
		public virtual bool canPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canPause12384);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canPause12384);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekBackward12385;
		public virtual bool canSeekBackward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canSeekBackward12385);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekBackward12385);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekForward12386;
		public virtual bool canSeekForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canSeekForward12386);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekForward12386);
		}
		internal static global::MonoJavaBridge.MethodId _resolveAdjustedSize12387;
		public virtual int resolveAdjustedSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._resolveAdjustedSize12387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resolveAdjustedSize12387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoPath12388;
		public virtual void setVideoPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setVideoPath12388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoPath12388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoURI12389;
		public virtual void setVideoURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setVideoURI12389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoURI12389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopPlayback12390;
		public virtual void stopPlayback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._stopPlayback12390);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._stopPlayback12390);
		}
		internal static global::MonoJavaBridge.MethodId _setMediaController12391;
		public virtual void setMediaController(android.widget.MediaController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setMediaController12391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setMediaController12391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _VideoView12392;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView12393;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView12394;
		public VideoView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.VideoView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/VideoView"));
			global::android.widget.VideoView._start12368 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "start", "()V");
			global::android.widget.VideoView._suspend12369 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "suspend", "()V");
			global::android.widget.VideoView._resume12370 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resume", "()V");
			global::android.widget.VideoView._onKeyDown12371 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.VideoView._onTouchEvent12372 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onTrackballEvent12373 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onMeasure12374 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V");
			global::android.widget.VideoView._getDuration12375 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getDuration", "()I");
			global::android.widget.VideoView._pause12376 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "pause", "()V");
			global::android.widget.VideoView._isPlaying12377 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "isPlaying", "()Z");
			global::android.widget.VideoView._seekTo12378 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "seekTo", "(I)V");
			global::android.widget.VideoView._getCurrentPosition12379 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I");
			global::android.widget.VideoView._setOnPreparedListener12380 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.widget.VideoView._setOnCompletionListener12381 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.widget.VideoView._setOnErrorListener12382 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.widget.VideoView._getBufferPercentage12383 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I");
			global::android.widget.VideoView._canPause12384 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canPause", "()Z");
			global::android.widget.VideoView._canSeekBackward12385 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z");
			global::android.widget.VideoView._canSeekForward12386 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z");
			global::android.widget.VideoView._resolveAdjustedSize12387 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I");
			global::android.widget.VideoView._setVideoPath12388 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V");
			global::android.widget.VideoView._setVideoURI12389 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V");
			global::android.widget.VideoView._stopPlayback12390 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "stopPlayback", "()V");
			global::android.widget.VideoView._setMediaController12391 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V");
			global::android.widget.VideoView._VideoView12392 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.VideoView._VideoView12393 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.VideoView._VideoView12394 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
