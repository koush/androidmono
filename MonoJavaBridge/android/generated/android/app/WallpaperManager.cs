namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WallpaperManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WallpaperManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear2212;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "clear", "()V", ref global::android.app.WallpaperManager._clear2212);
		}
		internal static global::MonoJavaBridge.MethodId _getInstance2213;
		public static global::android.app.WallpaperManager getInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.WallpaperManager._getInstance2213.native == global::System.IntPtr.Zero)
				global::android.app.WallpaperManager._getInstance2213 = @__env.GetStaticMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getInstance2213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.WallpaperManager;
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable2214;
		public virtual global::android.graphics.drawable.Drawable getDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._getDrawable2214) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			set
			{
				setBitmap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap2215;
		public virtual void setBitmap(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V", ref global::android.app.WallpaperManager._setBitmap2215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekDrawable2216;
		public virtual global::android.graphics.drawable.Drawable peekDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "peekDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._peekDrawable2216) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable FastDrawable
		{
			get
			{
				return getFastDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFastDrawable2217;
		public virtual global::android.graphics.drawable.Drawable getFastDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "getFastDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._getFastDrawable2217) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekFastDrawable2218;
		public virtual global::android.graphics.drawable.Drawable peekFastDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "peekFastDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._peekFastDrawable2218) as android.graphics.drawable.Drawable;
		}
		public new global::android.app.WallpaperInfo WallpaperInfo
		{
			get
			{
				return getWallpaperInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperInfo2219;
		public virtual global::android.app.WallpaperInfo getWallpaperInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.app.WallpaperInfo>(this, global::android.app.WallpaperManager.staticClass, "getWallpaperInfo", "()Landroid/app/WallpaperInfo;", ref global::android.app.WallpaperManager._getWallpaperInfo2219) as android.app.WallpaperInfo;
		}
		public new int Resource
		{
			set
			{
				setResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setResource2220;
		public virtual void setResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setResource", "(I)V", ref global::android.app.WallpaperManager._setResource2220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.InputStream Stream
		{
			set
			{
				setStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStream2221;
		public virtual void setStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setStream", "(Ljava/io/InputStream;)V", ref global::android.app.WallpaperManager._setStream2221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DesiredMinimumWidth
		{
			get
			{
				return getDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredMinimumWidth2222;
		public virtual int getDesiredMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.WallpaperManager.staticClass, "getDesiredMinimumWidth", "()I", ref global::android.app.WallpaperManager._getDesiredMinimumWidth2222);
		}
		public new int DesiredMinimumHeight
		{
			get
			{
				return getDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredMinimumHeight2223;
		public virtual int getDesiredMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.WallpaperManager.staticClass, "getDesiredMinimumHeight", "()I", ref global::android.app.WallpaperManager._getDesiredMinimumHeight2223);
		}
		internal static global::MonoJavaBridge.MethodId _suggestDesiredDimensions2224;
		public virtual void suggestDesiredDimensions(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "suggestDesiredDimensions", "(II)V", ref global::android.app.WallpaperManager._suggestDesiredDimensions2224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaperOffsets2225;
		public virtual void setWallpaperOffsets(android.os.IBinder arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setWallpaperOffsets", "(Landroid/os/IBinder;FF)V", ref global::android.app.WallpaperManager._setWallpaperOffsets2225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaperOffsetSteps2226;
		public virtual void setWallpaperOffsetSteps(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setWallpaperOffsetSteps", "(FF)V", ref global::android.app.WallpaperManager._setWallpaperOffsetSteps2226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendWallpaperCommand2227;
		public virtual void sendWallpaperCommand(android.os.IBinder arg0, java.lang.String arg1, int arg2, int arg3, int arg4, android.os.Bundle arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V", ref global::android.app.WallpaperManager._sendWallpaperCommand2227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaperOffsets2228;
		public virtual void clearWallpaperOffsets(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "clearWallpaperOffsets", "(Landroid/os/IBinder;)V", ref global::android.app.WallpaperManager._clearWallpaperOffsets2228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String ACTION_LIVE_WALLPAPER_CHOOSER
		{
			get
			{
				return "android.service.wallpaper.LIVE_WALLPAPER_CHOOSER";
			}
		}
		public static global::java.lang.String COMMAND_TAP
		{
			get
			{
				return "android.wallpaper.tap";
			}
		}
		public static global::java.lang.String COMMAND_DROP
		{
			get
			{
				return "android.home.drop";
			}
		}
		static WallpaperManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.WallpaperManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/WallpaperManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
