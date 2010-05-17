namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class VideoView : android.view.SurfaceView, android.widget.MediaController.MediaPlayerControl
	{ 
		internal new static global::java.lang.Class staticClass; 
		static VideoView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.VideoView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _start10459; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _start10459); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _start10459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10460; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown10460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _onKeyDown10460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10461; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent10461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _onTouchEvent10461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent10462; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent10462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _onTrackballEvent10462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10463; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _onMeasure10463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _onMeasure10463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration10464; 
		public virtual int getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallIntMethod(this, _getDuration10464); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.VideoView.staticClass, _getDuration10464); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause10465; 
		public virtual void pause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _pause10465); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _pause10465); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying10466; 
		public virtual bool isPlaying() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _isPlaying10466); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _isPlaying10466); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _seekTo10467; 
		public virtual void seekTo(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _seekTo10467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _seekTo10467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition10468; 
		public virtual int getCurrentPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallIntMethod(this, _getCurrentPosition10468); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.VideoView.staticClass, _getCurrentPosition10468); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreparedListener10469; 
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _setOnPreparedListener10469, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _setOnPreparedListener10469, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCompletionListener10470; 
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _setOnCompletionListener10470, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _setOnCompletionListener10470, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener10471; 
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _setOnErrorListener10471, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _setOnErrorListener10471, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBufferPercentage10472; 
		public virtual int getBufferPercentage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallIntMethod(this, _getBufferPercentage10472); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.VideoView.staticClass, _getBufferPercentage10472); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canPause10473; 
		public virtual bool canPause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _canPause10473); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _canPause10473); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canSeekBackward10474; 
		public virtual bool canSeekBackward() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _canSeekBackward10474); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _canSeekBackward10474); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canSeekForward10475; 
		public virtual bool canSeekForward() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallBooleanMethod(this, _canSeekForward10475); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.VideoView.staticClass, _canSeekForward10475); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveAdjustedSize10476; 
		public virtual int resolveAdjustedSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				return @__env.CallIntMethod(this, _resolveAdjustedSize10476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.VideoView.staticClass, _resolveAdjustedSize10476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoPath10477; 
		public virtual void setVideoPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _setVideoPath10477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _setVideoPath10477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoURI10478; 
		public virtual void setVideoURI(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _setVideoURI10478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _setVideoURI10478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopPlayback10479; 
		public virtual void stopPlayback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _stopPlayback10479); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _stopPlayback10479); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMediaController10480; 
		public virtual void setMediaController(android.widget.MediaController arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.VideoView)) 
				@__env.CallVoidMethod(this, _setMediaController10480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.VideoView.staticClass, _setMediaController10480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _VideoView10481; 
		public VideoView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.VideoView.staticClass, _VideoView10481, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _VideoView10482; 
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.VideoView.staticClass, _VideoView10482, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _VideoView10483; 
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.VideoView.staticClass, _VideoView10483, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.VideoView.staticClass = @__class; 
			global::android.widget.VideoView._start10459 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "start", "()V"); 
			global::android.widget.VideoView._onKeyDown10460 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.VideoView._onTouchEvent10461 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.VideoView._onTrackballEvent10462 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.VideoView._onMeasure10463 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.VideoView._getDuration10464 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getDuration", "()I"); 
			global::android.widget.VideoView._pause10465 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "pause", "()V"); 
			global::android.widget.VideoView._isPlaying10466 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "isPlaying", "()Z"); 
			global::android.widget.VideoView._seekTo10467 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "seekTo", "(I)V"); 
			global::android.widget.VideoView._getCurrentPosition10468 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I"); 
			global::android.widget.VideoView._setOnPreparedListener10469 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V"); 
			global::android.widget.VideoView._setOnCompletionListener10470 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V"); 
			global::android.widget.VideoView._setOnErrorListener10471 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V"); 
			global::android.widget.VideoView._getBufferPercentage10472 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I"); 
			global::android.widget.VideoView._canPause10473 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canPause", "()Z"); 
			global::android.widget.VideoView._canSeekBackward10474 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z"); 
			global::android.widget.VideoView._canSeekForward10475 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z"); 
			global::android.widget.VideoView._resolveAdjustedSize10476 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I"); 
			global::android.widget.VideoView._setVideoPath10477 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V"); 
			global::android.widget.VideoView._setVideoURI10478 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V"); 
			global::android.widget.VideoView._stopPlayback10479 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "stopPlayback", "()V"); 
			global::android.widget.VideoView._setMediaController10480 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V"); 
			global::android.widget.VideoView._VideoView10481 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.VideoView._VideoView10482 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.VideoView._VideoView10483 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
