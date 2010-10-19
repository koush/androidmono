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
			internal static global::MonoJavaBridge.MethodId _start12129;
			 void android.widget.MediaController.MediaPlayerControl.start() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._start12129);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._start12129);
			}
			internal static global::MonoJavaBridge.MethodId _getDuration12130;
			 int android.widget.MediaController.MediaPlayerControl.getDuration() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getDuration12130);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getDuration12130);
			}
			internal static global::MonoJavaBridge.MethodId _pause12131;
			 void android.widget.MediaController.MediaPlayerControl.pause() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._pause12131);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._pause12131);
			}
			internal static global::MonoJavaBridge.MethodId _isPlaying12132;
			 bool android.widget.MediaController.MediaPlayerControl.isPlaying() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._isPlaying12132);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._isPlaying12132);
			}
			internal static global::MonoJavaBridge.MethodId _seekTo12133;
			 void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._seekTo12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._seekTo12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getCurrentPosition12134;
			 int android.widget.MediaController.MediaPlayerControl.getCurrentPosition() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition12134);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition12134);
			}
			internal static global::MonoJavaBridge.MethodId _getBufferPercentage12135;
			 int android.widget.MediaController.MediaPlayerControl.getBufferPercentage() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage12135);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage12135);
			}
			internal static global::MonoJavaBridge.MethodId _canPause12136;
			 bool android.widget.MediaController.MediaPlayerControl.canPause() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canPause12136);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canPause12136);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekBackward12137;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekBackward() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward12137);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward12137);
			}
			internal static global::MonoJavaBridge.MethodId _canSeekForward12138;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekForward() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_._canSeekForward12138);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.MediaPlayerControl_.staticClass, global::android.widget.MediaController.MediaPlayerControl_._canSeekForward12138);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MediaController.MediaPlayerControl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController$MediaPlayerControl"));
				global::android.widget.MediaController.MediaPlayerControl_._start12129 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "start", "()V");
				global::android.widget.MediaController.MediaPlayerControl_._getDuration12130 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getDuration", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._pause12131 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "pause", "()V");
				global::android.widget.MediaController.MediaPlayerControl_._isPlaying12132 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "isPlaying", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._seekTo12133 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "seekTo", "(I)V");
				global::android.widget.MediaController.MediaPlayerControl_._getCurrentPosition12134 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getCurrentPosition", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._getBufferPercentage12135 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getBufferPercentage", "()I");
				global::android.widget.MediaController.MediaPlayerControl_._canPause12136 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canPause", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._canSeekBackward12137 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekBackward", "()Z");
				global::android.widget.MediaController.MediaPlayerControl_._canSeekForward12138 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekForward", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled12139;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setEnabled12139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setEnabled12139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12140;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._onTouchEvent12140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTouchEvent12140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent12141;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._onTrackballEvent12141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTrackballEvent12141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent12142;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._dispatchKeyEvent12142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._dispatchKeyEvent12142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate12143;
		public virtual void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._onFinishInflate12143);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onFinishInflate12143);
		}
		internal static global::MonoJavaBridge.MethodId _isShowing12144;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.MediaController._isShowing12144);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._isShowing12144);
		}
		internal static global::MonoJavaBridge.MethodId _show12145;
		public virtual void show(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._show12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show12146;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._show12146);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show12146);
		}
		internal static global::MonoJavaBridge.MethodId _hide12147;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._hide12147);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._hide12147);
		}
		internal static global::MonoJavaBridge.MethodId _setMediaPlayer12148;
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setMediaPlayer12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setMediaPlayer12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnchorView12149;
		public virtual void setAnchorView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setAnchorView12149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setAnchorView12149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrevNextListeners12150;
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.MediaController._setPrevNextListeners12150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setPrevNextListeners12150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MediaController12151;
		public MediaController(android.content.Context arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController12151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController12152;
		public MediaController(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController12152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MediaController12153;
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController12153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MediaController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController"));
			global::android.widget.MediaController._setEnabled12139 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V");
			global::android.widget.MediaController._onTouchEvent12140 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._onTrackballEvent12141 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._dispatchKeyEvent12142 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.MediaController._onFinishInflate12143 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "onFinishInflate", "()V");
			global::android.widget.MediaController._isShowing12144 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "isShowing", "()Z");
			global::android.widget.MediaController._show12145 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "show", "(I)V");
			global::android.widget.MediaController._show12146 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "show", "()V");
			global::android.widget.MediaController._hide12147 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "hide", "()V");
			global::android.widget.MediaController._setMediaPlayer12148 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V");
			global::android.widget.MediaController._setAnchorView12149 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V");
			global::android.widget.MediaController._setPrevNextListeners12150 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V");
			global::android.widget.MediaController._MediaController12151 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::android.widget.MediaController._MediaController12152 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MediaController._MediaController12153 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
