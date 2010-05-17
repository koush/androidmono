namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WallpaperManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WallpaperManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.WallpaperManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.WallpaperManager(@__env); 
			} 
		} 
		protected WallpaperManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear781; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _clear781); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _clear781); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance782; 
		public static android.app.WallpaperManager getInstance(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperManager>(@__env, @__env.CallStaticObjectMethodPtr(android.app.WallpaperManager.staticClass, _getInstance782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable783; 
		public virtual android.graphics.drawable.Drawable getDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable783)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperManager.staticClass, _getDrawable783)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap784; 
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _setBitmap784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _setBitmap784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekDrawable785; 
		public virtual android.graphics.drawable.Drawable peekDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _peekDrawable785)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperManager.staticClass, _peekDrawable785)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFastDrawable786; 
		public virtual android.graphics.drawable.Drawable getFastDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getFastDrawable786)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperManager.staticClass, _getFastDrawable786)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekFastDrawable787; 
		public virtual android.graphics.drawable.Drawable peekFastDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _peekFastDrawable787)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperManager.staticClass, _peekFastDrawable787)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperInfo788; 
		public virtual android.app.WallpaperInfo getWallpaperInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperInfo>(@__env, @__env.CallObjectMethodPtr(this, _getWallpaperInfo788)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperManager.staticClass, _getWallpaperInfo788)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResource789; 
		public virtual void setResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _setResource789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _setResource789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStream790; 
		public virtual void setStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _setStream790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _setStream790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumWidth791; 
		public virtual int getDesiredMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return @__env.CallIntMethod(this, _getDesiredMinimumWidth791); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.WallpaperManager.staticClass, _getDesiredMinimumWidth791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumHeight792; 
		public virtual int getDesiredMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				return @__env.CallIntMethod(this, _getDesiredMinimumHeight792); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.WallpaperManager.staticClass, _getDesiredMinimumHeight792); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _suggestDesiredDimensions793; 
		public virtual void suggestDesiredDimensions(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _suggestDesiredDimensions793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _suggestDesiredDimensions793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaperOffsets794; 
		public virtual void setWallpaperOffsets(android.os.IBinder arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _setWallpaperOffsets794, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _setWallpaperOffsets794, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaperOffsetSteps795; 
		public virtual void setWallpaperOffsetSteps(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _setWallpaperOffsetSteps795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _setWallpaperOffsetSteps795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendWallpaperCommand796; 
		public virtual void sendWallpaperCommand(android.os.IBinder arg0, java.lang.String arg1, int arg2, int arg3, int arg4, android.os.Bundle arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _sendWallpaperCommand796, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _sendWallpaperCommand796, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaperOffsets797; 
		public virtual void clearWallpaperOffsets(android.os.IBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperManager)) 
				@__env.CallVoidMethod(this, _clearWallpaperOffsets797, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperManager.staticClass, _clearWallpaperOffsets797, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		public static java.lang.String ACTION_LIVE_WALLPAPER_CHOOSER
		{ 
			get 
			{ 
				return "android.service.wallpaper.LIVE_WALLPAPER_CHOOSER"; 
			} 
		} 
		public static java.lang.String COMMAND_TAP
		{ 
			get 
			{ 
				return "android.wallpaper.tap"; 
			} 
		} 
		public static java.lang.String COMMAND_DROP
		{ 
			get 
			{ 
				return "android.home.drop"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.WallpaperManager.staticClass = @__class; 
			global::android.app.WallpaperManager._clear781 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "clear", "()V"); 
			global::android.app.WallpaperManager._getInstance782 = @__env.GetStaticMethodID(global::android.app.WallpaperManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;"); 
			global::android.app.WallpaperManager._getDrawable783 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.app.WallpaperManager._setBitmap784 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"); 
			global::android.app.WallpaperManager._peekDrawable785 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "peekDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.app.WallpaperManager._getFastDrawable786 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getFastDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.app.WallpaperManager._peekFastDrawable787 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "peekFastDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.app.WallpaperManager._getWallpaperInfo788 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getWallpaperInfo", "()Landroid/app/WallpaperInfo;"); 
			global::android.app.WallpaperManager._setResource789 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setResource", "(I)V"); 
			global::android.app.WallpaperManager._setStream790 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setStream", "(Ljava/io/InputStream;)V"); 
			global::android.app.WallpaperManager._getDesiredMinimumWidth791 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumWidth", "()I"); 
			global::android.app.WallpaperManager._getDesiredMinimumHeight792 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumHeight", "()I"); 
			global::android.app.WallpaperManager._suggestDesiredDimensions793 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "suggestDesiredDimensions", "(II)V"); 
			global::android.app.WallpaperManager._setWallpaperOffsets794 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsets", "(Landroid/os/IBinder;FF)V"); 
			global::android.app.WallpaperManager._setWallpaperOffsetSteps795 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsetSteps", "(FF)V"); 
			global::android.app.WallpaperManager._sendWallpaperCommand796 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V"); 
			global::android.app.WallpaperManager._clearWallpaperOffsets797 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "clearWallpaperOffsets", "(Landroid/os/IBinder;)V"); 
		} 
	} 
} 
