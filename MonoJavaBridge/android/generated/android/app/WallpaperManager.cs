namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WallpaperManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WallpaperManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "clear", "()V", ref global::android.app.WallpaperManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.app.WallpaperManager getInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.WallpaperManager._m1.native == global::System.IntPtr.Zero)
				global::android.app.WallpaperManager._m1 = @__env.GetStaticMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.WallpaperManager;
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.graphics.drawable.Drawable getDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._m2) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			set
			{
				setBitmap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setBitmap(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V", ref global::android.app.WallpaperManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.graphics.drawable.Drawable peekDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "peekDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._m4) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable FastDrawable
		{
			get
			{
				return getFastDrawable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.graphics.drawable.Drawable getFastDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "getFastDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._m5) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.graphics.drawable.Drawable peekFastDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperManager.staticClass, "peekFastDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperManager._m6) as android.graphics.drawable.Drawable;
		}
		public new global::android.app.WallpaperInfo WallpaperInfo
		{
			get
			{
				return getWallpaperInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.app.WallpaperInfo getWallpaperInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.app.WallpaperInfo>(this, global::android.app.WallpaperManager.staticClass, "getWallpaperInfo", "()Landroid/app/WallpaperInfo;", ref global::android.app.WallpaperManager._m7) as android.app.WallpaperInfo;
		}
		public new int Resource
		{
			set
			{
				setResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setResource", "(I)V", ref global::android.app.WallpaperManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.InputStream Stream
		{
			set
			{
				setStream(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setStream", "(Ljava/io/InputStream;)V", ref global::android.app.WallpaperManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DesiredMinimumWidth
		{
			get
			{
				return getDesiredMinimumWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getDesiredMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.WallpaperManager.staticClass, "getDesiredMinimumWidth", "()I", ref global::android.app.WallpaperManager._m10);
		}
		public new int DesiredMinimumHeight
		{
			get
			{
				return getDesiredMinimumHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getDesiredMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.WallpaperManager.staticClass, "getDesiredMinimumHeight", "()I", ref global::android.app.WallpaperManager._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void suggestDesiredDimensions(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "suggestDesiredDimensions", "(II)V", ref global::android.app.WallpaperManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setWallpaperOffsets(android.os.IBinder arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setWallpaperOffsets", "(Landroid/os/IBinder;FF)V", ref global::android.app.WallpaperManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setWallpaperOffsetSteps(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "setWallpaperOffsetSteps", "(FF)V", ref global::android.app.WallpaperManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void sendWallpaperCommand(android.os.IBinder arg0, java.lang.String arg1, int arg2, int arg3, int arg4, android.os.Bundle arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V", ref global::android.app.WallpaperManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void clearWallpaperOffsets(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperManager.staticClass, "clearWallpaperOffsets", "(Landroid/os/IBinder;)V", ref global::android.app.WallpaperManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
