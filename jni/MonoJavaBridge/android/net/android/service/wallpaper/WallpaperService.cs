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
			internal static global::net.sf.jni4net.jni.MethodId _onCreate6108; 
			public virtual void onCreate(android.view.SurfaceHolder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onCreate6108, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onCreate6108, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDestroy6109; 
			public virtual void onDestroy() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onDestroy6109); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onDestroy6109); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isVisible6110; 
			public virtual bool isVisible() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallBooleanMethod(this, _isVisible6110); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _isVisible6110); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent6111; 
			public virtual void onTouchEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onTouchEvent6111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onTouchEvent6111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumWidth6112; 
			public virtual int getDesiredMinimumWidth() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallIntMethod(this, _getDesiredMinimumWidth6112); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _getDesiredMinimumWidth6112); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumHeight6113; 
			public virtual int getDesiredMinimumHeight() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallIntMethod(this, _getDesiredMinimumHeight6113); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _getDesiredMinimumHeight6113); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceCreated6114; 
			public virtual void onSurfaceCreated(android.view.SurfaceHolder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onSurfaceCreated6114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onSurfaceCreated6114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceChanged6115; 
			public virtual void onSurfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onSurfaceChanged6115, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onSurfaceChanged6115, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSurfaceHolder6116; 
			public virtual android.view.SurfaceHolder getSurfaceHolder() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallObjectMethodPtr(this, _getSurfaceHolder6116)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.SurfaceHolder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _getSurfaceHolder6116)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isPreview6117; 
			public virtual bool isPreview() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return @__env.CallBooleanMethod(this, _isPreview6117); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _isPreview6117); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTouchEventsEnabled6118; 
			public virtual void setTouchEventsEnabled(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _setTouchEventsEnabled6118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _setTouchEventsEnabled6118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged6119; 
			public virtual void onVisibilityChanged(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onVisibilityChanged6119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onVisibilityChanged6119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onOffsetsChanged6120; 
			public virtual void onOffsetsChanged(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onOffsetsChanged6120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onOffsetsChanged6120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onCommand6121; 
			public virtual android.os.Bundle onCommand(java.lang.String arg0, int arg1, int arg2, int arg3, android.os.Bundle arg4, bool arg5) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _onCommand6121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onCommand6121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDesiredSizeChanged6122; 
			public virtual void onDesiredSizeChanged(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onDesiredSizeChanged6122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onDesiredSizeChanged6122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceDestroyed6123; 
			public virtual void onSurfaceDestroyed(android.view.SurfaceHolder arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.service.wallpaper.WallpaperService.Engine)) 
					@__env.CallVoidMethod(this, _onSurfaceDestroyed6123, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.Engine.staticClass, _onSurfaceDestroyed6123, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Engine6124; 
			public Engine(android.service.wallpaper.WallpaperService arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.service.wallpaper.WallpaperService.Engine.staticClass, _Engine6124, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.service.wallpaper.WallpaperService.Engine.staticClass = @__class; 
				global::android.service.wallpaper.WallpaperService.Engine._onCreate6108 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCreate", "(Landroid/view/SurfaceHolder;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onDestroy6109 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDestroy", "()V"); 
				global::android.service.wallpaper.WallpaperService.Engine._isVisible6110 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isVisible", "()Z"); 
				global::android.service.wallpaper.WallpaperService.Engine._onTouchEvent6111 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumWidth6112 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumWidth", "()I"); 
				global::android.service.wallpaper.WallpaperService.Engine._getDesiredMinimumHeight6113 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getDesiredMinimumHeight", "()I"); 
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceCreated6114 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceCreated", "(Landroid/view/SurfaceHolder;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceChanged6115 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceChanged", "(Landroid/view/SurfaceHolder;III)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._getSurfaceHolder6116 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;"); 
				global::android.service.wallpaper.WallpaperService.Engine._isPreview6117 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "isPreview", "()Z"); 
				global::android.service.wallpaper.WallpaperService.Engine._setTouchEventsEnabled6118 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "setTouchEventsEnabled", "(Z)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onVisibilityChanged6119 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onVisibilityChanged", "(Z)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onOffsetsChanged6120 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onOffsetsChanged", "(FFFFII)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onCommand6121 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onCommand", "(Ljava/lang/String;IIILandroid/os/Bundle;Z)Landroid/os/Bundle;"); 
				global::android.service.wallpaper.WallpaperService.Engine._onDesiredSizeChanged6122 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onDesiredSizeChanged", "(II)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._onSurfaceDestroyed6123 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "onSurfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"); 
				global::android.service.wallpaper.WallpaperService.Engine._Engine6124 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.Engine.staticClass, "<init>", "(Landroid/service/wallpaper/WallpaperService;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBind6125; 
		public sealed override android.os.IBinder onBind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.service.wallpaper.WallpaperService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _onBind6125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.service.wallpaper.WallpaperService.staticClass, _onBind6125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate6126; 
		public override void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.service.wallpaper.WallpaperService)) 
				@__env.CallVoidMethod(this, _onCreate6126); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.staticClass, _onCreate6126); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy6127; 
		public override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.service.wallpaper.WallpaperService)) 
				@__env.CallVoidMethod(this, _onDestroy6127); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.service.wallpaper.WallpaperService.staticClass, _onDestroy6127); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateEngine6128; 
		public abstract android.service.wallpaper.WallpaperService.Engine onCreateEngine(); 
		internal static global::net.sf.jni4net.jni.MethodId _WallpaperService6129; 
		public WallpaperService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.service.wallpaper.WallpaperService.staticClass, _WallpaperService6129, this); 
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
			global::android.service.wallpaper.WallpaperService._onBind6125 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.service.wallpaper.WallpaperService._onCreate6126 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onCreate", "()V"); 
			global::android.service.wallpaper.WallpaperService._onDestroy6127 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onDestroy", "()V"); 
			global::android.service.wallpaper.WallpaperService._onCreateEngine6128 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "onCreateEngine", "()Landroid/service/wallpaper/WallpaperService$Engine;"); 
			global::android.service.wallpaper.WallpaperService._WallpaperService6129 = @__env.GetMethodID(global::android.service.wallpaper.WallpaperService.staticClass, "<init>", "()V"); 
		} 
	} 
} 
