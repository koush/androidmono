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
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled9738; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setEnabled9738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setEnabled9738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9739; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent9739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _onTouchEvent9739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent9740; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent9740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _onTrackballEvent9740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9741; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent9741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _dispatchKeyEvent9741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate9742; 
		public virtual new void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _onFinishInflate9742); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _onFinishInflate9742); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowing9743; 
		public virtual bool isShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				return @__env.CallBooleanMethod(this, _isShowing9743); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.MediaController.staticClass, _isShowing9743); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show9744; 
		public virtual void show(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _show9744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _show9744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show9745; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _show9745); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _show9745); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hide9746; 
		public virtual void hide() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _hide9746); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _hide9746); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMediaPlayer9747; 
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setMediaPlayer9747, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setMediaPlayer9747, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnchorView9748; 
		public virtual void setAnchorView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setAnchorView9748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setAnchorView9748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPrevNextListeners9749; 
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.MediaController)) 
				@__env.CallVoidMethod(this, _setPrevNextListeners9749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.MediaController.staticClass, _setPrevNextListeners9749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaController9750; 
		public MediaController(android.content.Context arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MediaController.staticClass, _MediaController9750, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaController9751; 
		public MediaController(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MediaController.staticClass, _MediaController9751, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaController9752; 
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.MediaController.staticClass, _MediaController9752, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.MediaController.staticClass = @__class; 
			global::android.widget.MediaController._setEnabled9738 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.MediaController._onTouchEvent9739 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.MediaController._onTrackballEvent9740 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.MediaController._dispatchKeyEvent9741 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.MediaController._onFinishInflate9742 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.MediaController._isShowing9743 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "isShowing", "()Z"); 
			global::android.widget.MediaController._show9744 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "show", "(I)V"); 
			global::android.widget.MediaController._show9745 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "show", "()V"); 
			global::android.widget.MediaController._hide9746 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "hide", "()V"); 
			global::android.widget.MediaController._setMediaPlayer9747 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V"); 
			global::android.widget.MediaController._setAnchorView9748 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V"); 
			global::android.widget.MediaController._setPrevNextListeners9749 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.MediaController._MediaController9750 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V"); 
			global::android.widget.MediaController._MediaController9751 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.MediaController._MediaController9752 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
