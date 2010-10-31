namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Activity : android.view.ContextThemeWrapper, android.view.LayoutInflater.Factory, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.app.Activity getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;", ref global::android.app.Activity._m0) as android.app.Activity;
		}
		public new global::android.app.Application Application
		{
			get
			{
				return getApplication();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.app.Application getApplication()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;", ref global::android.app.Activity._m1) as android.app.Application;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.Activity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onStart", "()V", ref global::android.app.Activity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onDestroy", "()V", ref global::android.app.Activity._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.app.Activity._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onLowMemory", "()V", ref global::android.app.Activity._m6);
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getWallpaperDesiredMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I", ref global::android.app.Activity._m7);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getWallpaperDesiredMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I", ref global::android.app.Activity._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void startActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V", ref global::android.app.Activity._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", ref global::android.app.Activity._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.app.Activity._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.content.Intent getIntent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;", ref global::android.app.Activity._m12) as android.content.Intent;
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getChangingConfigurations", "()I", ref global::android.app.Activity._m13);
		}
		public new bool Visible
		{
			set
			{
				setVisible(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setVisible", "(Z)V", ref global::android.app.Activity._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Result
		{
			set
			{
				setResult(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setResult(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setResult", "(I)V", ref global::android.app.Activity._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setResult(int arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V", ref global::android.app.Activity._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void finish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "finish", "()V", ref global::android.app.Activity._m17);
		}
		public static long InstanceCount
		{
			get
			{
				return getInstanceCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static long getInstanceCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Activity._m18.native == global::System.IntPtr.Zero)
				global::android.app.Activity._m18 = @__env.GetStaticMethodIDNoThrow(global::android.app.Activity.staticClass, "getInstanceCount", "()J");
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, global::android.app.Activity._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V", ref global::android.app.Activity._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "isChild", "()Z", ref global::android.app.Activity._m20);
		}
		public new global::android.view.WindowManager WindowManager
		{
			get
			{
				return getWindowManager();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::android.view.WindowManager getWindowManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.WindowManager>(this, global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;", ref global::android.app.Activity._m21) as android.view.WindowManager;
		}
		public new global::android.view.Window Window
		{
			get
			{
				return getWindow();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.view.Window getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;", ref global::android.app.Activity._m22) as android.view.Window;
		}
		public new global::android.view.View CurrentFocus
		{
			get
			{
				return getCurrentFocus();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::android.view.View getCurrentFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;", ref global::android.app.Activity._m23) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.Activity._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected virtual void onPostCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V", ref global::android.app.Activity._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual void onRestart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onRestart", "()V", ref global::android.app.Activity._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected virtual void onResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onResume", "()V", ref global::android.app.Activity._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected virtual void onPostResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onPostResume", "()V", ref global::android.app.Activity._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected virtual void onNewIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V", ref global::android.app.Activity._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.Activity._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		protected virtual void onPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onPause", "()V", ref global::android.app.Activity._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected virtual void onUserLeaveHint()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onUserLeaveHint", "()V", ref global::android.app.Activity._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z", ref global::android.app.Activity._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.lang.CharSequence onCreateDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;", ref global::android.app.Activity._m34) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		protected virtual void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onStop", "()V", ref global::android.app.Activity._m35);
		}
		public new global::java.lang.Object LastNonConfigurationInstance
		{
			get
			{
				return getLastNonConfigurationInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.lang.Object getLastNonConfigurationInstance()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;", ref global::android.app.Activity._m36) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.lang.Object onRetainNonConfigurationInstance()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;", ref global::android.app.Activity._m37) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.app.Activity._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void startManagingCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V", ref global::android.app.Activity._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void stopManagingCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V", ref global::android.app.Activity._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Persistent
		{
			set
			{
				setPersistent(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setPersistent(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setPersistent", "(Z)V", ref global::android.app.Activity._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::android.view.View findViewById(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;", ref global::android.app.Activity._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void setContentView(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setContentView", "(I)V", ref global::android.app.Activity._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V", ref global::android.app.Activity._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.app.Activity._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.app.Activity._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int DefaultKeyMode
		{
			set
			{
				setDefaultKeyMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void setDefaultKeyMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V", ref global::android.app.Activity._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Activity._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Activity._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Activity._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.app.Activity._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual void onBackPressed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onBackPressed", "()V", ref global::android.app.Activity._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Activity._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Activity._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual void onUserInteraction()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onUserInteraction", "()V", ref global::android.app.Activity._m55);
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", ref global::android.app.Activity._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onContentChanged", "()V", ref global::android.app.Activity._m57);
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.app.Activity._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onAttachedToWindow", "()V", ref global::android.app.Activity._m59);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V", ref global::android.app.Activity._m60);
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual bool hasWindowFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "hasWindowFocus", "()Z", ref global::android.app.Activity._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.app.Activity._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Activity._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Activity._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.app.Activity._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual global::android.view.View onCreatePanelView(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;", ref global::android.app.Activity._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z", ref global::android.app.Activity._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", ref global::android.app.Activity._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z", ref global::android.app.Activity._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", ref global::android.app.Activity._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V", ref global::android.app.Activity._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z", ref global::android.app.Activity._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", ref global::android.app.Activity._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", ref global::android.app.Activity._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V", ref global::android.app.Activity._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual void openOptionsMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "openOptionsMenu", "()V", ref global::android.app.Activity._m76);
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void closeOptionsMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "closeOptionsMenu", "()V", ref global::android.app.Activity._m77);
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", ref global::android.app.Activity._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual void registerForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V", ref global::android.app.Activity._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual void unregisterForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V", ref global::android.app.Activity._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void openContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V", ref global::android.app.Activity._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual void closeContextMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "closeContextMenu", "()V", ref global::android.app.Activity._m82);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z", ref global::android.app.Activity._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual void onContextMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V", ref global::android.app.Activity._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;", ref global::android.app.Activity._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Dialog;
		}
		private static global::MonoJavaBridge.MethodId _m86;
		protected virtual global::android.app.Dialog onCreateDialog(int arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;", ref global::android.app.Activity._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.Dialog;
		}
		private static global::MonoJavaBridge.MethodId _m87;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V", ref global::android.app.Activity._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V", ref global::android.app.Activity._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public virtual bool showDialog(int arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "showDialog", "(ILandroid/os/Bundle;)Z", ref global::android.app.Activity._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public virtual void showDialog(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "showDialog", "(I)V", ref global::android.app.Activity._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public virtual void dismissDialog(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "dismissDialog", "(I)V", ref global::android.app.Activity._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public virtual void removeDialog(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "removeDialog", "(I)V", ref global::android.app.Activity._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public virtual bool onSearchRequested()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "onSearchRequested", "()Z", ref global::android.app.Activity._m93);
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V", ref global::android.app.Activity._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V", ref global::android.app.Activity._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public virtual void takeKeyEvents(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V", ref global::android.app.Activity._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public virtual bool requestWindowFeature(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z", ref global::android.app.Activity._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public virtual void setFeatureDrawableResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V", ref global::android.app.Activity._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V", ref global::android.app.Activity._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", ref global::android.app.Activity._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V", ref global::android.app.Activity._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public virtual global::android.view.LayoutInflater getLayoutInflater()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;", ref global::android.app.Activity._m102) as android.view.LayoutInflater;
		}
		public new global::android.view.MenuInflater MenuInflater
		{
			get
			{
				return getMenuInflater();
			}
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public virtual global::android.view.MenuInflater getMenuInflater()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;", ref global::android.app.Activity._m103) as android.view.MenuInflater;
		}
		private static global::MonoJavaBridge.MethodId _m104;
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", ref global::android.app.Activity._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V", ref global::android.app.Activity._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V", ref global::android.app.Activity._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z", ref global::android.app.Activity._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public virtual bool startNextMatchingActivity(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z", ref global::android.app.Activity._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V", ref global::android.app.Activity._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V", ref global::android.app.Activity._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public virtual void overridePendingTransition(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V", ref global::android.app.Activity._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String CallingPackage
		{
			get
			{
				return getCallingPackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public virtual global::java.lang.String getCallingPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;", ref global::android.app.Activity._m112) as java.lang.String;
		}
		public new global::android.content.ComponentName CallingActivity
		{
			get
			{
				return getCallingActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public virtual global::android.content.ComponentName getCallingActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;", ref global::android.app.Activity._m113) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public virtual bool isFinishing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "isFinishing", "()Z", ref global::android.app.Activity._m114);
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public virtual void finishFromChild(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V", ref global::android.app.Activity._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public virtual void finishActivity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "finishActivity", "(I)V", ref global::android.app.Activity._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V", ref global::android.app.Activity._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V", ref global::android.app.Activity._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public virtual global::android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.app.PendingIntent>(this, global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;", ref global::android.app.Activity._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.PendingIntent;
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public virtual void setRequestedOrientation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V", ref global::android.app.Activity._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m121;
		public virtual int getRequestedOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getRequestedOrientation", "()I", ref global::android.app.Activity._m121);
		}
		public new int TaskId
		{
			get
			{
				return getTaskId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m122;
		public virtual int getTaskId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getTaskId", "()I", ref global::android.app.Activity._m122);
		}
		private static global::MonoJavaBridge.MethodId _m123;
		public virtual bool isTaskRoot()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "isTaskRoot", "()Z", ref global::android.app.Activity._m123);
		}
		private static global::MonoJavaBridge.MethodId _m124;
		public virtual bool moveTaskToBack(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z", ref global::android.app.Activity._m124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String LocalClassName
		{
			get
			{
				return getLocalClassName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m125;
		public virtual global::java.lang.String getLocalClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;", ref global::android.app.Activity._m125) as java.lang.String;
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m126;
		public virtual global::android.content.ComponentName getComponentName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;", ref global::android.app.Activity._m126) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m127;
		public virtual global::android.content.SharedPreferences getPreferences(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;", ref global::android.app.Activity._m127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.SharedPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m128;
		public virtual void setTitle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setTitle", "(I)V", ref global::android.app.Activity._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m129;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.app.Activity._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m130;
		public virtual void setTitleColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setTitleColor", "(I)V", ref global::android.app.Activity._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m131;
		public virtual global::java.lang.CharSequence getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;", ref global::android.app.Activity._m131) as java.lang.CharSequence;
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
		private static global::MonoJavaBridge.MethodId _m132;
		public virtual int getTitleColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getTitleColor", "()I", ref global::android.app.Activity._m132);
		}
		private static global::MonoJavaBridge.MethodId _m133;
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V", ref global::android.app.Activity._m133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void onTitleChanged(string arg0, int arg1)
		{
			onTitleChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m134;
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V", ref global::android.app.Activity._m134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m135;
		public virtual void setProgressBarVisibility(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V", ref global::android.app.Activity._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ProgressBarIndeterminateVisibility
		{
			set
			{
				setProgressBarIndeterminateVisibility(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m136;
		public virtual void setProgressBarIndeterminateVisibility(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V", ref global::android.app.Activity._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ProgressBarIndeterminate
		{
			set
			{
				setProgressBarIndeterminate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m137;
		public virtual void setProgressBarIndeterminate(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V", ref global::android.app.Activity._m137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Progress
		{
			set
			{
				setProgress(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m138;
		public virtual void setProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setProgress", "(I)V", ref global::android.app.Activity._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SecondaryProgress
		{
			set
			{
				setSecondaryProgress(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m139;
		public virtual void setSecondaryProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V", ref global::android.app.Activity._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m140;
		public virtual void setVolumeControlStream(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V", ref global::android.app.Activity._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m141;
		public virtual int getVolumeControlStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Activity.staticClass, "getVolumeControlStream", "()I", ref global::android.app.Activity._m141);
		}
		private static global::MonoJavaBridge.MethodId _m142;
		public virtual void runOnUiThread(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V", ref global::android.app.Activity._m142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void runOnUiThread(global::java.lang.RunnableDelegate arg0)
		{
			runOnUiThread((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m143;
		public virtual global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", ref global::android.app.Activity._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m144;
		public Activity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Activity._m144.native == global::System.IntPtr.Zero)
				global::android.app.Activity._m144 = @__env.GetMethodIDNoThrow(global::android.app.Activity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Activity.staticClass, global::android.app.Activity._m144);
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
		static Activity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Activity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Activity"));
		}
	}
}
