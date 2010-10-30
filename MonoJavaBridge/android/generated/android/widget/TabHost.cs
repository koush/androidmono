namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabHost : android.widget.FrameLayout, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TabHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TabHost.OnTabChangeListener_))]
		public partial interface OnTabChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTabChanged(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TabHost.OnTabChangeListener))]
		internal sealed partial class OnTabChangeListener_ : java.lang.Object, OnTabChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnTabChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTabChanged17856;
			void android.widget.TabHost.OnTabChangeListener.onTabChanged(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost.OnTabChangeListener_._onTabChanged17856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnTabChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.OnTabChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$OnTabChangeListener"));
				global::android.widget.TabHost.OnTabChangeListener_._onTabChanged17856 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.OnTabChangeListener_.staticClass, "onTabChanged", "(Ljava/lang/String;)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnTabChangeListenerDelegate(java.lang.String arg0);

		internal partial class OnTabChangeListenerDelegateWrapper : java.lang.Object, OnTabChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTabChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnTabChangeListenerDelegateWrapper17857;
			public OnTabChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.OnTabChangeListenerDelegateWrapper.staticClass, global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper._OnTabChangeListenerDelegateWrapper17857);
				Init(@__env, handle);
			}
			static OnTabChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost_OnTabChangeListenerDelegateWrapper"));
				global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper._OnTabChangeListenerDelegateWrapper17857 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnTabChangeListenerDelegateWrapper
		{
			private OnTabChangeListenerDelegate myDelegate;
			public void onTabChanged(java.lang.String arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnTabChangeListenerDelegateWrapper(OnTabChangeListenerDelegate d)
			{
				global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper ret = new global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TabHost.TabContentFactory_))]
		public partial interface TabContentFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.view.View createTabContent(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TabHost.TabContentFactory))]
		internal sealed partial class TabContentFactory_ : java.lang.Object, TabContentFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TabContentFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createTabContent17858;
			global::android.view.View android.widget.TabHost.TabContentFactory.createTabContent(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabContentFactory_._createTabContent17858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			static TabContentFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabContentFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabContentFactory"));
				global::android.widget.TabHost.TabContentFactory_._createTabContent17858 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabContentFactory_.staticClass, "createTabContent", "(Ljava/lang/String;)Landroid/view/View;");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate android.view.View TabContentFactoryDelegate(java.lang.String arg0);

		internal partial class TabContentFactoryDelegateWrapper : java.lang.Object, TabContentFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected TabContentFactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _TabContentFactoryDelegateWrapper17859;
			public TabContentFactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.TabContentFactoryDelegateWrapper.staticClass, global::android.widget.TabHost.TabContentFactoryDelegateWrapper._TabContentFactoryDelegateWrapper17859);
				Init(@__env, handle);
			}
			static TabContentFactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabContentFactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost_TabContentFactoryDelegateWrapper"));
				global::android.widget.TabHost.TabContentFactoryDelegateWrapper._TabContentFactoryDelegateWrapper17859 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabContentFactoryDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class TabContentFactoryDelegateWrapper
		{
			private TabContentFactoryDelegate myDelegate;
			public android.view.View createTabContent(java.lang.String arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator TabContentFactoryDelegateWrapper(TabContentFactoryDelegate d)
			{
				global::android.widget.TabHost.TabContentFactoryDelegateWrapper ret = new global::android.widget.TabHost.TabContentFactoryDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class TabSpec : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected TabSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new global::java.lang.String Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag17860;
			public virtual global::java.lang.String getTag()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._getTag17860)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator17861;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator17861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0, android.graphics.drawable.Drawable arg1)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator17862;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(android.view.View arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator17862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator17863;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator17863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setContent17864;
			public virtual global::android.widget.TabHost.TabSpec setContent(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent17864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setContent17865;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.widget.TabHost.TabContentFactory arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent17865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setContent(global::android.widget.TabHost.TabContentFactoryDelegate arg0)
			{
				return setContent((global::android.widget.TabHost.TabContentFactoryDelegateWrapper)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setContent17866;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.content.Intent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent17866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			static TabSpec()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabSpec"));
				global::android.widget.TabHost.TabSpec._getTag17860 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "getTag", "()Ljava/lang/String;");
				global::android.widget.TabHost.TabSpec._setIndicator17861 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setIndicator17862 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setIndicator17863 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent17864 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(I)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent17865 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent17866 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;");
			}
			internal static void InitJNI()
			{
			}
		}
		public new global::android.app.LocalActivityManager up
		{
			set
			{
				setup(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setup17867;
		public virtual void setup(android.app.LocalActivityManager arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup17867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setup17868;
		public virtual void setup()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup17868);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow17869;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onAttachedToWindow17869);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17870;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onDetachedFromWindow17870);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17871;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchKeyEvent17871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged17872;
		public override void dispatchWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchWindowFocusChanged17872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged17873;
		public virtual void onTouchModeChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onTouchModeChanged17873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabWidget TabWidget
		{
			get
			{
				return getTabWidget();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabWidget17874;
		public virtual global::android.widget.TabWidget getTabWidget()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabWidget17874)) as android.widget.TabWidget;
		}
		internal static global::MonoJavaBridge.MethodId _newTabSpec17875;
		public virtual global::android.widget.TabHost.TabSpec newTabSpec(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._newTabSpec17875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
		}
		internal static global::MonoJavaBridge.MethodId _addTab17876;
		public virtual void addTab(android.widget.TabHost.TabSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._addTab17876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAllTabs17877;
		public virtual void clearAllTabs()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._clearAllTabs17877);
		}
		public new int CurrentTab
		{
			get
			{
				return getCurrentTab();
			}
			set
			{
				setCurrentTab(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTab17878;
		public virtual int getCurrentTab()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTab17878);
		}
		public new global::java.lang.String CurrentTabTag
		{
			get
			{
				return getCurrentTabTag();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTabTag17879;
		public virtual global::java.lang.String getCurrentTabTag()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabTag17879)) as java.lang.String;
		}
		public new global::android.view.View CurrentTabView
		{
			get
			{
				return getCurrentTabView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTabView17880;
		public virtual global::android.view.View getCurrentTabView()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabView17880)) as android.view.View;
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView17881;
		public virtual global::android.view.View getCurrentView()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentView17881)) as android.view.View;
		}
		public new global::java.lang.String CurrentTabByTag
		{
			set
			{
				setCurrentTabByTag(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTabByTag17882;
		public virtual void setCurrentTabByTag(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTabByTag17882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.FrameLayout TabContentView
		{
			get
			{
				return getTabContentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabContentView17883;
		public virtual global::android.widget.FrameLayout getTabContentView()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabContentView17883)) as android.widget.FrameLayout;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTab17884;
		public virtual void setCurrentTab(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTab17884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabHost.OnTabChangeListener OnTabChangedListener
		{
			set
			{
				setOnTabChangedListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnTabChangedListener17885;
		public virtual void setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setOnTabChangedListener17885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnTabChangedListener(global::android.widget.TabHost.OnTabChangeListenerDelegate arg0)
		{
			setOnTabChangedListener((global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _TabHost17886;
		public TabHost(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost17886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabHost17887;
		public TabHost(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost17887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TabHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost"));
			global::android.widget.TabHost._setup17867 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setup", "(Landroid/app/LocalActivityManager;)V");
			global::android.widget.TabHost._setup17868 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setup", "()V");
			global::android.widget.TabHost._onAttachedToWindow17869 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TabHost._onDetachedFromWindow17870 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TabHost._dispatchKeyEvent17871 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.TabHost._dispatchWindowFocusChanged17872 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.widget.TabHost._onTouchModeChanged17873 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.TabHost._getTabWidget17874 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.widget.TabHost._newTabSpec17875 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;");
			global::android.widget.TabHost._addTab17876 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "addTab", "(Landroid/widget/TabHost$TabSpec;)V");
			global::android.widget.TabHost._clearAllTabs17877 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "clearAllTabs", "()V");
			global::android.widget.TabHost._getCurrentTab17878 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTab", "()I");
			global::android.widget.TabHost._getCurrentTabTag17879 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTabTag", "()Ljava/lang/String;");
			global::android.widget.TabHost._getCurrentTabView17880 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTabView", "()Landroid/view/View;");
			global::android.widget.TabHost._getCurrentView17881 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.TabHost._setCurrentTabByTag17882 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setCurrentTabByTag", "(Ljava/lang/String;)V");
			global::android.widget.TabHost._getTabContentView17883 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getTabContentView", "()Landroid/widget/FrameLayout;");
			global::android.widget.TabHost._setCurrentTab17884 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabHost._setOnTabChangedListener17885 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V");
			global::android.widget.TabHost._TabHost17886 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabHost._TabHost17887 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
