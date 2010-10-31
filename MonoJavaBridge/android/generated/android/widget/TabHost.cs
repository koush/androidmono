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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.TabHost.OnTabChangeListener.onTabChanged(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.OnTabChangeListener_.staticClass, "onTabChanged", "(Ljava/lang/String;)V", ref global::android.widget.TabHost.OnTabChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnTabChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.OnTabChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$OnTabChangeListener"));
			}
		}

		public delegate void OnTabChangeListenerDelegate(java.lang.String arg0);

		internal partial class OnTabChangeListenerDelegateWrapper : java.lang.Object, OnTabChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTabChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnTabChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.OnTabChangeListenerDelegateWrapper.staticClass, global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnTabChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost_OnTabChangeListenerDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			global::android.view.View android.widget.TabHost.TabContentFactory.createTabContent(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabContentFactory_.staticClass, "createTabContent", "(Ljava/lang/String;)Landroid/view/View;", ref global::android.widget.TabHost.TabContentFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
			}
			static TabContentFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabContentFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabContentFactory"));
			}
		}

		public delegate android.view.View TabContentFactoryDelegate(java.lang.String arg0);

		internal partial class TabContentFactoryDelegateWrapper : java.lang.Object, TabContentFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected TabContentFactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public TabContentFactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TabHost.TabContentFactoryDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.TabHost.TabContentFactoryDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabContentFactoryDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.TabContentFactoryDelegateWrapper.staticClass, global::android.widget.TabHost.TabContentFactoryDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static TabContentFactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabContentFactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost_TabContentFactoryDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String getTag()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.TabHost.TabSpec.staticClass, "getTag", "()Ljava/lang/String;", ref global::android.widget.TabHost.TabSpec._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost.TabSpec._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0, android.graphics.drawable.Drawable arg1)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(android.view.View arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost.TabSpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TabHost.TabSpec;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost.TabSpec._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual global::android.widget.TabHost.TabSpec setContent(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(I)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost.TabSpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TabHost.TabSpec;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.widget.TabHost.TabContentFactory arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost.TabSpec._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setContent(global::android.widget.TabHost.TabContentFactoryDelegate arg0)
			{
				return setContent((global::android.widget.TabHost.TabContentFactoryDelegateWrapper)arg0);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.content.Intent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost.TabSpec._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TabHost.TabSpec;
			}
			static TabSpec()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabSpec"));
			}
		}
		public new global::android.app.LocalActivityManager up
		{
			set
			{
				setup(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setup(android.app.LocalActivityManager arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "setup", "(Landroid/app/LocalActivityManager;)V", ref global::android.widget.TabHost._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setup()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "setup", "()V", ref global::android.widget.TabHost._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.TabHost._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.TabHost._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TabHost.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.TabHost._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void dispatchWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "dispatchWindowFocusChanged", "(Z)V", ref global::android.widget.TabHost._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onTouchModeChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "onTouchModeChanged", "(Z)V", ref global::android.widget.TabHost._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabWidget TabWidget
		{
			get
			{
				return getTabWidget();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.TabWidget getTabWidget()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;", ref global::android.widget.TabHost._m7) as android.widget.TabWidget;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.widget.TabHost.TabSpec newTabSpec(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, "newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;", ref global::android.widget.TabHost._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TabHost.TabSpec;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void addTab(android.widget.TabHost.TabSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "addTab", "(Landroid/widget/TabHost$TabSpec;)V", ref global::android.widget.TabHost._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void clearAllTabs()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "clearAllTabs", "()V", ref global::android.widget.TabHost._m10);
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getCurrentTab()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TabHost.staticClass, "getCurrentTab", "()I", ref global::android.widget.TabHost._m11);
		}
		public new global::java.lang.String CurrentTabTag
		{
			get
			{
				return getCurrentTabTag();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String getCurrentTabTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.TabHost.staticClass, "getCurrentTabTag", "()Ljava/lang/String;", ref global::android.widget.TabHost._m12) as java.lang.String;
		}
		public new global::android.view.View CurrentTabView
		{
			get
			{
				return getCurrentTabView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.view.View getCurrentTabView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, "getCurrentTabView", "()Landroid/view/View;", ref global::android.widget.TabHost._m13) as android.view.View;
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.view.View getCurrentView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, "getCurrentView", "()Landroid/view/View;", ref global::android.widget.TabHost._m14) as android.view.View;
		}
		public new global::java.lang.String CurrentTabByTag
		{
			set
			{
				setCurrentTabByTag(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setCurrentTabByTag(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "setCurrentTabByTag", "(Ljava/lang/String;)V", ref global::android.widget.TabHost._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.FrameLayout TabContentView
		{
			get
			{
				return getTabContentView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.widget.FrameLayout getTabContentView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TabHost.staticClass, "getTabContentView", "()Landroid/widget/FrameLayout;", ref global::android.widget.TabHost._m16) as android.widget.FrameLayout;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setCurrentTab(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "setCurrentTab", "(I)V", ref global::android.widget.TabHost._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabHost.OnTabChangeListener OnTabChangedListener
		{
			set
			{
				setOnTabChangedListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TabHost.staticClass, "setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V", ref global::android.widget.TabHost._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnTabChangedListener(global::android.widget.TabHost.OnTabChangeListenerDelegate arg0)
		{
			setOnTabChangedListener((global::android.widget.TabHost.OnTabChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public TabHost(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TabHost._m19.native == global::System.IntPtr.Zero)
				global::android.widget.TabHost._m19 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public TabHost(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TabHost._m20.native == global::System.IntPtr.Zero)
				global::android.widget.TabHost._m20 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TabHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost"));
		}
	}
}
