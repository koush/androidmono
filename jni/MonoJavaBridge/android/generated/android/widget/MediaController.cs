namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class MediaController : android.widget.FrameLayout
	{
		internal new static global::java.lang.Class staticClass;
		static MediaController()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.MediaController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.MediaController.__MediaPlayerControl), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _start11204;
			 void android.widget.MediaController.MediaPlayerControl.start() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.MediaController.__MediaPlayerControl._start11204);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._start11204);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getDuration11205;
			 int android.widget.MediaController.MediaPlayerControl.getDuration() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MediaController.__MediaPlayerControl._getDuration11205);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._getDuration11205);
			}
			internal static global::net.sf.jni4net.jni.MethodId _pause11206;
			 void android.widget.MediaController.MediaPlayerControl.pause() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.MediaController.__MediaPlayerControl._pause11206);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._pause11206);
			}
			internal static global::net.sf.jni4net.jni.MethodId _isPlaying11207;
			 bool android.widget.MediaController.MediaPlayerControl.isPlaying() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl._isPlaying11207);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._isPlaying11207);
			}
			internal static global::net.sf.jni4net.jni.MethodId _seekTo11208;
			 void android.widget.MediaController.MediaPlayerControl.seekTo(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.MediaController.__MediaPlayerControl._seekTo11208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._seekTo11208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition11209;
			 int android.widget.MediaController.MediaPlayerControl.getCurrentPosition() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MediaController.__MediaPlayerControl._getCurrentPosition11209);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._getCurrentPosition11209);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getBufferPercentage11210;
			 int android.widget.MediaController.MediaPlayerControl.getBufferPercentage() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.widget.MediaController.__MediaPlayerControl._getBufferPercentage11210);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._getBufferPercentage11210);
			}
			internal static global::net.sf.jni4net.jni.MethodId _canPause11211;
			 bool android.widget.MediaController.MediaPlayerControl.canPause() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl._canPause11211);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._canPause11211);
			}
			internal static global::net.sf.jni4net.jni.MethodId _canSeekBackward11212;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekBackward() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl._canSeekBackward11212);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._canSeekBackward11212);
			}
			internal static global::net.sf.jni4net.jni.MethodId _canSeekForward11213;
			 bool android.widget.MediaController.MediaPlayerControl.canSeekForward() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl._canSeekForward11213);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.__MediaPlayerControl.staticClass, global::android.widget.MediaController.__MediaPlayerControl._canSeekForward11213);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.MediaController.__MediaPlayerControl.staticClass = @__class;
				global::android.widget.MediaController.__MediaPlayerControl._start11204 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.start", "()V");
				global::android.widget.MediaController.__MediaPlayerControl._getDuration11205 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.getDuration", "()I");
				global::android.widget.MediaController.__MediaPlayerControl._pause11206 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.pause", "()V");
				global::android.widget.MediaController.__MediaPlayerControl._isPlaying11207 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.isPlaying", "()Z");
				global::android.widget.MediaController.__MediaPlayerControl._seekTo11208 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.seekTo", "(I)V");
				global::android.widget.MediaController.__MediaPlayerControl._getCurrentPosition11209 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.getCurrentPosition", "()I");
				global::android.widget.MediaController.__MediaPlayerControl._getBufferPercentage11210 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.getBufferPercentage", "()I");
				global::android.widget.MediaController.__MediaPlayerControl._canPause11211 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.canPause", "()Z");
				global::android.widget.MediaController.__MediaPlayerControl._canSeekBackward11212 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.canSeekBackward", "()Z");
				global::android.widget.MediaController.__MediaPlayerControl._canSeekForward11213 = @__env.GetMethodID(global::android.widget.MediaController.__MediaPlayerControl.staticClass, "android.widget.MediaController.MediaPlayerControl.canSeekForward", "()Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled11214;
		public override void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._setEnabled11214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setEnabled11214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11215;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.MediaController._onTouchEvent11215, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTouchEvent11215, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent11216;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.MediaController._onTrackballEvent11216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onTrackballEvent11216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent11217;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.MediaController._dispatchKeyEvent11217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._dispatchKeyEvent11217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate11218;
		public virtual new void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._onFinishInflate11218);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._onFinishInflate11218);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShowing11219;
		public virtual bool isShowing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.MediaController._isShowing11219);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._isShowing11219);
		}
		internal static global::net.sf.jni4net.jni.MethodId _show11220;
		public virtual void show(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._show11220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show11220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _show11221;
		public virtual void show() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._show11221);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._show11221);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hide11222;
		public virtual void hide() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._hide11222);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._hide11222);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMediaPlayer11223;
		public virtual void setMediaPlayer(android.widget.MediaController.MediaPlayerControl arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._setMediaPlayer11223, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setMediaPlayer11223, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnchorView11224;
		public virtual void setAnchorView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._setAnchorView11224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setAnchorView11224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPrevNextListeners11225;
		public virtual void setPrevNextListeners(android.view.View.OnClickListener arg0, android.view.View.OnClickListener arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.MediaController._setPrevNextListeners11225, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.MediaController.staticClass, global::android.widget.MediaController._setPrevNextListeners11225, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MediaController11226;
		public MediaController(android.content.Context arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController11226, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MediaController11227;
		public MediaController(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController11227, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MediaController11228;
		public MediaController(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.MediaController.staticClass, global::android.widget.MediaController._MediaController11228, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.MediaController.staticClass = @__class;
			global::android.widget.MediaController._setEnabled11214 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setEnabled", "(Z)V");
			global::android.widget.MediaController._onTouchEvent11215 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._onTrackballEvent11216 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.MediaController._dispatchKeyEvent11217 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.MediaController._onFinishInflate11218 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "onFinishInflate", "()V");
			global::android.widget.MediaController._isShowing11219 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "isShowing", "()Z");
			global::android.widget.MediaController._show11220 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "show", "(I)V");
			global::android.widget.MediaController._show11221 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "show", "()V");
			global::android.widget.MediaController._hide11222 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "hide", "()V");
			global::android.widget.MediaController._setMediaPlayer11223 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V");
			global::android.widget.MediaController._setAnchorView11224 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setAnchorView", "(Landroid/view/View;)V");
			global::android.widget.MediaController._setPrevNextListeners11225 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V");
			global::android.widget.MediaController._MediaController11226 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Z)V");
			global::android.widget.MediaController._MediaController11227 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.MediaController._MediaController11228 = @__env.GetMethodID(global::android.widget.MediaController.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
