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
		internal static global::MonoJavaBridge.MethodId _start18103;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._start18103);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._start18103);
		}
		internal static global::MonoJavaBridge.MethodId _suspend18104;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._suspend18104);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._suspend18104);
		}
		internal static global::MonoJavaBridge.MethodId _resume18105;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._resume18105);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resume18105);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown18106;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onKeyDown18106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onKeyDown18106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent18107;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onTouchEvent18107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTouchEvent18107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent18108;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._onTrackballEvent18108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTrackballEvent18108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure18109;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._onMeasure18109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onMeasure18109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDuration18110;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getDuration18110);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getDuration18110);
		}
		internal static global::MonoJavaBridge.MethodId _pause18111;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._pause18111);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._pause18111);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying18112;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._isPlaying18112);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._isPlaying18112);
		}
		internal static global::MonoJavaBridge.MethodId _seekTo18113;
		public virtual void seekTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._seekTo18113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._seekTo18113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentPosition
		{
			get
			{
				return getCurrentPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentPosition18114;
		public virtual int getCurrentPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getCurrentPosition18114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getCurrentPosition18114);
		}
		internal static global::MonoJavaBridge.MethodId _setOnPreparedListener18115;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnPreparedListener18115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnPreparedListener18115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCompletionListener18116;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnCompletionListener18116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnCompletionListener18116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener18117;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setOnErrorListener18117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnErrorListener18117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BufferPercentage
		{
			get
			{
				return getBufferPercentage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBufferPercentage18118;
		public virtual int getBufferPercentage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._getBufferPercentage18118);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getBufferPercentage18118);
		}
		internal static global::MonoJavaBridge.MethodId _canPause18119;
		public virtual bool canPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canPause18119);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canPause18119);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekBackward18120;
		public virtual bool canSeekBackward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canSeekBackward18120);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekBackward18120);
		}
		internal static global::MonoJavaBridge.MethodId _canSeekForward18121;
		public virtual bool canSeekForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.VideoView._canSeekForward18121);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekForward18121);
		}
		internal static global::MonoJavaBridge.MethodId _resolveAdjustedSize18122;
		public virtual int resolveAdjustedSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.VideoView._resolveAdjustedSize18122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resolveAdjustedSize18122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoPath18123;
		public virtual void setVideoPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setVideoPath18123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoPath18123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoURI18124;
		public virtual void setVideoURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setVideoURI18124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoURI18124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopPlayback18125;
		public virtual void stopPlayback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._stopPlayback18125);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._stopPlayback18125);
		}
		internal static global::MonoJavaBridge.MethodId _setMediaController18126;
		public virtual void setMediaController(android.widget.MediaController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.VideoView._setMediaController18126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setMediaController18126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _VideoView18127;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView18127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView18128;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView18128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _VideoView18129;
		public VideoView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView18129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.VideoView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/VideoView"));
			global::android.widget.VideoView._start18103 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "start", "()V");
			global::android.widget.VideoView._suspend18104 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "suspend", "()V");
			global::android.widget.VideoView._resume18105 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resume", "()V");
			global::android.widget.VideoView._onKeyDown18106 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.VideoView._onTouchEvent18107 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onTrackballEvent18108 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onMeasure18109 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V");
			global::android.widget.VideoView._getDuration18110 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getDuration", "()I");
			global::android.widget.VideoView._pause18111 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "pause", "()V");
			global::android.widget.VideoView._isPlaying18112 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "isPlaying", "()Z");
			global::android.widget.VideoView._seekTo18113 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "seekTo", "(I)V");
			global::android.widget.VideoView._getCurrentPosition18114 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I");
			global::android.widget.VideoView._setOnPreparedListener18115 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.widget.VideoView._setOnCompletionListener18116 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.widget.VideoView._setOnErrorListener18117 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.widget.VideoView._getBufferPercentage18118 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I");
			global::android.widget.VideoView._canPause18119 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canPause", "()Z");
			global::android.widget.VideoView._canSeekBackward18120 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z");
			global::android.widget.VideoView._canSeekForward18121 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z");
			global::android.widget.VideoView._resolveAdjustedSize18122 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I");
			global::android.widget.VideoView._setVideoPath18123 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V");
			global::android.widget.VideoView._setVideoURI18124 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V");
			global::android.widget.VideoView._stopPlayback18125 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "stopPlayback", "()V");
			global::android.widget.VideoView._setMediaController18126 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V");
			global::android.widget.VideoView._VideoView18127 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.VideoView._VideoView18128 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.VideoView._VideoView18129 = @__env.GetMethodIDNoThrow(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
