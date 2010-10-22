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
			internal static global::MonoJavaBridge.MethodId _start17294;
			 void android.widget.MediaController.MediaPlayerControl.start() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._start17294);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._start17294);
			}
			internal static global::MonoJavaBridge.MethodId _getDuration17295;
			 int android.widget.MediaController.MediaPlayerControl.getDuration() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getDuration17295);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getDuration17295);
			}
			internal static global::MonoJavaBridge.MethodId _pause17296;
			 void android.widget.MediaController.MediaPlayerControl.pause() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._pause17296);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._pause17296);
			}
			internal static global::MonoJavaBridge.MethodId _isPlaying17297;
			 bool android.widget.MediaController.MediaPlayerControl.isPlaying() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._isPlaying17297);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._isPlaying17297);
			}
			internal static global::MonoJavaBridge.MethodId _seekTo17298;
			 void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._seekTo17298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._seekTo17298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentPosition17299;
			 int android.widget.MediaController.MediaPlayerControl.getCurrentPosition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition17299);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition17299);
			}
			internal static global::MonoJavaBridge.MethodId _getBufferPercentage17300;
			 int android.widget.MediaController.MediaPlayerControl.getBufferPercentage() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage17300);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage17300);
			}
			internal static global::MonoJavaBridge.MethodId _canPause17301;
			 bool android.widget.MediaController.MediaPlayerControl.canPause() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canPause17301);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canPause17301);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekBackward17302;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekBackward() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward17302);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward17302);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekForward17303;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekForward() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canSeekForward17303);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canSeekForward17303);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MediaController.MediaPlayerControl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController$MediaPlayerControl"));
				global::android.widget.MediaController.MediaPlayerControl_._start17294 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "start", "()V");
				global::android.widget.MediaController.MediaPlayerControl_._getDuration17295 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getDuration", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._pause17296 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "pause", "()V");
				global::android.widget.MediaController.MediaPlayerControl_._isPlaying17297 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "isPlaying", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._seekTo17298 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "seekTo", "(I)V");
				global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition17299 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getCurrentPosition", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage17300 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getBufferPercentage", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._canPause17301 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canPause", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward17302 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekBackward", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._canSeekForward17303 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekForward", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled17304;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setEnabled17304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setEnabled17304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17305;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._onTouchEvent17305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTouchEvent17305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent17306;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._onTrackballEvent17306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTrackballEvent17306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17307;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._dispatchKeyEvent17307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._dispatchKeyEvent17307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17308;
		public virtual void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._onFinishInflate17308);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onFinishInflate17308);
		}
		internal static global::MonoJavaBridge.MethodId _isShowing17309;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._isShowing17309);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._isShowing17309);
		}
		internal static global::MonoJavaBridge.MethodId _show17310;
		public virtual void show(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._show17310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show17310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show17311;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._show17311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show17311);
		}
		internal static global::MonoJavaBridge.MethodId _hide17312;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._hide17312);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._hide17312);
		}
		internal static global::MonoJavaBridge.MethodId _setMediaPlayer17313;
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setMediaPlayer17313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setMediaPlayer17313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnchorView17314;
		public virtual void setAnchorView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setAnchorView17314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setAnchorView17314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrevNextListeners17315;
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setPrevNextListeners17315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setPrevNextListeners17315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MediaController17316;
		public MediaController(android.content.Context arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController17316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController17317;
		public MediaController(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController17317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController17318;
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController17318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MediaController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController"));
			global::android.widget.MediaController._setEnabled17304 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V");
			global::android.widget.MediaController._onTouchEvent17305 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._onTrackballEvent17306 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._dispatchKeyEvent17307 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.MediaController._onFinishInflate17308 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onFinishInflate", "()V");
			global::android.widget.MediaController._isShowing17309 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "isShowing", "()Z");
			global::android.widget.MediaController._show17310 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "show", "(I)V");
			global::android.widget.MediaController._show17311 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "show", "()V");
			global::android.widget.MediaController._hide17312 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "hide", "()V");
			global::android.widget.MediaController._setMediaPlayer17313 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V");
			global::android.widget.MediaController._setAnchorView17314 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V");
			global::android.widget.MediaController._setPrevNextListeners17315 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V");
			global::android.widget.MediaController._MediaController17316 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::android.widget.MediaController._MediaController17317 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MediaController._MediaController17318 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
