namespace android.service.wallpaper
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class WallpaperService : android.app.Service
	{
		internal new static global::java.lang.Class staticClass;
		static WallpaperService()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.service.wallpaper.WallpaperService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected WallpaperService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Engine : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Engine()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.service.wallpaper.WallpaperService.Engine), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.service.wallpaper.WallpaperService.Engine(@__env);
				}
			}
			protected Engine(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCreate6983;
			public virtual void onCreate(android.view.SurfaceHolder arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onCreate6983, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onCreate6983, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDestroy6984;
			public virtual void onDestroy() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onDestroy6984);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onDestroy6984);
			}
			internal static global::net.sf.jni4net.jni.MethodId _isVisible6985;
			public virtual bool isVisible() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.service.wallpaper.WallpaperService.Engine._isVisible6985);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._isVisible6985);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent6986;
			public virtual void onTouchEvent(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent6986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent6986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged6987;
			public virtual void onVisibilityChanged(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged6987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged6987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumWidth6988;
			public virtual int getDesiredMinimumWidth() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth6988);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth6988);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumHeight6989;
			public virtual int getDesiredMinimumHeight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight6989);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight6989);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceCreated6990;
			public virtual void onSurfaceCreated(android.view.SurfaceHolder arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated6990, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated6990, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceChanged6991;
			public virtual void onSurfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged6991, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged6991, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSurfaceHolder6992;
			public virtual global::android.view.SurfaceHolder getSurfaceHolder() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallObjectMethodPtr(this, global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder6992));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder6992));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isPreview6993;
			public virtual bool isPreview() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.service.wallpaper.WallpaperService.Engine._isPreview6993);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._isPreview6993);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setTouchEventsEnabled6994;
			public virtual void setTouchEventsEnabled(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled6994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled6994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onOffsetsChanged6995;
			public virtual void onOffsetsChanged(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged6995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged6995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCommand6996;
			public virtual global::android.os.Bundle onCommand(java.lang.String arg0, int arg1, int arg2, int arg3, android.os.Bundle arg4, bool arg5) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.service.wallpaper.WallpaperService.Engine._onCommand6996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onCommand6996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDesiredSizeChanged6997;
			public virtual void onDesiredSizeChanged(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged6997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged6997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceDestroyed6998;
			public virtual void onSurfaceDestroyed(android.view.SurfaceHolder arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed6998, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed6998, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Engine6999;
			public Engine(android.service.wallpaper.WallpaperService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._Engine6999, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.service.wallpaper.WallpaperService.Engine.staticClass = @__class;
				global::android.service.wallpaper.WallpaperService.Engine._onCreate6983 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCreate", "(Landroid/view/SurfaceHolder;)V");
				global::android.service.wallpaper.WallpaperService.Engine._onDestroy6984 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDestroy", "()V");
				global::android.service.wallpaper.WallpaperService.Engine._isVisible6985 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isVisible", "()Z");
				global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent6986 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)V");
				global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged6987 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onVisibilityChanged", "(Z)V");
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth6988 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumWidth", "()I");
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight6989 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumHeight", "()I");
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated6990 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V");
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged6991 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
				global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder6992 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;");
				global::android.service.wallpaper.WallpaperService.Engine._isPreview6993 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isPreview", "()Z");
				global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled6994 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "setTouchEventsEnabled", "(Z)V");
				global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged6995 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onOffsetsChanged", "(FFFFII)V");
				global::android.service.wallpaper.WallpaperService.Engine._onCommand6996 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;");
				global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged6997 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDesiredSizeChanged", "(II)V");
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed6998 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
				global::android.service.wallpaper.WallpaperService.Engine._Engine6999 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "<init>", "(Landroid/service/wallpaper/WallpaperService;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBind7000;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.service.wallpaper.WallpaperService._onBind7000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._onBind7000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate7001;
		public override void onCreate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService._onCreate7001);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._onCreate7001);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy7002;
		public override void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.service.wallpaper.WallpaperService._onDestroy7002);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._onDestroy7002);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateEngine7003;
		public abstract global::android.service.wallpaper.WallpaperService.Engine onCreateEngine();
		internal static global::net.sf.jni4net.jni.MethodId _WallpaperService7004;
		public WallpaperService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._WallpaperService7004, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.service.wallpaper.WallpaperService.staticClass = @__class;
			global::android.service.wallpaper.WallpaperService._onBind7000 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.service.wallpaper.WallpaperService._onCreate7001 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onCreate", "()V");
			global::android.service.wallpaper.WallpaperService._onDestroy7002 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onDestroy", "()V");
			global::android.service.wallpaper.WallpaperService._onCreateEngine7003 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;");
			global::android.service.wallpaper.WallpaperService._WallpaperService7004 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "<init>", "()V");
		}
	}
}
