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
		internal static global::MonoJavaBridge.MethodId _getParent1390;
		public virtual global::android.app.Activity getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getParent1390)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getParent1390)) as android.app.Activity;
		}
		public new global::android.app.Application Application
		{
			get
			{
				return getApplication();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplication1391;
		public virtual global::android.app.Application getApplication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getApplication1391)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getApplication1391)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1392;
		protected virtual void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onCreate1392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreate1392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart1393;
		protected virtual void onStart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onStart1393);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onStart1393);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1394;
		protected virtual void onDestroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onDestroy1394);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onDestroy1394);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged1395;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onConfigurationChanged1395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onConfigurationChanged1395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory1396;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onLowMemory1396);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onLowMemory1396);
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth1397;
		public override int getWallpaperDesiredMinimumWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getWallpaperDesiredMinimumWidth1397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumWidth1397);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight1398;
		public override int getWallpaperDesiredMinimumHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getWallpaperDesiredMinimumHeight1398);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWallpaperDesiredMinimumHeight1398);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity1399;
		public override void startActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivity1399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivity1399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender1400;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSender1400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSender1400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService1401;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getSystemService1401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getSystemService1401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
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
		internal static global::MonoJavaBridge.MethodId _getIntent1402;
		public virtual global::android.content.Intent getIntent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getIntent1402)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getIntent1402)) as android.content.Intent;
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations1403;
		public virtual int getChangingConfigurations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getChangingConfigurations1403);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getChangingConfigurations1403);
		}
		public new bool Visible
		{
			set
			{
				setVisible(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVisible1404;
		public virtual void setVisible(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setVisible1404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setVisible1404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Result
		{
			set
			{
				setResult(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setResult1405;
		public virtual void setResult(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setResult1405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setResult1405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResult1406;
		public virtual void setResult(int arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setResult1406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setResult1406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _finish1407;
		public virtual void finish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finish1407);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finish1407);
		}
		public static long InstanceCount
		{
			get
			{
				return getInstanceCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstanceCount1408;
		public static long getInstanceCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, global::android.app.Activity._getInstanceCount1408);
		}
		internal static global::MonoJavaBridge.MethodId _setIntent1409;
		public virtual void setIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setIntent1409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setIntent1409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChild1410;
		public virtual bool isChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isChild1410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isChild1410);
		}
		public new global::android.view.WindowManager WindowManager
		{
			get
			{
				return getWindowManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager1411;
		public virtual global::android.view.WindowManager getWindowManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getWindowManager1411)) as android.view.WindowManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWindowManager1411)) as android.view.WindowManager;
		}
		public new global::android.view.Window Window
		{
			get
			{
				return getWindow();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindow1412;
		public virtual global::android.view.Window getWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getWindow1412)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getWindow1412)) as android.view.Window;
		}
		public new global::android.view.View CurrentFocus
		{
			get
			{
				return getCurrentFocus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus1413;
		public virtual global::android.view.View getCurrentFocus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCurrentFocus1413)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCurrentFocus1413)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1414;
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onRestoreInstanceState1414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRestoreInstanceState1414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPostCreate1415;
		protected virtual void onPostCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPostCreate1415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPostCreate1415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestart1416;
		protected virtual void onRestart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onRestart1416);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRestart1416);
		}
		internal static global::MonoJavaBridge.MethodId _onResume1417;
		protected virtual void onResume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onResume1417);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onResume1417);
		}
		internal static global::MonoJavaBridge.MethodId _onPostResume1418;
		protected virtual void onPostResume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPostResume1418);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPostResume1418);
		}
		internal static global::MonoJavaBridge.MethodId _onNewIntent1419;
		protected virtual void onNewIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onNewIntent1419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onNewIntent1419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1420;
		protected virtual void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onSaveInstanceState1420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onSaveInstanceState1420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPause1421;
		protected virtual void onPause()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPause1421);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPause1421);
		}
		internal static global::MonoJavaBridge.MethodId _onUserLeaveHint1422;
		protected virtual void onUserLeaveHint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onUserLeaveHint1422);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onUserLeaveHint1422);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateThumbnail1423;
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreateThumbnail1423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateThumbnail1423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDescription1424;
		public virtual global::java.lang.CharSequence onCreateDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDescription1424)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDescription1424)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onStop1425;
		protected virtual void onStop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onStop1425);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onStop1425);
		}
		public new global::java.lang.Object LastNonConfigurationInstance
		{
			get
			{
				return getLastNonConfigurationInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLastNonConfigurationInstance1426;
		public virtual global::java.lang.Object getLastNonConfigurationInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLastNonConfigurationInstance1426)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLastNonConfigurationInstance1426)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onRetainNonConfigurationInstance1427;
		public virtual global::java.lang.Object onRetainNonConfigurationInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onRetainNonConfigurationInstance1427)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onRetainNonConfigurationInstance1427)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _managedQuery1428;
		public virtual global::android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._managedQuery1428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._managedQuery1428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _startManagingCursor1429;
		public virtual void startManagingCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startManagingCursor1429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startManagingCursor1429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopManagingCursor1430;
		public virtual void stopManagingCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._stopManagingCursor1430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._stopManagingCursor1430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Persistent
		{
			set
			{
				setPersistent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPersistent1431;
		public virtual void setPersistent(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setPersistent1431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setPersistent1431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findViewById1432;
		public virtual global::android.view.View findViewById(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._findViewById1432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._findViewById1432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1433;
		public virtual void setContentView(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView1433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView1433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1434;
		public virtual void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView1434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView1434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1435;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setContentView1435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setContentView1435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView1436;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._addContentView1436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._addContentView1436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int DefaultKeyMode
		{
			set
			{
				setDefaultKeyMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultKeyMode1437;
		public virtual void setDefaultKeyMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setDefaultKeyMode1437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setDefaultKeyMode1437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown1438;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyDown1438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyDown1438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress1439;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyLongPress1439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyLongPress1439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp1440;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyUp1440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyUp1440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple1441;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onKeyMultiple1441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onKeyMultiple1441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onBackPressed1442;
		public virtual void onBackPressed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onBackPressed1442);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onBackPressed1442);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent1443;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onTouchEvent1443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTouchEvent1443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent1444;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onTrackballEvent1444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTrackballEvent1444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUserInteraction1445;
		public virtual void onUserInteraction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onUserInteraction1445);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onUserInteraction1445);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged1446;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onWindowAttributesChanged1446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowAttributesChanged1446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1447;
		public virtual void onContentChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onContentChanged1447);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContentChanged1447);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged1448;
		public virtual void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onWindowFocusChanged1448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onWindowFocusChanged1448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow1449;
		public virtual void onAttachedToWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onAttachedToWindow1449);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onAttachedToWindow1449);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow1450;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onDetachedFromWindow1450);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onDetachedFromWindow1450);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus1451;
		public virtual bool hasWindowFocus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._hasWindowFocus1451);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._hasWindowFocus1451);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent1452;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchKeyEvent1452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchKeyEvent1452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent1453;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchTouchEvent1453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTouchEvent1453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent1454;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchTrackballEvent1454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchTrackballEvent1454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent1455;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._dispatchPopulateAccessibilityEvent1455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dispatchPopulateAccessibilityEvent1455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelView1456;
		public virtual global::android.view.View onCreatePanelView(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreatePanelView1456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelView1456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu1457;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreatePanelMenu1457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreatePanelMenu1457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPreparePanel1458;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onPreparePanel1458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPreparePanel1458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuOpened1459;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onMenuOpened1459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuOpened1459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemSelected1460;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onMenuItemSelected1460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onMenuItemSelected1460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPanelClosed1461;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPanelClosed1461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPanelClosed1461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateOptionsMenu1462;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onCreateOptionsMenu1462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateOptionsMenu1462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareOptionsMenu1463;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onPrepareOptionsMenu1463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareOptionsMenu1463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsItemSelected1464;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onOptionsItemSelected1464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsItemSelected1464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsMenuClosed1465;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onOptionsMenuClosed1465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onOptionsMenuClosed1465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOptionsMenu1466;
		public virtual void openOptionsMenu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._openOptionsMenu1466);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._openOptionsMenu1466);
		}
		internal static global::MonoJavaBridge.MethodId _closeOptionsMenu1467;
		public virtual void closeOptionsMenu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._closeOptionsMenu1467);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._closeOptionsMenu1467);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu1468;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onCreateContextMenu1468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateContextMenu1468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerForContextMenu1469;
		public virtual void registerForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._registerForContextMenu1469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._registerForContextMenu1469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterForContextMenu1470;
		public virtual void unregisterForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._unregisterForContextMenu1470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._unregisterForContextMenu1470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openContextMenu1471;
		public virtual void openContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._openContextMenu1471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._openContextMenu1471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeContextMenu1472;
		public virtual void closeContextMenu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._closeContextMenu1472);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._closeContextMenu1472);
		}
		internal static global::MonoJavaBridge.MethodId _onContextItemSelected1473;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onContextItemSelected1473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContextItemSelected1473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextMenuClosed1474;
		public virtual void onContextMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onContextMenuClosed1474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onContextMenuClosed1474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialog1475;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDialog1475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog1475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDialog1476;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateDialog1476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateDialog1476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Dialog;
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialog1477;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPrepareDialog1477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog1477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareDialog1478;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onPrepareDialog1478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onPrepareDialog1478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _showDialog1479;
		public virtual bool showDialog(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._showDialog1479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog1479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showDialog1480;
		public virtual void showDialog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._showDialog1480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._showDialog1480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dismissDialog1481;
		public virtual void dismissDialog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._dismissDialog1481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._dismissDialog1481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeDialog1482;
		public virtual void removeDialog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._removeDialog1482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._removeDialog1482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSearchRequested1483;
		public virtual bool onSearchRequested()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._onSearchRequested1483);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onSearchRequested1483);
		}
		internal static global::MonoJavaBridge.MethodId _startSearch1484;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startSearch1484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startSearch1484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _triggerSearch1485;
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._triggerSearch1485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._triggerSearch1485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents1486;
		public virtual void takeKeyEvents(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._takeKeyEvents1486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._takeKeyEvents1486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestWindowFeature1487;
		public virtual bool requestWindowFeature(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._requestWindowFeature1487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._requestWindowFeature1487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource1488;
		public virtual void setFeatureDrawableResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableResource1488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableResource1488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri1489;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableUri1489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableUri1489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable1490;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawable1490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawable1490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha1491;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setFeatureDrawableAlpha1491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setFeatureDrawableAlpha1491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater1492;
		public virtual global::android.view.LayoutInflater getLayoutInflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLayoutInflater1492)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLayoutInflater1492)) as android.view.LayoutInflater;
		}
		public new global::android.view.MenuInflater MenuInflater
		{
			get
			{
				return getMenuInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMenuInflater1493;
		public virtual global::android.view.MenuInflater getMenuInflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getMenuInflater1493)) as android.view.MenuInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getMenuInflater1493)) as android.view.MenuInflater;
		}
		internal static global::MonoJavaBridge.MethodId _onApplyThemeResource1494;
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onApplyThemeResource1494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onApplyThemeResource1494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityForResult1495;
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivityForResult1495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityForResult1495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSenderForResult1496;
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSenderForResult1496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderForResult1496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityIfNeeded1497;
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._startActivityIfNeeded1497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityIfNeeded1497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startNextMatchingActivity1498;
		public virtual bool startNextMatchingActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._startNextMatchingActivity1498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startNextMatchingActivity1498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startActivityFromChild1499;
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startActivityFromChild1499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startActivityFromChild1499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSenderFromChild1500;
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._startIntentSenderFromChild1500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._startIntentSenderFromChild1500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _overridePendingTransition1501;
		public virtual void overridePendingTransition(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._overridePendingTransition1501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._overridePendingTransition1501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String CallingPackage
		{
			get
			{
				return getCallingPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingPackage1502;
		public virtual global::java.lang.String getCallingPackage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCallingPackage1502)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingPackage1502)) as java.lang.String;
		}
		public new global::android.content.ComponentName CallingActivity
		{
			get
			{
				return getCallingActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingActivity1503;
		public virtual global::android.content.ComponentName getCallingActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getCallingActivity1503)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getCallingActivity1503)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _isFinishing1504;
		public virtual bool isFinishing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isFinishing1504);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isFinishing1504);
		}
		internal static global::MonoJavaBridge.MethodId _finishFromChild1505;
		public virtual void finishFromChild(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishFromChild1505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishFromChild1505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finishActivity1506;
		public virtual void finishActivity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishActivity1506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivity1506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finishActivityFromChild1507;
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._finishActivityFromChild1507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._finishActivityFromChild1507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult1508;
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onActivityResult1508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onActivityResult1508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPendingResult1509;
		public virtual global::android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._createPendingResult1509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.PendingIntent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._createPendingResult1509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.PendingIntent;
		}
		internal static global::MonoJavaBridge.MethodId _setRequestedOrientation1510;
		public virtual void setRequestedOrientation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setRequestedOrientation1510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setRequestedOrientation1510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRequestedOrientation1511;
		public virtual int getRequestedOrientation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getRequestedOrientation1511);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getRequestedOrientation1511);
		}
		public new int TaskId
		{
			get
			{
				return getTaskId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTaskId1512;
		public virtual int getTaskId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getTaskId1512);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTaskId1512);
		}
		internal static global::MonoJavaBridge.MethodId _isTaskRoot1513;
		public virtual bool isTaskRoot()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._isTaskRoot1513);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._isTaskRoot1513);
		}
		internal static global::MonoJavaBridge.MethodId _moveTaskToBack1514;
		public virtual bool moveTaskToBack(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Activity._moveTaskToBack1514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._moveTaskToBack1514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String LocalClassName
		{
			get
			{
				return getLocalClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalClassName1515;
		public virtual global::java.lang.String getLocalClassName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getLocalClassName1515)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getLocalClassName1515)) as java.lang.String;
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentName1516;
		public virtual global::android.content.ComponentName getComponentName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getComponentName1516)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getComponentName1516)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences1517;
		public virtual global::android.content.SharedPreferences getPreferences(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getPreferences1517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getPreferences1517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1518;
		public virtual void setTitle(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitle1518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle1518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1519;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitle1519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitle1519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor1520;
		public virtual void setTitleColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setTitleColor1520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setTitleColor1520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTitle1521;
		public virtual global::java.lang.CharSequence getTitle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._getTitle1521)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTitle1521)) as java.lang.CharSequence;
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
		internal static global::MonoJavaBridge.MethodId _getTitleColor1522;
		public virtual int getTitleColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getTitleColor1522);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getTitleColor1522);
		}
		internal static global::MonoJavaBridge.MethodId _onTitleChanged1523;
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onTitleChanged1523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onTitleChanged1523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void onTitleChanged(string arg0, int arg1)
		{
			onTitleChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _onChildTitleChanged1524;
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._onChildTitleChanged1524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onChildTitleChanged1524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void onChildTitleChanged(android.app.Activity arg0, string arg1)
		{
			onChildTitleChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		public new bool ProgressBarVisibility
		{
			set
			{
				setProgressBarVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarVisibility1525;
		public virtual void setProgressBarVisibility(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarVisibility1525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarVisibility1525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ProgressBarIndeterminateVisibility
		{
			set
			{
				setProgressBarIndeterminateVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarIndeterminateVisibility1526;
		public virtual void setProgressBarIndeterminateVisibility(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarIndeterminateVisibility1526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminateVisibility1526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ProgressBarIndeterminate
		{
			set
			{
				setProgressBarIndeterminate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBarIndeterminate1527;
		public virtual void setProgressBarIndeterminate(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgressBarIndeterminate1527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgressBarIndeterminate1527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Progress
		{
			set
			{
				setProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProgress1528;
		public virtual void setProgress(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setProgress1528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setProgress1528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SecondaryProgress
		{
			set
			{
				setSecondaryProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress1529;
		public virtual void setSecondaryProgress(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setSecondaryProgress1529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setSecondaryProgress1529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream1530;
		public virtual void setVolumeControlStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._setVolumeControlStream1530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._setVolumeControlStream1530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream1531;
		public virtual int getVolumeControlStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Activity._getVolumeControlStream1531);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._getVolumeControlStream1531);
		}
		internal static global::MonoJavaBridge.MethodId _runOnUiThread1532;
		public virtual void runOnUiThread(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Activity._runOnUiThread1532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._runOnUiThread1532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void runOnUiThread(global::java.lang.RunnableDelegate arg0)
		{
			runOnUiThread((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView1533;
		public virtual global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Activity._onCreateView1533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Activity.staticClass, global::android.app.Activity._onCreateView1533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _Activity1534;
		public Activity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Activity.staticClass, global::android.app.Activity._Activity1534);
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
			global::android.app.Activity._getParent1390 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;");
			global::android.app.Activity._getApplication1391 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Activity._onCreate1392 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onStart1393 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onStart", "()V");
			global::android.app.Activity._onDestroy1394 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onDestroy", "()V");
			global::android.app.Activity._onConfigurationChanged1395 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Activity._onLowMemory1396 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onLowMemory", "()V");
			global::android.app.Activity._getWallpaperDesiredMinimumWidth1397 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.app.Activity._getWallpaperDesiredMinimumHeight1398 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.app.Activity._startActivity1399 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.app.Activity._startIntentSender1400 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.app.Activity._getSystemService1401 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.app.Activity._getIntent1402 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;");
			global::android.app.Activity._getChangingConfigurations1403 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getChangingConfigurations", "()I");
			global::android.app.Activity._setVisible1404 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setVisible", "(Z)V");
			global::android.app.Activity._setResult1405 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setResult", "(I)V");
			global::android.app.Activity._setResult1406 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V");
			global::android.app.Activity._finish1407 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finish", "()V");
			global::android.app.Activity._getInstanceCount1408 = @__env.GetStaticMethodIDNoThrow(global::android.app.Activity.staticClass, "getInstanceCount", "()J");
			global::android.app.Activity._setIntent1409 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._isChild1410 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isChild", "()Z");
			global::android.app.Activity._getWindowManager1411 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.app.Activity._getWindow1412 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Activity._getCurrentFocus1413 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Activity._onRestoreInstanceState1414 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPostCreate1415 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onRestart1416 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRestart", "()V");
			global::android.app.Activity._onResume1417 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onResume", "()V");
			global::android.app.Activity._onPostResume1418 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPostResume", "()V");
			global::android.app.Activity._onNewIntent1419 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V");
			global::android.app.Activity._onSaveInstanceState1420 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Activity._onPause1421 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPause", "()V");
			global::android.app.Activity._onUserLeaveHint1422 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onUserLeaveHint", "()V");
			global::android.app.Activity._onCreateThumbnail1423 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z");
			global::android.app.Activity._onCreateDescription1424 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._onStop1425 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onStop", "()V");
			global::android.app.Activity._getLastNonConfigurationInstance1426 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._onRetainNonConfigurationInstance1427 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;");
			global::android.app.Activity._managedQuery1428 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.app.Activity._startManagingCursor1429 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._stopManagingCursor1430 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V");
			global::android.app.Activity._setPersistent1431 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setPersistent", "(Z)V");
			global::android.app.Activity._findViewById1432 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Activity._setContentView1433 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(I)V");
			global::android.app.Activity._setContentView1434 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Activity._setContentView1435 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._addContentView1436 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Activity._setDefaultKeyMode1437 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V");
			global::android.app.Activity._onKeyDown1438 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyLongPress1439 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyUp1440 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onKeyMultiple1441 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Activity._onBackPressed1442 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onBackPressed", "()V");
			global::android.app.Activity._onTouchEvent1443 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onTrackballEvent1444 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._onUserInteraction1445 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onUserInteraction", "()V");
			global::android.app.Activity._onWindowAttributesChanged1446 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Activity._onContentChanged1447 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContentChanged", "()V");
			global::android.app.Activity._onWindowFocusChanged1448 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Activity._onAttachedToWindow1449 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Activity._onDetachedFromWindow1450 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Activity._hasWindowFocus1451 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "hasWindowFocus", "()Z");
			global::android.app.Activity._dispatchKeyEvent1452 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Activity._dispatchTouchEvent1453 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchTrackballEvent1454 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Activity._dispatchPopulateAccessibilityEvent1455 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Activity._onCreatePanelView1456 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Activity._onCreatePanelMenu1457 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onPreparePanel1458 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Activity._onMenuOpened1459 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Activity._onMenuItemSelected1460 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Activity._onPanelClosed1461 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Activity._onCreateOptionsMenu1462 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onPrepareOptionsMenu1463 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Activity._onOptionsItemSelected1464 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onOptionsMenuClosed1465 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._openOptionsMenu1466 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "openOptionsMenu", "()V");
			global::android.app.Activity._closeOptionsMenu1467 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Activity._onCreateContextMenu1468 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Activity._registerForContextMenu1469 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._unregisterForContextMenu1470 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._openContextMenu1471 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Activity._closeContextMenu1472 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "closeContextMenu", "()V");
			global::android.app.Activity._onContextItemSelected1473 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Activity._onContextMenuClosed1474 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Activity._onCreateDialog1475 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;");
			global::android.app.Activity._onCreateDialog1476 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;");
			global::android.app.Activity._onPrepareDialog1477 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V");
			global::android.app.Activity._onPrepareDialog1478 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V");
			global::android.app.Activity._showDialog1479 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "showDialog", "(ILandroid/os/Bundle;)Z");
			global::android.app.Activity._showDialog1480 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "showDialog", "(I)V");
			global::android.app.Activity._dismissDialog1481 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "dismissDialog", "(I)V");
			global::android.app.Activity._removeDialog1482 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "removeDialog", "(I)V");
			global::android.app.Activity._onSearchRequested1483 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onSearchRequested", "()Z");
			global::android.app.Activity._startSearch1484 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V");
			global::android.app.Activity._triggerSearch1485 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.app.Activity._takeKeyEvents1486 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Activity._requestWindowFeature1487 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Activity._setFeatureDrawableResource1488 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Activity._setFeatureDrawableUri1489 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Activity._setFeatureDrawable1490 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Activity._setFeatureDrawableAlpha1491 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Activity._getLayoutInflater1492 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Activity._getMenuInflater1493 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;");
			global::android.app.Activity._onApplyThemeResource1494 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			global::android.app.Activity._startActivityForResult1495 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderForResult1496 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._startActivityIfNeeded1497 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z");
			global::android.app.Activity._startNextMatchingActivity1498 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z");
			global::android.app.Activity._startActivityFromChild1499 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V");
			global::android.app.Activity._startIntentSenderFromChild1500 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V");
			global::android.app.Activity._overridePendingTransition1501 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V");
			global::android.app.Activity._getCallingPackage1502 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;");
			global::android.app.Activity._getCallingActivity1503 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;");
			global::android.app.Activity._isFinishing1504 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isFinishing", "()Z");
			global::android.app.Activity._finishFromChild1505 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V");
			global::android.app.Activity._finishActivity1506 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishActivity", "(I)V");
			global::android.app.Activity._finishActivityFromChild1507 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V");
			global::android.app.Activity._onActivityResult1508 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V");
			global::android.app.Activity._createPendingResult1509 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.Activity._setRequestedOrientation1510 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V");
			global::android.app.Activity._getRequestedOrientation1511 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getRequestedOrientation", "()I");
			global::android.app.Activity._getTaskId1512 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTaskId", "()I");
			global::android.app.Activity._isTaskRoot1513 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "isTaskRoot", "()Z");
			global::android.app.Activity._moveTaskToBack1514 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z");
			global::android.app.Activity._getLocalClassName1515 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;");
			global::android.app.Activity._getComponentName1516 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Activity._getPreferences1517 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;");
			global::android.app.Activity._setTitle1518 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitle", "(I)V");
			global::android.app.Activity._setTitle1519 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setTitleColor1520 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setTitleColor", "(I)V");
			global::android.app.Activity._getTitle1521 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.app.Activity._getTitleColor1522 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getTitleColor", "()I");
			global::android.app.Activity._onTitleChanged1523 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V");
			global::android.app.Activity._onChildTitleChanged1524 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.Activity._setProgressBarVisibility1525 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminateVisibility1526 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V");
			global::android.app.Activity._setProgressBarIndeterminate1527 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V");
			global::android.app.Activity._setProgress1528 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setProgress", "(I)V");
			global::android.app.Activity._setSecondaryProgress1529 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.Activity._setVolumeControlStream1530 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Activity._getVolumeControlStream1531 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Activity._runOnUiThread1532 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V");
			global::android.app.Activity._onCreateView1533 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.app.Activity._Activity1534 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "<init>", "()V");
		}
	}
}
