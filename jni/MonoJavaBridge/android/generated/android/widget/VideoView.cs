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
		internal static global::net.sf.jni4net.jni.MethodId _start11981;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._start11981);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._start11981);
		}
		internal static global::net.sf.jni4net.jni.MethodId _suspend11982;
		public virtual void suspend() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._suspend11982);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._suspend11982);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resume11983;
		public virtual void resume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._resume11983);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resume11983);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown11984;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._onKeyDown11984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onKeyDown11984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11985;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._onTouchEvent11985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTouchEvent11985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent11986;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._onTrackballEvent11986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onTrackballEvent11986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11987;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._onMeasure11987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._onMeasure11987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration11988;
		public virtual int getDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._getDuration11988);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getDuration11988);
		}
		internal static global::net.sf.jni4net.jni.MethodId _pause11989;
		public virtual void pause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._pause11989);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._pause11989);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying11990;
		public virtual bool isPlaying() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._isPlaying11990);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._isPlaying11990);
		}
		internal static global::net.sf.jni4net.jni.MethodId _seekTo11991;
		public virtual void seekTo(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._seekTo11991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._seekTo11991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition11992;
		public virtual int getCurrentPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._getCurrentPosition11992);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getCurrentPosition11992);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreparedListener11993;
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setOnPreparedListener11993, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnPreparedListener11993, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCompletionListener11994;
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setOnCompletionListener11994, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnCompletionListener11994, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener11995;
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setOnErrorListener11995, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setOnErrorListener11995, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBufferPercentage11996;
		public virtual int getBufferPercentage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._getBufferPercentage11996);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._getBufferPercentage11996);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canPause11997;
		public virtual bool canPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._canPause11997);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canPause11997);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canSeekBackward11998;
		public virtual bool canSeekBackward() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._canSeekBackward11998);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekBackward11998);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canSeekForward11999;
		public virtual bool canSeekForward() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.VideoView._canSeekForward11999);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._canSeekForward11999);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveAdjustedSize12000;
		public virtual int resolveAdjustedSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.VideoView._resolveAdjustedSize12000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._resolveAdjustedSize12000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoPath12001;
		public virtual void setVideoPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setVideoPath12001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoPath12001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoURI12002;
		public virtual void setVideoURI(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setVideoURI12002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setVideoURI12002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopPlayback12003;
		public virtual void stopPlayback() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._stopPlayback12003);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._stopPlayback12003);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMediaController12004;
		public virtual void setMediaController(android.widget.MediaController arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.VideoView._setMediaController12004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.VideoView.staticClass, global::android.widget.VideoView._setMediaController12004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _VideoView12005;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12005, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _VideoView12006;
		public VideoView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12006, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _VideoView12007;
		public VideoView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.VideoView.staticClass, global::android.widget.VideoView._VideoView12007, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.VideoView.staticClass = @__class;
			global::android.widget.VideoView._start11981 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "start", "()V");
			global::android.widget.VideoView._suspend11982 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "suspend", "()V");
			global::android.widget.VideoView._resume11983 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "resume", "()V");
			global::android.widget.VideoView._onKeyDown11984 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.VideoView._onTouchEvent11985 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onTrackballEvent11986 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.VideoView._onMeasure11987 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "onMeasure", "(II)V");
			global::android.widget.VideoView._getDuration11988 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getDuration", "()I");
			global::android.widget.VideoView._pause11989 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "pause", "()V");
			global::android.widget.VideoView._isPlaying11990 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "isPlaying", "()Z");
			global::android.widget.VideoView._seekTo11991 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "seekTo", "(I)V");
			global::android.widget.VideoView._getCurrentPosition11992 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getCurrentPosition", "()I");
			global::android.widget.VideoView._setOnPreparedListener11993 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V");
			global::android.widget.VideoView._setOnCompletionListener11994 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V");
			global::android.widget.VideoView._setOnErrorListener11995 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V");
			global::android.widget.VideoView._getBufferPercentage11996 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "getBufferPercentage", "()I");
			global::android.widget.VideoView._canPause11997 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canPause", "()Z");
			global::android.widget.VideoView._canSeekBackward11998 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canSeekBackward", "()Z");
			global::android.widget.VideoView._canSeekForward11999 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "canSeekForward", "()Z");
			global::android.widget.VideoView._resolveAdjustedSize12000 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "resolveAdjustedSize", "(II)I");
			global::android.widget.VideoView._setVideoPath12001 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setVideoPath", "(Ljava/lang/String;)V");
			global::android.widget.VideoView._setVideoURI12002 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setVideoURI", "(Landroid/net/Uri;)V");
			global::android.widget.VideoView._stopPlayback12003 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "stopPlayback", "()V");
			global::android.widget.VideoView._setMediaController12004 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "setMediaController", "(Landroid/widget/MediaController;)V");
			global::android.widget.VideoView._VideoView12005 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.VideoView._VideoView12006 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.VideoView._VideoView12007 = @__env.GetMethodID(global::android.widget.VideoView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
