namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaController : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MediaController()
		{
			InitJNI();
		}
		protected MediaController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.MediaController.MediaPlayerControl_))]
		public interface MediaPlayerControl  : global::MonoJavaBridge.IJavaObject 
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
		public sealed partial class MediaPlayerControl_ : java.lang.Object, MediaPlayerControl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MediaPlayerControl_()
			{
				InitJNI();
			}
			internal MediaPlayerControl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _start11583;
			 void android.widget.MediaController.MediaPlayerControl.start() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._start11583);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._start11583);
			}
			internal static global::MonoJavaBridge.MethodId _getDuration11584;
			 int android.widget.MediaController.MediaPlayerControl.getDuration() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getDuration11584);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getDuration11584);
			}
			internal static global::MonoJavaBridge.MethodId _pause11585;
			 void android.widget.MediaController.MediaPlayerControl.pause() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._pause11585);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._pause11585);
			}
			internal static global::MonoJavaBridge.MethodId _isPlaying11586;
			 bool android.widget.MediaController.MediaPlayerControl.isPlaying() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._isPlaying11586);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._isPlaying11586);
			}
			internal static global::MonoJavaBridge.MethodId _seekTo11587;
			 void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._seekTo11587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._seekTo11587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentPosition11588;
			 int android.widget.MediaController.MediaPlayerControl.getCurrentPosition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition11588);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition11588);
			}
			internal static global::MonoJavaBridge.MethodId _getBufferPercentage11589;
			 int android.widget.MediaController.MediaPlayerControl.getBufferPercentage() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage11589);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage11589);
			}
			internal static global::MonoJavaBridge.MethodId _canPause11590;
			 bool android.widget.MediaController.MediaPlayerControl.canPause() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canPause11590);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canPause11590);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekBackward11591;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekBackward() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward11591);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward11591);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekForward11592;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekForward() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canSeekForward11592);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canSeekForward11592);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MediaController.MediaPlayerControl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController$MediaPlayerControl"));
				global::android.widget.MediaController.MediaPlayerControl_._start11583 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "start", "()V");
				global::android.widget.MediaController.MediaPlayerControl_._getDuration11584 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getDuration", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._pause11585 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "pause", "()V");
				global::android.widget.MediaController.MediaPlayerControl_._isPlaying11586 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "isPlaying", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._seekTo11587 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "seekTo", "(I)V");
				global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition11588 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getCurrentPosition", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage11589 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getBufferPercentage", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._canPause11590 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canPause", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward11591 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekBackward", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._canSeekForward11592 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekForward", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled11593;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setEnabled11593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setEnabled11593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11594;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._onTouchEvent11594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTouchEvent11594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent11595;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._onTrackballEvent11595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTrackballEvent11595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent11596;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._dispatchKeyEvent11596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._dispatchKeyEvent11596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate11597;
		public virtual new void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._onFinishInflate11597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onFinishInflate11597);
		}
		internal static global::MonoJavaBridge.MethodId _isShowing11598;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._isShowing11598);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._isShowing11598);
		}
		internal static global::MonoJavaBridge.MethodId _show11599;
		public virtual void show(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._show11599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show11599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show11600;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._show11600);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show11600);
		}
		internal static global::MonoJavaBridge.MethodId _hide11601;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._hide11601);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._hide11601);
		}
		internal static global::MonoJavaBridge.MethodId _setMediaPlayer11602;
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setMediaPlayer11602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setMediaPlayer11602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnchorView11603;
		public virtual void setAnchorView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setAnchorView11603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setAnchorView11603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrevNextListeners11604;
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setPrevNextListeners11604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setPrevNextListeners11604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MediaController11605;
		public MediaController(android.content.Context arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController11605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController11606;
		public MediaController(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController11606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController11607;
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController11607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MediaController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController"));
			global::android.widget.MediaController._setEnabled11593 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V");
			global::android.widget.MediaController._onTouchEvent11594 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._onTrackballEvent11595 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._dispatchKeyEvent11596 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.MediaController._onFinishInflate11597 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onFinishInflate", "()V");
			global::android.widget.MediaController._isShowing11598 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "isShowing", "()Z");
			global::android.widget.MediaController._show11599 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "show", "(I)V");
			global::android.widget.MediaController._show11600 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "show", "()V");
			global::android.widget.MediaController._hide11601 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "hide", "()V");
			global::android.widget.MediaController._setMediaPlayer11602 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V");
			global::android.widget.MediaController._setAnchorView11603 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V");
			global::android.widget.MediaController._setPrevNextListeners11604 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V");
			global::android.widget.MediaController._MediaController11605 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::android.widget.MediaController._MediaController11606 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MediaController._MediaController11607 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
