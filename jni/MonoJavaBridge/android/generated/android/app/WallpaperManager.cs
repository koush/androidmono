namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WallpaperManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WallpaperManager()
		{
			InitJNI();
		}
		protected WallpaperManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear854;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._clear854);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._clear854);
		}
		internal static global::MonoJavaBridge.MethodId _getInstance855;
		public static global::android.app.WallpaperManager getInstance(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getInstance855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.WallpaperManager;
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable856;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperManager._getDrawable856)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDrawable856)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap857;
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._setBitmap857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setBitmap857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekDrawable858;
		public virtual global::android.graphics.drawable.Drawable peekDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperManager._peekDrawable858)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._peekDrawable858)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable FastDrawable
		{
			get
			{
				return getFastDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFastDrawable859;
		public virtual global::android.graphics.drawable.Drawable getFastDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperManager._getFastDrawable859)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getFastDrawable859)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekFastDrawable860;
		public virtual global::android.graphics.drawable.Drawable peekFastDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperManager._peekFastDrawable860)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._peekFastDrawable860)) as android.graphics.drawable.Drawable;
		}
		public new global::android.app.WallpaperInfo WallpaperInfo
		{
			get
			{
				return getWallpaperInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperInfo861;
		public virtual global::android.app.WallpaperInfo getWallpaperInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperManager._getWallpaperInfo861)) as android.app.WallpaperInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getWallpaperInfo861)) as android.app.WallpaperInfo;
		}
		internal static global::MonoJavaBridge.MethodId _setResource862;
		public virtual void setResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._setResource862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setResource862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStream863;
		public virtual void setStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._setStream863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setStream863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DesiredMinimumWidth
		{
			get
			{
				return getDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredMinimumWidth864;
		public virtual int getDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.WallpaperManager._getDesiredMinimumWidth864);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDesiredMinimumWidth864);
		}
		public new int DesiredMinimumHeight
		{
			get
			{
				return getDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredMinimumHeight865;
		public virtual int getDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.WallpaperManager._getDesiredMinimumHeight865);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDesiredMinimumHeight865);
		}
		internal static global::MonoJavaBridge.MethodId _suggestDesiredDimensions866;
		public virtual void suggestDesiredDimensions(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._suggestDesiredDimensions866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._suggestDesiredDimensions866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaperOffsets867;
		public virtual void setWallpaperOffsets(android.os.IBinder arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._setWallpaperOffsets867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setWallpaperOffsets867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaperOffsetSteps868;
		public virtual void setWallpaperOffsetSteps(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._setWallpaperOffsetSteps868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setWallpaperOffsetSteps868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendWallpaperCommand869;
		public virtual void sendWallpaperCommand(android.os.IBinder arg0, java.lang.String arg1, int arg2, int arg3, int arg4, android.os.Bundle arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._sendWallpaperCommand869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._sendWallpaperCommand869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaperOffsets870;
		public virtual void clearWallpaperOffsets(android.os.IBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperManager._clearWallpaperOffsets870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._clearWallpaperOffsets870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.WallpaperManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/WallpaperManager"));
			global::android.app.WallpaperManager._clear854 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "clear", "()V");
			global::android.app.WallpaperManager._getInstance855 = @__env.GetStaticMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;");
			global::android.app.WallpaperManager._getDrawable856 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._setBitmap857 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.app.WallpaperManager._peekDrawable858 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "peekDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._getFastDrawable859 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getFastDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._peekFastDrawable860 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "peekFastDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._getWallpaperInfo861 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getWallpaperInfo", "()Landroid/app/WallpaperInfo;");
			global::android.app.WallpaperManager._setResource862 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "setResource", "(I)V");
			global::android.app.WallpaperManager._setStream863 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "setStream", "(Ljava/io/InputStream;)V");
			global::android.app.WallpaperManager._getDesiredMinimumWidth864 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumWidth", "()I");
			global::android.app.WallpaperManager._getDesiredMinimumHeight865 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumHeight", "()I");
			global::android.app.WallpaperManager._suggestDesiredDimensions866 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "suggestDesiredDimensions", "(II)V");
			global::android.app.WallpaperManager._setWallpaperOffsets867 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsets", "(Landroid/os/IBinder;FF)V");
			global::android.app.WallpaperManager._setWallpaperOffsetSteps868 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsetSteps", "(FF)V");
			global::android.app.WallpaperManager._sendWallpaperCommand869 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V");
			global::android.app.WallpaperManager._clearWallpaperOffsets870 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperManager.staticClass, "clearWallpaperOffsets", "(Landroid/os/IBinder;)V");
		}
	}
}
