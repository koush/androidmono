namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class VideoView : android.view.SurfaceView, android.widget.MediaController.MediaPlayerControl
	{
		internal new static global::java.lang.Class staticClass;
		static VideoView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.VideoView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.VideoView(@__env);
			}
		}
		protected VideoView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _start11264;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._start11264);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._start11264);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown11265;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._onKeyDown11265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onKeyDown11265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11266;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._onTouchEvent11266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTouchEvent11266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent11267;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._onTrackballEvent11267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTrackballEvent11267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11268;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._onMeasure11268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onMeasure11268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration11269;
		public virtual int getDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._getDuration11269);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getDuration11269);
		}
		internal static global::net.sf.jni4net.jni.MethodId _pause11270;
		public virtual void pause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._pause11270);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._pause11270);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying11271;
		public virtual bool isPlaying() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._isPlaying11271);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._isPlaying11271);
		}
		internal static global::net.sf.jni4net.jni.MethodId _seekTo11272;
		public virtual void seekTo(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._seekTo11272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._seekTo11272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition11273;
		public virtual int getCurrentPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._getCurrentPosition11273);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getCurrentPosition11273);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreparedListener11274;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setOnPreparedListener11274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnPreparedListener11274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCompletionListener11275;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setOnCompletionListener11275, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnCompletionListener11275, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener11276;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setOnErrorListener11276, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnErrorListener11276, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBufferPercentage11277;
		public virtual int getBufferPercentage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._getBufferPercentage11277);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getBufferPercentage11277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canPause11278;
		public virtual bool canPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._canPause11278);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canPause11278);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canSeekBackward11279;
		public virtual bool canSeekBackward() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._canSeekBackward11279);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekBackward11279);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canSeekForward11280;
		public virtual bool canSeekForward() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._canSeekForward11280);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekForward11280);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveAdjustedSize11281;
		public virtual int resolveAdjustedSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._resolveAdjustedSize11281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resolveAdjustedSize11281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoPath11282;
		public virtual void setVideoPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setVideoPath11282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoPath11282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoURI11283;
		public virtual void setVideoURI(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setVideoURI11283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoURI11283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopPlayback11284;
		public virtual void stopPlayback() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._stopPlayback11284);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._stopPlayback11284);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMediaController11285;
		public virtual void setMediaController(android.widget.MediaController arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setMediaController11285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setMediaController11285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _VideoView11286;
		public VideoView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView11286, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _VideoView11287;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView11287, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _VideoView11288;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView11288, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.VideoView.staticClass = @__class;
			global::android.widget.VideoView._start11264 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "start", "()V");
			global::android.widget.VideoView._onKeyDown11265 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.VideoView._onTouchEvent11266 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onTrackballEvent11267 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onMeasure11268 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V");
			global::android.widget.VideoView._getDuration11269 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getDuration", "()I");
			global::android.widget.VideoView._pause11270 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "pause", "()V");
			global::android.widget.VideoView._isPlaying11271 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "isPlaying", "()Z");
			global::android.widget.VideoView._seekTo11272 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "seekTo", "(I)V");
			global::android.widget.VideoView._getCurrentPosition11273 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I");
			global::android.widget.VideoView._setOnPreparedListener11274 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.widget.VideoView._setOnCompletionListener11275 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.widget.VideoView._setOnErrorListener11276 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.widget.VideoView._getBufferPercentage11277 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I");
			global::android.widget.VideoView._canPause11278 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canPause", "()Z");
			global::android.widget.VideoView._canSeekBackward11279 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z");
			global::android.widget.VideoView._canSeekForward11280 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z");
			global::android.widget.VideoView._resolveAdjustedSize11281 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I");
			global::android.widget.VideoView._setVideoPath11282 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V");
			global::android.widget.VideoView._setVideoURI11283 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V");
			global::android.widget.VideoView._stopPlayback11284 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "stopPlayback", "()V");
			global::android.widget.VideoView._setMediaController11285 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V");
			global::android.widget.VideoView._VideoView11286 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.VideoView._VideoView11287 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.VideoView._VideoView11288 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
