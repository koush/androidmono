namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Activity : android.view.ContextThemeWrapper, android.view.LayoutInflater.Factory, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Activity()
		{
			InitJNI();
		}
		protected Activity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent137;
		public virtual global::android.app.Activity getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getParent137)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getParent137)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _getApplication138;
		public virtual global::android.app.Application getApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getApplication138)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getApplication138)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate139;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onCreate139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreate139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart140;
		protected virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onStart140);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onStart140);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy141;
		protected virtual void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onDestroy141);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onDestroy141);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged142;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onConfigurationChanged142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onConfigurationChanged142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory143;
		public virtual void onLowMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onLowMemory143);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onLowMemory143);
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth144;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getWallpaperDesiredMinimumWidth144);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumWidth144);
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight145;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getWallpaperDesiredMinimumHeight145);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumHeight145);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity146;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivity146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivity146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender147;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSender147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSender147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService148;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getSystemService148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getSystemService148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent149;
		public virtual global::android.content.Intent getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getIntent149)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getIntent149)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations150;
		public virtual int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getChangingConfigurations150);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getChangingConfigurations150);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible151;
		public virtual void setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setVisible151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setVisible151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResult152;
		public virtual void setResult(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setResult152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setResult152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResult153;
		public virtual void setResult(int arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setResult153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setResult153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _finish154;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finish154);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finish154);
		}
		internal static global::MonoJavaBridge.MethodId _getInstanceCount155;
		public static long getInstanceCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, global::android.app.Activity._getInstanceCount155);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent156;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setIntent156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setIntent156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChild157;
		public virtual bool isChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isChild157);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isChild157);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager158;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getWindowManager158)) as android.view.WindowManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWindowManager158)) as android.view.WindowManager;
		}
		internal static global::MonoJavaBridge.MethodId _getWindow159;
		public virtual global::android.view.Window getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getWindow159)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWindow159)) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus160;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCurrentFocus160)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCurrentFocus160)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState161;
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onRestoreInstanceState161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRestoreInstanceState161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPostCreate162;
		protected virtual void onPostCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPostCreate162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPostCreate162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestart163;
		protected virtual void onRestart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onRestart163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRestart163);
		}
		internal static global::MonoJavaBridge.MethodId _onResume164;
		protected virtual void onResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onResume164);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onResume164);
		}
		internal static global::MonoJavaBridge.MethodId _onPostResume165;
		protected virtual void onPostResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPostResume165);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPostResume165);
		}
		internal static global::MonoJavaBridge.MethodId _onNewIntent166;
		protected virtual void onNewIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onNewIntent166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onNewIntent166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState167;
		protected virtual void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onSaveInstanceState167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onSaveInstanceState167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPause168;
		protected virtual void onPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPause168);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPause168);
		}
		internal static global::MonoJavaBridge.MethodId _onUserLeaveHint169;
		protected virtual void onUserLeaveHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onUserLeaveHint169);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onUserLeaveHint169);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateThumbnail170;
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreateThumbnail170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateThumbnail170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDescription171;
		public virtual global::java.lang.CharSequence onCreateDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDescription171)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDescription171)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onStop172;
		protected virtual void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onStop172);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onStop172);
		}
		internal static global::MonoJavaBridge.MethodId _getLastNonConfigurationInstance173;
		public virtual global::java.lang.Object getLastNonConfigurationInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLastNonConfigurationInstance173)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLastNonConfigurationInstance173)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onRetainNonConfigurationInstance174;
		public virtual global::java.lang.Object onRetainNonConfigurationInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onRetainNonConfigurationInstance174)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRetainNonConfigurationInstance174)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _managedQuery175;
		public virtual global::android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._managedQuery175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._managedQuery175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _startManagingCursor176;
		public virtual void startManagingCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startManagingCursor176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startManagingCursor176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopManagingCursor177;
		public virtual void stopManagingCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._stopManagingCursor177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._stopManagingCursor177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPersistent178;
		public virtual void setPersistent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setPersistent178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setPersistent178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewById179;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._findViewById179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._findViewById179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView180;
		public virtual void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView181;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView182;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView183;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._addContentView183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._addContentView183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultKeyMode184;
		public virtual void setDefaultKeyMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setDefaultKeyMode184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setDefaultKeyMode184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown185;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyDown185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyDown185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress186;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyLongPress186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyLongPress186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp187;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyUp187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyUp187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple188;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyMultiple188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyMultiple188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onBackPressed189;
		public virtual void onBackPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onBackPressed189);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onBackPressed189);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent190;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onTouchEvent190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTouchEvent190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent191;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onTrackballEvent191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTrackballEvent191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUserInteraction192;
		public virtual void onUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onUserInteraction192);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onUserInteraction192);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged193;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onWindowAttributesChanged193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowAttributesChanged193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged194;
		public virtual void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onContentChanged194);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContentChanged194);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged195;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onWindowFocusChanged195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowFocusChanged195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow196;
		public virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onAttachedToWindow196);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onAttachedToWindow196);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow197;
		public virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onDetachedFromWindow197);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onDetachedFromWindow197);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus198;
		public virtual bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._hasWindowFocus198);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._hasWindowFocus198);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent199;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchKeyEvent199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchKeyEvent199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent200;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchTouchEvent200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTouchEvent200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent201;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchTrackballEvent201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTrackballEvent201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent202;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchPopulateAccessibilityEvent202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchPopulateAccessibilityEvent202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelView203;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreatePanelView203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelView203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu204;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreatePanelMenu204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelMenu204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPreparePanel205;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onPreparePanel205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPreparePanel205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuOpened206;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onMenuOpened206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuOpened206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemSelected207;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onMenuItemSelected207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuItemSelected207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPanelClosed208;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPanelClosed208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPanelClosed208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateOptionsMenu209;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreateOptionsMenu209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateOptionsMenu209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareOptionsMenu210;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onPrepareOptionsMenu210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareOptionsMenu210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsItemSelected211;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onOptionsItemSelected211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsItemSelected211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsMenuClosed212;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onOptionsMenuClosed212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsMenuClosed212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOptionsMenu213;
		public virtual void openOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._openOptionsMenu213);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._openOptionsMenu213);
		}
		internal static global::MonoJavaBridge.MethodId _closeOptionsMenu214;
		public virtual void closeOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._closeOptionsMenu214);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._closeOptionsMenu214);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu215;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onCreateContextMenu215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateContextMenu215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerForContextMenu216;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._registerForContextMenu216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._registerForContextMenu216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterForContextMenu217;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._unregisterForContextMenu217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._unregisterForContextMenu217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openContextMenu218;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._openContextMenu218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._openContextMenu218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeContextMenu219;
		public virtual void closeContextMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._closeContextMenu219);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._closeContextMenu219);
		}
		internal static global::MonoJavaBridge.MethodId _onContextItemSelected220;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onContextItemSelected220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContextItemSelected220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextMenuClosed221;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onContextMenuClosed221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContextMenuClosed221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialog222;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDialog222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialog223;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDialog223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialog224;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPrepareDialog224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialog225;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPrepareDialog225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _showDialog226;
		public virtual bool showDialog(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._showDialog226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showDialog227;
		public virtual void showDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._showDialog227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dismissDialog228;
		public virtual void dismissDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._dismissDialog228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dismissDialog228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeDialog229;
		public virtual void removeDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._removeDialog229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._removeDialog229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSearchRequested230;
		public virtual bool onSearchRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onSearchRequested230);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onSearchRequested230);
		}
		internal static global::MonoJavaBridge.MethodId _startSearch231;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startSearch231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startSearch231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _triggerSearch232;
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._triggerSearch232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._triggerSearch232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents233;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._takeKeyEvents233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._takeKeyEvents233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestWindowFeature234;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._requestWindowFeature234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._requestWindowFeature234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource235;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableResource235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableResource235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri236;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableUri236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableUri236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable237;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawable237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawable237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha238;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableAlpha238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableAlpha238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater239;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLayoutInflater239)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLayoutInflater239)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInflater240;
		public virtual global::android.view.MenuInflater getMenuInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getMenuInflater240)) as android.view.MenuInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getMenuInflater240)) as android.view.MenuInflater;
		}
		internal static global::MonoJavaBridge.MethodId _onApplyThemeResource241;
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onApplyThemeResource241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onApplyThemeResource241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityForResult242;
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivityForResult242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityForResult242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSenderForResult243;
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSenderForResult243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderForResult243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityIfNeeded244;
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._startActivityIfNeeded244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityIfNeeded244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startNextMatchingActivity245;
		public virtual bool startNextMatchingActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._startNextMatchingActivity245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startNextMatchingActivity245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityFromChild246;
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivityFromChild246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityFromChild246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSenderFromChild247;
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSenderFromChild247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderFromChild247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _overridePendingTransition248;
		public virtual void overridePendingTransition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._overridePendingTransition248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._overridePendingTransition248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCallingPackage249;
		public virtual global::java.lang.String getCallingPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCallingPackage249)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingPackage249)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCallingActivity250;
		public virtual global::android.content.ComponentName getCallingActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCallingActivity250)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingActivity250)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _isFinishing251;
		public virtual bool isFinishing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isFinishing251);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isFinishing251);
		}
		internal static global::MonoJavaBridge.MethodId _finishFromChild252;
		public virtual void finishFromChild(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishFromChild252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishFromChild252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finishActivity253;
		public virtual void finishActivity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishActivity253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivity253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finishActivityFromChild254;
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishActivityFromChild254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivityFromChild254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult255;
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onActivityResult255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onActivityResult255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPendingResult256;
		public virtual global::android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._createPendingResult256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.PendingIntent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._createPendingResult256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _setRequestedOrientation257;
		public virtual void setRequestedOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setRequestedOrientation257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setRequestedOrientation257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestedOrientation258;
		public virtual int getRequestedOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getRequestedOrientation258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getRequestedOrientation258);
		}
		internal static global::MonoJavaBridge.MethodId _getTaskId259;
		public virtual int getTaskId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getTaskId259);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTaskId259);
		}
		internal static global::MonoJavaBridge.MethodId _isTaskRoot260;
		public virtual bool isTaskRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isTaskRoot260);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isTaskRoot260);
		}
		internal static global::MonoJavaBridge.MethodId _moveTaskToBack261;
		public virtual bool moveTaskToBack(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._moveTaskToBack261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._moveTaskToBack261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocalClassName262;
		public virtual global::java.lang.String getLocalClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLocalClassName262)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLocalClassName262)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComponentName263;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getComponentName263)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getComponentName263)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences264;
		public virtual global::android.content.SharedPreferences getPreferences(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getPreferences264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getPreferences264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle265;
		public virtual void setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitle265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle266;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitle266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor267;
		public virtual void setTitleColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitleColor267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitleColor267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTitle268;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getTitle268)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTitle268)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTitleColor269;
		public virtual int getTitleColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getTitleColor269);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTitleColor269);
		}
		internal static global::MonoJavaBridge.MethodId _onTitleChanged270;
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onTitleChanged270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTitleChanged270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onChildTitleChanged271;
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onChildTitleChanged271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onChildTitleChanged271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarVisibility272;
		public virtual void setProgressBarVisibility(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarVisibility272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarVisibility272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarIndeterminateVisibility273;
		public virtual void setProgressBarIndeterminateVisibility(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarIndeterminateVisibility273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminateVisibility273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarIndeterminate274;
		public virtual void setProgressBarIndeterminate(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarIndeterminate274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminate274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgress275;
		public virtual void setProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgress275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgress275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress276;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setSecondaryProgress276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setSecondaryProgress276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream277;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setVolumeControlStream277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setVolumeControlStream277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream278;
		public virtual int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getVolumeControlStream278);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getVolumeControlStream278);
		}
		internal static global::MonoJavaBridge.MethodId _runOnUiThread279;
		public virtual void runOnUiThread(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._runOnUiThread279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._runOnUiThread279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView280;
		public virtual global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateView280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateView280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _Activity281;
		public Activity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Activity.staticClass, global::android.app.Activity._Activity281);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Activity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Activity"));
			global::android.app.Activity._getParent137 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;");
			global::android.app.Activity._getApplication138 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Activity._onCreate139 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onStart140 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onStart", "()V");
			global::android.app.Activity._onDestroy141 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onDestroy", "()V");
			global::android.app.Activity._onConfigurationChanged142 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Activity._onLowMemory143 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onLowMemory", "()V");
			global::android.app.Activity._getWallpaperDesiredMinimumWidth144 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.app.Activity._getWallpaperDesiredMinimumHeight145 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.app.Activity._startActivity146 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.app.Activity._startIntentSender147 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.app.Activity._getSystemService148 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.app.Activity._getIntent149 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.app.Activity._getChangingConfigurations150 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getChangingConfigurations", "()I");
			global::android.app.Activity._setVisible151 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setVisible", "(Z)V");
			global::android.app.Activity._setResult152 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setResult", "(I)V");
			global::android.app.Activity._setResult153 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V");
			global::android.app.Activity._finish154 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finish", "()V");
			global::android.app.Activity._getInstanceCount155 = @__env.GetStaticMethodIDNoThrow(global::android.app.Activity.staticClass, "getInstanceCount", "()J");
			global::android.app.Activity._setIntent156 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._isChild157 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isChild", "()Z");
			global::android.app.Activity._getWindowManager158 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.app.Activity._getWindow159 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Activity._getCurrentFocus160 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Activity._onRestoreInstanceState161 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPostCreate162 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onRestart163 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRestart", "()V");
			global::android.app.Activity._onResume164 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onResume", "()V");
			global::android.app.Activity._onPostResume165 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPostResume", "()V");
			global::android.app.Activity._onNewIntent166 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._onSaveInstanceState167 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPause168 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPause", "()V");
			global::android.app.Activity._onUserLeaveHint169 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onUserLeaveHint", "()V");
			global::android.app.Activity._onCreateThumbnail170 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z");
			global::android.app.Activity._onCreateDescription171 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._onStop172 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onStop", "()V");
			global::android.app.Activity._getLastNonConfigurationInstance173 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._onRetainNonConfigurationInstance174 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._managedQuery175 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.app.Activity._startManagingCursor176 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._stopManagingCursor177 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._setPersistent178 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setPersistent", "(Z)V");
			global::android.app.Activity._findViewById179 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Activity._setContentView180 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(I)V");
			global::android.app.Activity._setContentView181 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Activity._setContentView182 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._addContentView183 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._setDefaultKeyMode184 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V");
			global::android.app.Activity._onKeyDown185 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyLongPress186 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyUp187 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyMultiple188 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onBackPressed189 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onBackPressed", "()V");
			global::android.app.Activity._onTouchEvent190 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onTrackballEvent191 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onUserInteraction192 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onUserInteraction", "()V");
			global::android.app.Activity._onWindowAttributesChanged193 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Activity._onContentChanged194 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContentChanged", "()V");
			global::android.app.Activity._onWindowFocusChanged195 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Activity._onAttachedToWindow196 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Activity._onDetachedFromWindow197 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Activity._hasWindowFocus198 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "hasWindowFocus", "()Z");
			global::android.app.Activity._dispatchKeyEvent199 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Activity._dispatchTouchEvent200 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchTrackballEvent201 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchPopulateAccessibilityEvent202 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Activity._onCreatePanelView203 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Activity._onCreatePanelMenu204 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onPreparePanel205 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Activity._onMenuOpened206 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onMenuItemSelected207 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Activity._onPanelClosed208 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Activity._onCreateOptionsMenu209 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onPrepareOptionsMenu210 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onOptionsItemSelected211 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onOptionsMenuClosed212 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._openOptionsMenu213 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "openOptionsMenu", "()V");
			global::android.app.Activity._closeOptionsMenu214 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Activity._onCreateContextMenu215 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Activity._registerForContextMenu216 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._unregisterForContextMenu217 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._openContextMenu218 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._closeContextMenu219 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "closeContextMenu", "()V");
			global::android.app.Activity._onContextItemSelected220 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onContextMenuClosed221 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._onCreateDialog222 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;");
			global::android.app.Activity._onCreateDialog223 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;");
			global::android.app.Activity._onPrepareDialog224 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V");
			global::android.app.Activity._onPrepareDialog225 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V");
			global::android.app.Activity._showDialog226 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "showDialog", "(ILandroid/os/Bundle;)Z");
			global::android.app.Activity._showDialog227 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "showDialog", "(I)V");
			global::android.app.Activity._dismissDialog228 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dismissDialog", "(I)V");
			global::android.app.Activity._removeDialog229 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "removeDialog", "(I)V");
			global::android.app.Activity._onSearchRequested230 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onSearchRequested", "()Z");
			global::android.app.Activity._startSearch231 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V");
			global::android.app.Activity._triggerSearch232 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.app.Activity._takeKeyEvents233 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Activity._requestWindowFeature234 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Activity._setFeatureDrawableResource235 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Activity._setFeatureDrawableUri236 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Activity._setFeatureDrawable237 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Activity._setFeatureDrawableAlpha238 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Activity._getLayoutInflater239 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Activity._getMenuInflater240 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;");
			global::android.app.Activity._onApplyThemeResource241 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			global::android.app.Activity._startActivityForResult242 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderForResult243 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._startActivityIfNeeded244 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z");
			global::android.app.Activity._startNextMatchingActivity245 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z");
			global::android.app.Activity._startActivityFromChild246 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderFromChild247 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._overridePendingTransition248 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V");
			global::android.app.Activity._getCallingPackage249 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;");
			global::android.app.Activity._getCallingActivity250 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;");
			global::android.app.Activity._isFinishing251 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isFinishing", "()Z");
			global::android.app.Activity._finishFromChild252 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V");
			global::android.app.Activity._finishActivity253 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishActivity", "(I)V");
			global::android.app.Activity._finishActivityFromChild254 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V");
			global::android.app.Activity._onActivityResult255 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V");
			global::android.app.Activity._createPendingResult256 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.Activity._setRequestedOrientation257 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V");
			global::android.app.Activity._getRequestedOrientation258 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getRequestedOrientation", "()I");
			global::android.app.Activity._getTaskId259 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTaskId", "()I");
			global::android.app.Activity._isTaskRoot260 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isTaskRoot", "()Z");
			global::android.app.Activity._moveTaskToBack261 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z");
			global::android.app.Activity._getLocalClassName262 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;");
			global::android.app.Activity._getComponentName263 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Activity._getPreferences264 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;");
			global::android.app.Activity._setTitle265 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitle", "(I)V");
			global::android.app.Activity._setTitle266 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setTitleColor267 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitleColor", "(I)V");
			global::android.app.Activity._getTitle268 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._getTitleColor269 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTitleColor", "()I");
			global::android.app.Activity._onTitleChanged270 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V");
			global::android.app.Activity._onChildTitleChanged271 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setProgressBarVisibility272 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminateVisibility273 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminate274 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V");
			global::android.app.Activity._setProgress275 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgress", "(I)V");
			global::android.app.Activity._setSecondaryProgress276 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.Activity._setVolumeControlStream277 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Activity._getVolumeControlStream278 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Activity._runOnUiThread279 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.app.Activity._onCreateView280 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.app.Activity._Activity281 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "<init>", "()V");
		}
	}
}
