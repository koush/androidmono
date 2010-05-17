namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Activity : android.view.ContextThemeWrapper, android.view.LayoutInflater.Factory, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener, android.content.ComponentCallbacks
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Activity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Activity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getParent120; 
		public virtual android.app.Activity getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _getParent120)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getParent120)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getApplication121; 
		public virtual android.app.Application getApplication() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, _getApplication121)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getApplication121)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate122; 
		protected virtual void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onCreate122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onCreate122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart123; 
		protected virtual void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onStart123); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onStart123); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy124; 
		protected virtual void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onDestroy124); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onDestroy124); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged125; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onConfigurationChanged125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onConfigurationChanged125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory126; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onLowMemory126); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onLowMemory126); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth127; 
		public override int getWallpaperDesiredMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getWallpaperDesiredMinimumWidth127); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getWallpaperDesiredMinimumWidth127); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight128; 
		public override int getWallpaperDesiredMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getWallpaperDesiredMinimumHeight128); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getWallpaperDesiredMinimumHeight128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivity129; 
		public override void startActivity(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startActivity129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startActivity129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender130; 
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startIntentSender130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startIntentSender130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService131; 
		public override java.lang.Object getSystemService(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getSystemService131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getSystemService131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntent132; 
		public virtual android.content.Intent getIntent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _getIntent132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getIntent132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations133; 
		public virtual int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations133); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getChangingConfigurations133); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible134; 
		public virtual void setVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setVisible134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setVisible134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResult135; 
		public virtual void setResult(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setResult135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setResult135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setResult136; 
		public virtual void setResult(int arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setResult136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setResult136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finish137; 
		public virtual void finish() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _finish137); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _finish137); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstanceCount138; 
		public static long getInstanceCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.app.Activity.staticClass, _getInstanceCount138); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntent139; 
		public virtual void setIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setIntent139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setIntent139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChild140; 
		public virtual bool isChild() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _isChild140); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _isChild140); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowManager141; 
		public virtual android.view.WindowManager getWindowManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallObjectMethodPtr(this, _getWindowManager141)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getWindowManager141)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow142; 
		public virtual android.view.Window getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, _getWindow142)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getWindow142)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus143; 
		public virtual android.view.View getCurrentFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentFocus143)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getCurrentFocus143)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState144; 
		protected virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onRestoreInstanceState144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPostCreate145; 
		protected virtual void onPostCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onPostCreate145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onPostCreate145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestart146; 
		protected virtual void onRestart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onRestart146); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onRestart146); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResume147; 
		protected virtual void onResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onResume147); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onResume147); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPostResume148; 
		protected virtual void onPostResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onPostResume148); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onPostResume148); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onNewIntent149; 
		protected virtual void onNewIntent(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onNewIntent149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onNewIntent149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState150; 
		protected virtual void onSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onSaveInstanceState150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onSaveInstanceState150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPause151; 
		protected virtual void onPause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onPause151); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onPause151); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUserLeaveHint152; 
		protected virtual void onUserLeaveHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onUserLeaveHint152); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onUserLeaveHint152); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateThumbnail153; 
		public virtual bool onCreateThumbnail(android.graphics.Bitmap arg0, android.graphics.Canvas arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onCreateThumbnail153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onCreateThumbnail153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDescription154; 
		public virtual java.lang.CharSequence onCreateDescription() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _onCreateDescription154)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _onCreateDescription154)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop155; 
		protected virtual void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onStop155); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onStop155); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLastNonConfigurationInstance156; 
		public virtual java.lang.Object getLastNonConfigurationInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getLastNonConfigurationInstance156)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getLastNonConfigurationInstance156)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRetainNonConfigurationInstance157; 
		public virtual java.lang.Object onRetainNonConfigurationInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _onRetainNonConfigurationInstance157)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _onRetainNonConfigurationInstance157)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _managedQuery158; 
		public virtual android.database.Cursor managedQuery(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _managedQuery158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _managedQuery158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startManagingCursor159; 
		public virtual void startManagingCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startManagingCursor159, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startManagingCursor159, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopManagingCursor160; 
		public virtual void stopManagingCursor(android.database.Cursor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _stopManagingCursor160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _stopManagingCursor160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPersistent161; 
		public virtual void setPersistent(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setPersistent161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setPersistent161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById162; 
		public virtual android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewById162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _findViewById162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView163; 
		public virtual void setContentView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setContentView163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setContentView163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView164; 
		public virtual void setContentView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setContentView164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setContentView164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView165; 
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setContentView165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setContentView165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addContentView166; 
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _addContentView166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _addContentView166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultKeyMode167; 
		public virtual void setDefaultKeyMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setDefaultKeyMode167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setDefaultKeyMode167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown168; 
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onKeyDown168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onKeyDown168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress169; 
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onKeyLongPress169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onKeyLongPress169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp170; 
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onKeyUp170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onKeyUp170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple171; 
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onKeyMultiple171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBackPressed172; 
		public virtual void onBackPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onBackPressed172); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onBackPressed172); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent173; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onTouchEvent173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent174; 
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onTrackballEvent174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUserInteraction175; 
		public virtual void onUserInteraction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onUserInteraction175); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onUserInteraction175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged176; 
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onWindowAttributesChanged176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onWindowAttributesChanged176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged177; 
		public virtual void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onContentChanged177); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onContentChanged177); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged178; 
		public virtual void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onWindowFocusChanged178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow179; 
		public virtual void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow179); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onAttachedToWindow179); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow180; 
		public virtual void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow180); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onDetachedFromWindow180); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus181; 
		public virtual bool hasWindowFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _hasWindowFocus181); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _hasWindowFocus181); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent182; 
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _dispatchKeyEvent182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent183; 
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _dispatchTouchEvent183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _dispatchTouchEvent183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent184; 
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _dispatchTrackballEvent184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _dispatchTrackballEvent184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent185; 
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _dispatchPopulateAccessibilityEvent185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView186; 
		public virtual android.view.View onCreatePanelView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreatePanelView186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _onCreatePanelView186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu187; 
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onCreatePanelMenu187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onCreatePanelMenu187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel188; 
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onPreparePanel188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onPreparePanel188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened189; 
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onMenuOpened189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onMenuOpened189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected190; 
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onMenuItemSelected190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onMenuItemSelected190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed191; 
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onPanelClosed191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onPanelClosed191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateOptionsMenu192; 
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onCreateOptionsMenu192, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onCreateOptionsMenu192, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareOptionsMenu193; 
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onPrepareOptionsMenu193, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onPrepareOptionsMenu193, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsItemSelected194; 
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onOptionsItemSelected194, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onOptionsItemSelected194, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsMenuClosed195; 
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onOptionsMenuClosed195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onOptionsMenuClosed195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOptionsMenu196; 
		public virtual void openOptionsMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _openOptionsMenu196); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _openOptionsMenu196); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closeOptionsMenu197; 
		public virtual void closeOptionsMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _closeOptionsMenu197); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _closeOptionsMenu197); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu198; 
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onCreateContextMenu198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onCreateContextMenu198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerForContextMenu199; 
		public virtual void registerForContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _registerForContextMenu199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _registerForContextMenu199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterForContextMenu200; 
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _unregisterForContextMenu200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _unregisterForContextMenu200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openContextMenu201; 
		public virtual void openContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _openContextMenu201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _openContextMenu201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closeContextMenu202; 
		public virtual void closeContextMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _closeContextMenu202); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _closeContextMenu202); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContextItemSelected203; 
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onContextItemSelected203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onContextItemSelected203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContextMenuClosed204; 
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onContextMenuClosed204, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onContextMenuClosed204, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDialog205; 
		protected virtual android.app.Dialog onCreateDialog(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, _onCreateDialog205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _onCreateDialog205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareDialog206; 
		protected virtual void onPrepareDialog(int arg0, android.app.Dialog arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onPrepareDialog206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onPrepareDialog206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showDialog207; 
		public virtual void showDialog(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _showDialog207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _showDialog207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismissDialog208; 
		public virtual void dismissDialog(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _dismissDialog208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _dismissDialog208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeDialog209; 
		public virtual void removeDialog(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _removeDialog209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _removeDialog209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested210; 
		public virtual bool onSearchRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _onSearchRequested210); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _onSearchRequested210); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startSearch211; 
		public virtual void startSearch(java.lang.String arg0, bool arg1, android.os.Bundle arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startSearch211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startSearch211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _triggerSearch212; 
		public virtual void triggerSearch(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _triggerSearch212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _triggerSearch212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents213; 
		public virtual void takeKeyEvents(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _takeKeyEvents213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _takeKeyEvents213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestWindowFeature214; 
		public virtual bool requestWindowFeature(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _requestWindowFeature214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _requestWindowFeature214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource215; 
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setFeatureDrawableResource215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setFeatureDrawableResource215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri216; 
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setFeatureDrawableUri216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setFeatureDrawableUri216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable217; 
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setFeatureDrawable217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setFeatureDrawable217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha218; 
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setFeatureDrawableAlpha218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setFeatureDrawableAlpha218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater219; 
		public virtual android.view.LayoutInflater getLayoutInflater() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutInflater219)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getLayoutInflater219)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMenuInflater220; 
		public virtual android.view.MenuInflater getMenuInflater() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MenuInflater>(@__env, @__env.CallObjectMethodPtr(this, _getMenuInflater220)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MenuInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getMenuInflater220)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onApplyThemeResource221; 
		protected override void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onApplyThemeResource221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onApplyThemeResource221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivityForResult222; 
		public virtual void startActivityForResult(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startActivityForResult222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startActivityForResult222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSenderForResult223; 
		public virtual void startIntentSenderForResult(android.content.IntentSender arg0, int arg1, android.content.Intent arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startIntentSenderForResult223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startIntentSenderForResult223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivityIfNeeded224; 
		public virtual bool startActivityIfNeeded(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _startActivityIfNeeded224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _startActivityIfNeeded224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startNextMatchingActivity225; 
		public virtual bool startNextMatchingActivity(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _startNextMatchingActivity225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _startNextMatchingActivity225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivityFromChild226; 
		public virtual void startActivityFromChild(android.app.Activity arg0, android.content.Intent arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startActivityFromChild226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startActivityFromChild226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSenderFromChild227; 
		public virtual void startIntentSenderFromChild(android.app.Activity arg0, android.content.IntentSender arg1, int arg2, android.content.Intent arg3, int arg4, int arg5, int arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _startIntentSenderFromChild227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _startIntentSenderFromChild227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _overridePendingTransition228; 
		public virtual void overridePendingTransition(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _overridePendingTransition228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _overridePendingTransition228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallingPackage229; 
		public virtual java.lang.String getCallingPackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCallingPackage229)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getCallingPackage229)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallingActivity230; 
		public virtual android.content.ComponentName getCallingActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _getCallingActivity230)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getCallingActivity230)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFinishing231; 
		public virtual bool isFinishing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _isFinishing231); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _isFinishing231); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishFromChild232; 
		public virtual void finishFromChild(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _finishFromChild232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _finishFromChild232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishActivity233; 
		public virtual void finishActivity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _finishActivity233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _finishActivity233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishActivityFromChild234; 
		public virtual void finishActivityFromChild(android.app.Activity arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _finishActivityFromChild234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _finishActivityFromChild234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onActivityResult235; 
		protected virtual void onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onActivityResult235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onActivityResult235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createPendingResult236; 
		public virtual android.app.PendingIntent createPendingResult(int arg0, android.content.Intent arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallObjectMethodPtr(this, _createPendingResult236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _createPendingResult236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRequestedOrientation237; 
		public virtual void setRequestedOrientation(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setRequestedOrientation237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setRequestedOrientation237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRequestedOrientation238; 
		public virtual int getRequestedOrientation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getRequestedOrientation238); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getRequestedOrientation238); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTaskId239; 
		public virtual int getTaskId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getTaskId239); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getTaskId239); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isTaskRoot240; 
		public virtual bool isTaskRoot() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _isTaskRoot240); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _isTaskRoot240); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveTaskToBack241; 
		public virtual bool moveTaskToBack(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallBooleanMethod(this, _moveTaskToBack241, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Activity.staticClass, _moveTaskToBack241, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalClassName242; 
		public virtual java.lang.String getLocalClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLocalClassName242)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getLocalClassName242)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComponentName243; 
		public virtual android.content.ComponentName getComponentName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _getComponentName243)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getComponentName243)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPreferences244; 
		public virtual android.content.SharedPreferences getPreferences(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, _getPreferences244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getPreferences244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle245; 
		public virtual void setTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setTitle245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setTitle245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle246; 
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setTitle246, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setTitle246, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitleColor247; 
		public virtual void setTitleColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setTitleColor247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setTitleColor247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle248; 
		public virtual java.lang.CharSequence getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTitle248)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _getTitle248)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitleColor249; 
		public virtual int getTitleColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getTitleColor249); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getTitleColor249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTitleChanged250; 
		protected virtual void onTitleChanged(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onTitleChanged250, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onTitleChanged250, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildTitleChanged251; 
		protected virtual void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _onChildTitleChanged251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _onChildTitleChanged251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarVisibility252; 
		public virtual void setProgressBarVisibility(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setProgressBarVisibility252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setProgressBarVisibility252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarIndeterminateVisibility253; 
		public virtual void setProgressBarIndeterminateVisibility(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setProgressBarIndeterminateVisibility253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setProgressBarIndeterminateVisibility253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressBarIndeterminate254; 
		public virtual void setProgressBarIndeterminate(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setProgressBarIndeterminate254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setProgressBarIndeterminate254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgress255; 
		public virtual void setProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setProgress255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setProgress255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress256; 
		public virtual void setSecondaryProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setSecondaryProgress256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setSecondaryProgress256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream257; 
		public virtual void setVolumeControlStream(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _setVolumeControlStream257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _setVolumeControlStream257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream258; 
		public virtual int getVolumeControlStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return @__env.CallIntMethod(this, _getVolumeControlStream258); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Activity.staticClass, _getVolumeControlStream258); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runOnUiThread259; 
		public virtual void runOnUiThread(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				@__env.CallVoidMethod(this, _runOnUiThread259, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Activity.staticClass, _runOnUiThread259, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateView260; 
		public virtual android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Activity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreateView260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Activity.staticClass, _onCreateView260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Activity261; 
		public Activity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Activity.staticClass, _Activity261, this); 
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
			global::android.app.Activity._getParent120 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getParent", "()Landroid/app/Activity;"); 
			global::android.app.Activity._getApplication121 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getApplication", "()Landroid/app/Application;"); 
			global::android.app.Activity._onCreate122 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.Activity._onStart123 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onStart", "()V"); 
			global::android.app.Activity._onDestroy124 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onDestroy", "()V"); 
			global::android.app.Activity._onConfigurationChanged125 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.app.Activity._onLowMemory126 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onLowMemory", "()V"); 
			global::android.app.Activity._getWallpaperDesiredMinimumWidth127 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumWidth", "()I"); 
			global::android.app.Activity._getWallpaperDesiredMinimumHeight128 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWallpaperDesiredMinimumHeight", "()I"); 
			global::android.app.Activity._startActivity129 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivity", "(Landroid/content/Intent;)V"); 
			global::android.app.Activity._startIntentSender130 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V"); 
			global::android.app.Activity._getSystemService131 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.app.Activity._getIntent132 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getIntent", "()Landroid/content/Intent;"); 
			global::android.app.Activity._getChangingConfigurations133 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getChangingConfigurations", "()I"); 
			global::android.app.Activity._setVisible134 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setVisible", "(Z)V"); 
			global::android.app.Activity._setResult135 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setResult", "(I)V"); 
			global::android.app.Activity._setResult136 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setResult", "(ILandroid/content/Intent;)V"); 
			global::android.app.Activity._finish137 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finish", "()V"); 
			global::android.app.Activity._getInstanceCount138 = @__env.GetStaticMethodID(global::android.app.Activity.staticClass, "getInstanceCount", "()J"); 
			global::android.app.Activity._setIntent139 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setIntent", "(Landroid/content/Intent;)V"); 
			global::android.app.Activity._isChild140 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isChild", "()Z"); 
			global::android.app.Activity._getWindowManager141 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWindowManager", "()Landroid/view/WindowManager;"); 
			global::android.app.Activity._getWindow142 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getWindow", "()Landroid/view/Window;"); 
			global::android.app.Activity._getCurrentFocus143 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCurrentFocus", "()Landroid/view/View;"); 
			global::android.app.Activity._onRestoreInstanceState144 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.Activity._onPostCreate145 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.Activity._onRestart146 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRestart", "()V"); 
			global::android.app.Activity._onResume147 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onResume", "()V"); 
			global::android.app.Activity._onPostResume148 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPostResume", "()V"); 
			global::android.app.Activity._onNewIntent149 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onNewIntent", "(Landroid/content/Intent;)V"); 
			global::android.app.Activity._onSaveInstanceState150 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.Activity._onPause151 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPause", "()V"); 
			global::android.app.Activity._onUserLeaveHint152 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onUserLeaveHint", "()V"); 
			global::android.app.Activity._onCreateThumbnail153 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z"); 
			global::android.app.Activity._onCreateDescription154 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDescription", "()Ljava/lang/CharSequence;"); 
			global::android.app.Activity._onStop155 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onStop", "()V"); 
			global::android.app.Activity._getLastNonConfigurationInstance156 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLastNonConfigurationInstance", "()Ljava/lang/Object;"); 
			global::android.app.Activity._onRetainNonConfigurationInstance157 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onRetainNonConfigurationInstance", "()Ljava/lang/Object;"); 
			global::android.app.Activity._managedQuery158 = @__env.GetMethodID(global::android.app.Activity.staticClass, "managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.app.Activity._startManagingCursor159 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startManagingCursor", "(Landroid/database/Cursor;)V"); 
			global::android.app.Activity._stopManagingCursor160 = @__env.GetMethodID(global::android.app.Activity.staticClass, "stopManagingCursor", "(Landroid/database/Cursor;)V"); 
			global::android.app.Activity._setPersistent161 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setPersistent", "(Z)V"); 
			global::android.app.Activity._findViewById162 = @__env.GetMethodID(global::android.app.Activity.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.app.Activity._setContentView163 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.app.Activity._setContentView164 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(I)V"); 
			global::android.app.Activity._setContentView165 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.app.Activity._addContentView166 = @__env.GetMethodID(global::android.app.Activity.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.app.Activity._setDefaultKeyMode167 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setDefaultKeyMode", "(I)V"); 
			global::android.app.Activity._onKeyDown168 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Activity._onKeyLongPress169 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Activity._onKeyUp170 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Activity._onKeyMultiple171 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.app.Activity._onBackPressed172 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onBackPressed", "()V"); 
			global::android.app.Activity._onTouchEvent173 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Activity._onTrackballEvent174 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Activity._onUserInteraction175 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onUserInteraction", "()V"); 
			global::android.app.Activity._onWindowAttributesChanged176 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V"); 
			global::android.app.Activity._onContentChanged177 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContentChanged", "()V"); 
			global::android.app.Activity._onWindowFocusChanged178 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.app.Activity._onAttachedToWindow179 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onAttachedToWindow", "()V"); 
			global::android.app.Activity._onDetachedFromWindow180 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.app.Activity._hasWindowFocus181 = @__env.GetMethodID(global::android.app.Activity.staticClass, "hasWindowFocus", "()Z"); 
			global::android.app.Activity._dispatchKeyEvent182 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.app.Activity._dispatchTouchEvent183 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Activity._dispatchTrackballEvent184 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Activity._dispatchPopulateAccessibilityEvent185 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.app.Activity._onCreatePanelView186 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreatePanelView", "(I)Landroid/view/View;"); 
			global::android.app.Activity._onCreatePanelMenu187 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z"); 
			global::android.app.Activity._onPreparePanel188 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z"); 
			global::android.app.Activity._onMenuOpened189 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z"); 
			global::android.app.Activity._onMenuItemSelected190 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z"); 
			global::android.app.Activity._onPanelClosed191 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V"); 
			global::android.app.Activity._onCreateOptionsMenu192 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z"); 
			global::android.app.Activity._onPrepareOptionsMenu193 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z"); 
			global::android.app.Activity._onOptionsItemSelected194 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z"); 
			global::android.app.Activity._onOptionsMenuClosed195 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V"); 
			global::android.app.Activity._openOptionsMenu196 = @__env.GetMethodID(global::android.app.Activity.staticClass, "openOptionsMenu", "()V"); 
			global::android.app.Activity._closeOptionsMenu197 = @__env.GetMethodID(global::android.app.Activity.staticClass, "closeOptionsMenu", "()V"); 
			global::android.app.Activity._onCreateContextMenu198 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"); 
			global::android.app.Activity._registerForContextMenu199 = @__env.GetMethodID(global::android.app.Activity.staticClass, "registerForContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Activity._unregisterForContextMenu200 = @__env.GetMethodID(global::android.app.Activity.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Activity._openContextMenu201 = @__env.GetMethodID(global::android.app.Activity.staticClass, "openContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Activity._closeContextMenu202 = @__env.GetMethodID(global::android.app.Activity.staticClass, "closeContextMenu", "()V"); 
			global::android.app.Activity._onContextItemSelected203 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z"); 
			global::android.app.Activity._onContextMenuClosed204 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V"); 
			global::android.app.Activity._onCreateDialog205 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateDialog", "(I)Landroid/app/Dialog;"); 
			global::android.app.Activity._onPrepareDialog206 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onPrepareDialog", "(ILandroid/app/Dialog;)V"); 
			global::android.app.Activity._showDialog207 = @__env.GetMethodID(global::android.app.Activity.staticClass, "showDialog", "(I)V"); 
			global::android.app.Activity._dismissDialog208 = @__env.GetMethodID(global::android.app.Activity.staticClass, "dismissDialog", "(I)V"); 
			global::android.app.Activity._removeDialog209 = @__env.GetMethodID(global::android.app.Activity.staticClass, "removeDialog", "(I)V"); 
			global::android.app.Activity._onSearchRequested210 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onSearchRequested", "()Z"); 
			global::android.app.Activity._startSearch211 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V"); 
			global::android.app.Activity._triggerSearch212 = @__env.GetMethodID(global::android.app.Activity.staticClass, "triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.app.Activity._takeKeyEvents213 = @__env.GetMethodID(global::android.app.Activity.staticClass, "takeKeyEvents", "(Z)V"); 
			global::android.app.Activity._requestWindowFeature214 = @__env.GetMethodID(global::android.app.Activity.staticClass, "requestWindowFeature", "(I)Z"); 
			global::android.app.Activity._setFeatureDrawableResource215 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableResource", "(II)V"); 
			global::android.app.Activity._setFeatureDrawableUri216 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V"); 
			global::android.app.Activity._setFeatureDrawable217 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.app.Activity._setFeatureDrawableAlpha218 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setFeatureDrawableAlpha", "(II)V"); 
			global::android.app.Activity._getLayoutInflater219 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.app.Activity._getMenuInflater220 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getMenuInflater", "()Landroid/view/MenuInflater;"); 
			global::android.app.Activity._onApplyThemeResource221 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V"); 
			global::android.app.Activity._startActivityForResult222 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityForResult", "(Landroid/content/Intent;I)V"); 
			global::android.app.Activity._startIntentSenderForResult223 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V"); 
			global::android.app.Activity._startActivityIfNeeded224 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityIfNeeded", "(Landroid/content/Intent;I)Z"); 
			global::android.app.Activity._startNextMatchingActivity225 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startNextMatchingActivity", "(Landroid/content/Intent;)Z"); 
			global::android.app.Activity._startActivityFromChild226 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V"); 
			global::android.app.Activity._startIntentSenderFromChild227 = @__env.GetMethodID(global::android.app.Activity.staticClass, "startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III)V"); 
			global::android.app.Activity._overridePendingTransition228 = @__env.GetMethodID(global::android.app.Activity.staticClass, "overridePendingTransition", "(II)V"); 
			global::android.app.Activity._getCallingPackage229 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCallingPackage", "()Ljava/lang/String;"); 
			global::android.app.Activity._getCallingActivity230 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getCallingActivity", "()Landroid/content/ComponentName;"); 
			global::android.app.Activity._isFinishing231 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isFinishing", "()Z"); 
			global::android.app.Activity._finishFromChild232 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishFromChild", "(Landroid/app/Activity;)V"); 
			global::android.app.Activity._finishActivity233 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishActivity", "(I)V"); 
			global::android.app.Activity._finishActivityFromChild234 = @__env.GetMethodID(global::android.app.Activity.staticClass, "finishActivityFromChild", "(Landroid/app/Activity;I)V"); 
			global::android.app.Activity._onActivityResult235 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onActivityResult", "(IILandroid/content/Intent;)V"); 
			global::android.app.Activity._createPendingResult236 = @__env.GetMethodID(global::android.app.Activity.staticClass, "createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.Activity._setRequestedOrientation237 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setRequestedOrientation", "(I)V"); 
			global::android.app.Activity._getRequestedOrientation238 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getRequestedOrientation", "()I"); 
			global::android.app.Activity._getTaskId239 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTaskId", "()I"); 
			global::android.app.Activity._isTaskRoot240 = @__env.GetMethodID(global::android.app.Activity.staticClass, "isTaskRoot", "()Z"); 
			global::android.app.Activity._moveTaskToBack241 = @__env.GetMethodID(global::android.app.Activity.staticClass, "moveTaskToBack", "(Z)Z"); 
			global::android.app.Activity._getLocalClassName242 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getLocalClassName", "()Ljava/lang/String;"); 
			global::android.app.Activity._getComponentName243 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getComponentName", "()Landroid/content/ComponentName;"); 
			global::android.app.Activity._getPreferences244 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getPreferences", "(I)Landroid/content/SharedPreferences;"); 
			global::android.app.Activity._setTitle245 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitle", "(I)V"); 
			global::android.app.Activity._setTitle246 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.Activity._setTitleColor247 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setTitleColor", "(I)V"); 
			global::android.app.Activity._getTitle248 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTitle", "()Ljava/lang/CharSequence;"); 
			global::android.app.Activity._getTitleColor249 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getTitleColor", "()I"); 
			global::android.app.Activity._onTitleChanged250 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onTitleChanged", "(Ljava/lang/CharSequence;I)V"); 
			global::android.app.Activity._onChildTitleChanged251 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V"); 
			global::android.app.Activity._setProgressBarVisibility252 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarVisibility", "(Z)V"); 
			global::android.app.Activity._setProgressBarIndeterminateVisibility253 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarIndeterminateVisibility", "(Z)V"); 
			global::android.app.Activity._setProgressBarIndeterminate254 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgressBarIndeterminate", "(Z)V"); 
			global::android.app.Activity._setProgress255 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setProgress", "(I)V"); 
			global::android.app.Activity._setSecondaryProgress256 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setSecondaryProgress", "(I)V"); 
			global::android.app.Activity._setVolumeControlStream257 = @__env.GetMethodID(global::android.app.Activity.staticClass, "setVolumeControlStream", "(I)V"); 
			global::android.app.Activity._getVolumeControlStream258 = @__env.GetMethodID(global::android.app.Activity.staticClass, "getVolumeControlStream", "()I"); 
			global::android.app.Activity._runOnUiThread259 = @__env.GetMethodID(global::android.app.Activity.staticClass, "runOnUiThread", "(Ljava/lang/Runnable;)V"); 
			global::android.app.Activity._onCreateView260 = @__env.GetMethodID(global::android.app.Activity.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;"); 
			global::android.app.Activity._Activity261 = @__env.GetMethodID(global::android.app.Activity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
