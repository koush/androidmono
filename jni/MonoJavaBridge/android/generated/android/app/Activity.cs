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
		public new global::android.app.Activity Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent1388;
		public virtual global::android.app.Activity getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getParent1388)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getParent1388)) as android.app.Activity;
		}
		public new global::android.app.Application Application
		{
			get
			{
				return getApplication();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplication1389;
		public virtual global::android.app.Application getApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getApplication1389)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getApplication1389)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1390;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onCreate1390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreate1390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart1391;
		protected virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onStart1391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onStart1391);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1392;
		protected virtual void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onDestroy1392);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onDestroy1392);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged1393;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onConfigurationChanged1393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onConfigurationChanged1393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory1394;
		public virtual void onLowMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onLowMemory1394);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onLowMemory1394);
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth1395;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getWallpaperDesiredMinimumWidth1395);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumWidth1395);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight1396;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getWallpaperDesiredMinimumHeight1396);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumHeight1396);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity1397;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivity1397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivity1397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender1398;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSender1398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSender1398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService1399;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getSystemService1399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getSystemService1399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new global::android.content.Intent Intent
		{
			get
			{
				return getIntent();
			}
			set
			{
				setIntent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntent1400;
		public virtual global::android.content.Intent getIntent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getIntent1400)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getIntent1400)) as android.content.Intent;
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations1401;
		public virtual int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getChangingConfigurations1401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getChangingConfigurations1401);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible1402;
		public virtual void setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setVisible1402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setVisible1402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResult1403;
		public virtual void setResult(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setResult1403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setResult1403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResult1404;
		public virtual void setResult(int arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setResult1404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setResult1404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _finish1405;
		public virtual void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finish1405);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finish1405);
		}
		public static long InstanceCount
		{
			get
			{
				return getInstanceCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstanceCount1406;
		public static long getInstanceCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, global::android.app.Activity._getInstanceCount1406);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent1407;
		public virtual void setIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setIntent1407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setIntent1407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChild1408;
		public virtual bool isChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isChild1408);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isChild1408);
		}
		public new global::android.view.WindowManager WindowManager
		{
			get
			{
				return getWindowManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager1409;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getWindowManager1409)) as android.view.WindowManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWindowManager1409)) as android.view.WindowManager;
		}
		public new global::android.view.Window Window
		{
			get
			{
				return getWindow();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindow1410;
		public virtual global::android.view.Window getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getWindow1410)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWindow1410)) as android.view.Window;
		}
		public new global::android.view.View CurrentFocus
		{
			get
			{
				return getCurrentFocus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus1411;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCurrentFocus1411)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCurrentFocus1411)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1412;
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onRestoreInstanceState1412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRestoreInstanceState1412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPostCreate1413;
		protected virtual void onPostCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPostCreate1413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPostCreate1413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestart1414;
		protected virtual void onRestart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onRestart1414);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRestart1414);
		}
		internal static global::MonoJavaBridge.MethodId _onResume1415;
		protected virtual void onResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onResume1415);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onResume1415);
		}
		internal static global::MonoJavaBridge.MethodId _onPostResume1416;
		protected virtual void onPostResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPostResume1416);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPostResume1416);
		}
		internal static global::MonoJavaBridge.MethodId _onNewIntent1417;
		protected virtual void onNewIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onNewIntent1417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onNewIntent1417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1418;
		protected virtual void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onSaveInstanceState1418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onSaveInstanceState1418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPause1419;
		protected virtual void onPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPause1419);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPause1419);
		}
		internal static global::MonoJavaBridge.MethodId _onUserLeaveHint1420;
		protected virtual void onUserLeaveHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onUserLeaveHint1420);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onUserLeaveHint1420);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateThumbnail1421;
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreateThumbnail1421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateThumbnail1421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDescription1422;
		public virtual global::java.lang.CharSequence onCreateDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDescription1422)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDescription1422)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onStop1423;
		protected virtual void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onStop1423);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onStop1423);
		}
		public new global::java.lang.Object LastNonConfigurationInstance
		{
			get
			{
				return getLastNonConfigurationInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLastNonConfigurationInstance1424;
		public virtual global::java.lang.Object getLastNonConfigurationInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLastNonConfigurationInstance1424)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLastNonConfigurationInstance1424)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onRetainNonConfigurationInstance1425;
		public virtual global::java.lang.Object onRetainNonConfigurationInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onRetainNonConfigurationInstance1425)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRetainNonConfigurationInstance1425)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _managedQuery1426;
		public virtual global::android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._managedQuery1426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._managedQuery1426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _startManagingCursor1427;
		public virtual void startManagingCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startManagingCursor1427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startManagingCursor1427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopManagingCursor1428;
		public virtual void stopManagingCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._stopManagingCursor1428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._stopManagingCursor1428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPersistent1429;
		public virtual void setPersistent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setPersistent1429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setPersistent1429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewById1430;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._findViewById1430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._findViewById1430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1431;
		public virtual void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView1431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView1431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1432;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView1432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView1432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1433;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView1433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView1433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView1434;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._addContentView1434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._addContentView1434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultKeyMode1435;
		public virtual void setDefaultKeyMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setDefaultKeyMode1435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setDefaultKeyMode1435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown1436;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyDown1436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyDown1436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress1437;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyLongPress1437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyLongPress1437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp1438;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyUp1438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyUp1438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple1439;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyMultiple1439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyMultiple1439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onBackPressed1440;
		public virtual void onBackPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onBackPressed1440);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onBackPressed1440);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent1441;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onTouchEvent1441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTouchEvent1441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent1442;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onTrackballEvent1442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTrackballEvent1442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUserInteraction1443;
		public virtual void onUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onUserInteraction1443);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onUserInteraction1443);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged1444;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onWindowAttributesChanged1444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowAttributesChanged1444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1445;
		public virtual void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onContentChanged1445);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContentChanged1445);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged1446;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onWindowFocusChanged1446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowFocusChanged1446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow1447;
		public virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onAttachedToWindow1447);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onAttachedToWindow1447);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow1448;
		public virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onDetachedFromWindow1448);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onDetachedFromWindow1448);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus1449;
		public virtual bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._hasWindowFocus1449);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._hasWindowFocus1449);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent1450;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchKeyEvent1450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchKeyEvent1450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent1451;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchTouchEvent1451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTouchEvent1451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent1452;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchTrackballEvent1452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTrackballEvent1452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent1453;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchPopulateAccessibilityEvent1453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchPopulateAccessibilityEvent1453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelView1454;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreatePanelView1454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelView1454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu1455;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreatePanelMenu1455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelMenu1455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPreparePanel1456;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onPreparePanel1456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPreparePanel1456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuOpened1457;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onMenuOpened1457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuOpened1457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemSelected1458;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onMenuItemSelected1458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuItemSelected1458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPanelClosed1459;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPanelClosed1459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPanelClosed1459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateOptionsMenu1460;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreateOptionsMenu1460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateOptionsMenu1460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareOptionsMenu1461;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onPrepareOptionsMenu1461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareOptionsMenu1461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsItemSelected1462;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onOptionsItemSelected1462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsItemSelected1462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsMenuClosed1463;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onOptionsMenuClosed1463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsMenuClosed1463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOptionsMenu1464;
		public virtual void openOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._openOptionsMenu1464);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._openOptionsMenu1464);
		}
		internal static global::MonoJavaBridge.MethodId _closeOptionsMenu1465;
		public virtual void closeOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._closeOptionsMenu1465);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._closeOptionsMenu1465);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu1466;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onCreateContextMenu1466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateContextMenu1466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerForContextMenu1467;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._registerForContextMenu1467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._registerForContextMenu1467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterForContextMenu1468;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._unregisterForContextMenu1468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._unregisterForContextMenu1468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openContextMenu1469;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._openContextMenu1469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._openContextMenu1469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeContextMenu1470;
		public virtual void closeContextMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._closeContextMenu1470);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._closeContextMenu1470);
		}
		internal static global::MonoJavaBridge.MethodId _onContextItemSelected1471;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onContextItemSelected1471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContextItemSelected1471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextMenuClosed1472;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onContextMenuClosed1472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContextMenuClosed1472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialog1473;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDialog1473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog1473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialog1474;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDialog1474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog1474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialog1475;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPrepareDialog1475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog1475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialog1476;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPrepareDialog1476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog1476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _showDialog1477;
		public virtual bool showDialog(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._showDialog1477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog1477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showDialog1478;
		public virtual void showDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._showDialog1478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog1478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dismissDialog1479;
		public virtual void dismissDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._dismissDialog1479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dismissDialog1479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeDialog1480;
		public virtual void removeDialog(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._removeDialog1480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._removeDialog1480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSearchRequested1481;
		public virtual bool onSearchRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onSearchRequested1481);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onSearchRequested1481);
		}
		internal static global::MonoJavaBridge.MethodId _startSearch1482;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startSearch1482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startSearch1482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _triggerSearch1483;
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._triggerSearch1483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._triggerSearch1483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents1484;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._takeKeyEvents1484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._takeKeyEvents1484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestWindowFeature1485;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._requestWindowFeature1485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._requestWindowFeature1485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource1486;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableResource1486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableResource1486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri1487;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableUri1487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableUri1487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable1488;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawable1488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawable1488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha1489;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableAlpha1489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableAlpha1489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater1490;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLayoutInflater1490)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLayoutInflater1490)) as android.view.LayoutInflater;
		}
		public new global::android.view.MenuInflater MenuInflater
		{
			get
			{
				return getMenuInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInflater1491;
		public virtual global::android.view.MenuInflater getMenuInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getMenuInflater1491)) as android.view.MenuInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getMenuInflater1491)) as android.view.MenuInflater;
		}
		internal static global::MonoJavaBridge.MethodId _onApplyThemeResource1492;
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onApplyThemeResource1492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onApplyThemeResource1492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityForResult1493;
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivityForResult1493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityForResult1493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSenderForResult1494;
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSenderForResult1494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderForResult1494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityIfNeeded1495;
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._startActivityIfNeeded1495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityIfNeeded1495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startNextMatchingActivity1496;
		public virtual bool startNextMatchingActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._startNextMatchingActivity1496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startNextMatchingActivity1496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityFromChild1497;
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivityFromChild1497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityFromChild1497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSenderFromChild1498;
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSenderFromChild1498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderFromChild1498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _overridePendingTransition1499;
		public virtual void overridePendingTransition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._overridePendingTransition1499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._overridePendingTransition1499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String CallingPackage
		{
			get
			{
				return getCallingPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingPackage1500;
		public virtual global::java.lang.String getCallingPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCallingPackage1500)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingPackage1500)) as java.lang.String;
		}
		public new global::android.content.ComponentName CallingActivity
		{
			get
			{
				return getCallingActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingActivity1501;
		public virtual global::android.content.ComponentName getCallingActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCallingActivity1501)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingActivity1501)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _isFinishing1502;
		public virtual bool isFinishing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isFinishing1502);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isFinishing1502);
		}
		internal static global::MonoJavaBridge.MethodId _finishFromChild1503;
		public virtual void finishFromChild(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishFromChild1503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishFromChild1503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finishActivity1504;
		public virtual void finishActivity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishActivity1504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivity1504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finishActivityFromChild1505;
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishActivityFromChild1505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivityFromChild1505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult1506;
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onActivityResult1506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onActivityResult1506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPendingResult1507;
		public virtual global::android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._createPendingResult1507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.PendingIntent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._createPendingResult1507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _setRequestedOrientation1508;
		public virtual void setRequestedOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setRequestedOrientation1508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setRequestedOrientation1508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RequestedOrientation
		{
			get
			{
				return getRequestedOrientation();
			}
			set
			{
				setRequestedOrientation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestedOrientation1509;
		public virtual int getRequestedOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getRequestedOrientation1509);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getRequestedOrientation1509);
		}
		public new int TaskId
		{
			get
			{
				return getTaskId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTaskId1510;
		public virtual int getTaskId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getTaskId1510);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTaskId1510);
		}
		internal static global::MonoJavaBridge.MethodId _isTaskRoot1511;
		public virtual bool isTaskRoot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isTaskRoot1511);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isTaskRoot1511);
		}
		internal static global::MonoJavaBridge.MethodId _moveTaskToBack1512;
		public virtual bool moveTaskToBack(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._moveTaskToBack1512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._moveTaskToBack1512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String LocalClassName
		{
			get
			{
				return getLocalClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalClassName1513;
		public virtual global::java.lang.String getLocalClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLocalClassName1513)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLocalClassName1513)) as java.lang.String;
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentName1514;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getComponentName1514)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getComponentName1514)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences1515;
		public virtual global::android.content.SharedPreferences getPreferences(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getPreferences1515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getPreferences1515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1516;
		public virtual void setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitle1516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle1516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1517;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitle1517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle1517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor1518;
		public virtual void setTitleColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitleColor1518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitleColor1518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string Title
		{
			get
			{
				return getTitle().toString();
			}
			set
			{
				setTitle((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle1519;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getTitle1519)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTitle1519)) as java.lang.CharSequence;
		}
		public new int TitleColor
		{
			get
			{
				return getTitleColor();
			}
			set
			{
				setTitleColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitleColor1520;
		public virtual int getTitleColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getTitleColor1520);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTitleColor1520);
		}
		internal static global::MonoJavaBridge.MethodId _onTitleChanged1521;
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onTitleChanged1521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTitleChanged1521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onChildTitleChanged1522;
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onChildTitleChanged1522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onChildTitleChanged1522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarVisibility1523;
		public virtual void setProgressBarVisibility(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarVisibility1523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarVisibility1523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarIndeterminateVisibility1524;
		public virtual void setProgressBarIndeterminateVisibility(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarIndeterminateVisibility1524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminateVisibility1524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarIndeterminate1525;
		public virtual void setProgressBarIndeterminate(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarIndeterminate1525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminate1525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgress1526;
		public virtual void setProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgress1526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgress1526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress1527;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setSecondaryProgress1527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setSecondaryProgress1527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream1528;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setVolumeControlStream1528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setVolumeControlStream1528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VolumeControlStream
		{
			get
			{
				return getVolumeControlStream();
			}
			set
			{
				setVolumeControlStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream1529;
		public virtual int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getVolumeControlStream1529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getVolumeControlStream1529);
		}
		internal static global::MonoJavaBridge.MethodId _runOnUiThread1530;
		public virtual void runOnUiThread(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._runOnUiThread1530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._runOnUiThread1530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView1531;
		public virtual global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateView1531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateView1531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _Activity1532;
		public Activity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Activity.staticClass, global::android.app.Activity._Activity1532);
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
			global::android.app.Activity._getParent1388 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;");
			global::android.app.Activity._getApplication1389 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Activity._onCreate1390 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onStart1391 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onStart", "()V");
			global::android.app.Activity._onDestroy1392 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onDestroy", "()V");
			global::android.app.Activity._onConfigurationChanged1393 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Activity._onLowMemory1394 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onLowMemory", "()V");
			global::android.app.Activity._getWallpaperDesiredMinimumWidth1395 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.app.Activity._getWallpaperDesiredMinimumHeight1396 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.app.Activity._startActivity1397 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.app.Activity._startIntentSender1398 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.app.Activity._getSystemService1399 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.app.Activity._getIntent1400 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.app.Activity._getChangingConfigurations1401 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getChangingConfigurations", "()I");
			global::android.app.Activity._setVisible1402 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setVisible", "(Z)V");
			global::android.app.Activity._setResult1403 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setResult", "(I)V");
			global::android.app.Activity._setResult1404 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V");
			global::android.app.Activity._finish1405 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finish", "()V");
			global::android.app.Activity._getInstanceCount1406 = @__env.GetStaticMethodIDNoThrow(global::android.app.Activity.staticClass, "getInstanceCount", "()J");
			global::android.app.Activity._setIntent1407 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._isChild1408 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isChild", "()Z");
			global::android.app.Activity._getWindowManager1409 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.app.Activity._getWindow1410 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Activity._getCurrentFocus1411 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Activity._onRestoreInstanceState1412 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPostCreate1413 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onRestart1414 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRestart", "()V");
			global::android.app.Activity._onResume1415 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onResume", "()V");
			global::android.app.Activity._onPostResume1416 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPostResume", "()V");
			global::android.app.Activity._onNewIntent1417 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._onSaveInstanceState1418 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPause1419 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPause", "()V");
			global::android.app.Activity._onUserLeaveHint1420 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onUserLeaveHint", "()V");
			global::android.app.Activity._onCreateThumbnail1421 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z");
			global::android.app.Activity._onCreateDescription1422 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._onStop1423 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onStop", "()V");
			global::android.app.Activity._getLastNonConfigurationInstance1424 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._onRetainNonConfigurationInstance1425 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._managedQuery1426 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.app.Activity._startManagingCursor1427 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._stopManagingCursor1428 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._setPersistent1429 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setPersistent", "(Z)V");
			global::android.app.Activity._findViewById1430 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Activity._setContentView1431 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(I)V");
			global::android.app.Activity._setContentView1432 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Activity._setContentView1433 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._addContentView1434 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._setDefaultKeyMode1435 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V");
			global::android.app.Activity._onKeyDown1436 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyLongPress1437 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyUp1438 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyMultiple1439 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onBackPressed1440 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onBackPressed", "()V");
			global::android.app.Activity._onTouchEvent1441 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onTrackballEvent1442 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onUserInteraction1443 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onUserInteraction", "()V");
			global::android.app.Activity._onWindowAttributesChanged1444 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Activity._onContentChanged1445 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContentChanged", "()V");
			global::android.app.Activity._onWindowFocusChanged1446 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Activity._onAttachedToWindow1447 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Activity._onDetachedFromWindow1448 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Activity._hasWindowFocus1449 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "hasWindowFocus", "()Z");
			global::android.app.Activity._dispatchKeyEvent1450 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Activity._dispatchTouchEvent1451 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchTrackballEvent1452 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchPopulateAccessibilityEvent1453 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Activity._onCreatePanelView1454 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Activity._onCreatePanelMenu1455 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onPreparePanel1456 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Activity._onMenuOpened1457 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onMenuItemSelected1458 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Activity._onPanelClosed1459 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Activity._onCreateOptionsMenu1460 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onPrepareOptionsMenu1461 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onOptionsItemSelected1462 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onOptionsMenuClosed1463 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._openOptionsMenu1464 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "openOptionsMenu", "()V");
			global::android.app.Activity._closeOptionsMenu1465 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Activity._onCreateContextMenu1466 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Activity._registerForContextMenu1467 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._unregisterForContextMenu1468 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._openContextMenu1469 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._closeContextMenu1470 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "closeContextMenu", "()V");
			global::android.app.Activity._onContextItemSelected1471 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onContextMenuClosed1472 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._onCreateDialog1473 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;");
			global::android.app.Activity._onCreateDialog1474 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;");
			global::android.app.Activity._onPrepareDialog1475 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V");
			global::android.app.Activity._onPrepareDialog1476 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V");
			global::android.app.Activity._showDialog1477 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "showDialog", "(ILandroid/os/Bundle;)Z");
			global::android.app.Activity._showDialog1478 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "showDialog", "(I)V");
			global::android.app.Activity._dismissDialog1479 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dismissDialog", "(I)V");
			global::android.app.Activity._removeDialog1480 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "removeDialog", "(I)V");
			global::android.app.Activity._onSearchRequested1481 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onSearchRequested", "()Z");
			global::android.app.Activity._startSearch1482 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V");
			global::android.app.Activity._triggerSearch1483 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.app.Activity._takeKeyEvents1484 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Activity._requestWindowFeature1485 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Activity._setFeatureDrawableResource1486 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Activity._setFeatureDrawableUri1487 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Activity._setFeatureDrawable1488 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Activity._setFeatureDrawableAlpha1489 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Activity._getLayoutInflater1490 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Activity._getMenuInflater1491 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;");
			global::android.app.Activity._onApplyThemeResource1492 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			global::android.app.Activity._startActivityForResult1493 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderForResult1494 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._startActivityIfNeeded1495 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z");
			global::android.app.Activity._startNextMatchingActivity1496 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z");
			global::android.app.Activity._startActivityFromChild1497 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderFromChild1498 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._overridePendingTransition1499 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V");
			global::android.app.Activity._getCallingPackage1500 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;");
			global::android.app.Activity._getCallingActivity1501 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;");
			global::android.app.Activity._isFinishing1502 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isFinishing", "()Z");
			global::android.app.Activity._finishFromChild1503 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V");
			global::android.app.Activity._finishActivity1504 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishActivity", "(I)V");
			global::android.app.Activity._finishActivityFromChild1505 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V");
			global::android.app.Activity._onActivityResult1506 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V");
			global::android.app.Activity._createPendingResult1507 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.Activity._setRequestedOrientation1508 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V");
			global::android.app.Activity._getRequestedOrientation1509 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getRequestedOrientation", "()I");
			global::android.app.Activity._getTaskId1510 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTaskId", "()I");
			global::android.app.Activity._isTaskRoot1511 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isTaskRoot", "()Z");
			global::android.app.Activity._moveTaskToBack1512 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z");
			global::android.app.Activity._getLocalClassName1513 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;");
			global::android.app.Activity._getComponentName1514 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Activity._getPreferences1515 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;");
			global::android.app.Activity._setTitle1516 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitle", "(I)V");
			global::android.app.Activity._setTitle1517 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setTitleColor1518 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitleColor", "(I)V");
			global::android.app.Activity._getTitle1519 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._getTitleColor1520 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTitleColor", "()I");
			global::android.app.Activity._onTitleChanged1521 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V");
			global::android.app.Activity._onChildTitleChanged1522 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setProgressBarVisibility1523 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminateVisibility1524 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminate1525 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V");
			global::android.app.Activity._setProgress1526 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgress", "(I)V");
			global::android.app.Activity._setSecondaryProgress1527 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.Activity._setVolumeControlStream1528 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Activity._getVolumeControlStream1529 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Activity._runOnUiThread1530 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.app.Activity._onCreateView1531 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.app.Activity._Activity1532 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "<init>", "()V");
		}
	}
}
