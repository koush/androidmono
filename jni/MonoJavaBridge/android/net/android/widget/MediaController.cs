namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MediaController : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MediaController() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.MediaController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.MediaController(@__env); 
			} 
		} 
		protected MediaController(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface MediaPlayerControl 
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

		public partial class MediaPlayerControl_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __MediaPlayerControl.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __MediaPlayerControl : java.lang.Object, MediaPlayerControl
		{ 
			internal static global::java.lang.Class staticClass; 
			static __MediaPlayerControl() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.MediaController.__MediaPlayerControl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.MediaController.__MediaPlayerControl(@__env); 
				} 
			} 
			internal __MediaPlayerControl(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _start10494; 
			 void android.widget.MediaController.MediaPlayerControl.start() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					@__env.CallVoidMethod(this, _start10494); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _start10494); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDuration10495; 
			 int android.widget.MediaController.MediaPlayerControl.getDuration() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallIntMethod(this, _getDuration10495); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _getDuration10495); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _pause10496; 
			 void android.widget.MediaController.MediaPlayerControl.pause() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					@__env.CallVoidMethod(this, _pause10496); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _pause10496); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isPlaying10497; 
			 bool android.widget.MediaController.MediaPlayerControl.isPlaying() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallBooleanMethod(this, _isPlaying10497); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _isPlaying10497); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _seekTo10498; 
			 void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					@__env.CallVoidMethod(this, _seekTo10498, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _seekTo10498, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition10499; 
			 int android.widget.MediaController.MediaPlayerControl.getCurrentPosition() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallIntMethod(this, _getCurrentPosition10499); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _getCurrentPosition10499); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getBufferPercentage10500; 
			 int android.widget.MediaController.MediaPlayerControl.getBufferPercentage() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallIntMethod(this, _getBufferPercentage10500); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _getBufferPercentage10500); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _canPause10501; 
			 bool android.widget.MediaController.MediaPlayerControl.canPause() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallBooleanMethod(this, _canPause10501); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _canPause10501); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _canSeekBackward10502; 
			 bool android.widget.MediaController.MediaPlayerControl.canSeekBackward() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallBooleanMethod(this, _canSeekBackward10502); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _canSeekBackward10502); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _canSeekForward10503; 
			 bool android.widget.MediaController.MediaPlayerControl.canSeekForward() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.MediaController.__MediaPlayerControl)) 
					return @__env.CallBooleanMethod(this, _canSeekForward10503); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.__MediaPlayerControl.staticClass, _canSeekForward10503); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.MediaController.__MediaPlayerControl.staticClass = @__class; 
				global::android.widget.MediaController.__MediaPlayerControl._start10494 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.start", "()V"); 
				global::android.widget.MediaController.__MediaPlayerControl._getDuration10495 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.getDuration", "()I"); 
				global::android.widget.MediaController.__MediaPlayerControl._pause10496 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.pause", "()V"); 
				global::android.widget.MediaController.__MediaPlayerControl._isPlaying10497 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.isPlaying", "()Z"); 
				global::android.widget.MediaController.__MediaPlayerControl._seekTo10498 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.seekTo", "(I)V"); 
				global::android.widget.MediaController.__MediaPlayerControl._getCurrentPosition10499 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.getCurrentPosition", "()I"); 
				global::android.widget.MediaController.__MediaPlayerControl._getBufferPercentage10500 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.getBufferPercentage", "()I"); 
				global::android.widget.MediaController.__MediaPlayerControl._canPause10501 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.canPause", "()Z"); 
				global::android.widget.MediaController.__MediaPlayerControl._canSeekBackward10502 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.canSeekBackward", "()Z"); 
				global::android.widget.MediaController.__MediaPlayerControl._canSeekForward10503 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.canSeekForward", "()Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled10504; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setEnabled10504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setEnabled10504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10505; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent10505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _onTouchEvent10505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent10506; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent10506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _onTrackballEvent10506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10507; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent10507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _dispatchKeyEvent10507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10508; 
		public virtual new void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _onFinishInflate10508); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _onFinishInflate10508); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowing10509; 
		public virtual bool isShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _isShowing10509); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _isShowing10509); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show10510; 
		public virtual void show(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _show10510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _show10510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show10511; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _show10511); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _show10511); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hide10512; 
		public virtual void hide() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _hide10512); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _hide10512); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMediaPlayer10513; 
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setMediaPlayer10513, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setMediaPlayer10513, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnchorView10514; 
		public virtual void setAnchorView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setAnchorView10514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setAnchorView10514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPrevNextListeners10515; 
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setPrevNextListeners10515, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setPrevNextListeners10515, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaController10516; 
		public MediaController(android.content.Context arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MediaController.staticClass, _MediaController10516, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaController10517; 
		public MediaController(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MediaController.staticClass, _MediaController10517, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaController10518; 
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MediaController.staticClass, _MediaController10518, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.MediaController.staticClass = @__class; 
			global::android.widget.MediaController._setEnabled10504 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.MediaController._onTouchEvent10505 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.MediaController._onTrackballEvent10506 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.MediaController._dispatchKeyEvent10507 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.MediaController._onFinishInflate10508 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.MediaController._isShowing10509 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "isShowing", "()Z"); 
			global::android.widget.MediaController._show10510 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "show", "(I)V"); 
			global::android.widget.MediaController._show10511 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "show", "()V"); 
			global::android.widget.MediaController._hide10512 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "hide", "()V"); 
			global::android.widget.MediaController._setMediaPlayer10513 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V"); 
			global::android.widget.MediaController._setAnchorView10514 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V"); 
			global::android.widget.MediaController._setPrevNextListeners10515 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.MediaController._MediaController10516 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V"); 
			global::android.widget.MediaController._MediaController10517 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.MediaController._MediaController10518 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
