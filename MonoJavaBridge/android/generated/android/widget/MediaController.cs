namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaController : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal sealed partial class MediaPlayerControl_ : java.lang.Object, MediaPlayerControl
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MediaPlayerControl_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.MediaController.MediaPlayerControl.start()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "start", "()V", ref global::android.widget.MediaController.MediaPlayerControl_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			int android.widget.MediaController.MediaPlayerControl.getDuration()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getDuration", "()I", ref global::android.widget.MediaController.MediaPlayerControl_._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.widget.MediaController.MediaPlayerControl.pause()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "pause", "()V", ref global::android.widget.MediaController.MediaPlayerControl_._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			bool android.widget.MediaController.MediaPlayerControl.isPlaying()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "isPlaying", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "seekTo", "(I)V", ref global::android.widget.MediaController.MediaPlayerControl_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			int android.widget.MediaController.MediaPlayerControl.getCurrentPosition()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getCurrentPosition", "()I", ref global::android.widget.MediaController.MediaPlayerControl_._m5);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			int android.widget.MediaController.MediaPlayerControl.getBufferPercentage()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "getBufferPercentage", "()I", ref global::android.widget.MediaController.MediaPlayerControl_._m6);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			bool android.widget.MediaController.MediaPlayerControl.canPause()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canPause", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			bool android.widget.MediaController.MediaPlayerControl.canSeekBackward()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekBackward", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._m8);
			}
			private static global::MonoJavaBridge.MethodId _m9;
			bool android.widget.MediaController.MediaPlayerControl.canSeekForward()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.MediaPlayerControl_.staticClass, "canSeekForward", "()Z", ref global::android.widget.MediaController.MediaPlayerControl_._m9);
			}
			static MediaPlayerControl_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.MediaController.MediaPlayerControl_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController$MediaPlayerControl"));
			}
			internal static void InitJNI()
			{
			}
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V", ref global::android.widget.MediaController._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.MediaController._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.MediaController._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.MediaController._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "onFinishInflate", "()V", ref global::android.widget.MediaController._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.MediaController.staticClass, "isShowing", "()Z", ref global::android.widget.MediaController._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void show(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "show", "(I)V", ref global::android.widget.MediaController._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "show", "()V", ref global::android.widget.MediaController._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void hide()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "hide", "()V", ref global::android.widget.MediaController._m8);
		}
		public new global::android.widget.MediaController.MediaPlayerControl MediaPlayer
		{
			set
			{
				setMediaPlayer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V", ref global::android.widget.MediaController._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View AnchorView
		{
			set
			{
				setAnchorView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setAnchorView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V", ref global::android.widget.MediaController._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V", ref global::android.widget.MediaController._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setPrevNextListeners(global::android.view.View.OnClickListenerDelegate arg0, global::android.view.View.OnClickListenerDelegate arg1)
		{
			setPrevNextListeners((global::android.view.View.OnClickListenerDelegateWrapper)arg0, (global::android.view.View.OnClickListenerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public MediaController(android.content.Context arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MediaController._m12.native == global::System.IntPtr.Zero)
				global::android.widget.MediaController._m12 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public MediaController(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MediaController._m13.native == global::System.IntPtr.Zero)
				global::android.widget.MediaController._m13 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.MediaController._m14.native == global::System.IntPtr.Zero)
				global::android.widget.MediaController._m14 = @__env.GetMethodIDNoThrow(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MediaController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.MediaController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/MediaController"));
		}
		internal static void InitJNI()
		{
		}
	}
}
