namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TabHost : android.widget.FrameLayout, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TabHost() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TabHost), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TabHost(@__env); 
			} 
		} 
		protected TabHost(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTabChangeListener 
		{ 
			void onTabChanged(java.lang.String arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface TabContentFactory 
		{ 
			android.view.View createTabContent(java.lang.String arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class TabSpec : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static TabSpec() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TabHost.TabSpec), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TabHost.TabSpec(@__env); 
				} 
			} 
			protected TabSpec(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTag10111; 
			public virtual java.lang.String getTag() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTag10111)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _getTag10111)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIndicator10112; 
			public virtual android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _setIndicator10112, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _setIndicator10112, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIndicator10113; 
			public virtual android.widget.TabHost.TabSpec setIndicator(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _setIndicator10113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _setIndicator10113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIndicator10114; 
			public virtual android.widget.TabHost.TabSpec setIndicator(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _setIndicator10114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _setIndicator10114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setContent10115; 
			public virtual android.widget.TabHost.TabSpec setContent(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _setContent10115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _setContent10115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setContent10116; 
			public virtual android.widget.TabHost.TabSpec setContent(android.widget.TabHost.TabContentFactory arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _setContent10116, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _setContent10116, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setContent10117; 
			public virtual android.widget.TabHost.TabSpec setContent(android.content.Intent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TabHost.TabSpec)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _setContent10117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.TabSpec.staticClass, _setContent10117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TabHost.TabSpec.staticClass = @__class; 
				global::android.widget.TabHost.TabSpec._getTag10111 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "getTag", "()Ljava/lang/String;"); 
				global::android.widget.TabHost.TabSpec._setIndicator10112 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setIndicator10113 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setIndicator10114 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setContent10115 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(I)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setContent10116 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;"); 
				global::android.widget.TabHost.TabSpec._setContent10117 = @__env.GetMethodID(global::android.widget.TabHost.TabSpec.staticClass, "setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setup10118; 
		public virtual void setup(android.app.LocalActivityManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _setup10118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _setup10118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setup10119; 
		public virtual void setup() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _setup10119); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _setup10119); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10120; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow10120); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _onAttachedToWindow10120); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10121; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow10121); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _onDetachedFromWindow10121); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10122; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent10122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TabHost.staticClass, _dispatchKeyEvent10122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged10123; 
		public override void dispatchWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _dispatchWindowFocusChanged10123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _dispatchWindowFocusChanged10123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged10124; 
		public virtual void onTouchModeChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _onTouchModeChanged10124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _onTouchModeChanged10124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabWidget10125; 
		public virtual android.widget.TabWidget getTabWidget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallObjectMethodPtr(this, _getTabWidget10125)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.staticClass, _getTabWidget10125)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newTabSpec10126; 
		public virtual android.widget.TabHost.TabSpec newTabSpec(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallObjectMethodPtr(this, _newTabSpec10126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost.TabSpec>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.staticClass, _newTabSpec10126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTab10127; 
		public virtual void addTab(android.widget.TabHost.TabSpec arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _addTab10127, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _addTab10127, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearAllTabs10128; 
		public virtual void clearAllTabs() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _clearAllTabs10128); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _clearAllTabs10128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTab10129; 
		public virtual int getCurrentTab() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return @__env.CallIntMethod(this, _getCurrentTab10129); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TabHost.staticClass, _getCurrentTab10129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTabTag10130; 
		public virtual java.lang.String getCurrentTabTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentTabTag10130)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.staticClass, _getCurrentTabTag10130)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTabView10131; 
		public virtual android.view.View getCurrentTabView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentTabView10131)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.staticClass, _getCurrentTabView10131)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentView10132; 
		public virtual android.view.View getCurrentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentView10132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.staticClass, _getCurrentView10132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTabByTag10133; 
		public virtual void setCurrentTabByTag(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _setCurrentTabByTag10133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _setCurrentTabByTag10133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabContentView10134; 
		public virtual android.widget.FrameLayout getTabContentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout>(@__env, @__env.CallObjectMethodPtr(this, _getTabContentView10134)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.FrameLayout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TabHost.staticClass, _getTabContentView10134)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentTab10135; 
		public virtual void setCurrentTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _setCurrentTab10135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _setCurrentTab10135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnTabChangedListener10136; 
		public virtual void setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TabHost)) 
				@__env.CallVoidMethod(this, _setOnTabChangedListener10136, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TabHost.staticClass, _setOnTabChangedListener10136, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabHost10137; 
		public TabHost(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabHost.staticClass, _TabHost10137, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabHost10138; 
		public TabHost(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TabHost.staticClass, _TabHost10138, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TabHost.staticClass = @__class; 
			global::android.widget.TabHost._setup10118 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setup", "(Landroid/app/LocalActivityManager;)V"); 
			global::android.widget.TabHost._setup10119 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setup", "()V"); 
			global::android.widget.TabHost._onAttachedToWindow10120 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.TabHost._onDetachedFromWindow10121 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.TabHost._dispatchKeyEvent10122 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.TabHost._dispatchWindowFocusChanged10123 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "dispatchWindowFocusChanged", "(Z)V"); 
			global::android.widget.TabHost._onTouchModeChanged10124 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "onTouchModeChanged", "(Z)V"); 
			global::android.widget.TabHost._getTabWidget10125 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;"); 
			global::android.widget.TabHost._newTabSpec10126 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;"); 
			global::android.widget.TabHost._addTab10127 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "addTab", "(Landroid/widget/TabHost$TabSpec;)V"); 
			global::android.widget.TabHost._clearAllTabs10128 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "clearAllTabs", "()V"); 
			global::android.widget.TabHost._getCurrentTab10129 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentTab", "()I"); 
			global::android.widget.TabHost._getCurrentTabTag10130 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentTabTag", "()Ljava/lang/String;"); 
			global::android.widget.TabHost._getCurrentTabView10131 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentTabView", "()Landroid/view/View;"); 
			global::android.widget.TabHost._getCurrentView10132 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getCurrentView", "()Landroid/view/View;"); 
			global::android.widget.TabHost._setCurrentTabByTag10133 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setCurrentTabByTag", "(Ljava/lang/String;)V"); 
			global::android.widget.TabHost._getTabContentView10134 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "getTabContentView", "()Landroid/widget/FrameLayout;"); 
			global::android.widget.TabHost._setCurrentTab10135 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setCurrentTab", "(I)V"); 
			global::android.widget.TabHost._setOnTabChangedListener10136 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V"); 
			global::android.widget.TabHost._TabHost10137 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TabHost._TabHost10138 = @__env.GetMethodID(global::android.widget.TabHost.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
