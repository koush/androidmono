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
		internal static global::net.sf.jni4net.jni.MethodId _getParent127;
		public virtual global::android.app.Activity getParent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getParent127));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getParent127));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplication128;
		public virtual global::android.app.Application getApplication() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getApplication128));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getApplication128));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate129;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onCreate129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreate129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStart130;
		protected virtual void onStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onStart130);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onStart130);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy131;
		protected virtual void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onDestroy131);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onDestroy131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged132;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onConfigurationChanged132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onConfigurationChanged132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory133;
		public virtual void onLowMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onLowMemory133);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onLowMemory133);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth134;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getWallpaperDesiredMinimumWidth134);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumWidth134);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight135;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getWallpaperDesiredMinimumHeight135);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumHeight135);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivity136;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startActivity136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivity136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender137;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startIntentSender137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSender137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService138;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getSystemService138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getSystemService138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntent139;
		public virtual global::android.content.Intent getIntent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getIntent139));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getIntent139));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations140;
		public virtual int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getChangingConfigurations140);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getChangingConfigurations140);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible141;
		public virtual void setVisible(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setVisible141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setVisible141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResult142;
		public virtual void setResult(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setResult142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setResult142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setResult143;
		public virtual void setResult(int arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setResult143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setResult143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finish144;
		public virtual void finish() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finish144);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finish144);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstanceCount145;
		public static long getInstanceCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, global::android.app.Activity._getInstanceCount145);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntent146;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setIntent146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setIntent146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChild147;
		public virtual bool isChild() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._isChild147);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._isChild147);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowManager148;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getWindowManager148));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWindowManager148));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow149;
		public virtual global::android.view.Window getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getWindow149));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getWindow149));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus150;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getCurrentFocus150));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getCurrentFocus150));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState151;
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onRestoreInstanceState151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onRestoreInstanceState151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostCreate152;
		protected virtual void onPostCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPostCreate152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPostCreate152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestart153;
		protected virtual void onRestart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onRestart153);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onRestart153);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResume154;
		protected virtual void onResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onResume154);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onResume154);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostResume155;
		protected virtual void onPostResume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPostResume155);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPostResume155);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onNewIntent156;
		protected virtual void onNewIntent(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onNewIntent156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onNewIntent156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState157;
		protected virtual void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onSaveInstanceState157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onSaveInstanceState157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPause158;
		protected virtual void onPause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPause158);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPause158);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUserLeaveHint159;
		protected virtual void onUserLeaveHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onUserLeaveHint159);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onUserLeaveHint159);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateThumbnail160;
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onCreateThumbnail160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateThumbnail160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDescription161;
		public virtual global::java.lang.CharSequence onCreateDescription() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateDescription161));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDescription161));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStop162;
		protected virtual void onStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onStop162);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onStop162);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastNonConfigurationInstance163;
		public virtual global::java.lang.Object getLastNonConfigurationInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getLastNonConfigurationInstance163));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getLastNonConfigurationInstance163));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRetainNonConfigurationInstance164;
		public virtual global::java.lang.Object onRetainNonConfigurationInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onRetainNonConfigurationInstance164));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onRetainNonConfigurationInstance164));
		}
		internal static global::net.sf.jni4net.jni.MethodId _managedQuery165;
		public virtual global::android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._managedQuery165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._managedQuery165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startManagingCursor166;
		public virtual void startManagingCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startManagingCursor166, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startManagingCursor166, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopManagingCursor167;
		public virtual void stopManagingCursor(android.database.Cursor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._stopManagingCursor167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._stopManagingCursor167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPersistent168;
		public virtual void setPersistent(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setPersistent168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setPersistent168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewById169;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._findViewById169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._findViewById169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView170;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setContentView170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setContentView172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addContentView173;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._addContentView173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._addContentView173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultKeyMode174;
		public virtual void setDefaultKeyMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setDefaultKeyMode174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setDefaultKeyMode174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown175;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyDown175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyDown175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress176;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyLongPress176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyLongPress176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp177;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyUp177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyUp177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple178;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onKeyMultiple178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyMultiple178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBackPressed179;
		public virtual void onBackPressed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onBackPressed179);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onBackPressed179);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent180;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onTouchEvent180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onTouchEvent180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent181;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onTrackballEvent181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onTrackballEvent181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUserInteraction182;
		public virtual void onUserInteraction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onUserInteraction182);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onUserInteraction182);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged183;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onWindowAttributesChanged183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowAttributesChanged183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged184;
		public virtual void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onContentChanged184);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onContentChanged184);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged185;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onWindowFocusChanged185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowFocusChanged185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow186;
		public virtual void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onAttachedToWindow186);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onAttachedToWindow186);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow187;
		public virtual void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onDetachedFromWindow187);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onDetachedFromWindow187);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus188;
		public virtual bool hasWindowFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._hasWindowFocus188);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._hasWindowFocus188);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent189;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchKeyEvent189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchKeyEvent189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent190;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchTouchEvent190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTouchEvent190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent191;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchTrackballEvent191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTrackballEvent191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent192;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._dispatchPopulateAccessibilityEvent192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchPopulateAccessibilityEvent192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView193;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreatePanelView193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelView193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu194;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onCreatePanelMenu194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelMenu194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel195;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onPreparePanel195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPreparePanel195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened196;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onMenuOpened196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuOpened196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected197;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onMenuItemSelected197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuItemSelected197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed198;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPanelClosed198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPanelClosed198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateOptionsMenu199;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onCreateOptionsMenu199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateOptionsMenu199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareOptionsMenu200;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onPrepareOptionsMenu200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareOptionsMenu200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsItemSelected201;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onOptionsItemSelected201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsItemSelected201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsMenuClosed202;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onOptionsMenuClosed202, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsMenuClosed202, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOptionsMenu203;
		public virtual void openOptionsMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._openOptionsMenu203);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._openOptionsMenu203);
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeOptionsMenu204;
		public virtual void closeOptionsMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._closeOptionsMenu204);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._closeOptionsMenu204);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu205;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onCreateContextMenu205, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateContextMenu205, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerForContextMenu206;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._registerForContextMenu206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._registerForContextMenu206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterForContextMenu207;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._unregisterForContextMenu207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._unregisterForContextMenu207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openContextMenu208;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._openContextMenu208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._openContextMenu208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeContextMenu209;
		public virtual void closeContextMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._closeContextMenu209);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._closeContextMenu209);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContextItemSelected210;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onContextItemSelected210, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onContextItemSelected210, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContextMenuClosed211;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onContextMenuClosed211, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onContextMenuClosed211, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialog212;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateDialog212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialog213;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onPrepareDialog213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showDialog214;
		public virtual void showDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._showDialog214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dismissDialog215;
		public virtual void dismissDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._dismissDialog215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._dismissDialog215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeDialog216;
		public virtual void removeDialog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._removeDialog216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._removeDialog216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested217;
		public virtual bool onSearchRequested() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._onSearchRequested217);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onSearchRequested217);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSearch218;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startSearch218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startSearch218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _triggerSearch219;
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._triggerSearch219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._triggerSearch219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents220;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._takeKeyEvents220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._takeKeyEvents220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestWindowFeature221;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._requestWindowFeature221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._requestWindowFeature221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource222;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawableResource222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableResource222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri223;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawableUri223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableUri223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable224;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawable224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawable224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha225;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setFeatureDrawableAlpha225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableAlpha225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater226;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getLayoutInflater226));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getLayoutInflater226));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMenuInflater227;
		public virtual global::android.view.MenuInflater getMenuInflater() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MenuInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getMenuInflater227));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MenuInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getMenuInflater227));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onApplyThemeResource228;
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onApplyThemeResource228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onApplyThemeResource228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivityForResult229;
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startActivityForResult229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityForResult229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSenderForResult230;
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startIntentSenderForResult230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderForResult230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivityIfNeeded231;
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._startActivityIfNeeded231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityIfNeeded231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startNextMatchingActivity232;
		public virtual bool startNextMatchingActivity(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._startNextMatchingActivity232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startNextMatchingActivity232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivityFromChild233;
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startActivityFromChild233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityFromChild233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSenderFromChild234;
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._startIntentSenderFromChild234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderFromChild234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _overridePendingTransition235;
		public virtual void overridePendingTransition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._overridePendingTransition235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._overridePendingTransition235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallingPackage236;
		public virtual global::java.lang.String getCallingPackage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getCallingPackage236));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingPackage236));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallingActivity237;
		public virtual global::android.content.ComponentName getCallingActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getCallingActivity237));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingActivity237));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFinishing238;
		public virtual bool isFinishing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._isFinishing238);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._isFinishing238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishFromChild239;
		public virtual void finishFromChild(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finishFromChild239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finishFromChild239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishActivity240;
		public virtual void finishActivity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finishActivity240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivity240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishActivityFromChild241;
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._finishActivityFromChild241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivityFromChild241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult242;
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onActivityResult242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onActivityResult242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createPendingResult243;
		public virtual global::android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._createPendingResult243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._createPendingResult243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRequestedOrientation244;
		public virtual void setRequestedOrientation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setRequestedOrientation244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setRequestedOrientation244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRequestedOrientation245;
		public virtual int getRequestedOrientation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getRequestedOrientation245);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getRequestedOrientation245);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTaskId246;
		public virtual int getTaskId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getTaskId246);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getTaskId246);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTaskRoot247;
		public virtual bool isTaskRoot() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._isTaskRoot247);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._isTaskRoot247);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveTaskToBack248;
		public virtual bool moveTaskToBack(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Activity._moveTaskToBack248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._moveTaskToBack248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalClassName249;
		public virtual global::java.lang.String getLocalClassName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getLocalClassName249));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getLocalClassName249));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComponentName250;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getComponentName250));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getComponentName250));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreferences251;
		public virtual global::android.content.SharedPreferences getPreferences(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getPreferences251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getPreferences251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle252;
		public virtual void setTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setTitle252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle253;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setTitle253, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle253, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitleColor254;
		public virtual void setTitleColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setTitleColor254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setTitleColor254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle255;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._getTitle255));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._getTitle255));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitleColor256;
		public virtual int getTitleColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getTitleColor256);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getTitleColor256);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTitleChanged257;
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onTitleChanged257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onTitleChanged257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildTitleChanged258;
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._onChildTitleChanged258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._onChildTitleChanged258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarVisibility259;
		public virtual void setProgressBarVisibility(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgressBarVisibility259, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarVisibility259, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarIndeterminateVisibility260;
		public virtual void setProgressBarIndeterminateVisibility(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgressBarIndeterminateVisibility260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminateVisibility260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarIndeterminate261;
		public virtual void setProgressBarIndeterminate(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgressBarIndeterminate261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminate261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgress262;
		public virtual void setProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setProgress262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setProgress262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress263;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setSecondaryProgress263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setSecondaryProgress263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream264;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._setVolumeControlStream264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._setVolumeControlStream264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream265;
		public virtual int getVolumeControlStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Activity._getVolumeControlStream265);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._getVolumeControlStream265);
		}
		internal static global::net.sf.jni4net.jni.MethodId _runOnUiThread266;
		public virtual void runOnUiThread(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Activity._runOnUiThread266, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Activity.staticClass, global::android.app.Activity._runOnUiThread266, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView267;
		public virtual global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Activity._onCreateView267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateView267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Activity268;
		public Activity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Activity.staticClass, global::android.app.Activity._Activity268, this);
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
			global::android.app.Activity._getParent127 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;");
			global::android.app.Activity._getApplication128 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Activity._onCreate129 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onStart130 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onStart", "()V");
			global::android.app.Activity._onDestroy131 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onDestroy", "()V");
			global::android.app.Activity._onConfigurationChanged132 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Activity._onLowMemory133 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onLowMemory", "()V");
			global::android.app.Activity._getWallpaperDesiredMinimumWidth134 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.app.Activity._getWallpaperDesiredMinimumHeight135 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.app.Activity._startActivity136 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.app.Activity._startIntentSender137 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.app.Activity._getSystemService138 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.app.Activity._getIntent139 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.app.Activity._getChangingConfigurations140 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getChangingConfigurations", "()I");
			global::android.app.Activity._setVisible141 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setVisible", "(Z)V");
			global::android.app.Activity._setResult142 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setResult", "(I)V");
			global::android.app.Activity._setResult143 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V");
			global::android.app.Activity._finish144 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finish", "()V");
			global::android.app.Activity._getInstanceCount145 = @__env.GetStaticMethodID(global::android.app.Activity.staticClass, "getInstanceCount", "()J");
			global::android.app.Activity._setIntent146 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._isChild147 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isChild", "()Z");
			global::android.app.Activity._getWindowManager148 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.app.Activity._getWindow149 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Activity._getCurrentFocus150 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Activity._onRestoreInstanceState151 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPostCreate152 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onRestart153 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRestart", "()V");
			global::android.app.Activity._onResume154 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onResume", "()V");
			global::android.app.Activity._onPostResume155 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPostResume", "()V");
			global::android.app.Activity._onNewIntent156 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._onSaveInstanceState157 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPause158 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPause", "()V");
			global::android.app.Activity._onUserLeaveHint159 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onUserLeaveHint", "()V");
			global::android.app.Activity._onCreateThumbnail160 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z");
			global::android.app.Activity._onCreateDescription161 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._onStop162 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onStop", "()V");
			global::android.app.Activity._getLastNonConfigurationInstance163 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._onRetainNonConfigurationInstance164 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._managedQuery165 = @__env.GetMethodID(global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.app.Activity._startManagingCursor166 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._stopManagingCursor167 = @__env.GetMethodID(global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._setPersistent168 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setPersistent", "(Z)V");
			global::android.app.Activity._findViewById169 = @__env.GetMethodID(global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Activity._setContentView170 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Activity._setContentView171 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(I)V");
			global::android.app.Activity._setContentView172 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._addContentView173 = @__env.GetMethodID(global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._setDefaultKeyMode174 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V");
			global::android.app.Activity._onKeyDown175 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyLongPress176 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyUp177 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyMultiple178 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onBackPressed179 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onBackPressed", "()V");
			global::android.app.Activity._onTouchEvent180 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onTrackballEvent181 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onUserInteraction182 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onUserInteraction", "()V");
			global::android.app.Activity._onWindowAttributesChanged183 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Activity._onContentChanged184 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContentChanged", "()V");
			global::android.app.Activity._onWindowFocusChanged185 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Activity._onAttachedToWindow186 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Activity._onDetachedFromWindow187 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Activity._hasWindowFocus188 = @__env.GetMethodID(global::android.app.Activity.staticClass, "hasWindowFocus", "()Z");
			global::android.app.Activity._dispatchKeyEvent189 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Activity._dispatchTouchEvent190 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchTrackballEvent191 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchPopulateAccessibilityEvent192 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Activity._onCreatePanelView193 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Activity._onCreatePanelMenu194 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onPreparePanel195 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Activity._onMenuOpened196 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onMenuItemSelected197 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Activity._onPanelClosed198 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Activity._onCreateOptionsMenu199 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onPrepareOptionsMenu200 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onOptionsItemSelected201 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onOptionsMenuClosed202 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._openOptionsMenu203 = @__env.GetMethodID(global::android.app.Activity.staticClass, "openOptionsMenu", "()V");
			global::android.app.Activity._closeOptionsMenu204 = @__env.GetMethodID(global::android.app.Activity.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Activity._onCreateContextMenu205 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Activity._registerForContextMenu206 = @__env.GetMethodID(global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._unregisterForContextMenu207 = @__env.GetMethodID(global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._openContextMenu208 = @__env.GetMethodID(global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._closeContextMenu209 = @__env.GetMethodID(global::android.app.Activity.staticClass, "closeContextMenu", "()V");
			global::android.app.Activity._onContextItemSelected210 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onContextMenuClosed211 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._onCreateDialog212 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;");
			global::android.app.Activity._onPrepareDialog213 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V");
			global::android.app.Activity._showDialog214 = @__env.GetMethodID(global::android.app.Activity.staticClass, "showDialog", "(I)V");
			global::android.app.Activity._dismissDialog215 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dismissDialog", "(I)V");
			global::android.app.Activity._removeDialog216 = @__env.GetMethodID(global::android.app.Activity.staticClass, "removeDialog", "(I)V");
			global::android.app.Activity._onSearchRequested217 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onSearchRequested", "()Z");
			global::android.app.Activity._startSearch218 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V");
			global::android.app.Activity._triggerSearch219 = @__env.GetMethodID(global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.app.Activity._takeKeyEvents220 = @__env.GetMethodID(global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Activity._requestWindowFeature221 = @__env.GetMethodID(global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Activity._setFeatureDrawableResource222 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Activity._setFeatureDrawableUri223 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Activity._setFeatureDrawable224 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Activity._setFeatureDrawableAlpha225 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Activity._getLayoutInflater226 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Activity._getMenuInflater227 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;");
			global::android.app.Activity._onApplyThemeResource228 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			global::android.app.Activity._startActivityForResult229 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderForResult230 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._startActivityIfNeeded231 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z");
			global::android.app.Activity._startNextMatchingActivity232 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z");
			global::android.app.Activity._startActivityFromChild233 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderFromChild234 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._overridePendingTransition235 = @__env.GetMethodID(global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V");
			global::android.app.Activity._getCallingPackage236 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;");
			global::android.app.Activity._getCallingActivity237 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;");
			global::android.app.Activity._isFinishing238 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isFinishing", "()Z");
			global::android.app.Activity._finishFromChild239 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V");
			global::android.app.Activity._finishActivity240 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishActivity", "(I)V");
			global::android.app.Activity._finishActivityFromChild241 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V");
			global::android.app.Activity._onActivityResult242 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V");
			global::android.app.Activity._createPendingResult243 = @__env.GetMethodID(global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.Activity._setRequestedOrientation244 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V");
			global::android.app.Activity._getRequestedOrientation245 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getRequestedOrientation", "()I");
			global::android.app.Activity._getTaskId246 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTaskId", "()I");
			global::android.app.Activity._isTaskRoot247 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isTaskRoot", "()Z");
			global::android.app.Activity._moveTaskToBack248 = @__env.GetMethodID(global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z");
			global::android.app.Activity._getLocalClassName249 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;");
			global::android.app.Activity._getComponentName250 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Activity._getPreferences251 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;");
			global::android.app.Activity._setTitle252 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitle", "(I)V");
			global::android.app.Activity._setTitle253 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setTitleColor254 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitleColor", "(I)V");
			global::android.app.Activity._getTitle255 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._getTitleColor256 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTitleColor", "()I");
			global::android.app.Activity._onTitleChanged257 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V");
			global::android.app.Activity._onChildTitleChanged258 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setProgressBarVisibility259 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminateVisibility260 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminate261 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V");
			global::android.app.Activity._setProgress262 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgress", "(I)V");
			global::android.app.Activity._setSecondaryProgress263 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.Activity._setVolumeControlStream264 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Activity._getVolumeControlStream265 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Activity._runOnUiThread266 = @__env.GetMethodID(global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.app.Activity._onCreateView267 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.app.Activity._Activity268 = @__env.GetMethodID(global::android.app.Activity.staticClass, "<init>", "()V");
		}
	}
	public static class ActivityExtensionMethods
	{
		public static void setTitle(this global::android.app.Activity __this, string arg0)
		{
			__this.setTitle((global::java.lang.String)arg0);
		}
	}
}
