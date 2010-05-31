namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class WallpaperManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static WallpaperManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.WallpaperManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _clear794;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._clear794);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._clear794);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance795;
		public static global::android.app.WallpaperManager getInstance(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperManager>(@__env, @__env.CallStaticObjectMethodPtr(android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getInstance795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable796;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._getDrawable796));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDrawable796));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap797;
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setBitmap797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setBitmap797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekDrawable798;
		public virtual global::android.graphics.drawable.Drawable peekDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._peekDrawable798));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._peekDrawable798));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFastDrawable799;
		public virtual global::android.graphics.drawable.Drawable getFastDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._getFastDrawable799));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getFastDrawable799));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekFastDrawable800;
		public virtual global::android.graphics.drawable.Drawable peekFastDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._peekFastDrawable800));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._peekFastDrawable800));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperInfo801;
		public virtual global::android.app.WallpaperInfo getWallpaperInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._getWallpaperInfo801));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getWallpaperInfo801));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResource802;
		public virtual void setResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setResource802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setResource802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStream803;
		public virtual void setStream(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setStream803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setStream803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumWidth804;
		public virtual int getDesiredMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.WallpaperManager._getDesiredMinimumWidth804);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDesiredMinimumWidth804);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumHeight805;
		public virtual int getDesiredMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.WallpaperManager._getDesiredMinimumHeight805);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDesiredMinimumHeight805);
		}
		internal static global::net.sf.jni4net.jni.MethodId _suggestDesiredDimensions806;
		public virtual void suggestDesiredDimensions(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._suggestDesiredDimensions806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._suggestDesiredDimensions806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaperOffsets807;
		public virtual void setWallpaperOffsets(android.os.IBinder arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setWallpaperOffsets807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setWallpaperOffsets807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaperOffsetSteps808;
		public virtual void setWallpaperOffsetSteps(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setWallpaperOffsetSteps808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setWallpaperOffsetSteps808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendWallpaperCommand809;
		public virtual void sendWallpaperCommand(android.os.IBinder arg0, java.lang.String arg1, int arg2, int arg3, int arg4, android.os.Bundle arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._sendWallpaperCommand809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._sendWallpaperCommand809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaperOffsets810;
		public virtual void clearWallpaperOffsets(android.os.IBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._clearWallpaperOffsets810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._clearWallpaperOffsets810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.WallpaperManager.staticClass = @__class;
			global::android.app.WallpaperManager._clear794 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "clear", "()V");
			global::android.app.WallpaperManager._getInstance795 = @__env.GetStaticMethodID(global::android.app.WallpaperManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;");
			global::android.app.WallpaperManager._getDrawable796 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._setBitmap797 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.app.WallpaperManager._peekDrawable798 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "peekDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._getFastDrawable799 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getFastDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._peekFastDrawable800 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "peekFastDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._getWallpaperInfo801 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getWallpaperInfo", "()Landroid/app/WallpaperInfo;");
			global::android.app.WallpaperManager._setResource802 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setResource", "(I)V");
			global::android.app.WallpaperManager._setStream803 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setStream", "(Ljava/io/InputStream;)V");
			global::android.app.WallpaperManager._getDesiredMinimumWidth804 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumWidth", "()I");
			global::android.app.WallpaperManager._getDesiredMinimumHeight805 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumHeight", "()I");
			global::android.app.WallpaperManager._suggestDesiredDimensions806 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "suggestDesiredDimensions", "(II)V");
			global::android.app.WallpaperManager._setWallpaperOffsets807 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsets", "(Landroid/os/IBinder;FF)V");
			global::android.app.WallpaperManager._setWallpaperOffsetSteps808 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsetSteps", "(FF)V");
			global::android.app.WallpaperManager._sendWallpaperCommand809 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V");
			global::android.app.WallpaperManager._clearWallpaperOffsets810 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "clearWallpaperOffsets", "(Landroid/os/IBinder;)V");
		}
	}
}
