namespace android.service.wallpaper
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.service.wallpaper.WallpaperService_))]
	public abstract partial class WallpaperService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WallpaperService()
		{
			InitJNI();
		}
		protected WallpaperService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Engine : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Engine()
			{
				InitJNI();
			}
			protected Engine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreate7259;
			public virtual void onCreate(android.view.SurfaceHolder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onCreate7259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onCreate7259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDestroy7260;
			public virtual void onDestroy() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onDestroy7260);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onDestroy7260);
			}
			internal static global::MonoJavaBridge.MethodId _isVisible7261;
			public virtual bool isVisible() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._isVisible7261);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._isVisible7261);
			}
			internal static global::MonoJavaBridge.MethodId _onTouchEvent7262;
			public virtual void onTouchEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent7262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent7262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onVisibilityChanged7263;
			public virtual void onVisibilityChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged7263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged7263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getDesiredMinimumWidth7264;
			public virtual int getDesiredMinimumWidth() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth7264);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth7264);
			}
			internal static global::MonoJavaBridge.MethodId _getDesiredMinimumHeight7265;
			public virtual int getDesiredMinimumHeight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight7265);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight7265);
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceCreated7266;
			public virtual void onSurfaceCreated(android.view.SurfaceHolder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated7266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated7266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceChanged7267;
			public virtual void onSurfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged7267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged7267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _getSurfaceHolder7268;
			public virtual global::android.view.SurfaceHolder getSurfaceHolder() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder7268)) as android.view.SurfaceHolder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.SurfaceHolder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder7268)) as android.view.SurfaceHolder;
			}
			internal static global::MonoJavaBridge.MethodId _isPreview7269;
			public virtual bool isPreview() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._isPreview7269);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._isPreview7269);
			}
			internal static global::MonoJavaBridge.MethodId _setTouchEventsEnabled7270;
			public virtual void setTouchEventsEnabled(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled7270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled7270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onOffsetsChanged7271;
			public virtual void onOffsetsChanged(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged7271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged7271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _onCommand7272;
			public virtual global::android.os.Bundle onCommand(java.lang.String arg0, int arg1, int arg2, int arg3, android.os.Bundle arg4, bool arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onCommand7272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.os.Bundle;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onCommand7272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.os.Bundle;
			}
			internal static global::MonoJavaBridge.MethodId _onDesiredSizeChanged7273;
			public virtual void onDesiredSizeChanged(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged7273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged7273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceDestroyed7274;
			public virtual void onSurfaceDestroyed(android.view.SurfaceHolder arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed7274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed7274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _Engine7275;
			public Engine(android.service.wallpaper.WallpaperService arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.service.wallpaper.WallpaperService.Engine.staticClass, global::android.service.wallpaper.WallpaperService.Engine._Engine7275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.service.wallpaper.WallpaperService.Engine.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/service/wallpaper/WallpaperService$Engine"));
				global::android.service.wallpaper.WallpaperService.Engine._onCreate7259 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCreate", "(Landroid/view/SurfaceHolder;)V");
				global::android.service.wallpaper.WallpaperService.Engine._onDestroy7260 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDestroy", "()V");
				global::android.service.wallpaper.WallpaperService.Engine._isVisible7261 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isVisible", "()Z");
				global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent7262 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)V");
				global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged7263 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onVisibilityChanged", "(Z)V");
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth7264 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumWidth", "()I");
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight7265 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumHeight", "()I");
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated7266 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V");
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged7267 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
				global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder7268 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;");
				global::android.service.wallpaper.WallpaperService.Engine._isPreview7269 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isPreview", "()Z");
				global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled7270 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "setTouchEventsEnabled", "(Z)V");
				global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged7271 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onOffsetsChanged", "(FFFFII)V");
				global::android.service.wallpaper.WallpaperService.Engine._onCommand7272 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;");
				global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged7273 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDesiredSizeChanged", "(II)V");
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed7274 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
				global::android.service.wallpaper.WallpaperService.Engine._Engine7275 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "<init>", "(Landroid/service/wallpaper/WallpaperService;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onBind7276;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService._onBind7276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._onBind7276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate7277;
		public override void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService._onCreate7277);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._onCreate7277);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy7278;
		public override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService._onDestroy7278);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._onDestroy7278);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateEngine7279;
		public abstract global::android.service.wallpaper.WallpaperService.Engine onCreateEngine();
		internal static global::MonoJavaBridge.MethodId _WallpaperService7280;
		public WallpaperService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.service.wallpaper.WallpaperService.staticClass, global::android.service.wallpaper.WallpaperService._WallpaperService7280);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.service.wallpaper.WallpaperService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/service/wallpaper/WallpaperService"));
			global::android.service.wallpaper.WallpaperService._onBind7276 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.service.wallpaper.WallpaperService._onCreate7277 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.staticClass, "onCreate", "()V");
			global::android.service.wallpaper.WallpaperService._onDestroy7278 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.staticClass, "onDestroy", "()V");
			global::android.service.wallpaper.WallpaperService._onCreateEngine7279 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.staticClass, "onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;");
			global::android.service.wallpaper.WallpaperService._WallpaperService7280 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.service.wallpaper.WallpaperService))]
	public sealed partial class WallpaperService_ : android.service.wallpaper.WallpaperService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WallpaperService_()
		{
			InitJNI();
		}
		internal WallpaperService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreateEngine7281;
		public override global::android.service.wallpaper.WallpaperService.Engine onCreateEngine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService_._onCreateEngine7281)) as android.service.wallpaper.WallpaperService.Engine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.service.wallpaper.WallpaperService_.staticClass, global::android.service.wallpaper.WallpaperService_._onCreateEngine7281)) as android.service.wallpaper.WallpaperService.Engine;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.service.wallpaper.WallpaperService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/service/wallpaper/WallpaperService"));
			global::android.service.wallpaper.WallpaperService_._onCreateEngine7281 = @__env.GetMethodIDNoThrow(global::android.service.wallpaper.WallpaperService_.staticClass, "onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;");
		}
	}
}
