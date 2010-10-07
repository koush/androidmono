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
		internal static global::net.sf.jni4net.jni.MethodId _clear842;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._clear842);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._clear842);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance843;
		public static global::android.app.WallpaperManager getInstance(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperManager>(@__env, @__env.CallStaticObjectMethodPtr(android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getInstance843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable844;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._getDrawable844));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDrawable844));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBitmap845;
		public virtual void setBitmap(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setBitmap845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setBitmap845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekDrawable846;
		public virtual global::android.graphics.drawable.Drawable peekDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._peekDrawable846));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._peekDrawable846));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFastDrawable847;
		public virtual global::android.graphics.drawable.Drawable getFastDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._getFastDrawable847));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getFastDrawable847));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekFastDrawable848;
		public virtual global::android.graphics.drawable.Drawable peekFastDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._peekFastDrawable848));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._peekFastDrawable848));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperInfo849;
		public virtual global::android.app.WallpaperInfo getWallpaperInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperManager._getWallpaperInfo849));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.WallpaperInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getWallpaperInfo849));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResource850;
		public virtual void setResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setResource850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setResource850, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStream851;
		public virtual void setStream(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setStream851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setStream851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumWidth852;
		public virtual int getDesiredMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.WallpaperManager._getDesiredMinimumWidth852);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDesiredMinimumWidth852);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredMinimumHeight853;
		public virtual int getDesiredMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.WallpaperManager._getDesiredMinimumHeight853);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._getDesiredMinimumHeight853);
		}
		internal static global::net.sf.jni4net.jni.MethodId _suggestDesiredDimensions854;
		public virtual void suggestDesiredDimensions(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._suggestDesiredDimensions854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._suggestDesiredDimensions854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaperOffsets855;
		public virtual void setWallpaperOffsets(android.os.IBinder arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setWallpaperOffsets855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setWallpaperOffsets855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaperOffsetSteps856;
		public virtual void setWallpaperOffsetSteps(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._setWallpaperOffsetSteps856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._setWallpaperOffsetSteps856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendWallpaperCommand857;
		public virtual void sendWallpaperCommand(android.os.IBinder arg0, java.lang.String arg1, int arg2, int arg3, int arg4, android.os.Bundle arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._sendWallpaperCommand857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._sendWallpaperCommand857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaperOffsets858;
		public virtual void clearWallpaperOffsets(android.os.IBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperManager._clearWallpaperOffsets858, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperManager.staticClass, global::android.app.WallpaperManager._clearWallpaperOffsets858, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
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
			global::android.app.WallpaperManager._clear842 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "clear", "()V");
			global::android.app.WallpaperManager._getInstance843 = @__env.GetStaticMethodID(global::android.app.WallpaperManager.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;");
			global::android.app.WallpaperManager._getDrawable844 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._setBitmap845 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.app.WallpaperManager._peekDrawable846 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "peekDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._getFastDrawable847 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getFastDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._peekFastDrawable848 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "peekFastDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperManager._getWallpaperInfo849 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getWallpaperInfo", "()Landroid/app/WallpaperInfo;");
			global::android.app.WallpaperManager._setResource850 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setResource", "(I)V");
			global::android.app.WallpaperManager._setStream851 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setStream", "(Ljava/io/InputStream;)V");
			global::android.app.WallpaperManager._getDesiredMinimumWidth852 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumWidth", "()I");
			global::android.app.WallpaperManager._getDesiredMinimumHeight853 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "getDesiredMinimumHeight", "()I");
			global::android.app.WallpaperManager._suggestDesiredDimensions854 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "suggestDesiredDimensions", "(II)V");
			global::android.app.WallpaperManager._setWallpaperOffsets855 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsets", "(Landroid/os/IBinder;FF)V");
			global::android.app.WallpaperManager._setWallpaperOffsetSteps856 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "setWallpaperOffsetSteps", "(FF)V");
			global::android.app.WallpaperManager._sendWallpaperCommand857 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V");
			global::android.app.WallpaperManager._clearWallpaperOffsets858 = @__env.GetMethodID(global::android.app.WallpaperManager.staticClass, "clearWallpaperOffsets", "(Landroid/os/IBinder;)V");
		}
	}
}
