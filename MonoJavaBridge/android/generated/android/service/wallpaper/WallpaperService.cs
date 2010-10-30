namespace android.service.wallpaper
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.service.wallpaper.WallpaperService_))]
	public abstract partial class WallpaperService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WallpaperService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Engine : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Engine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreate11621;
			public virtual void onCreate(android.view.SurfaceHolder arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCreate", "(Landroid/view/SurfaceHolder;)V", ref global::android.service.wallpaper.WallpaperService.Engine._onCreate11621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDestroy11622;
			public virtual void onDestroy()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDestroy", "()V", ref global::android.service.wallpaper.WallpaperService.Engine._onDestroy11622);
			}
			internal static global::MonoJavaBridge.MethodId _isVisible11623;
			public virtual bool isVisible()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isVisible", "()Z", ref global::android.service.wallpaper.WallpaperService.Engine._isVisible11623);
			}
			internal static global::MonoJavaBridge.MethodId _onTouchEvent11624;
			public virtual void onTouchEvent(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)V", ref global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent11624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onVisibilityChanged11625;
			public virtual void onVisibilityChanged(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onVisibilityChanged", "(Z)V", ref global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged11625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int DesiredMinimumWidth
			{
				get
				{
					return getDesiredMinimumWidth();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getDesiredMinimumWidth11626;
			public virtual int getDesiredMinimumWidth()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumWidth", "()I", ref global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth11626);
			}
			public new int DesiredMinimumHeight
			{
				get
				{
					return getDesiredMinimumHeight();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getDesiredMinimumHeight11627;
			public virtual int getDesiredMinimumHeight()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumHeight", "()I", ref global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight11627);
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceCreated11628;
			public virtual void onSurfaceCreated(android.view.SurfaceHolder arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V", ref global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated11628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceChanged11629;
			public virtual void onSurfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V", ref global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged11629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			public new global::android.view.SurfaceHolder SurfaceHolder
			{
				get
				{
					return getSurfaceHolder();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSurfaceHolder11630;
			public virtual global::android.view.SurfaceHolder getSurfaceHolder()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SurfaceHolder>(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;", ref global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder11630) as android.view.SurfaceHolder;
			}
			internal static global::MonoJavaBridge.MethodId _isPreview11631;
			public virtual bool isPreview()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isPreview", "()Z", ref global::android.service.wallpaper.WallpaperService.Engine._isPreview11631);
			}
			public new bool TouchEventsEnabled
			{
				set
				{
					setTouchEventsEnabled(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setTouchEventsEnabled11632;
			public virtual void setTouchEventsEnabled(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "setTouchEventsEnabled", "(Z)V", ref global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled11632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onOffsetsChanged11633;
			public virtual void onOffsetsChanged(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onOffsetsChanged", "(FFFFII)V", ref global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged11633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _onCommand11634;
			public virtual global::android.os.Bundle onCommand(java.lang.String arg0, int arg1, int arg2, int arg3, android.os.Bundle arg4, bool arg5)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;", ref global::android.service.wallpaper.WallpaperService.Engine._onCommand11634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as android.os.Bundle;
			}
			internal static global::MonoJavaBridge.MethodId _onDesiredSizeChanged11635;
			public virtual void onDesiredSizeChanged(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDesiredSizeChanged", "(II)V", ref global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged11635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceDestroyed11636;
			public virtual void onSurfaceDestroyed(android.view.SurfaceHolder arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", ref global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed11636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _Engine11637;
			public Engine(android.service.wallpaper.WallpaperService arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.service.wallpaper.WallpaperService.Engine._Engine11637.native == global::System.IntPtr.Zero)
					global::android.service.wallpaper.WallpaperService.Engine._Engine11637 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "<init>", "(Landroid/service/wallpaper/WallpaperService;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._Engine11637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static Engine()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.service.wallpaper.WallpaperService.Engine.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/service/wallpaper/WallpaperService$Engine"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onBind11638;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.service.wallpaper.WallpaperService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.service.wallpaper.WallpaperService._onBind11638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate11639;
		public override void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.staticClass, "onCreate", "()V", ref global::android.service.wallpaper.WallpaperService._onCreate11639);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy11640;
		public override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.staticClass, "onDestroy", "()V", ref global::android.service.wallpaper.WallpaperService._onDestroy11640);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateEngine11641;
		public abstract global::android.service.wallpaper.WallpaperService.Engine onCreateEngine();
		internal static global::MonoJavaBridge.MethodId _WallpaperService11642;
		public WallpaperService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.service.wallpaper.WallpaperService._WallpaperService11642.native == global::System.IntPtr.Zero)
				global::android.service.wallpaper.WallpaperService._WallpaperService11642 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._WallpaperService11642);
			Init(@__env, handle);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.service.wallpaper.WallpaperService";
			}
		}
		public static global::java.lang.String SERVICE_META_DATA
		{
			get
			{
				return "android.service.wallpaper";
			}
		}
		static WallpaperService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.service.wallpaper.WallpaperService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/service/wallpaper/WallpaperService"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.service.wallpaper.WallpaperService))]
	internal sealed partial class WallpaperService_ : android.service.wallpaper.WallpaperService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WallpaperService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreateEngine11645;
		public override global::android.service.wallpaper.WallpaperService.Engine onCreateEngine()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.service.wallpaper.WallpaperService_.staticClass, "onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;", ref global::android.service.wallpaper.WallpaperService_._onCreateEngine11645) as android.service.wallpaper.WallpaperService.Engine;
		}
		static WallpaperService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.service.wallpaper.WallpaperService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/service/wallpaper/WallpaperService"));
		}
		internal static void InitJNI()
		{
		}
	}
}
