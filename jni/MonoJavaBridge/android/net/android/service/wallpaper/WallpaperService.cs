namespace android.service.wallpaper 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class WallpaperService : android.app.Service
	{ 
		internal new static global::java.lang.Class staticClass; 
		static WallpaperService() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.service.wallpaper.WallpaperService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.service.wallpaper.WallpaperService.Engine), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onCreate6394; 
			public virtual void onCreate(android.view.SurfaceHolder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onCreate6394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onCreate6394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDestroy6395; 
			public virtual void onDestroy() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onDestroy6395); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onDestroy6395); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isVisible6396; 
			public virtual bool isVisible() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallBooleanMethod(this, _isVisible6396); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _isVisible6396); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent6397; 
			public virtual void onTouchEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onTouchEvent6397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onTouchEvent6397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumWidth6398; 
			public virtual int getDesiredMinimumWidth() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallIntMethod(this, _getDesiredMinimumWidth6398); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _getDesiredMinimumWidth6398); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumHeight6399; 
			public virtual int getDesiredMinimumHeight() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallIntMethod(this, _getDesiredMinimumHeight6399); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _getDesiredMinimumHeight6399); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceCreated6400; 
			public virtual void onSurfaceCreated(android.view.SurfaceHolder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onSurfaceCreated6400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onSurfaceCreated6400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceChanged6401; 
			public virtual void onSurfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onSurfaceChanged6401, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onSurfaceChanged6401, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSurfaceHolder6402; 
			public virtual android.view.SurfaceHolder getSurfaceHolder() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallObjectMethodPtr(this, _getSurfaceHolder6402)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _getSurfaceHolder6402)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isPreview6403; 
			public virtual bool isPreview() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallBooleanMethod(this, _isPreview6403); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _isPreview6403); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTouchEventsEnabled6404; 
			public virtual void setTouchEventsEnabled(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _setTouchEventsEnabled6404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _setTouchEventsEnabled6404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged6405; 
			public virtual void onVisibilityChanged(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onVisibilityChanged6405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onVisibilityChanged6405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onOffsetsChanged6406; 
			public virtual void onOffsetsChanged(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onOffsetsChanged6406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onOffsetsChanged6406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onCommand6407; 
			public virtual android.os.Bundle onCommand(java.lang.String arg0, int arg1, int arg2, int arg3, android.os.Bundle arg4, bool arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _onCommand6407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onCommand6407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDesiredSizeChanged6408; 
			public virtual void onDesiredSizeChanged(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onDesiredSizeChanged6408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onDesiredSizeChanged6408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceDestroyed6409; 
			public virtual void onSurfaceDestroyed(android.view.SurfaceHolder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onSurfaceDestroyed6409, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onSurfaceDestroyed6409, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Engine6410; 
			public Engine(android.service.wallpaper.WallpaperService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.service.wallpaper.WallpaperService.Engine.staticClass, _Engine6410, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.service.wallpaper.WallpaperService.Engine.staticClass = @__class; 
				global::android.service.wallpaper.WallpaperService.Engine._onCreate6394 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCreate", "(Landroid/view/SurfaceHolder;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onDestroy6395 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDestroy", "()V"); 
				global::android.service.wallpaper.WallpaperService.Engine._isVisible6396 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isVisible", "()Z"); 
				global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent6397 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth6398 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumWidth", "()I"); 
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight6399 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumHeight", "()I"); 
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated6400 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged6401 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder6402 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;"); 
				global::android.service.wallpaper.WallpaperService.Engine._isPreview6403 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isPreview", "()Z"); 
				global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled6404 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "setTouchEventsEnabled", "(Z)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged6405 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onVisibilityChanged", "(Z)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged6406 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onOffsetsChanged", "(FFFFII)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onCommand6407 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;"); 
				global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged6408 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDesiredSizeChanged", "(II)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed6409 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._Engine6410 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "<init>", "(Landroid/service/wallpaper/WallpaperService;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBind6411; 
		public sealed override android.os.IBinder onBind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.service.wallpaper.WallpaperService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _onBind6411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.service.wallpaper.WallpaperService.staticClass, _onBind6411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate6412; 
		public override void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.service.wallpaper.WallpaperService)) 
				@__env.CallVoidMethod(this, _onCreate6412); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.staticClass, _onCreate6412); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy6413; 
		public override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.service.wallpaper.WallpaperService)) 
				@__env.CallVoidMethod(this, _onDestroy6413); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.staticClass, _onDestroy6413); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateEngine6414; 
		public abstract android.service.wallpaper.WallpaperService.Engine onCreateEngine(); 
		internal static global::net.sf.jni4net.jni.MethodId _WallpaperService6415; 
		public WallpaperService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.service.wallpaper.WallpaperService.staticClass, _WallpaperService6415, this); 
		} 
		public static java.lang.String SERVICE_INTERFACE
		{ 
			get 
			{ 
				return "android.service.wallpaper.WallpaperService"; 
			} 
		} 
		public static java.lang.String SERVICE_META_DATA
		{ 
			get 
			{ 
				return "android.service.wallpaper"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.service.wallpaper.WallpaperService.staticClass = @__class; 
			global::android.service.wallpaper.WallpaperService._onBind6411 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.service.wallpaper.WallpaperService._onCreate6412 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onCreate", "()V"); 
			global::android.service.wallpaper.WallpaperService._onDestroy6413 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onDestroy", "()V"); 
			global::android.service.wallpaper.WallpaperService._onCreateEngine6414 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;"); 
			global::android.service.wallpaper.WallpaperService._WallpaperService6415 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "<init>", "()V"); 
		} 
	} 
} 
