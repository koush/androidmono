namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Activity : android.view.ContextThemeWrapper, android.view.LayoutInflater.Factory, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener, android.content.ComponentCallbacks
	{
		internal new static global::java.lang.Class staticClass;
		static Activity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Activity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.Activity(@__env);
			}
		}
		protected Activity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParent128;
		public virtual global::android.app.Activity getParent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getParent128));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getParent128));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplication129;
		public virtual global::android.app.Application getApplication() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getApplication129));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getApplication129));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate130;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onCreate130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreate130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStart131;
		protected virtual void onStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onStart131);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onStart131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy132;
		protected virtual void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onDestroy132);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onDestroy132);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged133;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onConfigurationChanged133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onConfigurationChanged133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory134;
		public virtual void onLowMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onLowMemory134);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onLowMemory134);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth135;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getWallpaperDesiredMinimumWidth135);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumWidth135);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight136;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getWallpaperDesiredMinimumHeight136);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumHeight136);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivity137;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startActivity137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivity137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender138;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startIntentSender138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSender138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService139;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getSystemService139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getSystemService139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntent140;
		public virtual global::android.content.Intent getIntent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getIntent140));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getIntent140));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations141;
		public virtual int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getChangingConfigurations141);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getChangingConfigurations141);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible142;
		public virtual void setVisible(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setVisible142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setVisible142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResult143;
		public virtual void setResult(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setResult143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setResult143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResult144;
		public virtual void setResult(int arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setResult144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setResult144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finish145;
		public virtual void finish() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finish145);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finish145);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstanceCount146;
		public static long getInstanceCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, global::android.app.Activity._getInstanceCount146);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntent147;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setIntent147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setIntent147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChild148;
		public virtual bool isChild() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._isChild148);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._isChild148);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowManager149;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getWindowManager149));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWindowManager149));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow150;
		public virtual global::android.view.Window getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getWindow150));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWindow150));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus151;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getCurrentFocus151));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getCurrentFocus151));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState152;
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onRestoreInstanceState152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onRestoreInstanceState152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostCreate153;
		protected virtual void onPostCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPostCreate153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPostCreate153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestart154;
		protected virtual void onRestart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onRestart154);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onRestart154);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResume155;
		protected virtual void onResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onResume155);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onResume155);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostResume156;
		protected virtual void onPostResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPostResume156);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPostResume156);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onNewIntent157;
		protected virtual void onNewIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onNewIntent157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onNewIntent157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState158;
		protected virtual void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onSaveInstanceState158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onSaveInstanceState158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPause159;
		protected virtual void onPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPause159);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPause159);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUserLeaveHint160;
		protected virtual void onUserLeaveHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onUserLeaveHint160);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onUserLeaveHint160);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateThumbnail161;
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onCreateThumbnail161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateThumbnail161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDescription162;
		public virtual global::java.lang.CharSequence onCreateDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateDescription162));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDescription162));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStop163;
		protected virtual void onStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onStop163);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onStop163);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastNonConfigurationInstance164;
		public virtual global::java.lang.Object getLastNonConfigurationInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getLastNonConfigurationInstance164));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getLastNonConfigurationInstance164));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRetainNonConfigurationInstance165;
		public virtual global::java.lang.Object onRetainNonConfigurationInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onRetainNonConfigurationInstance165));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onRetainNonConfigurationInstance165));
		}
		internal static global::net.sf.jni4net.jni.MethodId _managedQuery166;
		public virtual global::android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._managedQuery166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._managedQuery166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startManagingCursor167;
		public virtual void startManagingCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startManagingCursor167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startManagingCursor167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopManagingCursor168;
		public virtual void stopManagingCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._stopManagingCursor168, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._stopManagingCursor168, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPersistent169;
		public virtual void setPersistent(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setPersistent169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setPersistent169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewById170;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._findViewById170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._findViewById170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView171;
		public virtual void setContentView(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setContentView171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView172;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setContentView172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView173;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setContentView173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addContentView174;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._addContentView174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._addContentView174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultKeyMode175;
		public virtual void setDefaultKeyMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setDefaultKeyMode175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setDefaultKeyMode175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown176;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyDown176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyDown176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress177;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyLongPress177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyLongPress177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp178;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyUp178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyUp178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple179;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyMultiple179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyMultiple179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBackPressed180;
		public virtual void onBackPressed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onBackPressed180);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onBackPressed180);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent181;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onTouchEvent181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onTouchEvent181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent182;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onTrackballEvent182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onTrackballEvent182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUserInteraction183;
		public virtual void onUserInteraction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onUserInteraction183);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onUserInteraction183);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged184;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onWindowAttributesChanged184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowAttributesChanged184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged185;
		public virtual void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onContentChanged185);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onContentChanged185);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged186;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onWindowFocusChanged186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowFocusChanged186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow187;
		public virtual void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onAttachedToWindow187);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onAttachedToWindow187);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow188;
		public virtual void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onDetachedFromWindow188);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onDetachedFromWindow188);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus189;
		public virtual bool hasWindowFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._hasWindowFocus189);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._hasWindowFocus189);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent190;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchKeyEvent190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchKeyEvent190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent191;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchTouchEvent191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTouchEvent191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent192;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchTrackballEvent192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTrackballEvent192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent193;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchPopulateAccessibilityEvent193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchPopulateAccessibilityEvent193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView194;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreatePanelView194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelView194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu195;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onCreatePanelMenu195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelMenu195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel196;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onPreparePanel196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPreparePanel196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened197;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onMenuOpened197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuOpened197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected198;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onMenuItemSelected198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuItemSelected198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed199;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPanelClosed199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPanelClosed199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateOptionsMenu200;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onCreateOptionsMenu200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateOptionsMenu200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareOptionsMenu201;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onPrepareOptionsMenu201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareOptionsMenu201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsItemSelected202;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onOptionsItemSelected202, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsItemSelected202, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsMenuClosed203;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onOptionsMenuClosed203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsMenuClosed203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOptionsMenu204;
		public virtual void openOptionsMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._openOptionsMenu204);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._openOptionsMenu204);
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeOptionsMenu205;
		public virtual void closeOptionsMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._closeOptionsMenu205);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._closeOptionsMenu205);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu206;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onCreateContextMenu206, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateContextMenu206, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerForContextMenu207;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._registerForContextMenu207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._registerForContextMenu207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterForContextMenu208;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._unregisterForContextMenu208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._unregisterForContextMenu208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openContextMenu209;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._openContextMenu209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._openContextMenu209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeContextMenu210;
		public virtual void closeContextMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._closeContextMenu210);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._closeContextMenu210);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContextItemSelected211;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onContextItemSelected211, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onContextItemSelected211, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContextMenuClosed212;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onContextMenuClosed212, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onContextMenuClosed212, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialog213;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateDialog213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialog214;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateDialog214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialog215;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPrepareDialog215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialog216;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPrepareDialog216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showDialog217;
		public virtual bool showDialog(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._showDialog217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showDialog218;
		public virtual void showDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._showDialog218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dismissDialog219;
		public virtual void dismissDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._dismissDialog219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dismissDialog219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeDialog220;
		public virtual void removeDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._removeDialog220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._removeDialog220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested221;
		public virtual bool onSearchRequested() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onSearchRequested221);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onSearchRequested221);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSearch222;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startSearch222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startSearch222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _triggerSearch223;
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._triggerSearch223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._triggerSearch223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents224;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._takeKeyEvents224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._takeKeyEvents224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestWindowFeature225;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._requestWindowFeature225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._requestWindowFeature225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource226;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawableResource226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableResource226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri227;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawableUri227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableUri227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable228;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawable228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawable228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha229;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawableAlpha229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableAlpha229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater230;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getLayoutInflater230));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getLayoutInflater230));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMenuInflater231;
		public virtual global::android.view.MenuInflater getMenuInflater() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MenuInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getMenuInflater231));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MenuInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getMenuInflater231));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onApplyThemeResource232;
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onApplyThemeResource232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onApplyThemeResource232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivityForResult233;
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startActivityForResult233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityForResult233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSenderForResult234;
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startIntentSenderForResult234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderForResult234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivityIfNeeded235;
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._startActivityIfNeeded235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityIfNeeded235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startNextMatchingActivity236;
		public virtual bool startNextMatchingActivity(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._startNextMatchingActivity236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startNextMatchingActivity236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivityFromChild237;
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startActivityFromChild237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityFromChild237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSenderFromChild238;
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startIntentSenderFromChild238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderFromChild238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _overridePendingTransition239;
		public virtual void overridePendingTransition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._overridePendingTransition239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._overridePendingTransition239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallingPackage240;
		public virtual global::java.lang.String getCallingPackage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getCallingPackage240));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingPackage240));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallingActivity241;
		public virtual global::android.content.ComponentName getCallingActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getCallingActivity241));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingActivity241));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFinishing242;
		public virtual bool isFinishing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._isFinishing242);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._isFinishing242);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishFromChild243;
		public virtual void finishFromChild(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finishFromChild243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finishFromChild243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishActivity244;
		public virtual void finishActivity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finishActivity244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivity244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishActivityFromChild245;
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finishActivityFromChild245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivityFromChild245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult246;
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onActivityResult246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onActivityResult246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createPendingResult247;
		public virtual global::android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._createPendingResult247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._createPendingResult247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRequestedOrientation248;
		public virtual void setRequestedOrientation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setRequestedOrientation248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setRequestedOrientation248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRequestedOrientation249;
		public virtual int getRequestedOrientation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getRequestedOrientation249);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getRequestedOrientation249);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTaskId250;
		public virtual int getTaskId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getTaskId250);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getTaskId250);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTaskRoot251;
		public virtual bool isTaskRoot() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._isTaskRoot251);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._isTaskRoot251);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveTaskToBack252;
		public virtual bool moveTaskToBack(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._moveTaskToBack252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._moveTaskToBack252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalClassName253;
		public virtual global::java.lang.String getLocalClassName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getLocalClassName253));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getLocalClassName253));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComponentName254;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getComponentName254));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getComponentName254));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreferences255;
		public virtual global::android.content.SharedPreferences getPreferences(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getPreferences255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getPreferences255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle256;
		public virtual void setTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setTitle256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle257;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setTitle257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitleColor258;
		public virtual void setTitleColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setTitleColor258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setTitleColor258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle259;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getTitle259));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getTitle259));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitleColor260;
		public virtual int getTitleColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getTitleColor260);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getTitleColor260);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTitleChanged261;
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onTitleChanged261, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onTitleChanged261, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildTitleChanged262;
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onChildTitleChanged262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onChildTitleChanged262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarVisibility263;
		public virtual void setProgressBarVisibility(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgressBarVisibility263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarVisibility263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarIndeterminateVisibility264;
		public virtual void setProgressBarIndeterminateVisibility(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgressBarIndeterminateVisibility264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminateVisibility264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarIndeterminate265;
		public virtual void setProgressBarIndeterminate(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgressBarIndeterminate265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminate265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgress266;
		public virtual void setProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgress266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgress266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress267;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setSecondaryProgress267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setSecondaryProgress267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream268;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setVolumeControlStream268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setVolumeControlStream268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream269;
		public virtual int getVolumeControlStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getVolumeControlStream269);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getVolumeControlStream269);
		}
		internal static global::net.sf.jni4net.jni.MethodId _runOnUiThread270;
		public virtual void runOnUiThread(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._runOnUiThread270, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._runOnUiThread270, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView271;
		public virtual global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateView271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateView271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Activity272;
		public Activity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Activity.staticClass, global::android.app.Activity._Activity272, this);
		}
		public static int RESULT_CANCELED
		{
			get
			{
				return 0;
			}
		}
		public static int RESULT_OK
		{
			get
			{
				return -1;
			}
		}
		public static int RESULT_FIRST_USER
		{
			get
			{
				return 1;
			}
		}
		public static int DEFAULT_KEYS_DISABLE
		{
			get
			{
				return 0;
			}
		}
		public static int DEFAULT_KEYS_DIALER
		{
			get
			{
				return 1;
			}
		}
		public static int DEFAULT_KEYS_SHORTCUT
		{
			get
			{
				return 2;
			}
		}
		public static int DEFAULT_KEYS_SEARCH_LOCAL
		{
			get
			{
				return 3;
			}
		}
		public static int DEFAULT_KEYS_SEARCH_GLOBAL
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.Activity.staticClass = @__class;
			global::android.app.Activity._getParent128 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;");
			global::android.app.Activity._getApplication129 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Activity._onCreate130 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onStart131 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onStart", "()V");
			global::android.app.Activity._onDestroy132 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onDestroy", "()V");
			global::android.app.Activity._onConfigurationChanged133 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Activity._onLowMemory134 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onLowMemory", "()V");
			global::android.app.Activity._getWallpaperDesiredMinimumWidth135 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.app.Activity._getWallpaperDesiredMinimumHeight136 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.app.Activity._startActivity137 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.app.Activity._startIntentSender138 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.app.Activity._getSystemService139 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.app.Activity._getIntent140 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.app.Activity._getChangingConfigurations141 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getChangingConfigurations", "()I");
			global::android.app.Activity._setVisible142 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setVisible", "(Z)V");
			global::android.app.Activity._setResult143 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setResult", "(I)V");
			global::android.app.Activity._setResult144 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V");
			global::android.app.Activity._finish145 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finish", "()V");
			global::android.app.Activity._getInstanceCount146 = @__env.GetStaticMethodID(global::android.app.Activity.staticClass, "getInstanceCount", "()J");
			global::android.app.Activity._setIntent147 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._isChild148 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isChild", "()Z");
			global::android.app.Activity._getWindowManager149 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.app.Activity._getWindow150 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Activity._getCurrentFocus151 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Activity._onRestoreInstanceState152 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPostCreate153 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onRestart154 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRestart", "()V");
			global::android.app.Activity._onResume155 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onResume", "()V");
			global::android.app.Activity._onPostResume156 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPostResume", "()V");
			global::android.app.Activity._onNewIntent157 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._onSaveInstanceState158 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPause159 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPause", "()V");
			global::android.app.Activity._onUserLeaveHint160 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onUserLeaveHint", "()V");
			global::android.app.Activity._onCreateThumbnail161 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z");
			global::android.app.Activity._onCreateDescription162 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._onStop163 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onStop", "()V");
			global::android.app.Activity._getLastNonConfigurationInstance164 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._onRetainNonConfigurationInstance165 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._managedQuery166 = @__env.GetMethodID(global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.app.Activity._startManagingCursor167 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._stopManagingCursor168 = @__env.GetMethodID(global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._setPersistent169 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setPersistent", "(Z)V");
			global::android.app.Activity._findViewById170 = @__env.GetMethodID(global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Activity._setContentView171 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(I)V");
			global::android.app.Activity._setContentView172 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Activity._setContentView173 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._addContentView174 = @__env.GetMethodID(global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._setDefaultKeyMode175 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V");
			global::android.app.Activity._onKeyDown176 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyLongPress177 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyUp178 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyMultiple179 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onBackPressed180 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onBackPressed", "()V");
			global::android.app.Activity._onTouchEvent181 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onTrackballEvent182 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onUserInteraction183 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onUserInteraction", "()V");
			global::android.app.Activity._onWindowAttributesChanged184 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Activity._onContentChanged185 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContentChanged", "()V");
			global::android.app.Activity._onWindowFocusChanged186 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Activity._onAttachedToWindow187 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Activity._onDetachedFromWindow188 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Activity._hasWindowFocus189 = @__env.GetMethodID(global::android.app.Activity.staticClass, "hasWindowFocus", "()Z");
			global::android.app.Activity._dispatchKeyEvent190 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Activity._dispatchTouchEvent191 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchTrackballEvent192 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchPopulateAccessibilityEvent193 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Activity._onCreatePanelView194 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Activity._onCreatePanelMenu195 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onPreparePanel196 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Activity._onMenuOpened197 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onMenuItemSelected198 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Activity._onPanelClosed199 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Activity._onCreateOptionsMenu200 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onPrepareOptionsMenu201 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onOptionsItemSelected202 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onOptionsMenuClosed203 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._openOptionsMenu204 = @__env.GetMethodID(global::android.app.Activity.staticClass, "openOptionsMenu", "()V");
			global::android.app.Activity._closeOptionsMenu205 = @__env.GetMethodID(global::android.app.Activity.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Activity._onCreateContextMenu206 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Activity._registerForContextMenu207 = @__env.GetMethodID(global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._unregisterForContextMenu208 = @__env.GetMethodID(global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._openContextMenu209 = @__env.GetMethodID(global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._closeContextMenu210 = @__env.GetMethodID(global::android.app.Activity.staticClass, "closeContextMenu", "()V");
			global::android.app.Activity._onContextItemSelected211 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onContextMenuClosed212 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._onCreateDialog213 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;");
			global::android.app.Activity._onCreateDialog214 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;");
			global::android.app.Activity._onPrepareDialog215 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V");
			global::android.app.Activity._onPrepareDialog216 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V");
			global::android.app.Activity._showDialog217 = @__env.GetMethodID(global::android.app.Activity.staticClass, "showDialog", "(ILandroid/os/Bundle;)Z");
			global::android.app.Activity._showDialog218 = @__env.GetMethodID(global::android.app.Activity.staticClass, "showDialog", "(I)V");
			global::android.app.Activity._dismissDialog219 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dismissDialog", "(I)V");
			global::android.app.Activity._removeDialog220 = @__env.GetMethodID(global::android.app.Activity.staticClass, "removeDialog", "(I)V");
			global::android.app.Activity._onSearchRequested221 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onSearchRequested", "()Z");
			global::android.app.Activity._startSearch222 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V");
			global::android.app.Activity._triggerSearch223 = @__env.GetMethodID(global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.app.Activity._takeKeyEvents224 = @__env.GetMethodID(global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Activity._requestWindowFeature225 = @__env.GetMethodID(global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Activity._setFeatureDrawableResource226 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Activity._setFeatureDrawableUri227 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Activity._setFeatureDrawable228 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Activity._setFeatureDrawableAlpha229 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Activity._getLayoutInflater230 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Activity._getMenuInflater231 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;");
			global::android.app.Activity._onApplyThemeResource232 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			global::android.app.Activity._startActivityForResult233 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderForResult234 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._startActivityIfNeeded235 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z");
			global::android.app.Activity._startNextMatchingActivity236 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z");
			global::android.app.Activity._startActivityFromChild237 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderFromChild238 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._overridePendingTransition239 = @__env.GetMethodID(global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V");
			global::android.app.Activity._getCallingPackage240 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;");
			global::android.app.Activity._getCallingActivity241 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;");
			global::android.app.Activity._isFinishing242 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isFinishing", "()Z");
			global::android.app.Activity._finishFromChild243 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V");
			global::android.app.Activity._finishActivity244 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishActivity", "(I)V");
			global::android.app.Activity._finishActivityFromChild245 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V");
			global::android.app.Activity._onActivityResult246 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V");
			global::android.app.Activity._createPendingResult247 = @__env.GetMethodID(global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.Activity._setRequestedOrientation248 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V");
			global::android.app.Activity._getRequestedOrientation249 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getRequestedOrientation", "()I");
			global::android.app.Activity._getTaskId250 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTaskId", "()I");
			global::android.app.Activity._isTaskRoot251 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isTaskRoot", "()Z");
			global::android.app.Activity._moveTaskToBack252 = @__env.GetMethodID(global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z");
			global::android.app.Activity._getLocalClassName253 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;");
			global::android.app.Activity._getComponentName254 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Activity._getPreferences255 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;");
			global::android.app.Activity._setTitle256 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitle", "(I)V");
			global::android.app.Activity._setTitle257 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setTitleColor258 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitleColor", "(I)V");
			global::android.app.Activity._getTitle259 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._getTitleColor260 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTitleColor", "()I");
			global::android.app.Activity._onTitleChanged261 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V");
			global::android.app.Activity._onChildTitleChanged262 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setProgressBarVisibility263 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminateVisibility264 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminate265 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V");
			global::android.app.Activity._setProgress266 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgress", "(I)V");
			global::android.app.Activity._setSecondaryProgress267 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.Activity._setVolumeControlStream268 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Activity._getVolumeControlStream269 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Activity._runOnUiThread270 = @__env.GetMethodID(global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.app.Activity._onCreateView271 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.app.Activity._Activity272 = @__env.GetMethodID(global::android.app.Activity.staticClass, "<init>", "()V");
		}
	}
}
