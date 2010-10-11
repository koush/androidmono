namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabHost : android.widget.FrameLayout, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TabHost()
		{
			InitJNI();
		}
		protected TabHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TabHost.OnTabChangeListener_))]
		public interface OnTabChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTabChanged(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TabHost.OnTabChangeListener))]
		public sealed partial class OnTabChangeListener_ : java.lang.Object, OnTabChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTabChangeListener_()
			{
				InitJNI();
			}
			internal OnTabChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTabChanged12010;
			 void android.widget.TabHost.OnTabChangeListener.onTabChanged(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost.OnTabChangeListener_._onTabChanged12010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.OnTabChangeListener_.staticClass, global::android.widget.TabHost.OnTabChangeListener_._onTabChanged12010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.OnTabChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$OnTabChangeListener"));
				global::android.widget.TabHost.OnTabChangeListener_._onTabChanged12010 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.OnTabChangeListener_.staticClass, "onTabChanged", "(Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TabHost.TabContentFactory_))]
		public interface TabContentFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.view.View createTabContent(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TabHost.TabContentFactory))]
		public sealed partial class TabContentFactory_ : java.lang.Object, TabContentFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TabContentFactory_()
			{
				InitJNI();
			}
			internal TabContentFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createTabContent12011;
			 global::android.view.View android.widget.TabHost.TabContentFactory.createTabContent(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabContentFactory_._createTabContent12011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabContentFactory_.staticClass, global::android.widget.TabHost.TabContentFactory_._createTabContent12011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabContentFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabContentFactory"));
				global::android.widget.TabHost.TabContentFactory_._createTabContent12011 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabContentFactory_.staticClass, "createTabContent", "(Ljava/lang/String;)Landroid/view/View;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class TabSpec : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TabSpec()
			{
				InitJNI();
			}
			protected TabSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getTag12012;
			public virtual global::java.lang.String getTag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._getTag12012)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._getTag12012)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator12013;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setIndicator12013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator12013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0, android.graphics.drawable.Drawable arg1)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator12014;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setIndicator12014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator12014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator12015;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setIndicator12015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator12015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setContent12016;
			public virtual global::android.widget.TabHost.TabSpec setContent(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setContent12016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent12016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setContent12017;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.widget.TabHost.TabContentFactory arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setContent12017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent12017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setContent12018;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.content.Intent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setContent12018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent12018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabSpec"));
				global::android.widget.TabHost.TabSpec._getTag12012 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "getTag", "()Ljava/lang/String;");
				global::android.widget.TabHost.TabSpec._setIndicator12013 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setIndicator12014 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setIndicator12015 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent12016 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(I)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent12017 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent12018 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setup12019;
		public virtual void setup(android.app.LocalActivityManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setup12019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup12019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setup12020;
		public virtual void setup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setup12020);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup12020);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow12021;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._onAttachedToWindow12021);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onAttachedToWindow12021);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow12022;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._onDetachedFromWindow12022);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onDetachedFromWindow12022);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent12023;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TabHost._dispatchKeyEvent12023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchKeyEvent12023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged12024;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._dispatchWindowFocusChanged12024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchWindowFocusChanged12024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged12025;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._onTouchModeChanged12025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onTouchModeChanged12025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTabWidget12026;
		public virtual global::android.widget.TabWidget getTabWidget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getTabWidget12026)) as android.widget.TabWidget;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabWidget12026)) as android.widget.TabWidget;
		}
		internal static global::MonoJavaBridge.MethodId _newTabSpec12027;
		public virtual global::android.widget.TabHost.TabSpec newTabSpec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._newTabSpec12027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._newTabSpec12027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
		}
		internal static global::MonoJavaBridge.MethodId _addTab12028;
		public virtual void addTab(android.widget.TabHost.TabSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._addTab12028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._addTab12028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAllTabs12029;
		public virtual void clearAllTabs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._clearAllTabs12029);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._clearAllTabs12029);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTab12030;
		public virtual int getCurrentTab() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentTab12030);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTab12030);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTabTag12031;
		public virtual global::java.lang.String getCurrentTabTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentTabTag12031)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabTag12031)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTabView12032;
		public virtual global::android.view.View getCurrentTabView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentTabView12032)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabView12032)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView12033;
		public virtual global::android.view.View getCurrentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentView12033)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentView12033)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTabByTag12034;
		public virtual void setCurrentTabByTag(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setCurrentTabByTag12034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTabByTag12034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTabContentView12035;
		public virtual global::android.widget.FrameLayout getTabContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getTabContentView12035)) as android.widget.FrameLayout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabContentView12035)) as android.widget.FrameLayout;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTab12036;
		public virtual void setCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setCurrentTab12036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTab12036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnTabChangedListener12037;
		public virtual void setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setOnTabChangedListener12037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setOnTabChangedListener12037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TabHost12038;
		public TabHost(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost12038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabHost12039;
		public TabHost(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost12039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost"));
			global::android.widget.TabHost._setup12019 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setup", "(Landroid/app/LocalActivityManager;)V");
			global::android.widget.TabHost._setup12020 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setup", "()V");
			global::android.widget.TabHost._onAttachedToWindow12021 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TabHost._onDetachedFromWindow12022 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TabHost._dispatchKeyEvent12023 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.TabHost._dispatchWindowFocusChanged12024 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.widget.TabHost._onTouchModeChanged12025 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.TabHost._getTabWidget12026 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.widget.TabHost._newTabSpec12027 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;");
			global::android.widget.TabHost._addTab12028 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "addTab", "(Landroid/widget/TabHost$TabSpec;)V");
			global::android.widget.TabHost._clearAllTabs12029 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "clearAllTabs", "()V");
			global::android.widget.TabHost._getCurrentTab12030 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTab", "()I");
			global::android.widget.TabHost._getCurrentTabTag12031 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTabTag", "()Ljava/lang/String;");
			global::android.widget.TabHost._getCurrentTabView12032 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTabView", "()Landroid/view/View;");
			global::android.widget.TabHost._getCurrentView12033 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.TabHost._setCurrentTabByTag12034 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setCurrentTabByTag", "(Ljava/lang/String;)V");
			global::android.widget.TabHost._getTabContentView12035 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getTabContentView", "()Landroid/widget/FrameLayout;");
			global::android.widget.TabHost._setCurrentTab12036 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabHost._setOnTabChangedListener12037 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V");
			global::android.widget.TabHost._TabHost12038 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabHost._TabHost12039 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
