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
			internal static global::MonoJavaBridge.MethodId _onTabChanged17743;
			 void android.widget.TabHost.OnTabChangeListener.onTabChanged(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost.OnTabChangeListener_._onTabChanged17743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.OnTabChangeListener_.staticClass, global::android.widget.TabHost.OnTabChangeListener_._onTabChanged17743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.OnTabChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$OnTabChangeListener"));
				global::android.widget.TabHost.OnTabChangeListener_._onTabChanged17743 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.OnTabChangeListener_.staticClass, "onTabChanged", "(Ljava/lang/String;)V");
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
			internal static global::MonoJavaBridge.MethodId _createTabContent17744;
			 global::android.view.View android.widget.TabHost.TabContentFactory.createTabContent(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabContentFactory_._createTabContent17744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabContentFactory_.staticClass, global::android.widget.TabHost.TabContentFactory_._createTabContent17744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabContentFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabContentFactory"));
				global::android.widget.TabHost.TabContentFactory_._createTabContent17744 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabContentFactory_.staticClass, "createTabContent", "(Ljava/lang/String;)Landroid/view/View;");
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
			public new global::java.lang.String Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag17745;
			public virtual global::java.lang.String getTag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._getTag17745)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._getTag17745)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator17746;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setIndicator17746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator17746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0, android.graphics.drawable.Drawable arg1)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator17747;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setIndicator17747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator17747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setIndicator17748;
			public virtual global::android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setIndicator17748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setIndicator17748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			public android.widget.TabHost.TabSpec setIndicator(string arg0)
			{
				return setIndicator((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setContent17749;
			public virtual global::android.widget.TabHost.TabSpec setContent(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setContent17749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent17749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setContent17750;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.widget.TabHost.TabContentFactory arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setContent17750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent17750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			internal static global::MonoJavaBridge.MethodId _setContent17751;
			public virtual global::android.widget.TabHost.TabSpec setContent(android.content.Intent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec._setContent17751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.TabSpec.staticClass, global::android.widget.TabHost.TabSpec._setContent17751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TabHost.TabSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost$TabSpec"));
				global::android.widget.TabHost.TabSpec._getTag17745 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "getTag", "()Ljava/lang/String;");
				global::android.widget.TabHost.TabSpec._setIndicator17746 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setIndicator17747 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setIndicator17748 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent17749 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(I)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent17750 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;");
				global::android.widget.TabHost.TabSpec._setContent17751 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setup17752;
		public virtual void setup(android.app.LocalActivityManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setup17752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup17752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setup17753;
		public virtual void setup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setup17753);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setup17753);
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow17754;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._onAttachedToWindow17754);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onAttachedToWindow17754);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17755;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._onDetachedFromWindow17755);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onDetachedFromWindow17755);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17756;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TabHost._dispatchKeyEvent17756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchKeyEvent17756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged17757;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._dispatchWindowFocusChanged17757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._dispatchWindowFocusChanged17757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged17758;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._onTouchModeChanged17758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._onTouchModeChanged17758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabWidget TabWidget
		{
			get
			{
				return getTabWidget();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabWidget17759;
		public virtual global::android.widget.TabWidget getTabWidget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getTabWidget17759)) as android.widget.TabWidget;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabWidget17759)) as android.widget.TabWidget;
		}
		internal static global::MonoJavaBridge.MethodId _newTabSpec17760;
		public virtual global::android.widget.TabHost.TabSpec newTabSpec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._newTabSpec17760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._newTabSpec17760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TabHost.TabSpec;
		}
		internal static global::MonoJavaBridge.MethodId _addTab17761;
		public virtual void addTab(android.widget.TabHost.TabSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._addTab17761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._addTab17761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearAllTabs17762;
		public virtual void clearAllTabs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._clearAllTabs17762);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._clearAllTabs17762);
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
		internal static global::MonoJavaBridge.MethodId _getCurrentTab17763;
		public virtual int getCurrentTab() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentTab17763);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTab17763);
		}
		public new global::java.lang.String CurrentTabTag
		{
			get
			{
				return getCurrentTabTag();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTabTag17764;
		public virtual global::java.lang.String getCurrentTabTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentTabTag17764)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabTag17764)) as java.lang.String;
		}
		public new global::android.view.View CurrentTabView
		{
			get
			{
				return getCurrentTabView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTabView17765;
		public virtual global::android.view.View getCurrentTabView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentTabView17765)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentTabView17765)) as android.view.View;
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView17766;
		public virtual global::android.view.View getCurrentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getCurrentView17766)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getCurrentView17766)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTabByTag17767;
		public virtual void setCurrentTabByTag(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setCurrentTabByTag17767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTabByTag17767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.FrameLayout TabContentView
		{
			get
			{
				return getTabContentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabContentView17768;
		public virtual global::android.widget.FrameLayout getTabContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TabHost._getTabContentView17768)) as android.widget.FrameLayout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._getTabContentView17768)) as android.widget.FrameLayout;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentTab17769;
		public virtual void setCurrentTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setCurrentTab17769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setCurrentTab17769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnTabChangedListener17770;
		public virtual void setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TabHost._setOnTabChangedListener17770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TabHost.staticClass, global::android.widget.TabHost._setOnTabChangedListener17770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TabHost17771;
		public TabHost(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost17771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TabHost17772;
		public TabHost(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TabHost.staticClass, global::android.widget.TabHost._TabHost17772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TabHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TabHost"));
			global::android.widget.TabHost._setup17752 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setup", "(Landroid/app/LocalActivityManager;)V");
			global::android.widget.TabHost._setup17753 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setup", "()V");
			global::android.widget.TabHost._onAttachedToWindow17754 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TabHost._onDetachedFromWindow17755 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TabHost._dispatchKeyEvent17756 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.TabHost._dispatchWindowFocusChanged17757 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.widget.TabHost._onTouchModeChanged17758 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.TabHost._getTabWidget17759 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.widget.TabHost._newTabSpec17760 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;");
			global::android.widget.TabHost._addTab17761 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "addTab", "(Landroid/widget/TabHost$TabSpec;)V");
			global::android.widget.TabHost._clearAllTabs17762 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "clearAllTabs", "()V");
			global::android.widget.TabHost._getCurrentTab17763 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTab", "()I");
			global::android.widget.TabHost._getCurrentTabTag17764 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTabTag", "()Ljava/lang/String;");
			global::android.widget.TabHost._getCurrentTabView17765 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentTabView", "()Landroid/view/View;");
			global::android.widget.TabHost._getCurrentView17766 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.TabHost._setCurrentTabByTag17767 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setCurrentTabByTag", "(Ljava/lang/String;)V");
			global::android.widget.TabHost._getTabContentView17768 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "getTabContentView", "()Landroid/widget/FrameLayout;");
			global::android.widget.TabHost._setCurrentTab17769 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setCurrentTab", "(I)V");
			global::android.widget.TabHost._setOnTabChangedListener17770 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V");
			global::android.widget.TabHost._TabHost17771 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TabHost._TabHost17772 = @__env.GetMethodIDNoThrow(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
